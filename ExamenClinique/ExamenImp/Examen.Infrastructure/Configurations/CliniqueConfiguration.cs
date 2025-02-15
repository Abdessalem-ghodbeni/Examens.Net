﻿using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    internal class CliniqueConfiguration : IEntityTypeConfiguration<Clinique>
    {
        public void Configure(EntityTypeBuilder<Clinique> builder)
        {
            builder.HasMany(f => f.Chambres)
              .WithOne(p => p.Clinique)
              .HasForeignKey(f => f.CliniqueFK)
              .OnDelete(DeleteBehavior.Cascade); //The values
        }
    }
}
