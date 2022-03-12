using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hellow.Models;
using Hellow.Data;
using Microsoft.EntityFrameworkCore;

namespace Hellow.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var contacts = await _db.Contact.ToListAsync();
            ViewBag.o = contacts;
            return View();
        }

        [HttpGet("/{clientName}/contacts")]
        public async Task<IActionResult> GetContacts([FromRoute]string clientName)

        {
            var contacts = await _db.Contact.ToListAsync();
            ViewBag.o = contacts;
            return View();
        }
    }
}
