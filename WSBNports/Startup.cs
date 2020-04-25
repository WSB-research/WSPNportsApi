using System.Linq;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.Edm;
using Newtonsoft.Json.Serialization;
using WSBNports.Api.Options;
using WSBNports.Infrastructure;

namespace WSBNports
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
            // Bind database options. Invalid configuration will terminate the application startup.
            var connectionStringsOptions =
                Configuration.GetSection("ConnectionStrings").Get<ConnectionStringsOptions>();
            var cosmosDbOptions = Configuration.GetSection("CosmosDb").Get<CosmosDbOptions>();
            var (serviceEndpoint, authKey) = connectionStringsOptions.ActiveConnectionStringOptions;
            var (databaseName, collectionData) = cosmosDbOptions;
            var collectionNames = collectionData.Select(c => c.Name).ToList();

            // Add Mvc.
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                });

            // Add version support.
            services.AddMvcCore();

            services.AddOData();
        }

       


        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

            builder.EntitySet<Nport>("Nports").EntityType.HasKey(np => np.Id);

            builder.EnableLowerCamelCase();
            return builder.GetEdmModel();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Item}/{action=Index}/{id?}");

                routes.EnableDependencyInjection();
                routes.Expand().Select().Filter().OrderBy().MaxTop(10000).Count();
                routes.MapODataServiceRoute("odata", "odata", GetEdmModel());

            });
            NportRepository<Nport>.Initialize();
        }
    }
}
