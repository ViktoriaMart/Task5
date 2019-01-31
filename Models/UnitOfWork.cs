using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public class UnitOfWork : IDisposable
    {
        private BaseContext db = new BaseContext();
        private OrderDetailsRepository detailsRepository;
        private OrderProductRepository productRepository;
        private OrderRepository orderRepository;

        public OrderRepository Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(db);
                return orderRepository;
            }
        }

        public OrderProductRepository OrderProducts
        {
            get
            {
                if (productRepository == null)
                    productRepository = new OrderProductRepository(db);
                return productRepository;
            }
        }

        public OrderDetailsRepository OrderDetail
        {
            get
            {
                if (detailsRepository == null)
                    detailsRepository = new OrderDetailsRepository(db);
                return detailsRepository;
            }
        }

        public IEnumerable<Requst> GetRequsts(int id)
        {
            var res = from orderDetail in OrderDetail.GetAll()
                      where orderDetail.OrderId == id
                      join order in Orders.GetAll() on orderDetail.OrderId equals order.OrderId
                      join orderProduct in OrderProducts.GetAll() on orderDetail.OrderProductId equals orderProduct.OrderProductId
                      select new Requst()
                      {
                          ProductId = orderProduct.OrderProductId,
                          ProductName = orderProduct.ProductName,
                          ProductQuantity = orderDetail.Quantity,
                          ProductPrice = orderProduct.ProductPrice
                      };

            return res;
        }

        public void Delete(int id)
        {
            foreach (var item in OrderDetail.GetAll())
            {
                if (item.OrderId == id)
                {
                    OrderDetail.Delete(item.OrderDetailsId);
                }
            }
            Orders.Delete(id);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
