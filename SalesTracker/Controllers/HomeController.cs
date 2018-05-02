using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesTracker.Models;

namespace SalesTracker.Controllers
{
    public class HomeController : Controller
    {
        //private ApplicationDbContext _db = new ApplicationDbContext();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        //public IActionResult RandomItemsList(int itemCount)
        //{
        //    var randomItemList = _db.Items.OrderBy(r => Guid.NewGuid()).Take(itemCount);
        //    return Json(randomItemList);
        //}
    }
}
