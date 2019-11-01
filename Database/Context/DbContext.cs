using Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Context
{
   public class DbContext : System.Data.Entity.DbContext
    {
        public DbContext() : base("DBconnect")
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Rolle> Roll { get; set; }
    }
}
