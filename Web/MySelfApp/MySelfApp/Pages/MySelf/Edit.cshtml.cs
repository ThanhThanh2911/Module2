using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Myself;
using Myself.Data;

namespace MySelfApp.Pages.MySelf
{
    public class EditModel : PageModel
    {
        private readonly IMyselfData myselfData;
        private readonly IHtmlHelper htmlHelper;

        public Myself1 myselfs { get; set; }
        public IEnumerable<SelectListItem> Types { get; set; }
        public EditModel(IMyselfData myselfData, IHtmlHelper htmlHelper)
        {
            this.myselfData = myselfData;
            this.htmlHelper = htmlHelper;
        }
        public void OnGet()
        {
            myselfs = new Myself1();
        }
    }
}