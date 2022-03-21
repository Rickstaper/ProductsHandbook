using Handbook.Data.ConfigurationModels;
using Handbook.Data.Models;
using Handbook.Data.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook.Data
{
    public class HandbookContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Price> Prices { get; set; }



        public HandbookContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionConfiguration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PriceConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
