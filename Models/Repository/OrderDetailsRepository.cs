using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces;
using System.Data.Entity;

namespace Models.Repository
{
    public class OrderDetailsRepository: IRepository<OrderDetails>
    {
        private BaseContext db;

        public OrderDetailsRepository(BaseContext context)
        {
            this.db = context;
        }

        public OrderDetails Get(int id)
        {
            return db.OrderDetails.Find(id);
        }

        public IEnumerable<OrderDetails> GetAll()
        {
            return db.OrderDetails.ToList();
        }

        public void Create(OrderDetails orderDetails)
        {
            db.OrderDetails.Add(orderDetails);
        }

        public void Update(OrderDetails orderDetails)
        {
            db.Entry(orderDetails).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            OrderDetails orderDetails = db.OrderDetails.Find(id);
            if (orderDetails != null)
                db.OrderDetails.Remove(orderDetails);
        }
    }
}
