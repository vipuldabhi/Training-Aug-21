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
using Tiffin.Helpers;
using Tiffin.Models;
using Tiffin.Repository;

namespace Tiffin
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Tiffin", Version = "v1" });
            });
            services.AddAutoMapper(typeof(Startup));
            services.AddDbContext<tiffinContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<tiffinContext>()
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



            services.AddScoped<IAreaRepository, AreaRepository>();
            services.AddScoped<ICancellationStatusRepository, CancellationStatusRepository>();
            services.AddScoped<IContactInfoRepository, ContactInfoRepository>();
            services.AddScoped<IDayWiseMenuRepository, DayWiseMenuRepository>();
            services.AddScoped<IDeliveryStatusRepository, DeliveryStatusRepository>();
            services.AddScoped<IDurationRepository, DurationRepository>();
            services.AddScoped<IFoodRepository, FoodRepository>();
            services.AddScoped<IFoodTypeRepository, FoodTypeRepository>();
            services.AddScoped<IIntervalRepository, IntervalRepository>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IWeekDayRepository, WeekDayRepository>();
            services.AddScoped<IRestaurantRepository, RestaurantRepository>(); 
            services.AddScoped<IMealChargesRepository, MealChargesRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IRatingRepository, RatingRepository>();
            services.AddScoped<IAvgRatingRepository, AvgRatingRepository>();
            services.AddScoped<ITotalRevenueRepository, TotalRevenueRepository>();
            services.AddScoped<IDeliveryBoyRepository, DeliveryBoyRepository>();
            services.AddScoped<IDeliveryChargesRepository, DeliveryChargesRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tiffin v1"));
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
