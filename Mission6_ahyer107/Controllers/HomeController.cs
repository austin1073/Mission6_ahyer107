using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_ahyer107.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_ahyer107.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //Connecting the model to the database
        private MovieFormResponses blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieFormResponses someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        //Homepage view
        public IActionResult Index()
        {
            return View();
        }

        //Podcasts view
        public IActionResult MyPodcasts()
        {
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }

        //If the user requests a get it will load the form
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        //If the user submits the form and the form is valid, then it will send them to the success page
        [HttpPost]
        public IActionResult MovieForm (MovieFormResponse ar)
        {
            if (ModelState.IsValid)
            {
                blahContext.Add(ar);
                blahContext.SaveChanges();
                return View("Success", ar);
            }
            else
            {
                return View();
            }

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
