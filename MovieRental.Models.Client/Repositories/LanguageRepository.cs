using GlobalLanguage = MovieRental.Models.Global.Entities.Language;

using MovieRental.Models.Client.Entities;
using MovieRental.Models.Common.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using MovieRental.Models.Client.Mappers;

namespace MovieRental.Models.Client.Repositories
{
    public class LanguageRepository : ILanguageRepository<Language>
    {
        readonly ILanguageRepository<GlobalLanguage> _repository;

        public LanguageRepository(ILanguageRepository<GlobalLanguage> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Language> Get()
        {
            return _repository.Get().Select(c => c.ToClient());
        }
    }
}
