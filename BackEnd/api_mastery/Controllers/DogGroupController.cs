using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_mastery.Controllers
{
    public class DogGroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}