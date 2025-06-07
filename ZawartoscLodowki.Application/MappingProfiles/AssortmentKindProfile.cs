using AutoMapper;
using ZawartoscLodowki.Application.Features.AssortmentKind.Queries;
using ZawartoscLodowki.Domain;

namespace ZawartoscLodowki.Application.MappingProfiles;

public class AssortmentKindProfile: Profile
{
    public AssortmentKindProfile()
    {
        CreateMap<AssortmentKind, AssortmentKindDto>().ReverseMap();
    }
}