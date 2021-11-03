using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DBConnection;
using System.Data.Common;

namespace WebApplication1.Data
{
    public class SQLData : DBInterface
    {
        public DbConnection Connection => throw new NotImplementedException();

        public void InitialDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
