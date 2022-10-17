using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientMDA.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult 電影排行()
        {
            return View();
        }
    }
}
