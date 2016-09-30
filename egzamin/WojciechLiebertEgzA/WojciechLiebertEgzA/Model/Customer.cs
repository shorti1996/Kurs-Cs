using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechLiebertEgzA.Model
{
    public partial class Customer
    {
        public static IQueryable<Customer> GetAllCustomers(DataClasses1DataContext dataContext)
        {
            return from customer in dataContext.Customers where customer.Country=="Mexico" || customer.Country=="Brazil" select customer;
        }
    }
}
