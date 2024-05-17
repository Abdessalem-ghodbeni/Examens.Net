using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServicePrestataire : Service<Prestataire>, IServicePrestataire
    {
        public ServicePrestataire(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Prestataire> Get3Prestataire()
        {
            
                return GetMany(p => p.Zone == Zone.Raoued).OrderBy(p => p.Note).Take(3);
            
        }
    }
}
