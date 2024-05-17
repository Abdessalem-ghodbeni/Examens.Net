using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Acitivite
    {
        public int AcitiviteId { get; set; }

        public Zone Zone { get; set; }
        public double Prix { get; set; }
        public string TypeService { get; set; }
        public virtual List<Pack> Packs { get; set; }

    }
}
