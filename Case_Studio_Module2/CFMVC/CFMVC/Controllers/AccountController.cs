using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CFMVC.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Account account)
        {
            if (ModelState.IsValid)
            {

            }
            return View(account);
        }

        //private bool CheckUserName(string userName)
        //{

        //}
    }
}