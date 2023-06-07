using ConsoleApp1.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProductRepository : IProdcutRepository
    {
        public string AddProduct(Product product)
        {
            
        }

        public string GetProductByID(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductList()
        {
            throw new NotImplementedException();
        }
    }
}
