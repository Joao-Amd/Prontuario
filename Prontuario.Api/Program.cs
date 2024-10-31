using Microsoft.EntityFrameworkCore;
using Prontuario.Aplicacao.Mappings;
using Prontuario.Aplicacao.Pacientes;
using Prontuario.Dominio.Pacientes;
using Prontuario.Repositorio.Contextos;
using Prontuario.Infra;
using Prontuario.Repositorio.UnitOfWorks;
using Prontuario.Repositorio.RepPatterns;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<Contexto>(options =>
    options.UseSqlServer(connectionString, 
    x => x.MigrationsAssembly(typeof(Contexto).Assembly.FullName)));

builder.Services.AddAutoMapper(typeof(EntitiesToDtoMappingProfile));

builder.Services.AddControllers();

builder.Services.AddScoped<IAplicPaciente, AplicPaciente>();
builder.Services.AddScoped<IRep<Paciente>, Rep<Paciente>>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

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
