using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News.Data;

namespace SimpleNewsApp.Pages.TinTucs
{
    public class DetailModel : PageModel
    {
        private readonly ITinTucData tinTucData;

        public DetailModel(ITinTucData tinTucData)
        {
            this.tinTucData = tinTucData;
        }
        public IActionResult OnGet(int studentId)
        {
             
        }
    }
}