using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quotingdojo.Models;
using Microsoft.EntityFrameworkCore;

namespace quotingdojo.Controllers
{
    public class newqdController : Controller
    {
        private quotingdojoContext _context;
        public newqdController(quotingdojoContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.authors = _context.authors.ToList();
            ViewBag.cats = _context.categories.ToList();
            return View();

        }
        [HttpPost]
        [Route("author/create")]
        public IActionResult AddAuthor(AuthorViewModel incoming)
        {
            if(ModelState.IsValid)
            {
                System.Console.WriteLine("All good in da hood!");
                Author NewAuthor = new Author{
                    name = incoming.name,
                };
                _context.authors.Add(NewAuthor);
                _context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("All is not good in da hood. :(");
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Route("quote/create")]
        public IActionResult AddQuote(QuoteViewModel incoming)
        {
            if(ModelState.IsValid)
            {
                System.Console.WriteLine("Goodness!");
            }
            else
            {
                System.Console.WriteLine("Badness. :(");
            }
            return RedirectToAction("Index");
        }
    }
}
