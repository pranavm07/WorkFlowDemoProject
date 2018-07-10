using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogEntity.Helper
{
    public class AuditLogEntityModel: DbContext
    {
        public AuditLogEntityModel(string connectionString) :base(connectionString)
        {

        }

        public AuditLogEntityModel(DbConnection connection, bool contextOwnsConnection):base(connection, contextOwnsConnection)
        {

        }
    }
}
