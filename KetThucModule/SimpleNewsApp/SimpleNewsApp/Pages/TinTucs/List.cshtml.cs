using Microsoft.AspNetCore.Mvc.RazorPages;
using News.Core;
using News.Data;
using System.Collections.Generic;

namespace SimpleNewsApp.Pages.TinTucs
{
    public class ListModel : PageModel
    {
        private readonly ITinTucData tinTucData;

        public IEnumerable<TinTuc> TinTucs { get; set; }
        public ListModel(ITinTucData tinTucData)
        {
            this.tinTucData = tinTucData;
        }
        public void OnGet()
        {
            TinTucs = tinTucData.GetAll();
        }
    }
}