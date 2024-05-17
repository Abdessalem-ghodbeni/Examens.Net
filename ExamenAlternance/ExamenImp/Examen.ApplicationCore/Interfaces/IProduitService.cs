using AM.ApplicationCore.Interfaces;
using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IProduitService : IService<Produit>
    {
        public List<Fournisseur> GetFournisses(Ctegorie categorie);
        public List<Chimique> GetChimiques(double prix);

    }
}
