using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZawartoscLodowki.Domain;

namespace ZawartoscLodowki.Persistance.Configurations;

public class AssortmentKindConfiguration: IEntityTypeConfiguration<AssortmentKind>
{
    public void Configure(EntityTypeBuilder<AssortmentKind> builder)
    {
        builder.HasData(
            new AssortmentKind() { Id = 1, Name = "Nabiał" },
            new AssortmentKind() { Id = 2, Name = "Szynka" },
            new AssortmentKind() { Id = 3, Name = "Pieczywo" },
            new AssortmentKind() { Id = 4, Name = "Sok" },
            new AssortmentKind() { Id = 5, Name = "Warzywa" },
            new AssortmentKind() { Id = 6, Name = "Owoce" }
            );
    }
}