using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.Models.Client.Entities
{
    public class Language
    {
        public int LanguageId { get; private set; }
        public string Name { get; private set; }

        internal Language(int languageId, string name)
        {
            LanguageId = languageId;
            Name = name;
        }
    }
}
