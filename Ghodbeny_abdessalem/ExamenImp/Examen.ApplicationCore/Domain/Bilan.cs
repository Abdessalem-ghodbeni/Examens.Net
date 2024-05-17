using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public  class Bilan
    {
        public DateTime DatePrelevement { get; set; }
        public string EmailMedecin { get; set; }
        public Boolean Paye { get; set; }

        [ForeignKey("Infirmier")]
        public virtual int CodeInfirmier { get; set; }

        [ForeignKey("Patient")]
        public virtual int CodePatient { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Infirmier Infirmier { get; set; }
        public virtual List<Analyse> Analyses { get; set; }



    }
}
