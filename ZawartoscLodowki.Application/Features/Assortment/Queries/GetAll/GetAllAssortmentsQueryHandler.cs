using AutoMapper;
using MediatR;
using ZawartoscLodowki.Application.Contracts;

namespace ZawartoscLodowki.Application.Features.Assortment.Queries.GetAll;

public class GetAllAssortmentsQueryHandler(IMapper mapper,IAssortmentRepository assortmentRepository): IRequestHandler<GetAllAssortmentsQuery,List<AssortmentDto>>
{
    public async Task<List<AssortmentDto>> Handle(GetAllAssortmentsQuery request, CancellationToken cancellationToken)
    {
        var data = await  assortmentRepository.GetAllWithDetailsAsync();
        return mapper.Map<List<AssortmentDto>>(data);
    }
}