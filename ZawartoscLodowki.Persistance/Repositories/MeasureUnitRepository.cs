using ZawartoscLodowki.Application.Contracts;
using ZawartoscLodowki.Domain;
using ZawartoscLodowki.Persistance.DatabaseContext;

namespace ZawartoscLodowki.Persistance.Repositories;

public class MeasureUnitRepository(AppDbContext context) :  GenericRepository<MeasureUnit>(context), IMeasureUnitRepository
{
    
}