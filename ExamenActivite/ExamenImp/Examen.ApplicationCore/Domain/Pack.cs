using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Pack
    {
        public int PackId { get; set; }
        public int NbPlaces { get; set; }
        public DateTime DateDebut { get; set; }
        public int Duree { get; set; }
        public string IntitulePack { get; set; }

        public virtual List<Acitivite> AcitiviteList { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
    }
}
