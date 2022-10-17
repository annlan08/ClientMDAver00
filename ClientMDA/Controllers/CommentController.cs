using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientMDA.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult 評論首頁()
        {
            return View();
        }
        public IActionResult 會員評論()
        {
            return View();
        }
        public IActionResult 電影評論()
        {
            return View();
        }
        public IActionResult 我的評論()
        {
            return View();
        }
    }
}
