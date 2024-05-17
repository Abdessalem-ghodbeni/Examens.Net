using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Fournisseur
    {
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        [Key]
        public int Identifiant { get; set; }
        public Boolean IsApproved { get; set; }
       [ StringLength(12, MinimumLength = 3)] 
        public string Nom { get; set; }

        public virtual List<Produit> ProduitList { get; set;}

    }
}
