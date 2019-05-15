using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Country : BaseModel
    {
        public string Name { get; set; }

        public ICollection<Place> Places { get; set; }
    }
}
