using ZawartoscLodowki.Application.Features.AssortmentKind.Queries;
using ZawartoscLodowki.Application.Features.MeasureUnit.Queries;

namespace ZawartoscLodowki.Application.Features.Assortment.Queries;

public class AssortmentDto
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int AssortmentKindId { get; set; }
    public AssortmentKindDto AssortmentKind { get; set; }
    public DateTime ExpireDate { get; set; }
    public double Quantity { get; set; }
    public MeasureUnitDto MeasureUnit { get; set; }
    public int MeasureUnitId { get; set; }
}