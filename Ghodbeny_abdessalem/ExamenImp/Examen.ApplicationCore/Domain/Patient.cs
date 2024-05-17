using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Patient
    {
        [Key]
        [StringLength(5, MinimumLength = 5,ErrorMessage ="longeur doit etre =5 ")]
        public int CodePatient { get; set; }
        public string EmailPatient { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Information suplementaire")]


        public string Informations { get; set; }
        public string NomComplet { get; set; }
        public string NumeroTel { get; set; }
        public virtual List<Bilan>Bilans { get; set; }

    }
}
