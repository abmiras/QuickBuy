using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamentoConfiguration>
    {
        public void Configure(EntityTypeBuilder<FormaPagamentoConfiguration> builder)
        {
            //builder.Haskey
        }
    }
}
