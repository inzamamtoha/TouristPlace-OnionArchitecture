using DataLayer.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TouristPlaceContext(serviceProvider.GetRequiredService<DbContextOptions<TouristPlaceContext>>()))
            {
                if (!context.UserLogIn.Any())
                {
                    context.UserLogIn.AddRange(
                    new UserLogIn
                    {
                        UserId = "a",
                        Password = "a"
                    },
                    new UserLogIn
                    {
                        UserId = "toha",
                        Password = "123"
                    }
                    );
                    context.SaveChanges();
                }
                if (!context.Country.Any())
                {
                    context.Country.AddRange(
                    new Country
                    {
                        Name = "Bangladesh"
                    },
                    new Country
                    {
                        Name = "India"
                    },
                    new Country
                    {
                        Name = "Nepal"
                    },
                    new Country
                    {
                        Name = "Thailand"
                    },
                    new Country
                    {
                        Name = "USA"
                    }
                    );
                    context.SaveChanges();
                }

            }
        }
    }
}
