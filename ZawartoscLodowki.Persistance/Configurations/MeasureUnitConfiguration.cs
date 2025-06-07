using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZawartoscLodowki.Domain;

namespace ZawartoscLodowki.Persistance.Configurations;

public class MeasureUnitConfiguration: IEntityTypeConfiguration<MeasureUnit>
{
    public void Configure(EntityTypeBuilder<MeasureUnit> builder)
    {
        builder.HasData(
            new MeasureUnit(){Id=1,Name = "Szt"},
            new MeasureUnit(){Id=2,Name = "L"}
        );
    }
}