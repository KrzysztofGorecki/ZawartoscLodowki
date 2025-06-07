using ZawartoscLodowki.BlazorGui.Models.ViewModels;

namespace ZawartoscLodowki.BlazorGui.Interfaces;

public interface IMeasureUnitService
{
    Task<List<MeasureUnitVM>> GetMeasureUnits();
}