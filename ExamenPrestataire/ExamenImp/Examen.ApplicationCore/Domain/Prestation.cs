using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Prestation
    {
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Intitule { get; set; }
        public int PrestationId { get; set; }

        public Type PrestationType { get; set; }
        [DataType(DataType.Currency)] // Utiliser DataType.Currency pour indiquer une valeur monétaire
        public double Prix { get; set; }
        [ForeignKey("Prestataire")]
        public int PrestataireFK { get; set; }

        public virtual Prestataire Prestataire { get; set; }
        public virtual List<RDV> RDVs { get; set; }
        public object Type { get; internal set; }
    }
}
