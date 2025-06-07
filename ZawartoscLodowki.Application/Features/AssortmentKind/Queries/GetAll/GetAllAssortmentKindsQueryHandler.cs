using AutoMapper;
using MediatR;
using ZawartoscLodowki.Application.Contracts;

namespace ZawartoscLodowki.Application.Features.AssortmentKind.Queries.GetAll;

public class GetAllAssortmentKindsQueryHandler(IMapper mapper,IAssortmentKindRepository assortmentKindRepository): IRequestHandler<GetAllAssortmentKindsQuery, List<AssortmentKindDto>>
{
    public async Task<List<AssortmentKindDto>> Handle(GetAllAssortmentKindsQuery request, CancellationToken cancellationToken)
    {
        var data = await assortmentKindRepository.GetAllAsync();
        return mapper.Map<List<AssortmentKindDto>>(data);
    }
}