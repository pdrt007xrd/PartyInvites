﻿using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Saludando = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {   //esto es una validacion de error
                return View();
            }
        }

        public ViewResult ListResponse()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
//    public class HomeController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }

//        public IActionResult About()
//        {
//            ViewData["Message"] = "Your application description page.";

//            return View();
//        }

//        public IActionResult Contact()
//        {
//            ViewData["Message"] = "Your contact page.";

//            return View();
//        }

//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}
