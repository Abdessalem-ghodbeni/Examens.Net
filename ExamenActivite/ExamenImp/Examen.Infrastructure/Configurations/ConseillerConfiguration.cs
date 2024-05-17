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
    public class ConseillerConfiguration : IEntityTypeConfiguration<Conseiller>
    {
        public void Configure(EntityTypeBuilder<Conseiller> builder)
        {
            builder.HasMany(p => p.Clients)
    .WithOne(p => p.Conseiller)
    .HasForeignKey(p => p.ConseillerFK)
    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
