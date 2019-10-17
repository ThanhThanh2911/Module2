using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Myself.Data;
using Myself;

namespace MySelfApp.Pages.MySelf
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IMyselfData myselfData;

        public string Message { get; set; }

        [BindProperty(SupportsGet =true)]
        public string SearchKeyWord { get; set; }
        public IEnumerable<Myself1> Myselves { get; set; }
        //ctor
        public ListModel(IConfiguration config, IMyselfData myselfData)
        {
            this.config = config;
            this.myselfData = myselfData;
        }
        public void OnGet()
        {
            Message = config["Message"];
            Myselves = myselfData.GetMyselvesByName(SearchKeyWord);
        }
    }
}