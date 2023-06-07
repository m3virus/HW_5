using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using ConsoleApp1.domain;


namespace ConsoleApp1
{
    class StockRepository : IStockRepository
    {
        public string BuyProduct(Stock productInStock)
        {
            throw new NotImplementedException();
        }

        public List<Stock> GetSalesProductList()
        {
            throw new NotImplementedException();
        }

        public string SaleProduct(int productId, int cnt)
        {
            throw new NotImplementedException();
        }
    }
}
