using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechLiebertLab5.Model
{
    public partial class Product
    {
        public static IQueryable<Product> GetAllProducts(DataClasses1DataContext dataContext)
        {
            /*var query = from product in dataContext.Products /*where product.ProductName.StartsWith("G") orderby product.ProductID descending select new { product.ProductID, product.ProductName, product.UnitPrice };*/
            return from product in dataContext.Products select product;
        }
    }
}
