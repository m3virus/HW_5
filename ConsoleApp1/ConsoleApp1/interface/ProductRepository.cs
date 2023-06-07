using ConsoleApp1.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class ProductRepository : IProdcutRepository
    {
        public static bool CheckProductName(string name) 
        {
            if(Regex.IsMatch(name, @"[A-Z][a-z]{3}\_\d{3}"))
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public void AddProduct(Product product)
        {
            

            try
            {

                string fileName = "ProductJson.json";
                var jsonData = File.ReadAllText(fileName);
                List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(jsonData);
                productList.Add(product);
                string jsonDataUpdate = JsonConvert.SerializeObject(productList, Formatting.Indented);
                File.WriteAllText(fileName, jsonDataUpdate);
                

            }
            catch (Exception FileEx)
            {
                Console.WriteLine(FileEx.Message);
                
            }


        }

        public string GetProductByID(int ID)
        {
            try
            {
                
                string fileName = "ProductJson.json";
                var jsonData = File.ReadAllText(fileName);
                List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(jsonData);
                foreach( var i in productList)
                {
                    if (i.ProductID == ID)
                    {
                        return i.Name;
                    }
                    else
                    {
                        return "your ID is invalid";
                    }
                }


            }
            catch (Exception FileEx)
            {
                return FileEx.Message;

            }

        }

        public List<Product> GetProductList()
        {
            string fileName = "ProductJson.json";
            var jsonData = File.ReadAllText(fileName);
            List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(jsonData);
            return productList;
        }
        
    }
}
