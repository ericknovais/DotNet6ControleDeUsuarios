using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UsuariosApi.Data;
using UsuariosApi.Models;
using UsuariosApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<UsuarioDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("UsuarioConnection")));

builder.Services.AddIdentity<Usuario, IdentityRole>().
    AddEntityFrameworkStores<UsuarioDbContext>().
    AddDefaultTokenProviders();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<CadastroService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
