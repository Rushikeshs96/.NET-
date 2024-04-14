﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCDemo.Models;
using System.Diagnostics;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            ViewBag.Country = new List<String>()     //viewbag uses dynamic properties. internally viewbag properties are stores as name/value pair in viewdata disctionery.
            {
                "India",
                "China",
                "Japan",
                "Korea"
            };

            ViewData["City"] = new List<String>()     //uses string keys. viewdata is dictionery of objects
            {
                "Pune",
                "Mumbau",
                "Delhie",
                "satara"
            };

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    
    }
}