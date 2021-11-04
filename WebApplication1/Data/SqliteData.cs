using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DBConnection;
using System.Data.Common;
using Dapper;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;

namespace WebApplication1.Data
{
    public class SqliteData: DBInterface
    {
        string SqliteFilePath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserDb.sqlite");

        public SqliteData()
        {
        }

        public void InitialDatabase()
        {

            if (!File.Exists(SqliteFilePath))
            {

                // Sqlite file does not exist, create a new file

                SQLiteConnection.CreateFile(SqliteFilePath);
                // script to create a new table 

                this.Connection.Execute(@"
                                        CREATE TABLE IF NOT EXISTS [AppUser]  (
                                                            Id integer primary key identity(1,1),
                                                            FirstName nvarchar(255) not null,
                                                            LastName nvarchar(255) not null,
                                                            Adress nvarchar,
                                                            PartnerNumber int(20) not null,
                                                            CroatianPIN int,
                                                            PartnerTypeId int(1) not null,
                                                            CreatedAtUtc datetime default current_timestamp,
                                                            CreateByUser nvarchar(255),
                                                            IsForeign bool not null,
                                                            ExternalCode nvarchar(20) unique,
                                                            Gender int(1) not null
                                              )");
            }
        }

        public DbConnection Connection
        {
            get
            {
                // Create a new connection if null or disposed

                if (_connection == null)
                {
                    _connection = new SQLiteConnection("Data Source=" + SqliteFilePath);
                    _connection.Open();
                }

                //*** Open the connection if other than disposed

                else if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }

                return _connection;
            }
        }

        private DbConnection _connection;
    }
}
