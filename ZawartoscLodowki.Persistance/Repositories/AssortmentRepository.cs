using Microsoft.EntityFrameworkCore;
using ZawartoscLodowki.Application.Contracts;
using ZawartoscLodowki.Application.Features.Assortment.Queries;
using ZawartoscLodowki.Domain;
using ZawartoscLodowki.Persistance.DatabaseContext;

namespace ZawartoscLodowki.Persistance.Repositories;

public class AssortmentRepository(AppDbContext context) : GenericRepository<Assortment>(context), IAssortmentRepository
{
    public async Task<List<Assortment>> GetAllWithDetailsAsync()
    {
        return await Context.Set<Assortment>()
            .Include(q => q.AssortmentKind)
            .Include(q => q.MeasureUnit)
            .AsNoTracking()
            .ToListAsync();
    }
}