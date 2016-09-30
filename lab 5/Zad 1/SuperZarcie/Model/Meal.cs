using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperZarcie.Model
{
    public partial class Meal
    {
        public static IQueryable<Meal> GetAllMeals(DataClassesSuperZarcieDataContext dataContext)
        {
            /*var query = from product in dataContext.Products /*where product.ProductName.StartsWith("G") orderby product.ProductID descending select new { product.ProductID, product.ProductName, product.UnitPrice };*/
            return from meal in dataContext.Meals select meal;
        }
    }
}
