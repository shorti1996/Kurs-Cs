using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechLiebertEgzA.Model
{
    public partial class Supplier
    {
        public static IQueryable<Supplier> GetAllSuppliers(DataClasses1DataContext dataContext)
        {
            return from supplier in dataContext.Suppliers select supplier;
        }

        /// <summary>
        /// It has to be join query
        /// </summary>
        /// <param name="dataContext"></param>
        /// <returns></returns>
        public static IQueryable<Supplier> GetAllSuppliersAndProducts(DataClasses1DataContext dataContext)
        {
            return from supplier in dataContext.Suppliers join dataContext.Products on product.Id==supplier.Products select supplier;
        }
    }
}
