using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Place : BaseModel
    {
        private readonly ILazyLoader _lazyLoader;
        public Place()
        {
        }
        public Place(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
        public string Picture { get; set; }

        public int CountryId { get; set; }
        private Country _Country;

        public Country Country
        {
            get => _lazyLoader.Load(this, ref _Country);
            set => _Country = value;
        }
    }
}
