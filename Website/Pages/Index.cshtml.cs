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

        public List<IOrderItem> Entree { get; set; }

        public List<IOrderItem> Side { get; set; }

        public List<IOrderItem> Drink { get; set; }

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

            Entree = new List<IOrderItem>();
            Drink = new List<IOrderItem>();
            Side = new List<IOrderItem>();

            foreach(IOrderItem item in Order)
            {
                if(item is BleakwindBuffet.Data.Entrees.Entree)
                {
                    Entree.Add(item);
                }
                if (item is BleakwindBuffet.Data.Sides.Side)
                {
                    Side.Add(item);
                }
                if (item is BleakwindBuffet.Data.Drinks.Drink)
                {
                    Drink.Add(item);
                }
            }
        }
    }
}
