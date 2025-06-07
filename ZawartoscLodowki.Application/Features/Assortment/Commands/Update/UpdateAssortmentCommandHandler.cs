using AutoMapper;
using MediatR;
using ZawartoscLodowki.Application.Contracts;

namespace ZawartoscLodowki.Application.Features.Assortment.Commands.Update;

public class UpdateAssortmentCommandHandler(IMapper mapper, IAssortmentRepository assortmentRepository): IRequestHandler<UpdateAssortmentCommand, bool>
{
    public Task<bool> Handle(UpdateAssortmentCommand request, CancellationToken cancellationToken)
    {
        var payload = mapper.Map<Domain.Assortment>(request);
        return assortmentRepository.UpdateAsync(payload);
    }
}