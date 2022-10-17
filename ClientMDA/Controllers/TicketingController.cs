using ClientMDA.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Utils;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientMDA.Controllers
{
    public class TicketingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieInfoIndex()
        {
            return View();
        }
        //public IActionResult MovieInfoIndex2()
        //{
        //    return View();
        //}

        //public IActionResult MovieInfoIndex3()
        //{
        //    return View();
        //}

        public IActionResult SelectMovie()
        {
            return View();
        }

        public IActionResult SelectPartialView()
        {

            return PartialView($"~/Views/Ticketing/_TheaterPartialView.cshtml");
        }

        public IActionResult MoviePartialView()
        {
            return PartialView($"~/Views/Ticketing/_MoviePartialView.cshtml");
        }

        public IActionResult SeatMap(int AA)
        {
            return View(AA);
        }

        public IActionResult PaymentWeb() 
        {
            return View();
        }

        public IActionResult PaymentWeb2()
        {
            return View();
        }

        public IActionResult PaymentWeb3()
        {

            return View();
        }


        public IActionResult SelectByMovie()
        {
            return View();
        }

        public IActionResult SelectTicket()
        {
            return View();
        }

        public IActionResult sendmail()
        {
            MimeMessage message = new MimeMessage();
            BodyBuilder builder = new BodyBuilder();
            var image = builder.LinkedResources.Add("C:\\Users\\Student\\Documents\\123\\ClientMDA\\wwwroot\\images\\Ticketing\\3.jpg");

            string name = "NAME";

            builder.HtmlBody = "<p>你好 ，不能退票</p>" +
                               "<div style='border: 1px solid black;text-align: center;'>一個大框框</div>" +
                              $"<p>當前時間:{DateTime.Now:yyyy-MM-dd HH:mm:ss}</p>"+
                              $"<p>哈哈{name}</p>";

            message.From.Add(new MailboxAddress("MDA訂票官網", "annlan08@outlook.com"));
            message.To.Add(new MailboxAddress("親愛的客戶", "annlan08@gmail.com"));
            message.Subject = "MDA訂票網付款資訊";
            message.Body = builder.ToMessageBody();


            using (SmtpClient client = new SmtpClient())
            {
                client.Connect("smtp.outlook.com", 25, MailKit.Security.SecureSocketOptions.StartTls);
                client.Authenticate("annlan08@outlook.com", "ssbb19970513");
                client.Send(message);
                client.Disconnect(true);
            }

            return Json("K");
        }
    }
}
