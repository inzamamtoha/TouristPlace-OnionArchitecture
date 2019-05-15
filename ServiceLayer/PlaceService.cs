using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Model;

namespace ServiceLayer
{
    public class PlaceService : IPlaceService
    {
        private readonly ITPRepository<Place> _placeRepository;
        private readonly ITPRepository<Country> _countryRepository;

        public PlaceService(ITPRepository<Place> placeRepository, ITPRepository<Country> countryRepository)
        {
            _placeRepository = placeRepository;
            _countryRepository = countryRepository;
        }

        public IEnumerable<Place> GetAllPlaces()
        {
            return _placeRepository.GetAll();
        }

        public IEnumerable<Place> GetFilterPlaces(string SearchKey, string SelectKey)
        {

            var resAll = _placeRepository.GetAll();

            if (SearchKey != null)
            {
                var results = resAll.Where(x => x.Name.Contains(SearchKey));

                if (SelectKey == "asc")
                {
                    results = results.OrderBy(x => x.Rating);
                }
                else if (SelectKey == "desc")
                {
                    results = results.OrderByDescending(x => x.Rating);
                }
                return results;
            }
            return resAll;
        }

        public Place GetPlace(long id)
        {
            return _placeRepository.Get(id);
        }

        public void InsertPlace(Place place)
        {
            _placeRepository.Insert(place);
        }

        public void UpdatePlace(Place place)
        {
            _placeRepository.Update(place);
        }

        public void DeletePlace(long id)
        {
            Place place = GetPlace(id);
            _placeRepository.Delete(place);
        }

    }
}
