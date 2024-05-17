using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ProduitService : Service<Produit>, IProduitService
    {
        public ProduitService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public List<Chimique> GetChimiques(double prix)
        {
            return GetAll().OfType<Chimique>().OrderByDescending(p => p.Price).Take(5).ToList();
        }

        public List<Fournisseur> GetFournisses(Ctegorie categorie)
        {
           return GetMany(produit=>produit.Equals(categorie)).SelectMany(produit=>produit.Fournisseurs).ToList();
        }
    }
}
