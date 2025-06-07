using AutoMapper;
using ZawartoscLodowki.Application.Features.Assortment.Commands.Create;
using ZawartoscLodowki.Application.Features.Assortment.Commands.Update;
using ZawartoscLodowki.Application.Features.Assortment.Queries;
using ZawartoscLodowki.Domain;

namespace ZawartoscLodowki.Application.MappingProfiles;

public class AssortmentProfile: Profile
{
    public AssortmentProfile()
    {
        CreateMap<CreateAssortmentCommand, Assortment>();
        CreateMap<UpdateAssortmentCommand, Assortment>();
        CreateMap<Assortment, AssortmentDto>().ReverseMap();
    }
}