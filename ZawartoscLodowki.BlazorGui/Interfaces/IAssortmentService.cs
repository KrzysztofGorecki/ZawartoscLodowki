using ZawartoscLodowki.BlazorGui.Models.ViewModels;

namespace ZawartoscLodowki.BlazorGui.Interfaces;

public interface IAssortmentService
{
    Task<List<AssortmentVM>> GetAssortments();
    Task<int> CreateAssortment(AssortmentVM assortment);
    Task UpdateAssortment(AssortmentVM assortment);
    Task DeleteAssortment(AssortmentVM assortment);
}