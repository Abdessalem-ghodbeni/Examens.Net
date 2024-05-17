
using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure
{
    public class ExamenContext:DbContext
    {
       public DbSet<Analyse> Analyses { get; set; }
      public DbSet<Bilan> Bilans { get; set; }
       public DbSet<Infirmier> Infirmiers { get; set; }
        public DbSet<Laboratoire> Laboratoires { get; set; }
        public DbSet<Patient> Patients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(); 

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                       Initial Catalog= LaboGhodbeniAbdessalem;
                       Integrated Security=true;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BilanConfiguration());
            modelBuilder.Entity<Laboratoire>()
               .Property(l => l.Localisation)
               .HasColumnName("AdressLabo")
               .HasMaxLength(50);



        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
           // configurationBuilder.Properties<string>().HaveMaxLength(15);

        }
    }
}
