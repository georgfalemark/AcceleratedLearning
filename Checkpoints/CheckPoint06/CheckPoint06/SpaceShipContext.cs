using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint06
{
    public class SpaceShipContext : DbContext
    {
        public DbSet<SpaceShip> spaceShips { get; set; }
        public DbSet<Ravioli> raviolis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = Checkpoint06;");
            }
        }
    }
}
