
using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure
{
    public class ExamenContext:DbContext
    {

        public DbSet<Client> Clients { get; set; }
        public DbSet<Prestataire> Prestataires { get; set; }
        public DbSet<Prestation> Prestations { get; set; }
        public DbSet<RDV> RDVs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(); 

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                       Initial Catalog= BeautyGhodbenyAbdessalem;
                       Integrated Security=true;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RDVConfiguration());




        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(150);

        }
    }
}
