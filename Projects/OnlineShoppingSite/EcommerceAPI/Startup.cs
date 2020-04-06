// <copyright file="Startup.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EcommerceAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EcommerceBL;
    using EcommerceBL.AddToCart;
    using EcommerceBL.Category;
    using EcommerceBL.CustomerRegistrationBL;
    using EcommerceBL.Payment;
    using EcommerceBL.PaymentMode;
    using EcommerceBL.Products;
    using EcommerceBL.ShippingAddress;
    using EcommerceBL.YourOrder;
    using EcommerceBL.YourOrderDetails;
    using EcommerceDAL;
    using EcommerceDAL.AddToCart;
    using EcommerceDAL.Category;
    using EcommerceDAL.CustomerRegistrationDAL;
    using EcommerceDAL.FeedbackDAL;
    using EcommerceDAL.FeedbackDAL.PaymentModeDAL;
    using EcommerceDAL.PaymentDAL;
    using EcommerceDAL.PaymentMode;
    using EcommerceDAL.ProductsDAL;
    using EcommerceDAL.RepositoryPattern;
    using EcommerceDAL.ShippingAddress;
    using EcommerceDAL.YourOrder;
    using EcommerceDAL.YourOrderDetails;
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

    /// <summary>
    /// Implementation of a class.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">value.</param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Gets implementation of a property.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Gets or sets implementation of a property.
        /// </summary>
        public static string ConnectionString { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        private readonly string myAllowSpecificOrigins = "_myAllowSpecificOrigins";

        /// <summary>
        /// Method.
        /// </summary>
        /// <param name="services">value.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(myAllowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod();
                });
            });

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
            services.AddTransient<IYourOrderDetailsDAL, YourOrderDetailsDAL>();
            services.AddTransient<IYourOrderDetailsBL, YourOrderDetailsBL>();
            services.AddTransient<ICategoryBL, CategoryBL>();
            services.AddTransient<ICategoryDAL, CategoryDAL>();
            services.AddTransient<IPaymentBL, PaymentBL>();
            services.AddTransient<IPaymentDAL, PaymentDAL>();
            services.AddTransient<IPaymentModeBL, PaymentModeBL>();
            services.AddTransient<IPaymentModeDAL, PaymentModeDAL>();
            services.AddTransient<IShippingAddressBL, ShippingAddressBL>();
            services.AddTransient<IShippingAddressDAL, ShippingAddressDAL>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

            /// <summary>
            /// Method.
            /// </summary>
            /// <param name="app">app.</param>
            /// <param name="env">env.</param>
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

            app.UseCors(myAllowSpecificOrigins);

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
                app.UseExceptionHandler("/Error");

                app.UseHsts();
            }
        }
    }
}
