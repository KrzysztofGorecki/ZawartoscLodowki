using System.Reflection;
using Radzen;
using ZawartoscLodowki.Application;
using ZawartoscLodowki.Application.MappingProfiles;
using ZawartoscLodowki.BlazorGui.Components;
using ZawartoscLodowki.BlazorGui.Interfaces;
using ZawartoscLodowki.BlazorGui.Profiles;
using ZawartoscLodowki.BlazorGui.Services;
using ZawartoscLodowki.Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddRadzenComponents();

builder.Services.AddApplicationService();
builder.Services.AddPersistenceServices(builder.Configuration);

builder.Services.AddScoped<IAssortmentService, AssortmentService>();
builder.Services.AddScoped<IMeasureUnitService, MeasureUnitService>();
builder.Services.AddScoped<IAssortmentKindService, AssortmentKindService>();

builder.Services.AddAutoMapper(typeof(AssortmentProfile).Assembly);
builder.Services.AddAutoMapper(typeof(AssortmentVmProfile).Assembly);
builder.Services.AddMediatR(cfg=> cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();