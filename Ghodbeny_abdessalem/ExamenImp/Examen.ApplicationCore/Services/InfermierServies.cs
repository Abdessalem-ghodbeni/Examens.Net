using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class InfermierServies : Service<Infirmier>, IIfermiereServices
    {
    
public InfermierServies(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double poucentageInfi(Specialite specialite)
        {
            throw new NotImplementedException();
        }

        // public double poucentageInfi(Specialite specialite)
        // {

        //return GetMany(p=>p.Equals(specialite)).SelectMany(p=>p.InfirmierId).ToList()/ GetMany(p => p.Equals(specialite)).ToList() *100;
        // }
    }
}
 
