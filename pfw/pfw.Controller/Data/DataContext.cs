using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace pfw.Controller.Data
{
    public class DataContext : DbContext
    {
        public DataContext(string connectionString)
            : base(connectionString)
        {
            Database.SetInitializer<DataContext>(new DropCreateDatabaseIfModelChanges<DataContext>());
        }
    }
}
