using BEDF.Data.Context;
using BEDF.Data.Repository;
using BEDF.Domain.Interfaces;
using BEDF.Services.MainServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BEDF.API
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
            services.AddControllers();

            services.AddDbContext<DevFinanceContext>(opt =>
                 opt.UseSqlServer(Configuration.GetConnectionString("DevFinanceDb")));
            services.AddScoped<DevFinanceContext>();
            services.AddScoped<ITransactionRepository, DevFinanceRepository>();
            services.AddScoped<ITransactionService, DevFinanceService>();


            services.AddCors(opt =>
            {
                opt.AddPolicy("Total",
                    builder =>
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader());
            });
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
            app.UseCors("Total");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
