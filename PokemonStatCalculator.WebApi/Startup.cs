using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using PokemonStatCalculator.DataAccess.Contexts;
using PokemonStatCalculator.DataAccess.Mapping;
using PokemonStatCalculator.DataAccess.Repositories;
using PokemonStatCalculator.Entities.Train;
using PokemonStatCalculator.Entities.Train.Stats;
using PokemonStatCalculator.Entities.Train.Stats.Factory;
using PokemonStatCalculator.WebApi.Models.PokemonTraining;
using PokemonStatCalculator.WebApi.Validators.PokemonTraining;
using System.Text;

namespace PokemonStatCalculator.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddControllers();

            services.AddDbContext<AuthenticationContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("AuthenticationContext")));

            MongoDbPersistence.Configure();

            services.AddScoped<IMongoContext, MongoContext>();

            services.AddScoped<IUserTrainedPokemonRepository, UserTrainedPokemonRepository>();

            services.AddScoped<AbstractValidator<TrainingViewModel>,TrainingViewModelValidator>();

            services.AddScoped<IStatTrainingChecker, StatTrainingChecker>();

            services.AddScoped<IStatTrainingFactory, StatTrainingFactory>();

            services.AddScoped<ITrainingStrategy, DefaultTrainingStrategy>();

            services.AddAutoMapper(typeof(Startup));

            services
                .AddIdentity<IdentityUser, IdentityRole>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AuthenticationContext>()
                .AddDefaultTokenProviders();

            var appSettingsSection = Configuration.GetSection("AppSettings");

            services.Configure<AppSettings>(appSettingsSection);

            var jsonWebTokenSettings = appSettingsSection.Get<AppSettings>();

            var key = Encoding.ASCII.GetBytes(jsonWebTokenSettings.Secret);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = true;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = jsonWebTokenSettings.ValidIn,
                    ValidIssuer = jsonWebTokenSettings.Issuer
                };
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}