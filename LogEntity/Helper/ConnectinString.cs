using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogEntity.Helper
{
    public class ConnectinString
    {
        public static string getConnectionString()
        {
            string constr = string.Empty;

            constr = new AuditLogDbEntities().Database.Connection.ConnectionString;


            return constr;
        }
    }
}
