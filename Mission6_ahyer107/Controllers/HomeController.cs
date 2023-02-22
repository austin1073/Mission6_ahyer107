using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        //Connecting the model to the database
        private MovieFormResponses daContext { get; set; }

        public HomeController(MovieFormResponses someName)
        {
            daContext = someName;
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

        //Successful addition view
        public IActionResult Success()
        {
            return View();
        }

        //If the user requests a get it will load the form
        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = daContext.Categories.ToList();

            return View();
        }

        //If the user submits the form and the form is valid, then it will send them to the success page
        [HttpPost]
        public IActionResult MovieForm (MovieFormResponse ar)
        {
            if (ModelState.IsValid)
            {
                daContext.Add(ar);
                daContext.SaveChanges();
                return View("Success", ar);
            }
            else
            {
                ViewBag.Categories = daContext.Categories.ToList();
                return View();
            }

        }

        //Shows the list of movies
        public IActionResult MovieList ()
        { 

            var movies = daContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movies);
        }

        //Shows the get for the edit action
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = daContext.Categories.ToList();

            var submission = daContext.Responses.Single(x => x.MovieId == movieid);

            return View("MovieForm", submission);
        }

        //Action for updating a record
        [HttpPost]
        public IActionResult Edit(MovieFormResponse mfr)
        {
            daContext.Update(mfr);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        //Pulls up the delete page
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var submission = daContext.Responses.Single(x => x.MovieId == movieid);
            return View(submission);
        }
        //Deletes the record after the user confirms
        [HttpPost]
        public IActionResult Delete(MovieFormResponse mfr)
        {
            daContext.Responses.Remove(mfr);
            daContext.SaveChanges();
            
            return RedirectToAction("MovieList");
        }

    }
}
