using AutoMapper;
using MediatR;
using ZawartoscLodowki.Application.Features.Assortment.Queries.GetAll;
using ZawartoscLodowki.Application.Features.AssortmentKind.Queries.GetAll;
using ZawartoscLodowki.BlazorGui.Interfaces;
using ZawartoscLodowki.BlazorGui.Models.ViewModels;

namespace ZawartoscLodowki.BlazorGui.Services;

public class AssortmentKindService(IMediator mediator,IMapper mapper): IAssortmentKindService
{
    public async Task<List<AssortmentKindVM>> GetAssortmentKinds()
    {
        var data = await mediator.Send(new GetAllAssortmentKindsQuery());
        return mapper.Map<List<AssortmentKindVM>>(data);
    }
}