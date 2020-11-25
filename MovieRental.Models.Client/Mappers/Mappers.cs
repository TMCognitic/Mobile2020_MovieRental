#region Alias
using GlobalActor = MovieRental.Models.Global.Entities.Actor;
using GlobalCategory = MovieRental.Models.Global.Entities.Category;
using GlobalCustomer = MovieRental.Models.Global.Entities.Customer;
using GlobalFilm = MovieRental.Models.Global.Entities.Film;
using GlobalLanguage = MovieRental.Models.Global.Entities.Language;
using GlobalRental = MovieRental.Models.Global.Entities.Rental;
#endregion

using MovieRental.Models.Client.Entities;
using System.Linq;

namespace MovieRental.Models.Client.Mappers
{
    public static class Mappers
    {
        #region Actor
        public static GlobalActor ToGlobal(this Actor entity)
        {
            return new GlobalActor()
            {
                ActorId = entity.ActorId,
                LastName = entity.LastName,
                FirstName = entity.FirstName
            };
        }

        public static Category ToClient(this GlobalCategory entity)
        {
            return new Category(entity.CategoryId, entity.Name);
        }
        #endregion

        #region Category
        public static GlobalCategory ToGlobal(this Category entity)
        {
            return new GlobalCategory()
            {
                CategoryId = entity.CategoryId,
                Name = entity.Name
            };
        }

        public static Actor ToClient(this GlobalActor entity)
        {
            return new Actor(entity.ActorId, entity.LastName, entity.FirstName);
        }
        #endregion

        #region Customer
        public static GlobalCustomer ToGlobal(this Customer entity)
        {
            return new GlobalCustomer() { 
                CustomerId = entity.CustomerId, 
                LastName = entity.LastName, 
                FirstName = entity.FirstName, 
                Email = entity.Email, 
                Passwd = entity.Passwd 
            };
        }

        public static Customer ToClient(this GlobalCustomer entity)
        {
            return new Customer(entity.CustomerId, entity.LastName, entity.FirstName, entity.Email);
        }
        #endregion

        #region Film
        public static GlobalFilm ToGlobal(this Film entity)
        {
            return new GlobalFilm()
            {
                FilmId = entity.FilmId,
                Title = entity.Title,
                Description = entity.Description,
                ReleaseYear = entity.ReleaseYear,
                Language = entity.Language,
                RentalDuration = entity.RentalDuration,
                RentalPrice = entity.RentalPrice,
                Length = entity.Length,
                ReplacementCost = entity.ReplacementCost,
                Rating = entity.Rating,
            };
        }

        public static Film ToClient(this GlobalFilm entity)
        {
            return new Film(entity.FilmId, entity.Title, entity.Description, entity.ReleaseYear, entity.Language, entity.RentalDuration, entity.RentalPrice, entity.Length, entity.ReplacementCost, entity.Rating);
        }
        #endregion

        #region Language
        public static GlobalLanguage ToGlobal(this Language entity)
        {
            return new GlobalLanguage()
            {
                LanguageId = entity.LanguageId,
                Name = entity.Name
            };
        }

        public static Language ToClient(this GlobalLanguage entity)
        {
            return new Language(entity.LanguageId, entity.Name);
        }
        #endregion

        #region Rental
        public static GlobalRental ToGlobal(this Rental entity)
        {
            return new GlobalRental()
            {
                CustomerId = entity.CustomerId,
                FilmIds = entity.FilmIds.ToArray()
            };
        }
        #endregion
    }
}
