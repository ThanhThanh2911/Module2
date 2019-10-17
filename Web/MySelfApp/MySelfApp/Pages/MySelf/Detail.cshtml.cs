using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Myself.Data;
using Myself;

namespace MySelfApp.Pages.MySelf
{
    public class DetailModel : PageModel
    {
        private readonly IMyselfData myselvesData;

        public Myself1 Myself { get; set; }

        //ctor
        public DetailModel(IMyselfData myselvesData)
        {
            this.myselvesData = myselvesData;
        }

        //IActionResult -void
        public IActionResult OnGet(int myselfId)
        {
            Myself = new Myself1();
            Myself.Id = myselfId;
            Myself = myselvesData.GetById(myselfId);
            if(Myself == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }

    
}