using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceBL;
using EcommerceBL.CustomerRegistrationBL;
using EcommerceDAL;
using EcommerceDAL.CustomerRegistrationDAL;
using EcommerceDAL.RepositoryPattern;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using EcommerceDAL.ProductsDAL;
using EcommerceBL.Products;
using EcommerceBL.YourOrder;
using EcommerceDAL.YourOrder;
using EcommerceDAL.AddToCart;
using EcommerceBL.AddToCart;


namespace EcommerceAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public static string ConnectionString { get; set; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<IRegistrationDAL, RegistrationDAL>();
            services.AddTransient<IRegistrationBL, RegistrationBL>();
            services.AddTransient<IProductsListDAL, ProductsListDAL>();
            services.AddTransient<IProductListBL, ProductListBL>();
            services.AddTransient<IAddCartBL, AddCartBL>();
            services.AddTransient<IAddCartDAL, AddCartDAL>();
            services.AddTransient<IYourOrderDAL, YourOrderDAL>();
            services.AddTransient<IYourOrderBL, YourOrderBL>();
            services.AddTransient<IBaseDAL, BaseDAL>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
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

            app.UseHttpsRedirection();
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseRouting();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Registration}/{action=Insertion}/{id?}");
                endpoints.MapRazorPages();
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //TODO: Enable production exception handling (https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling)
                app.UseExceptionHandler("/Error");

                app.UseHsts();
            }

        }
    }
}
