using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public int OrderProductId { get; set; }
        public int Quantity { get; set; }

        public OrderDetails(int quantity)
        {
            Quantity = quantity;
        }

        public OrderDetails()
        {
        }
    }
}
