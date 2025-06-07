using ZawartoscLodowki.Application.Features.Assortment.Queries;
using ZawartoscLodowki.Domain;

namespace ZawartoscLodowki.Application.Contracts;

public interface IAssortmentRepository: IGenericRepository<Assortment>
{
    Task<List<Assortment>> GetAllWithDetailsAsync();
}