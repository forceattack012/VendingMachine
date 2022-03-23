using Microsoft.EntityFrameworkCore;
using VendingMachine.Data;
using VendingMachine.Data.Interfaces;
using VendingMachine.Repositories;
using VendingMachine.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

var connectionString = builder.Configuration["DbContextSettings:ConnectionString"];
builder.Services.AddDbContext<VendingMachineContext>(opt => opt.UseNpgsql(connectionString));

builder.Services.AddScoped<IVendingMachineContext, VendingMachineContext>();
builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddScoped<IMachineRepository, MachineRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}

app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
