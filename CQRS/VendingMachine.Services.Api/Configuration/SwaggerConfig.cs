using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace VendingMachine.Services.Api.Configuration
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Vending Machine Project",
                    Description = "Vending Machine API Swagger surface",
                    Contact = new OpenApiContact { Name = "Diego Armando", Email = "dgo.npp@gmail.com", Url = new Uri("https://https://github.com/diegarm") }                    
                });

            });
        }

        public static void UseSwaggerSetup(this IApplicationBuilder app)
        {
            ArgumentNullException.ThrowIfNull(nameof(app));

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
        }
    }
}