using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductObject
    {
        IEnumerable<ProductObject> GetProducts();
        ProductObject GetProductById(int productId);
        int InsertProduct(ProductObject product);

        int UpdateProduct(ProductObject product);

        int DeleteProduct(int productId);
    }
}
