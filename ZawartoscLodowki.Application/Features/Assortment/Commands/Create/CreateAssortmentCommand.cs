using MediatR;
using ZawartoscLodowki.Application.Features.AssortmentKind.Queries;
using ZawartoscLodowki.Application.Features.MeasureUnit.Queries;

namespace ZawartoscLodowki.Application.Features.Assortment.Commands.Create;

public class CreateAssortmentCommand: IRequest<int>
{
    public string ProductName { get; set; }
    public int AssortmentKindId { get; set; }
    public DateTime ExpireDate { get; set; }
    public double Quantity { get; set; }
    public int MeasureUnitId { get; set; }
}