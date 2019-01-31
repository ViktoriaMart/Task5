using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces;
using System.Data.Entity;

namespace Models.Repository
{
    public class OrderProductRepository: IRepository<OrderProduct>
    {
        private BaseContext db;

        public OrderProductRepository(BaseContext context)
        {
            this.db = context;
        }

        public OrderProduct Get(int id)
        {
            return db.OrderProduct.Find(id);
        }

        public IEnumerable<OrderProduct> GetAll()
        {
            return db.OrderProduct.ToList();
        }

        public void Create(OrderProduct orderProduct)
        {
            db.OrderProduct.Add(orderProduct);
        }

        public void Update(OrderProduct orderProduct)
        {
            db.Entry(orderProduct).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            OrderProduct orderProduct = db.OrderProduct.Find(id);
            if (orderProduct != null)
                db.OrderProduct.Remove(orderProduct);
        }
    }
}
