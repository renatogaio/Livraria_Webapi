using Livraria.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Infra.Data.Mapeamentos
{
    public class LivroMap : MapBase<Livro>
    {
        public override void Configure(EntityTypeBuilder<Livro> builder)
        {
            base.Configure(builder);
            builder.ToTable("livro");
            builder.Property(c => c.Titulo).IsRequired().HasColumnName("Titulo").HasMaxLength(100);
            builder.Property(c => c.Exemplar).IsRequired().HasColumnName("Exemplar");
        }
    }
}
