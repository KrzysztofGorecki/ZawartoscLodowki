using MediatR;

namespace ZawartoscLodowki.Application.Features.Assortment.Commands.Delete;

public record DeleteAssortmentCommand(int Id): IRequest<bool>;