using microservices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace microservices.Repository
{
    interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int ProductID);
        void InsertProduct(Product Product);
        void DeleteProduct(int ProductID);
        void UpdateProduct(Product Product);
        void Save();
    }
}
