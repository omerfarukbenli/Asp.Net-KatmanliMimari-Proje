using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayerRepository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
       // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
         //   optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=aaaa;Trusted_Connection=True;");
        //}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //entitylerin özellikleri
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //mapin kısa yolu

            base.OnModelCreating(modelBuilder);
        }
    }
}
