using MediatR;

namespace ZawartoscLodowki.Application.Features.Assortment.Queries.GetById;

public record GetAssortmentByIdQuery(int Id): IRequest<AssortmentDto>;