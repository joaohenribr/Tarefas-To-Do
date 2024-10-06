using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TarefasToDo.Models;

namespace TarefasToDo.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Username).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PasswordHash).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CreatedAt);
        }
    }
}
