using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsAPI.Application;
using ContactsAPI.Application.Contract;
using ContactsAPI.configuration;
using ContactsAPI.Persistence.Contract;
using ContactsAPI.Persistence.DbContexts;
using ContactsAPI.Persistence.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace ContactsAPI
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
            // Register Db Context with connection string
            services.AddDbContext<ContactContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ConnectionString")));

            services.ConfigureAutoMapperSetup();

            services.AddScoped<IContactApplication, ContactApplication>();
            services.AddScoped<IContactRepository, ContactRepository>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSwaggerGen(swg =>
            {
                swg.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Contacts API",
                    Description = "Contact API Explorer"
                });
            });

            services.AddMvc(
                config =>
                {
                    config.Filters.Add(typeof(ExceptionFilter));
                }
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "Contacts API V1");
                s.RoutePrefix = string.Empty;
            });

            app.UseMvc();
        }
    }
}
