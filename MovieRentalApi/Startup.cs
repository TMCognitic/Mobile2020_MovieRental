#region Alias
using GlobalActor = MovieRental.Models.Global.Entities.Actor;
using GlobalActorRepository = MovieRental.Models.Global.Repositories.ActorRepository;
using GlobalCategory = MovieRental.Models.Global.Entities.Category;
using GlobalCategoryRepository = MovieRental.Models.Global.Repositories.CategoryRepository;
using GlobalCustomer = MovieRental.Models.Global.Entities.Customer;
using GlobalAuthRepository = MovieRental.Models.Global.Repositories.AuthRepository;
using GlobalFilm = MovieRental.Models.Global.Entities.Film;
using GlobalFilmRepository = MovieRental.Models.Global.Repositories.FilmRepository;
using GlobalLanguage = MovieRental.Models.Global.Entities.Language;
using GlobalLanguageRepository = MovieRental.Models.Global.Repositories.LanguageRepository;
using GlobalRental = MovieRental.Models.Global.Entities.Rental;
using GlobalRentalRepository = MovieRental.Models.Global.Repositories.RentalRepository;
#endregion

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MovieRental.Models.Client.Entities;
using MovieRental.Models.Client.Repositories;
using MovieRental.Models.Common.Interfaces;
using System.Data.SqlClient;
using Tools.Connection;
using MovieRentalApi.Infrastructure.Security;

namespace MovieRentalApi
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MovieRentalApi", Version = "v1" });
            });

            services.AddSingleton<ITokenService, TokenService>();
            services.AddSingleton<IConnection, Connection>(sp => new Connection(SqlClientFactory.Instance, @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MovieRental;Integrated Security=True;"));            
            services.AddSingleton<IActorRepository<GlobalActor>, GlobalActorRepository>();
            services.AddSingleton<IActorRepository<Actor>, ActorRepository>();
            services.AddSingleton<ICategoryRepository<GlobalCategory>, GlobalCategoryRepository>();
            services.AddSingleton<ICategoryRepository<Category>, CategoryRepository>();
            services.AddSingleton<IAuthRepository<GlobalCustomer>, GlobalAuthRepository>();
            services.AddSingleton<IAuthRepository<Customer>, AuthRepository>();
            services.AddSingleton<IFilmRepository<GlobalFilm>, GlobalFilmRepository>();
            services.AddSingleton<IFilmRepository<Film>, FilmRepository>();
            services.AddSingleton<ILanguageRepository<GlobalLanguage>, GlobalLanguageRepository>();
            services.AddSingleton<ILanguageRepository<Language>, LanguageRepository>();
            services.AddSingleton<IRentalRepository<GlobalRental>, GlobalRentalRepository>();
            services.AddSingleton<IRentalRepository<Rental>, RentalRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MovieRentalApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
