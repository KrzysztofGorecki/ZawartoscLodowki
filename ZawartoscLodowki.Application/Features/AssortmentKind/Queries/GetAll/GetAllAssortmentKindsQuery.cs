using MediatR;

namespace ZawartoscLodowki.Application.Features.AssortmentKind.Queries.GetAll;

public record GetAllAssortmentKindsQuery(): IRequest<List<AssortmentKindDto>>;