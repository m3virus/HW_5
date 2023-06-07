using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.domain;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("welcome to program how can I help you?");
            Console.WriteLine("1.product management");
            Console.WriteLine("2.stock management");
            Console.WriteLine("3.exit");
        }
        public static void ProductMenu()
        {
            Console.WriteLine("product menu");
            Console.WriteLine("1.add product");
            Console.WriteLine("2.get product by id");
            Console.WriteLine("3.get all products");
            Console.WriteLine("4.back");
        }
        public static void StockMenu()
        {
            Console.WriteLine("stock menu");
            Console.WriteLine("1.buy product");
            Console.WriteLine("2.sale product");
            Console.WriteLine("3.get sales list");
            Console.WriteLine("4.back");
        }
        public static int productID()
        {
            int number = 1;
            string fileName = "ProductJson.json";
            var jsonData = File.ReadAllText(fileName);
            List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(jsonData);
            foreach(var i in productList)
            {
                if (i.ProductID >= number)
                {
                    number = i.ProductID + 1;
                    
                }
                
            }
            return number;

        }
        static void Main(string[] args)
        {
            Menu();
            int menuNumber = int.Parse(Console.ReadLine());
            switch (menuNumber)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
        
    }
}
