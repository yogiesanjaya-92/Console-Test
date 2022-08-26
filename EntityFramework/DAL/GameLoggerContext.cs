using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.DAL
{
    public class GameLoggerContext : DbContext
    {
        public GameLoggerContext() 
            : base("name=Game_Logger")
        {
        }

        public virtual DbSet<Game_Logger> GameLogger { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
