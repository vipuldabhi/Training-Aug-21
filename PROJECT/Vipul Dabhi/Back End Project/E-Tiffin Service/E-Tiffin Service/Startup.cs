using E_Tiffin_Service.Models;
using E_Tiffin_Service.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Tiffin_Service
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "E_Tiffin_Service", Version = "v1" });
            });
            services.AddDbContext<ETiffinContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ETiffinContext>()
                .AddDefaultTokenProviders();

            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
               .AddJwtBearer(option =>
               {
                   option.SaveToken = true;
                   option.RequireHttpsMetadata = false;
                   option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                   {
                       ValidateIssuer = true,
                       ValidateAudience = true,
                       ValidAudience = Configuration["JWT:ValidAudience"],
                       ValidIssuer = Configuration["JWT:ValidIssuer"],
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]))
                   };


               });

            services.AddScoped<ICancellationStatusRepository, CancellationStatusRepository>();
            services.AddScoped<IContactInfoRepository, ContactInfoRepository>();
            services.AddScoped<IDeliveryStatusRepository, DeliveryStatusRepository>();
            services.AddScoped<IFridayDinnerMenuRepository, FridayDinnerMenuRepository>();
            services.AddScoped<IFridayLunchMenuRepository, FridayLunchMenuRepository>();
            services.AddScoped<IMondayLunchMenuRepository, MondayLunchMenuRepository>();
            services.AddScoped<IMondayDinnerMenuRepository, MondayDinnerMenuRepository>();
            services.AddScoped<ITuesdayDinnerMenuRepository, TuesdayDinnerMenuRepository>();
            services.AddScoped<ITuesdayLunchMenuRepository, TuesdayLunchMenuRepository>();
            services.AddScoped<IWednesdayLunchMenuRepository, WednesdayLunchMenuRepository>();
            services.AddScoped<IWednesdayDinnerMenuRepository, WednesdayDinnerMenuRepository>();
            services.AddScoped<IThursdayLunchMenuRepository, ThursdayLunchMenuRepository>();
            services.AddScoped<IThursdayDinnerMenuRepository, ThursdayDinnerMenuRepository>();
            services.AddScoped<ISaturdayLunchMenuRepository, SaturdayLunchMenuRepository>();
            services.AddScoped<ISaturdayDinnerMenuRepository, SaturdayDinnerMenuRepository>();
            services.AddScoped<ISundayLunchMenuRepository, SundayLunchMenuRepository>();
            services.AddScoped<ISundayDinnerMenuRepository, SundayDinnerMenuRepository>();
            services.AddScoped<IOrderDetailsRepository, OrderDetailsRepository>();
            services.AddScoped<IPaymentStatusRepository, PaymentStatusRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>(); 
            services.AddScoped<ICancelledOrderRepository, CancelledOrderRepository>();
            services.AddScoped<IPendingPaymentRepository, PendingPaymentRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "E_Tiffin_Service v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
