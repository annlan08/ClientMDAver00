using ClientMDA.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientMDA.Controllers
{
    public class MemberController : Controller
    {
        List<CMemberDemoViewModel> members = new List<CMemberDemoViewModel>();
        CMemberDemoViewModel memberDemo1 = new CMemberDemoViewModel
        {
            MemberID = 2,
            Cellphone = "0902002002",
            Email = "002@gmail.com",
            Password = "0000",
            Formal = false,
            Permission = 0,
            CreatedTime = DateTime.Now,
        };
        CMemberDemoViewModel memberDemo2 = new CMemberDemoViewModel
        {
            MemberID = 1,
            Cellphone = "0901001001",
            Email = "001@gmail.com",
            Password = "0000",
            Formal = true,
            Permission = 0,
            Address = "台北市",
            BirthDate = new DateTime(1990, 1, 1),
            F_Name = "Wei",
            L_Name = "Wang",
            NickName = "Yuka",
            Gender = 1,
            Bonus = 100,
            CreatedTime = new DateTime(2022, 6, 15),
        };
        public IActionResult MemberMain()
        {

            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(CLoginViewModel vModel)
        {
            if (vModel.txtphone == "0901001001")
                return RedirectToAction("Login2");
            else
                return RedirectToAction("SignUp");
        }
        public IActionResult Login2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login2(CLogin2ViewModel vModel)
        {
            if (vModel.txtPassword == "0000")
                return RedirectToAction("MemberMain");
            else return View();
        }
        public IActionResult SignUp(CLoginViewModel vModel)
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp()
        {
            return RedirectToAction("MemberMain");
        }
        public IActionResult MemberEdit()
        {
            return View();
        }

        public IActionResult CommentList()
        {
            return View();
        }
        public IActionResult CommentEdit()
        {
            return View();
        }
        public IActionResult FollowList()
        {
            return View();
        }
        public IActionResult WatchList()
        {
            return View();
        }

        public IActionResult PasswordEdit()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
        public IActionResult MemberBonusList()
        {
            return View();
        }
        public IActionResult MemberDiscount()
        {
            return View();
        }
        public IActionResult OrderList()
        {
            return View();
        }
    }
}
