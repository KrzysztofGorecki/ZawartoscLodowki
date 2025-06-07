using MediatR;
using ZawartoscLodowki.Application.Features.AssortmentKind.Queries;
using ZawartoscLodowki.Application.Features.MeasureUnit.Queries;

namespace ZawartoscLodowki.Application.Features.Assortment.Commands.Update;

public class UpdateAssortmentCommand: IRequest<bool>
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