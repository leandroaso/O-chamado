using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OChamado.API.DAO;
using OChamado.API.Models;

namespace OChamado.API
{
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
            services.AddMvc();
            services.AddDbContext<ChamadoContext>(options => options.UseSqlServer(this.Configuration.GetConnectionString("Default")));
            services.AddRouting();
            
            //Dependency Injection
            services.AddTransient<AtendimentoDao>();
            services.AddTransient<ClienteDao>();
            services.AddTransient<EmpresaDao>();
            services.AddTransient<EmpresaSolucaoDao>();
            services.AddTransient<ResponsavelDao>();
            services.AddTransient<SolucaoDao>();
            services.AddTransient<UsuarioDao>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc( routes => 
                routes.MapRoute(
                    name: "default",
                    template: "{Controller}/{action}/{id?}"));

            serviceProvider.GetService<ChamadoContext>().Database.EnsureCreated();
        }
    }
}
