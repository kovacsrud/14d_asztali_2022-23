using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MysqlCars
{
    public class CarContext:DbContext
    {
        public DbSet<Car> Car { get; set; }
        public DbSet<Owner> Owner { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=cars;user=root;password=");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>(
                entity =>
                {
                    entity.HasKey(e => e.ID);
                    entity.Property(e => e.GyartasiEv).IsRequired();
                    entity.Property(e => e.Marka).IsRequired();
                    entity.Property(e => e.Tipus).IsRequired();
                    entity.Property(e => e.Rendszam).IsRequired();
                    entity.HasOne(p => p.Owner).WithMany(q => q.Cars);
                    

                }
                
                );

            modelBuilder.Entity<Owner>(

                    entity =>
                    {
                        entity.HasKey(e => e.ID);
                        entity.Property(e => e.Name).IsRequired();
                        
                    }


                );
        }
    }
}
