
using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure
{
    public class ExamenContext:DbContext
    {
        public DbSet<Acitivite> Acitivites { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Conseiller> Conseillers { get; set; }
        public DbSet<Pack> Packs { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(); 

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                       Initial Catalog= GhodbenyActivity;
                       Integrated Security=true;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration(new ConseillerConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());



        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(15);
        }
    }
}
