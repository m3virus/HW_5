using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.domain
{
    [Serializable]
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }

    }
}
