using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaciejAndruszkoLab5.Models
{
    public class Component
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public float Price { set; get; }
        public int PizzaId { set; get; }
        public virtual Pizza Pizza { set; get; }
    }
}