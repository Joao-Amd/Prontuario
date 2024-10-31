using Microsoft.EntityFrameworkCore;
using Prontuario.Repositorio.Contextos;
using Prontuario.Infra;


var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<Contexto>(options =>
    options.UseSqlServer(connectionString, 
    x => x.MigrationsAssembly(typeof(Contexto).Assembly.FullName)));

builder.Services.AddControllers();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddInfraStrucureSwagger();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
