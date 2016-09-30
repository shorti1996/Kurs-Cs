using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechLiebertEgzA.Model
{
    public partial class Product
    {
        public static IQueryable<Product> GetAllProducts(DataClasses1DataContext dataContext)
        {
            return from product in dataContext.Products select product;
        }
    }
}
