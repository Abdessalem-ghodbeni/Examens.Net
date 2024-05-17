using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class RDV
    {
        public Boolean Confirmation { get; set; }
        public DateTime DateRDV { get; set; }
        [ForeignKey("Client")]
        public int ClientFK { get; set; }
        public virtual Client Client { get; set; }
        [ForeignKey("Prestation")]
        public int PrestationFK { get; set; }
        public virtual Prestation  Prestation { get; set; }
    }
}
