using Football.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Football.DataAccess
{
    public class FootballContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DIMAMONDESKTOP\SQLEXPRESS;Database=Football;Trusted_Connection=True;");
        }
    }
}
