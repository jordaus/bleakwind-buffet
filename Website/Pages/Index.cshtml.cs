using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<IOrderItem> Order { get; set; }
        public string SearchTerms { get; set; }
        public string[] FoodType { get; set; } = new string[0];
        public double PriceMax { get; set; }
        public double PriceMin { get; set; }
        public int CalMin { get; set; }
        public int CalMax { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, string[] FoodType, double? PriceMin, double? PriceMax, int? CalMin, int? CalMax)
        {
            Order = Menu.Search(SearchTerms);
            Order = Menu.FilterByFoodType(Order, FoodType);
            Order = Menu.FilterByCalories(Order, CalMin, CalMax);
            Order = Menu.FilterByPrice(Order, PriceMin, PriceMax);


        }
    }
}
