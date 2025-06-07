using AutoMapper;
using ZawartoscLodowki.Application.Features.MeasureUnit.Queries;
using ZawartoscLodowki.Domain;

namespace ZawartoscLodowki.Application.MappingProfiles;

public class MeasureKindProfile: Profile
{
    public MeasureKindProfile()
    {
        CreateMap<MeasureUnit, MeasureUnitDto>().ReverseMap();
    }
}