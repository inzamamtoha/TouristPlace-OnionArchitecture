using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataLayer.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;

namespace TouristPlace.Controllers
{
    public class LogInController : Controller
    {
        private readonly IUserLogInService userLogInService;

        public LogInController(IUserLogInService userLogInService)
        {
            this.userLogInService = userLogInService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(string UserId, string Password)
        {
            UserLogIn myUser = userLogInService.MatchUser(UserId, Password);

            if (myUser != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, myUser.UserId)
                };
                ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Info = "UserId or Password is Wrong";
                return View("Index");
            }
        }
    }
}