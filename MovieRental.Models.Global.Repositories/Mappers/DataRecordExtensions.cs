using MovieRental.Models.Global.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MovieRental.Models.Global.Repositories.Mappers
{
    internal static class DataRecordExtensions
    {
        internal static Actor ToActor(this IDataRecord dataRecord)
        {
            return new Actor() { 
                ActorId = (int)dataRecord["ActorId"], 
                LastName = (string)dataRecord["LastName"], 
                FirstName = (string)dataRecord["FirstName"] 
            };
        }

        internal static Category ToCategory(this IDataRecord dataRecord)
        {
            return new Category() { CategoryId = 
                (int)dataRecord["CategoryId"], 
                Name = (string)dataRecord["Name"] 
            };
        }

        internal static Customer ToCustomer(this IDataRecord dataRecord)
        {
            return new Customer() { 
                CustomerId = (int)dataRecord["CustomerId"], 
                LastName = (string)dataRecord["LastName"], 
                FirstName = (string)dataRecord["FirstName"], 
                Email = (string)dataRecord["Email"] 
            };
        }

        internal static Film ToFilm(this IDataRecord dataRecord)
        {
            return new Film() { 
                FilmId = (int)dataRecord["FilmId"],
                Title = (string)dataRecord["Title"],
                Description = (string)dataRecord["Description"],
                ReleaseYear = (int)dataRecord["ReleaseYear"],
                Language = (string)dataRecord["Language"],
                RentalDuration = (int)dataRecord["RentalDuration"],
                RentalPrice = (decimal)dataRecord["RentalPrice"],
                Length = (int)dataRecord["Length"],
                ReplacementCost = (decimal)dataRecord["ReplacementCost"],
                Rating = (string)dataRecord["Rating"]
            };
        }

        internal static Language ToLanguage(this IDataRecord dataRecord)
        {
            return new Language() { 
                LanguageId = (int)dataRecord["LanguageId"], 
                Name = (string)dataRecord["Name"] 
            };
        }
    }
}
