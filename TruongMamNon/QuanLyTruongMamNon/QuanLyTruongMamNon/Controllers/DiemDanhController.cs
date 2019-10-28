using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QuanLyTruongMamNon.Controllers
{
    public class DiemDanhController : Controller
    {
        public IActionResult CheckIn()
        {
            return View();
        }

        public IActionResult CheckOut()
        {
            return View();
        }
    }
}