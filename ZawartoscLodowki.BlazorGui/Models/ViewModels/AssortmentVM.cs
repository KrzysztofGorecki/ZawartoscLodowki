namespace ZawartoscLodowki.BlazorGui.Models.ViewModels;

public class AssortmentVM
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int AssortmentKindId { get; set; }
    public AssortmentKindVM AssortmentKind { get; set; }
    public DateTime ExpireDate { get; set; }
    public double Quantity { get; set; }
    public MeasureUnitVM MeasureUnit { get; set; }
    public int MeasureUnitId { get; set; }
}