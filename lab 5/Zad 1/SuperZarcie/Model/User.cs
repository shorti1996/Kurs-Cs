using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperZarcie.Model
{
    public partial class User
    {
        public static IQueryable<User> GetAllUsers(DataClassesSuperZarcieDataContext dataContext)
        {
            /*var query = from product in dataContext.Products /*where product.ProductName.StartsWith("G") orderby product.ProductID descending select new { product.ProductID, product.ProductName, product.UnitPrice };*/
            return from user in dataContext.Users select user;
        }
    }
}
