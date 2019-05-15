using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Model;

namespace ServiceLayer
{
    public class CountryService : ICountryService
    {
        private readonly ITPRepository<Country> _countryRepository;

        public CountryService(ITPRepository<Country> countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IEnumerable<Country> GetAllCountries()
        {
            return _countryRepository.GetAll(); 
        }

        public Country GetCountry(long id)
        {
            return _countryRepository.Get(id);
        }
    }
}
