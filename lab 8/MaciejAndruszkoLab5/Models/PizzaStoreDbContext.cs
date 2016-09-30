using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MaciejAndruszkoLab5.Models
{
    public class PizzaStoreDbContext:DbContext
    {
        public PizzaStoreDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer<PizzaStoreDbContext>(new PizzaStoreDbInitializer());
        }
        public DbSet<Pizza> Pizzas { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<Component> Components { set; get; }
    }
}