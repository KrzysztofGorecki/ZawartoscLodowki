using AutoMapper;
using MediatR;
using ZawartoscLodowki.Application.Contracts;

namespace ZawartoscLodowki.Application.Features.Assortment.Queries.GetById;

public class GetAssortmentByIdQueryHandler(IMapper mapper,IAssortmentRepository assortmentRepository): IRequestHandler<GetAssortmentByIdQuery, AssortmentDto>
{
    public async Task<AssortmentDto> Handle(GetAssortmentByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await assortmentRepository.GetByIdAsync(request.Id);
        return mapper.Map<AssortmentDto>(entity);
    }
}