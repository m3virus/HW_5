using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.domain
{
    class Stock
    {
        public int StockID { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public long ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        
    }
}
