using ZawartoscLodowki.BlazorGui.Models.ViewModels;

namespace ZawartoscLodowki.BlazorGui.Interfaces;

public interface IAssortmentKindService
{
    Task<List<AssortmentKindVM>> GetAssortmentKinds();
}