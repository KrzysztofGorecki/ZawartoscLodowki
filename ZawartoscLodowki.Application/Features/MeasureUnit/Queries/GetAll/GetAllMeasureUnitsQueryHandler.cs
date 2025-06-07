using AutoMapper;
using MediatR;
using ZawartoscLodowki.Application.Contracts;

namespace ZawartoscLodowki.Application.Features.MeasureUnit.Queries.GetAll;

public class GetAllMeasureUnitsQueryHandler(IMapper mapper,IMeasureUnitRepository measureUnitRepository): IRequestHandler<GetAllMeasureUnitsQuery, List<MeasureUnitDto>>
{
    public async Task<List<MeasureUnitDto>> Handle(GetAllMeasureUnitsQuery request, CancellationToken cancellationToken)
    {
        var data = await measureUnitRepository.GetAllAsync();
        return mapper.Map<List<MeasureUnitDto>>(data);
    }
}