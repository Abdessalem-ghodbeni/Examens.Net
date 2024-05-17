using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Examen.ApplicationCore.Domain.Type;

namespace Examen.ApplicationCore.Services
{
    public class PrestationsService : Service<Prestation>, IPrestationServic
    {
        public PrestationsService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double PrixMoyen()
        {
            return GetMany(p => p.Type.Equals(Type.Coiffure)).Average(p => p.Prix);
        }
    }
}
