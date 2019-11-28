using CFMVC.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFMVC.ViewModels
{
    public class ProductCreateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public IFormFile Image { get; set; }

        public int DrinkTypeId { get; set; }
        public DrinkType DrinkType { get; set; }
    }
}
