using ZawartoscLodowki.Application.Contracts;
using ZawartoscLodowki.Domain;
using ZawartoscLodowki.Persistance.DatabaseContext;

namespace ZawartoscLodowki.Persistance.Repositories;

public class AssortmentKindRepository(AppDbContext context) : GenericRepository<AssortmentKind>(context), IAssortmentKindRepository
{
    
}