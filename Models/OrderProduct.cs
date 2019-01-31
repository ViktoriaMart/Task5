using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderProduct
    {
       
        public int OrderProductId { get; set; }

        public string ProductName { get; set; }

        public double ProductPrice { get; set; }

        public OrderProduct(int id, string name, double price)
        {
            OrderProductId = id;
            ProductName = name;
            ProductPrice = price;
        }

        public OrderProduct()
        {
            OrderProductId = 0;
            ProductName = "";
            ProductPrice = 0;
        }

        //public OrderProduct ReadOrder(string line)
        //{
        //    string[] elements = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //    return (new OrderProduct(Convert.ToInt32(elements[0]), elements[1],/* Convert.ToInt32(elements[2]),*/ Convert.ToDouble(elements[3])));
        //}
    }
}
