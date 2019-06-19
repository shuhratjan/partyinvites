using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    using PartyInvites.Models;
    using System.Diagnostics.CodeAnalysis;

    public class HomeController : Controller
    {
        // GET: /Home/
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour > 12 ? "Good Afternoon" : "Good Morning";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if(ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }else
            {
                return this.View();
            }
        }
    }
}
