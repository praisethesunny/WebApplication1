using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DBConnection
{
    public interface DBInterface
    {

        void InitialDatabase();

        DbConnection Connection { get;}

    }
}

