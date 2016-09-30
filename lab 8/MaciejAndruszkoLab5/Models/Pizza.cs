using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaciejAndruszkoLab5.Models
{
    public class Pizza
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public float Price { set; get; }
        public bool isVegetarian{ set;get;}
        public virtual ICollection<Component> Components { set; get; }
    }
}