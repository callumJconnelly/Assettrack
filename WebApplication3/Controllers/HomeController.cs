using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(AppDbContext ctx)
        {
            _ctx = ctx;

        }

           private AppDbContext _ctx;


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View(new Post());
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Post post)
        {
            _ctx.Posts.Add(post);
            await _ctx.SaveChangesAsync();

            return RedirectToAction("index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
