using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface BilanInterface : IService<Bilan>
    {
        public double montan(Bilan bilan);
    }
}
