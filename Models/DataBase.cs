using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DataBase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s15526;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Animal> Animals {get; set;}
        public DbSet<Owner> Owners {get; set;}
        public DbSet<Person> Persons {get; set;}
        public DbSet<Student> Students  {get; set;}
        public DbSet<Studies> Studies  {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Animal>().Property(a => a.Name)
            //    .IsRequired();
            modelBuilder.Entity<Animal>().HasData(
                new Animal {  Id=1, Name="test"}
                );
            base.OnModelCreating(modelBuilder);
        }

    }

     
}
