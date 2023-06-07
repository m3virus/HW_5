using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.domain;
using System.Text.Json;
using System.IO;


namespace ConsoleApp1
{
    interface IStockRepository
    {
        string SaleProduct(int productId, int cnt);
        string BuyProduct(Stock productInStock);
        List<Stock> GetSalesProductList();
    }
}
