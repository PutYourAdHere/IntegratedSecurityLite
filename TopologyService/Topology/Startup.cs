using DataAccess.CrossCutting.DbContext;
using Domain.CrossCutting.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TopologyDataAccess.DbContext;
using TopologyDomain.Model;

namespace TopologyApi
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
            services.AddOpenApiDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Version = "v1";
                    document.Info.Title = "Topology API";
                    document.Info.Description = "Spatial topology";
                    document.Info.TermsOfService = "None";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "Alvaro & Marta",
                        Email = string.Empty,
                        Url = "string.Empty"
                    };
                };
            });

            services.AddTransient<IRepositoryReaderAsync<Place>, Repository<Place>>();
            services.AddTransient<IRepositoryReaderAsync<PlaceSet>, Repository<PlaceSet>>();
            services.AddTransient<IRepositoryReader<Place>, Repository<Place>>();
            services.AddTransient<IRepositoryReader<PlaceSet>, Repository<PlaceSet>>();
            services.AddTransient<IRepositoryWriter<Place>, Repository<Place>>();
            services.AddTransient<IRepositoryWriter<PlaceSet>, Repository<PlaceSet>>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUnitOfWorkContext, UnitOfWork>();
            services.AddTransient<DbContext, TopologyDbContext>();

            services.AddEntityFrameworkSqlServer()
                    .AddEntityFrameworkSqlServerHierarchyId()
                    .AddEntityFrameworkSqlServerNetTopologySuite();
            
            services.AddDbContext<TopologyDbContext>((sp, options) =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("TopologyConnectionString"),
                        sqlOptions => sqlOptions
                                                        .UseNetTopologySuite()
                                                        .UseHierarchyId()
                                                        .MigrationsAssembly("TopologyDataAccess"));

                    options.UseInternalServiceProvider(sp);
                }
            );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseOpenApi(); // serve OpenAPI/Swagger documents
            app.UseSwaggerUi3(); // serve Swagger UI
            app.UseReDoc(); // serve ReDoc UI

        }
    }
}
