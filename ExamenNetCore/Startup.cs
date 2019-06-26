using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Belatrix.WebApi.Repository.Postgresql;
using Examen.Api.Repository;
using Examen.Api.Repository.SqlServer;
using Exman.Api.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace ExamenNetCore
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
            services.AddControllers()
                .AddNewtonsoftJson();
            

            services.AddEntityFrameworkSqlServer()
                .AddDbContext<ExamenDbContext>(
                opt => opt.UseSqlServer(Configuration.GetConnectionString("sqlServer"),
                b => b.MigrationsAssembly("ExamenNetCoreApi")))
               .BuildServiceProvider();

            services.AddTransient<IRepository<Customer>, Repository<Customer>>();
            services.AddTransient<IRepository<Album>, Repository<Album>>();
            services.AddTransient<IRepository<Artist>, Repository<Artist>>();
            services.AddTransient<IRepository<Employee>, Repository<Employee>>();
            services.AddTransient<IRepository<Genre>, Repository<Genre>>();
            services.AddTransient<IRepository<Invoice>, Repository<Invoice>>();
            services.AddTransient<IRepository<InvoiceItem>, Repository<InvoiceItem>>();
            services.AddTransient<IRepository<MediaType>, Repository<MediaType>>();
            services.AddTransient<IRepository<Playlist>, Repository<Playlist>>();
            services.AddTransient<IRepository<PlaylistTrack>, Repository<PlaylistTrack>>();
            services.AddTransient<IRepository<Track>, Repository<Track>>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Examen API",
                    Version = "v1"
                });
                c.CustomSchemaIds(x => x.FullName);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "Examen Api v1");
            });
        }
    }
}
