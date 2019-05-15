using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using WebLayer.Models;

namespace WebLayer.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IPlaceService placeService;
        private readonly ICountryService countryService;
        private readonly IHostingEnvironment hostingEnvironment;
        const string SessionSearch = "_Search";
        const string SessionSelect = "_Select";

        public HomeController(IPlaceService placeService, ICountryService countryService, IHostingEnvironment hostingEnvironment)
        {
            this.placeService = placeService;
            this.countryService = countryService;
            this.hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public IActionResult Index(string SearchKey, string SelectKey)
        {
            if (SearchKey == null)
            {
                SearchKey = "";
            }

            if (SelectKey == null)
            {
                SelectKey = "none";
            }

            HttpContext.Session.SetString(SessionSelect, SelectKey);
            HttpContext.Session.SetString(SessionSearch, SearchKey);
            ViewBag.Search = SearchKey;
            ViewBag.Select = SelectKey;
            /*
            var countryList = countryService.GetAllCountries();
            var ob = placeService.GetFilterPlaces(SearchKey, SelectKey).ToList().Join(countryList, p => p.CountryId, c => c.Id,
               (p,c) => new PlaceViewModel {
               Id = p.Id,
               Name = p.Name,
               Address = p.Address,
               Rating = p.Rating,
               Picture = p.Picture,
               Country = p.Country.Name
               });
            return View(ob);
            */

            List<PlaceViewModel> placeModel = new List<PlaceViewModel>();
            placeService.GetFilterPlaces(SearchKey, SelectKey).ToList().ForEach(p =>
            {
                PlaceViewModel _place = new PlaceViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Address = p.Address,
                    Rating = p.Rating,
                    Picture = p.Picture,
                    Country = p.Country.Name
                };
                placeModel.Add(_place);
            });
            return View(placeModel);
        }

        public IActionResult Create()
        {
            List<CountryViewModel> countryModel = new List<CountryViewModel>();
            countryService.GetAllCountries().ToList().ForEach(u =>
            {
                CountryViewModel _country = new CountryViewModel
                {
                    Id = u.Id,
                    Name = u.Name
                };
                countryModel.Add(_country);
            });
            return View(countryModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string Name, string Address, int Rating, IFormFile Picture, int CountryId)
        {
            Place plc = new Place();
            if (Picture != null)
            {
                var fileName = Path.Combine(hostingEnvironment.WebRootPath + "/images", DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetFileName(Picture.FileName));
                FileStream fs = new FileStream(fileName, FileMode.Create);
                await Picture.CopyToAsync(fs);
                fs.Close();
                plc.Picture = "~/images/" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetFileName(Picture.FileName);
            }

            plc.Name = Name;
            plc.Address = Address;
            plc.Rating = Rating;
            plc.CountryId = CountryId;

            placeService.InsertPlace(plc);

            string searchKey = HttpContext.Session.GetString(SessionSearch);
            string selectKey = HttpContext.Session.GetString(SessionSelect);
            return RedirectToAction("Index", "Home", new { SearchKey = searchKey, SelectKey = selectKey });
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            List<CountryViewModel> countryModel = new List<CountryViewModel>();
            countryService.GetAllCountries().ToList().ForEach(u =>
            {
                CountryViewModel _country = new CountryViewModel
                {
                    Id = u.Id,
                    Name = u.Name
                };
                countryModel.Add(_country);
            });
            ViewData["Country"] = countryModel.ToList();

            Place _place = placeService.GetPlace((long)id);

            PlaceViewModel placeModel = new PlaceViewModel
            {
                Id = _place.Id,
                Name = _place.Name,
                Address = _place.Address,
                Rating = _place.Rating,
                Picture = _place.Picture,
                Country = _place.Country.Name
            };
            
            return View(placeModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int Id, string Name, string Address, int Rating, IFormFile Picture, string PicPath, int CountryId)
        {
            if(placeService.GetPlace(Id)== null)
            {
                return NotFound();
            }

            Place plc = placeService.GetPlace(Id);
            if (Picture != null)
            {
                var fileName = Path.Combine(hostingEnvironment.WebRootPath + "/images", DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetFileName(Picture.FileName));
                FileStream fs = new FileStream(fileName, FileMode.Create);
                await Picture.CopyToAsync(fs);
                fs.Close();
                plc.Picture = "~/images/" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetFileName(Picture.FileName); 
            }
            else
            {
                plc.Picture = PicPath;
            }
            plc.Name = Name;
            plc.Address = Address;
            plc.Rating = Rating;
            plc.Id = Id;
            plc.CountryId = CountryId;

            placeService.UpdatePlace(plc);

            string searchKey = HttpContext.Session.GetString(SessionSearch);
            string selectKey = HttpContext.Session.GetString(SessionSelect);
            return RedirectToAction("Index", "Home", new { SearchKey = searchKey, SelectKey = selectKey });
        }

       

        public IActionResult DeleteConfirmed(int id)
        {
            var fileName = placeService.GetPlace(id);
            string fName = "";

            for (int i = 1; i < fileName.Picture.Length; i++)
            {
                fName += fileName.Picture[i];
            }

            string fullPath = Path.Combine(hostingEnvironment.WebRootPath + fName);
            GC.Collect();

            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
                placeService.DeletePlace(id);
            }

            string searchKey = HttpContext.Session.GetString(SessionSearch);
            string selectKey = HttpContext.Session.GetString(SessionSelect);
            return RedirectToAction("Index", "Home", new { SearchKey = searchKey, SelectKey = selectKey });
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.SetString(SessionSelect, "none");
            HttpContext.Session.SetString(SessionSearch, "");
            return RedirectToAction("Index", "LogIn");
        }

    }
}
