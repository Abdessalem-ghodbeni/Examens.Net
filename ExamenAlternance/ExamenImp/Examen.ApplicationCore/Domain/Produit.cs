using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Produit
    {
        [DataType(DataType.DateTime,ErrorMessage ="Date non valide")]
        public DateTime DateProd { get; set; }
        public string Destination { get; set; }
        public string Nom { get; set; }
        public double Price { get; set; }
        public int ProduitId { get; set; }
        public virtual List<Fournisseur> Fournisseurs { get; set; }

        public virtual Ctegorie Ctegorie { get; set; }
        [ForeignKey("CategorieFk ")]
        public int CategorieFk { get; set; }

    }
}
