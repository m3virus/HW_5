using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using ConsoleApp1.domain;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class StockRepository : IStockRepository
    {

        public int GetProductQuantity(int amount , int productID)
        {
            if (productID >= amount)
            {
                return productID - amount;
            }
            else
            {
                return -1;
            }
        }
        public string BuyProduct(Stock productInStock)
        {
            
        }

        public List<Stock> GetSalesProductList()
        {
            throw new NotImplementedException();
        }

        public string SaleProduct(int productId, int amount)
        {
            int check = 0;
            Stock mainStock = new Stock();
            string fileName = "StockJson.json";
            var jsonData = File.ReadAllText(fileName);
            List<Stock> stockList = JsonConvert.DeserializeObject<List<Stock>>(jsonData);

            foreach(var i in stockList)
            {
                if(i.ProductID == productId)
                {
                    mainStock = i;
                    stockList.Remove(mainStock);
                    check++;
                    break;
                }
            }
            if (check == 1)
            {
                var difference = GetProductQuantity(mainStock.ProductQuantity, amount);
                if (difference == -1)
                {
                    stockList.Add(mainStock);
                    string jsonDataUpdate = JsonConvert.SerializeObject(stockList, Formatting.Indented);
                    File.WriteAllText(fileName, jsonDataUpdate);
                    return "we dont have enought amount ";
                }
                else if(difference == 0)
                {
                    string jsonDataUpdate = JsonConvert.SerializeObject(stockList, Formatting.Indented);
                    File.WriteAllText(fileName, jsonDataUpdate);
                    return Convert.ToString(difference);
                }
                else
                {
                    mainStock.ProductQuantity = difference;
                    stockList.Add(mainStock);
                    string jsonDataUpdate = JsonConvert.SerializeObject(stockList, Formatting.Indented);
                    File.WriteAllText(fileName, jsonDataUpdate);
                    return Convert.ToString(difference);
                    
                }
            }
            else
            {
                return "this product is unvalid";
            }
            s

        }
    }
}
