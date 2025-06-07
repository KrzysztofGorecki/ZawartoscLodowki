using MediatR;

namespace ZawartoscLodowki.Application.Features.MeasureUnit.Queries.GetAll;

public record GetAllMeasureUnitsQuery(): IRequest<List<MeasureUnitDto>>;