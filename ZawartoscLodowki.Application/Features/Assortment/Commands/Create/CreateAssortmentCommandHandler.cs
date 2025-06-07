using AutoMapper;
using MediatR;
using ZawartoscLodowki.Application.Contracts;

namespace ZawartoscLodowki.Application.Features.Assortment.Commands.Create;

public class CreateAssortmentCommandHandler(IMapper mapper, IAssortmentRepository assortmentRepository): IRequestHandler<CreateAssortmentCommand, int>
{
    public Task<int> Handle(CreateAssortmentCommand request, CancellationToken cancellationToken)
    {
        try
        {

            if (string.IsNullOrEmpty(request.ProductName))
                throw new ArgumentException("Nazwa produktu jest pusta");
            var payload = mapper.Map<Domain.Assortment>(request);
            return assortmentRepository.CreateAsync(payload);
        }
        catch (ArgumentException ex)
        {
            return Task.FromResult(-1);
        }
    }
}