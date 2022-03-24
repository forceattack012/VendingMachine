using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using VendingMachine.Data;
using VendingMachine.Hubs;
using VendingMachine.Repositories;
using VendingMachine.Repositories.Interfaces;
using VendingMachine.Services;
using VendingMachine.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

var connectionString = builder.Configuration["DbContextSettings:ConnectionString"];
builder.Services.AddDbContext<VendingMachineContext>(opt => opt.UseNpgsql(connectionString));

builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddScoped<IMachineRepository, MachineRepository>();
builder.Services.AddScoped<IMachineInventoryRepository, MachineInventoryRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

builder.Services.AddAuthentication(auth =>
{
    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidIssuer = builder.Configuration["JwtToken:Issuer"],
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JwtToken:Audience"],
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtToken:SigningKey"]))
    };
});
builder.Services.AddSignalR();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthentication();


app.UseRouting();
app.UseAuthorization();

app.UseWebSockets();
app.UseEndpoints(configure =>
{
   configure.MapHub<AdminNotificationHub>("/adminHub");
});

app.MapControllers();

app.Run();
