using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Prontuario.Aplicacao.Mappings;
using Prontuario.Aplicacao.Pacientes;
using Prontuario.Dominio.Pacientes;
using Prontuario.Repositorio.Contextos;
using Prontuario.Repositorio.RepPatterns;
using Prontuario.Repositorio.UnitOfWorks;
using System.Text;

namespace Prontuario.Infra
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfraStructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<Contexto>(options =>
                options.UseSqlServer(connectionString,
                 x => x.MigrationsAssembly(typeof(Contexto).Assembly.FullName)));

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidAudience = configuration["Jwt:SecretKey"],
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(configuration["Jwt:Audience"])),
                    ClockSkew = TimeSpan.Zero
                };
            });

            services.AddAutoMapper(typeof(EntitiesToDtoMappingProfile));


            services.AddScoped<IAplicPaciente, AplicPaciente>();
            services.AddScoped<IRep<Paciente>, Rep<Paciente>>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
