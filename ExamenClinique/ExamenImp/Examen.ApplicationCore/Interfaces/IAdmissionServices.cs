using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IAdmissionServices :IService<Admission>
    {
        public List<NomComplet> ListeDesNomOccupant(Chambre ch, DateTime date);
    }
}
