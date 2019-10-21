using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace StudentMVC.Controllers
{
    public class EmailController : Controller
    {
        private readonly IConfiguration config;

        public string Mess { get; set; }

        public EmailController(IConfiguration config)
        {
            this.config = config;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string receiverEmail, string subject, string message)
        {
            //try
            //{
                if (ModelState.IsValid)
                {
                    var senderemail = new MailAddress("laithanhthanh2911@gmail.com", "Sender");
                    var receiveremail = new MailAddress(receiverEmail, "Receiver");

                    var password = config["Mess"];
                    var sub = subject;
                    var body = message;  

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderemail.Address, password)
                    };

                    using (var mess = new MailMessage(senderemail, receiveremail)
                    {
                        Subject = subject,
                        Body = body 
                    }
                    )
                    {
                        smtp.Send(mess);
                    }


                    return View();
                }
            //}
            //catch (Exception)
            //{
            //    ViewBag.Error = "There are some problems in sending email";
            //}
            return View();
        }
    }
}