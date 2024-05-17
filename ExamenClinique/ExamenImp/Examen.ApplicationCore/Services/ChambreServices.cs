using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ChambreServices : Service<Chambre>, IChambreService
    {
        public ChambreServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double ChambrePercent(Clinique clinique)
        {
            return clinique.Chambres.Where(p => p.TypeChambre == TypeChambre.SIMPLE).Count() / clinique.Chambres.Count() * 100;
        }
    }
}
