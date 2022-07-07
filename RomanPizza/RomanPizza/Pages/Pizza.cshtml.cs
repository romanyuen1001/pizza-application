using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RomanPizza.Models;

namespace RomanPizza.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle = "Margerita",
                PizzaName = "Magerita",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                FinalPrice = 4
            },
            new PizzasModel(){ImageTitle = "Vegetarian",
                PizzaName = "Vegetarian",
                BasePrice = 2,
                Mushroom = true,
                FinalPrice = 3
            }
        };

        public void OnGet()
        {
        }
    }
}
