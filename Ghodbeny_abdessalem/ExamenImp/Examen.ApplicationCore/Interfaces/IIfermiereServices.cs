using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IIfermiereServices : IService<Infirmier>
    {
        public double poucentageInfi(Specialite specialite);
    }
}
