using AutoMapper;
using ZawartoscLodowki.Application.Features.AssortmentKind.Queries;
using ZawartoscLodowki.BlazorGui.Models.ViewModels;
using ZawartoscLodowki.Domain;

namespace ZawartoscLodowki.BlazorGui.Profiles;

public class AssortmentKindVMProfile: Profile
{
    public AssortmentKindVMProfile()
    {
        CreateMap<AssortmentKindDto, AssortmentKindVM>().ReverseMap();
    }
}