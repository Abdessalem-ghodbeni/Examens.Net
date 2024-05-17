using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class BilanServices : Service<Bilan>, BilanInterface
    {
    
public BilanServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double montan(Bilan bilan)
        {
            {
                //decimal montantTotal = 0;

                //foreach (var bilan in bilans)
                //{
                //    if (bilan.Paye && bilan.EmailMedecin == emailMedecin)
                //    {
                //        decimal montant = bilan.Montant;

                //        // Vérifier le nombre de prélevements effectués par le patient
                //        int nombrePrelevements = bilans.Count(b => b.Paye && b.EmailMedecin == emailMedecin && b.DatePrelevement <= bilan.DatePrelevement);

                //        if (nombrePrelevements > 5)
                //        {
                //            montant -= montant * 0.1m; // Appliquer la réduction de 10%
                //        }

                //        montantTotal += montant;
                //    }
                //}

                //return montantTotal;
                return 0;
            }
        }
    }
}
