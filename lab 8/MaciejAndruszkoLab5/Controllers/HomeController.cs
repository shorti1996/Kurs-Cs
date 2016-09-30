using MaciejAndruszkoLab5.Models;
using MaciejAndruszkoLab5.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaciejAndruszkoLab5.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            context = new PizzaStoreDbContext();
        }
        private PizzaStoreDbContext context;
        public ActionResult Index()
        {
            return View(context.Pizzas.ToList());
        }
        public PartialViewResult _Details(int id)
        {
            Pizza pizza = context.Pizzas.Find(id);
            DetailModelView mv = new DetailModelView();
            mv.Pizza = pizza;
            float sum = 0;
            foreach (var item in pizza.Components)
            {
                sum += item.Price;
            }
            mv.ComponentPrice = sum;
            return PartialView("~/Views/Home/_DetailsModal.cshtml", mv);
        }
        public ActionResult Add()
        {
            return View(new Pizza());
        }
        [HttpPost]
        public ActionResult AddNewPizza(Pizza pizza)
        {
            context.Pizzas.Add(pizza);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Pizza pizzaToDelete = context.Pizzas.Find(id);
            context.Pizzas.Remove(pizzaToDelete);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "About page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}