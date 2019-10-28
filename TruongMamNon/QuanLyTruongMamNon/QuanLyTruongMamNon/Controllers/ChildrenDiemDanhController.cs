using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyTruongMamNon.Models;

namespace QuanLyTruongMamNon.Controllers
{
    public class ChildrenDiemDanhController : Controller
    {
        private readonly IChildrenDiemDanhRePo childrenDiemDanhRePo;
        public int MyProperty { get; set; }

        public ChildrenDiemDanhController(IChildrenDiemDanhRePo childrenDiemDanhRePo)
        {
            this.childrenDiemDanhRePo = childrenDiemDanhRePo;
        }
        public IActionResult List()
        {
            var treEmDiemDanh = childrenDiemDanhRePo.GetAll();
            return View(treEmDiemDanh);
        }

    }
}