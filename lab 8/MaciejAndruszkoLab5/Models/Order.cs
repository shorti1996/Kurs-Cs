using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaciejAndruszkoLab5.Models
{
    public class Order
    {
        public int Id { set; get; }
        public string OrderName { set; get; }
        public int PizzaId { set; get; }
        public virtual Pizza Pizza { set; get; }

    }
}