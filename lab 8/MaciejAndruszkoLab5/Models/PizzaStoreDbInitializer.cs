using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MaciejAndruszkoLab5.Models
{
    public class PizzaStoreDbInitializer : DropCreateDatabaseAlways<PizzaStoreDbContext>
    {
        protected override void Seed(PizzaStoreDbContext context)
        {
            Pizza newPizza1 = new Pizza() { isVegetarian = true, Name = "Margarita", Price = 13.45f };
            Pizza newPizza2 = new Pizza() { isVegetarian = false, Name = "Salami", Price = 13.45f };
            Pizza newPizza3 = new Pizza() { isVegetarian = true, Name = "Wegetariańska", Price = 13.45f };
            List<Pizza> list = new List<Pizza>();
            list.Add(newPizza1);
            list.Add(newPizza2);
            list.Add(newPizza3);
 
            context.Pizzas.AddRange(list);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}