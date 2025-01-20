using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Core.Entity;



namespace Infrastructure
{
    public class ApplicationContext: DbContext
    {
        readonly IConfiguration _configuration;
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
            
        }
        //protected ApplicatonContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string _connectionString = _configuration.GetConnectionString("DefaultConnection")
        //                                ?? throw new InvalidOperationException("Connection string not found");
        //    optionsBuilder.UseSqlServer(_connectionString);
        //}

        public DbSet<Core.Entity.Service> Service { get; set; }
        public DbSet<Core.Entity.Fonction> Fonction { get; set; }
        public DbSet<Core.Entity.EmployeFonction> EmployeFonction { get; set; }
        public DbSet<Core.Entity.Employe> Employes { get; set; }
        public DbSet<Core.Entity.Demande> Demande { get; set; }

    }
}
