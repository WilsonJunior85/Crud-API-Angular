using AGREGAMENTO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AGREGAMENTO.Data.Mappings
{
    public class DadosColaboradorMapping : IEntityTypeConfiguration<DadosDoColaboradorModel>
    {
        public void Configure(EntityTypeBuilder<DadosDoColaboradorModel> builder)
        {
            builder.ToTable("Colaboradores");

            builder.HasKey(c => c.IdSerede);
            builder.Property(x => x.IdSerede)
                .ValueGeneratedNever();
        }
    }
}