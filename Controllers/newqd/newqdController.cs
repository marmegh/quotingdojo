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
            return View();

        }
    }
}
