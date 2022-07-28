using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Natalia.Business.Models.Fabricantes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natalia.Data.Mappings
{
    public class FabricanteMapping : IEntityTypeConfiguration<Fabricante>
    {
        public void Configure(EntityTypeBuilder<Fabricante> builder)
        {
            builder.ToTable("Fabricantes");

            builder.Property(u => u.Id).ValueGeneratedOnAdd();
        }
    }
}
