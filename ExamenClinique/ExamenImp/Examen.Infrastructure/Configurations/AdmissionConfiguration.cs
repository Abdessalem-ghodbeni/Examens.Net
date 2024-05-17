using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    internal class AdmissionConfiguration : IEntityTypeConfiguration<Admission>
    {
        public void Configure(EntityTypeBuilder<Admission> builder)
        {
            builder.HasKey(admission => new { admission.ChambreFk, admission.PatientFk, admission.DateAdmission });
        }
    }
}
