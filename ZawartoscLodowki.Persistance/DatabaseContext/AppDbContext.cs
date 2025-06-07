using Microsoft.EntityFrameworkCore;
using ZawartoscLodowki.Domain;

namespace ZawartoscLodowki.Persistance.DatabaseContext;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    DbSet<Assortment>  Assortments { get; set; }
    DbSet<AssortmentKind> AssortmentKinds { get; set; }
    DbSet<MeasureUnit> MeasureUnits { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}