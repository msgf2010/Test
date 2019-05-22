using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using URLShortner.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using URLShortner.Data;

//Create a simple URL Shortener.
//The purpose of this application is to give users the ability to enter a long url,
//  and be given a much smaller shorter URL, that when accessed, will redirect the user to the original URL.

//Here's the basic functionality:
//On the home page, there should be a textbox and a button. When the button is clicked,
//  via ajax, display the "shortened" url to the user beneath the textbox.
//E.g. if your site is at "http://localhost:12345" and the user submits a url to be shortened,
//  it should display something like: "http://localhost:12345/fjopUsS".

//There will also be a login system for this application.
//The purpose of this is that if a logged in user enters a URL to be shortened,
//  we will give them a way to view the amount of times that shortened URL was accessed.
//The way we'll do that is that for logged in users, there will be a link on top that says "My URLs" that when clicked,
//  will take them to a page that will display all the URLs they've ever shortened, as well as a number indicating how many views it got.

//Use the shortid library from Nuget to generate the short ids. Use attribute routing to enable the dynamic url part.

namespace URLShortner.Web.Controllers
{
    public class HomeController : Controller
    {
        private string _connectionString;

        public HomeController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ConStr");
        }

        public IActionResult Index()
        {
            var authDb = new Authentication(_connectionString);
            var user = authDb.GetByEmail(User.Identity.Name);

            var repo = new URLRepository(_connectionString);
            
            return View();
        }

        public IActionResult ShortenURL(URL url)
        {
            var authDb = new Authentication(_connectionString);
            var user = authDb.GetByEmail(User.Identity.Name);

            var repo = new URLRepository(_connectionString);

            return View();
        }

        [Authorize]
        public IActionResult ListOfURLs()
        {
            var authDb = new Authentication(_connectionString);
            var user = authDb.GetByEmail(User.Identity.Name);

            var repo = new URLRepository(_connectionString);

            return View();
        }
    }
}
