using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class PatientServices : Service<Patient>, PatientInterfacesServices
    {
    
public PatientServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
