
using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure
{
    public class ExamenContext:DbContext
    {

        public DbSet<Admission> Admissions { get; set; }
        public DbSet<Chambre> Chambres { get; set; }
        public DbSet<Clinique> Cliniques { get; set; }
        public DbSet<Patient> Patients { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(); 

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                       Initial Catalog= ExamenAdmissionSlouma;
                       Integrated Security=true;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CliniqueConfiguration());
            modelBuilder.ApplyConfiguration(new AdmissionConfiguration());





        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            
        }
    }
}
