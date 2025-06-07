using AutoMapper;
using MediatR;
using ZawartoscLodowki.Application.Features.MeasureUnit.Queries.GetAll;
using ZawartoscLodowki.BlazorGui.Interfaces;
using ZawartoscLodowki.BlazorGui.Models.ViewModels;

namespace ZawartoscLodowki.BlazorGui.Services;

public class MeasureUnitService(IMediator mediator, IMapper mapper): IMeasureUnitService
{
    public async Task<List<MeasureUnitVM>> GetMeasureUnits()
    {
        var data = await mediator.Send(new GetAllMeasureUnitsQuery());
        return mapper.Map<List<MeasureUnitVM>>(data);
    }
}