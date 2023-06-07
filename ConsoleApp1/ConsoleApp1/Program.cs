using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.domain;
using Newtonsoft.Json;
using ConsoleApp1.repository;

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
        public static void ProductManagement(int entry)
        {
            ProductRepository a = new ProductRepository();
            do
            {
                if (entry == 1)
                {

                    Product product = new Product();
                    Console.WriteLine("enter your product name");
                    product.Name = Console.ReadLine();
                    product.Barcode = new Guid();
                    product.ProductID = productID();
                    a.AddProduct(product);

                }
                else if (entry == 2)
                {
                    Console.WriteLine("enter the Id of the product");
                    int number = int.Parse(Console.ReadLine());
                    a.GetProductByID(number);
                }
                else if (entry == 3)
                {
                    a.GetProductList();
                }
                else
                {
                    break;
                }
            } while (entry != 4);
        }
        static void Main(string[] args)
        {
            int menuNumber;
            int productMenuNumber;
            int stickMenuNumber;
            do
            {
                Menu();
                menuNumber = int.Parse(Console.ReadLine());

                if(menuNumber == 1)
                {
                    ProductMenu();
                    productMenuNumber = int.Parse(Console.ReadLine());
                    ProductManagement(productMenuNumber);
                }
                else if (menuNumber == 2)
                {

                }
                else
                {
                    break;
                }

            } while (menuNumber != 3);
            
        }
        
    }
}
