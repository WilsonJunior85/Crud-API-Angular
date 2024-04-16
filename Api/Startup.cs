using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AGREGAMENTO.Data;
using AGREGAMENTO.Service.ColaboradorInterface;
using AGREGAMENTO.Service.ColaboradorService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace Agregamento;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {

        //Configuração do Banco de dados
        services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));




        services.AddControllers();

        //Configurando o Cors  // testeeeeeeeeeeeeeee options
        services.AddCors( options =>
            {
            options.AddPolicy("AllowSpecificOrigin",
                builder =>
                {
                    builder.WithOrigins("http://localhost:4200") // Adicione a URL do seu aplicativo Angular
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
        }
            
            );


        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Agregamento", Version = "v1" });
        });

        //Quando eu fizer uma injeção de dependência da interface "IAgregamentoInterface.cs" eu quero que seja utilizado os métodos que estão na "AgregamentoService.cs".
        services.AddScoped<IColaboradorInterface, ColaboradorService>();


        //Vamos falar para o nosso DataContext.cs qual é a nossa connectionstring e manda criar o nosso banco apartir das migrações
        services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Agregamento v1"));
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();


        // Configurando o Cors
        app.UseCors("AllowSpecificOrigin");
        app.UseCors( x => x.AllowAnyHeader()
                               .AllowAnyMethod()
                               .AllowAnyOrigin()



           ) ;


     


        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
