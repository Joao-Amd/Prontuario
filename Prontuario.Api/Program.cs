using Microsoft.EntityFrameworkCore;
using Prontuario.Aplicacao.Pacientes;
using Prontuario.Dominio.Pacientes;
using Prontuario.Repositorio.Contextos;
using Prontuario.Repositorio.RepPatterns;
using Prontuario.Repositorio.UnitOfWorks;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<Contexto>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();

builder.Services.AddScoped<IAplicPaciente, AplicPaciente>();
builder.Services.AddScoped<IRep<Paciente>, Rep<Paciente>>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
