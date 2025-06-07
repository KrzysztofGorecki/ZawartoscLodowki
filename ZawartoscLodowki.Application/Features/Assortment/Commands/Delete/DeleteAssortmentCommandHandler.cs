using MediatR;
using ZawartoscLodowki.Application.Contracts;

namespace ZawartoscLodowki.Application.Features.Assortment.Commands.Delete;

public class DeleteAssortmentCommandHandler(IAssortmentRepository assortmentRepository):  IRequestHandler<DeleteAssortmentCommand,bool>
{
    public async Task<bool> Handle(DeleteAssortmentCommand request, CancellationToken cancellationToken)
    {
        var entity = await assortmentRepository.GetByIdAsync(request.Id);
        return await assortmentRepository.DeleteAsync(entity);
    }
}