using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProvCli.Api.Mappers;
using ProvCli.CrossCutting.IoC;
using Swashbuckle.AspNetCore.Swagger;

namespace ProvCli.Api
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
            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            Bootstrapper.ConfigureServices(services);
            #region AutoMapper
            var mapper = new MapperConfiguration(cfg =>
            {
                Mapping.ModelToEntity(cfg);
                Mapping.EntityToModel(cfg);
            }).CreateMapper();
            services.AddSingleton(mapper);
            #endregion
            #region Swagger
            services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new Info
                    {
                        Version = "v1",
                        Title = "ToDo API",
                        Description = "A simple example ASP.NET Core Web API",
                        TermsOfService = "https://example.com/terms",
                        Contact = new Contact
                        {
                            Name = "Shayne Boyer",
                            Email = string.Empty,
                            Url = "https://twitter.com/spboyer",
                        },
                        License = new License
                        {
                            Name = "Use under LICX",
                            Url = "https://example.com/license",
                        }
                    });
                }); 
            #endregion
        }

        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();

            #region Swagger

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            }); 
            #endregion
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
