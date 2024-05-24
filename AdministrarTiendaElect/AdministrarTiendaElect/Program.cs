using AdministrarTiendaElect.Client.Pages;
using AdministrarTiendaElect.Components;
using AdministrarTiendaElect.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ATEDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IProducto, RepoProducto>();
builder.Services.AddScoped<ICategoria, RepoCategoria>();
builder.Services.AddScoped<IProveedor, RepoProveedor>();
builder.Services.AddScoped<IVentaControl, RepoVentaControl>();
builder.Services.AddScoped<IVentaDetalle,RepoVentaDetalle>();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(AdministrarTiendaElect.Client._Imports).Assembly);

app.Run();
