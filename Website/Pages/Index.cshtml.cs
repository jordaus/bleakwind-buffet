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

        public List<IOrderItem> Entree { get; set; }

        public List<IOrderItem> Drink { get; set; }

        public List<IOrderItem> Side { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, string[] FoodType, double? PriceMin, double? PriceMax, int? CalMin, int? CalMax)
        {
            //Order = Menu.Search(SearchTerms);
            //Order = Menu.FilterByFoodType(Order, FoodType);
            //Order = Menu.FilterByCalories(Order, CalMin, CalMax);
            //Order = Menu.FilterByPrice(Order, PriceMin, PriceMax);

            Order = Menu.FullMenu();

            //Search Terms
            if(SearchTerms != null)
            {
                string temp = SearchTerms;
                string[] words = temp.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Order = Order.Where(item =>
                item.ToString() != null && item.ToString().Contains(SearchTerms, StringComparison.CurrentCultureIgnoreCase) ||
                item.Description != null && item.Description.Contains(SearchTerms, StringComparison.CurrentCultureIgnoreCase) ||
                item.Description != null && item.Description.Contains(words[0]) ||
                item.Description != null && words.Length == 2 && item.Description.Contains(words[1]) ||
                item.Description != null && words.Length == 3 && item.Description.Contains(words[1]) ||
                item.Description != null && words.Length == 3 && item.Description.Contains(words[2]));
            }

            //filter by choice
            if(FoodType.Length != 0)
            {
                Order = Order.Where(item =>
                item is BleakwindBuffet.Data.Entrees.Entree && FoodType.Contains("Entree") ||
                item is BleakwindBuffet.Data.Sides.Side && FoodType.Contains("Side") ||
                item is BleakwindBuffet.Data.Drinks.Drink && FoodType.Contains("Drink"));
            }

            //Filter by Calories
            //Max calories
            if(CalMin == null && CalMax != null)
            {
                Order = Order.Where(item => item.Calories <= CalMax);
            }
            //Filter for Min Calories
            if (CalMax == null && CalMin != null)
            {
                Order = Order.Where(item => item.Calories >= CalMin);
            }
            //Max and Min
            if (CalMin != null && CalMax != null)
            {
                Order = Order.Where(item => 
                item.Calories >= CalMin && item.Calories <= CalMax);
            }

            //Price filter
            if(PriceMin == null && PriceMax != null)
            {
                Order = Order.Where(item => item.Price <= PriceMax);
            }
            if(PriceMax == null && PriceMin != null)
            {
                Order = Order.Where(item => item.Price >= PriceMin);
            }
            if(PriceMin != null && PriceMax != null)
            {
                Order = Order.Where(item => item.Price >= PriceMin && item.Price <= PriceMax);
            }

            Entree = new List<IOrderItem>();
            Drink = new List<IOrderItem>();
            Side = new List<IOrderItem>();

            foreach (IOrderItem item in Order)
            {
                if (item is BleakwindBuffet.Data.Entrees.Entree)
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
