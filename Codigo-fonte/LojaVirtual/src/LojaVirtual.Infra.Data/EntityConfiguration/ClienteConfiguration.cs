using LojaVirtual.Domain;
using System.Data.Entity.ModelConfiguration;

namespace LojaVirtual.Infra.Data.EntityConfiguration
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            ToTable("Cliente");

            HasKey(c => c.Id);
            Property(c => c.Nome).HasMaxLength(50).IsRequired();
            Property(c => c.Cpf).HasMaxLength(11).IsRequired();
            Property(c => c.Email).HasMaxLength(50).IsRequired();
        }
    }
}
