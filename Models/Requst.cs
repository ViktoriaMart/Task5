using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Requst
    {
        public Requst()
        {
        }

        public Requst(int productId, string productName, int productQuantity, double productPrice)
        {
            ProductId = productId;
            ProductName = productName;
            ProductQuantity = productQuantity;
            ProductPrice = ProductPrice;
        }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int ProductQuantity { get; set; }

        public double ProductPrice { get; set; }

    }
}
