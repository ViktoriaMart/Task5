using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Order(DateTime orderDate)
        {
            OrderDate = orderDate;
        }

        public Order()
        {
        }
        
    }
}
