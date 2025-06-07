using AutoMapper;
using Radzen;
using ZawartoscLodowki.Application.Features.Assortment.Commands.Create;
using ZawartoscLodowki.Application.Features.Assortment.Commands.Delete;
using ZawartoscLodowki.Application.Features.Assortment.Commands.Update;
using ZawartoscLodowki.Application.Features.Assortment.Queries;
using ZawartoscLodowki.Application.MappingProfiles;
using ZawartoscLodowki.BlazorGui.Models.ViewModels;

namespace ZawartoscLodowki.BlazorGui.Profiles;

public class AssortmentVmProfile: Profile
{
    public AssortmentVmProfile()
    {
        CreateMap<AssortmentDto, AssortmentVM>().ReverseMap();
        CreateMap<AssortmentVM,UpdateAssortmentCommand>();
        CreateMap<AssortmentVM,CreateAssortmentCommand>();
        CreateMap<AssortmentVM,DeleteAssortmentCommand>();
        Console.WriteLine($"Dodałem mapowanie {nameof(AssortmentVmProfile)}");
    }
}