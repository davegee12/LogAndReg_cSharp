using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LogAndRegCSharp.Models;

namespace LogAndRegCSharp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost("create/register")]
        public IActionResult CreateRegUser(RegUser user)
        {
            if(ModelState.IsValid)
            {
                return View("Success", user);
            }
            else
            {
                return View("Index");
            }
        }
        [HttpPost("create/login")]
        public IActionResult CreateLogUser(LogUser user)
        {
            if(ModelState.IsValid)
            {
                return View("Success", user);
            }
            else
            {
                return View("Index");
            }
        }
    }
}
