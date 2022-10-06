using DI_Commun.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");
            builder.HasKey(e => e.Id);
            builder.Ignore(e => e.IgnoreMe);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property<string>("_password" /*nom dans l'objet*/).HasColumnName("password" /*nom dans la bdd*/).IsRequired(true);
        }
    }
}
