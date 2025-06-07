using AutoMapper;
using MediatR;
using ZawartoscLodowki.Application.Features.Assortment.Commands.Create;
using ZawartoscLodowki.Application.Features.Assortment.Commands.Delete;
using ZawartoscLodowki.Application.Features.Assortment.Commands.Update;
using ZawartoscLodowki.Application.Features.Assortment.Queries.GetAll;
using ZawartoscLodowki.BlazorGui.Interfaces;
using ZawartoscLodowki.BlazorGui.Models.ViewModels;

namespace ZawartoscLodowki.BlazorGui.Services;

public class AssortmentService(IMediator mediator, IMapper mapper): IAssortmentService
{
    public async Task<List<AssortmentVM>> GetAssortments()
    {
        var data = await mediator.Send(new GetAllAssortmentsQuery());
        return mapper.Map<List<AssortmentVM>>(data);
    }

    public Task<int> CreateAssortment(AssortmentVM assortment)
    {
        var payload =  mapper.Map<CreateAssortmentCommand>(assortment);
        return mediator.Send(payload);
    }

    public Task UpdateAssortment(AssortmentVM assortment)
    {
        var payload = mapper.Map<UpdateAssortmentCommand>(assortment);
        return mediator.Send(payload);
    }

    public Task DeleteAssortment(AssortmentVM assortment)
    {
        var entity = mapper.Map<DeleteAssortmentCommand>(assortment);
        return mediator.Send(entity);
    }
}