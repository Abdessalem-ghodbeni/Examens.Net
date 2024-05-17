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
    public class RDVConfiguration : IEntityTypeConfiguration<RDV>
    {
        public void Configure(EntityTypeBuilder<RDV> builder)
        {
            builder.HasKey(rdv => new { rdv.PrestationFK, rdv.ClientFK, rdv.DateRDV });
        }
    }
}
