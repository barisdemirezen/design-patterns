using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public class SqlServer
    {
        private SqlServer()
        {

        }
        private static SqlServer? sqlServer;
        public static SqlServer CreateObject()
        {
            if (sqlServer == null)
            {
                sqlServer = new SqlServer();
            }
            return sqlServer;
        }

        public void SomeMethod()
        {
            // Some implementation...
        }
    }
}
