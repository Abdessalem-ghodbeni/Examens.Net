
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

        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Ctegorie> Ctegories { get; set; }
        public DbSet<Chimique> Chimiques { get; set; }
        public DbSet<Biologique> Biologiques { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(); 

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                       Initial Catalog= GhodbeniAbdessalemProduit;
                       Integrated Security=true;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration(new ProduitConfiguration());


        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            
        }
    }
}
