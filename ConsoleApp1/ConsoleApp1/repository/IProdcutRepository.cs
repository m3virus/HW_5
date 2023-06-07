using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.domain;

namespace ConsoleApp1.repository

{
    interface IProdcutRepository
    {
        
        void AddProduct(Product product);
        List<Product> GetProductList();
        string GetProductByID(int ID);

    }
}

