using Manbet.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;
using Manbet.Core.Interfaces.Repositories;
using Manbet.Infrastructure.Persistence.Repositories;
using Manbet.Application.Services;

namespace Manbet.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddTransient<ICasaApostaRepository, CasaApostaRepository>();
            services.AddScoped<ICasaApostaService, CasaApostaService>();
            //services.AddScoped<ICasaApostaService, CasaApostaService>();

            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ManbetDBContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
