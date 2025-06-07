using MediatR;

namespace ZawartoscLodowki.Application.Features.Assortment.Queries.GetAll;

public record GetAllAssortmentsQuery(): IRequest<List<AssortmentDto>>;