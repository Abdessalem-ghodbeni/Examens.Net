using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class AdmissionServices : Service<Admission>, IAdmissionServices
    {
        public AdmissionServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public List<NomComplet> ListeDesNomOccupant(Chambre c, DateTime debut)
        {
            return c.Admissions.Where(p => DateTime.Compare(p.DateAdmission, debut) > 0)
                .Select(p => p.Patient.NomComplet).ToList();
        }
    }
}
