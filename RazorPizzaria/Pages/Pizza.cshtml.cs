using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaria.Models;

namespace RazorPizzaria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ ImageTitle="custompizza", PizzaName="Magerita", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice = 10},
            new PizzasModel(){ ImageTitle="custompizza", PizzaName="Aloha Chicken", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice = 10},
            new PizzasModel(){ ImageTitle="custompizza", PizzaName="Peperoni", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice = 10},
            new PizzasModel(){ ImageTitle="custompizza", PizzaName="Beef", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice = 10},
            new PizzasModel(){ ImageTitle="custompizza", PizzaName="Vegetable", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice = 10},
            new PizzasModel(){ ImageTitle="custompizza", PizzaName="Mix Chicken Beef", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice = 10},
            new PizzasModel(){ ImageTitle="custompizza", PizzaName="Pineaple", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice = 10},
            new PizzasModel(){ ImageTitle="custompizza", PizzaName="Bean", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice = 10},
        };
        public void OnGet()
        {
        }
    }
}
