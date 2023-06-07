using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.domain;

namespace ConsoleApp1
{
    interface IProdcutRepository
    {
        void AddProduct(Product product);
        List<Product> GetProductList();
        public string GetProductByID(int ID);

    }
}

