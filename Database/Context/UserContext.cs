using Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Context
{
   public class UserContext : DbContext
    {
        public UserContext() : base("DBconnect")
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Roll> Roll { get; set; }
    }
}
