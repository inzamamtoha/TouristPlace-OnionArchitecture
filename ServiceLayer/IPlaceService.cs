using DataLayer.Model;
using System.Collections.Generic;

namespace ServiceLayer
{
    public interface IPlaceService
    {
        IEnumerable<Place> GetAllPlaces();
        IEnumerable<Place> GetFilterPlaces(string SearchKey, string SelectKey);
        Place GetPlace(long id);
        void InsertPlace(Place place);
        void UpdatePlace(Place place);
        void DeletePlace(long id);
    }
}
