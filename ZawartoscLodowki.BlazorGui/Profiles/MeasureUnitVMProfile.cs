using AutoMapper;
using ZawartoscLodowki.Application.Features.MeasureUnit.Queries;
using ZawartoscLodowki.BlazorGui.Models.ViewModels;

namespace ZawartoscLodowki.BlazorGui.Profiles;

public class MeasureUnitVMProfile: Profile
{
    public MeasureUnitVMProfile()
    {
        CreateMap<MeasureUnitDto, MeasureUnitVM>().ReverseMap();
    }
}