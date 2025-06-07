namespace ZawartoscLodowki.Domain;

public class Assortment:  BaseEntity
{
    public string ProductName { get; set; }
    public int AssortmentKindId { get; set; }
    public AssortmentKind AssortmentKind { get; set; }
    public DateTime ExpireDate { get; set; }
    public double Quantity { get; set; }
    public MeasureUnit MeasureUnit { get; set; }
    public int MeasureUnitId { get; set; }
}