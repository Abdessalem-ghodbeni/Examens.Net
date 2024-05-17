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
        [DataType(DataType.EmailAddress)]
        public string AdresseEmail { get; set; }
        [Key]
        public string CIN { get; set; }
        //public string Nom { get; set; }
        public NomComplet NomComplet { get; set; }
        public DateTime DateNaissance { get; set; }
        public int NumeroDossier { get; set; }
        public int NumTel { get; set; }
        //public string Prenom { get; set; }
        public virtual List<Admission> Admissions { get; set; }

    }
}
