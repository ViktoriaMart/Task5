using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DAO;
using Models;
using Models.Repository;

namespace BUS
{
    public class OrderBUS
    {
        OrderDAO orderDAO;
        int id;

        public OrderBUS()
        {
            orderDAO = new OrderDAO();
            GetNext();
        }

        public ObservableCollection<Requst> GetOrder()
        {
            ObservableCollection<Requst> collection = new ObservableCollection<Requst>();

            var order = orderDAO.ReadOrder(id);

            foreach (var item in order)
            {
                collection.Add(item);
            }

            if (collection.Count == 0)
            {
                throw new Exception("Немає активних замовлень");
            }
            return collection;
        }

        public void DeleteOrder()
        {
            orderDAO.DeleteOrder(id);
            GetNext();
        }

        void GetNext()
        {
            var order = (new UnitOfWork()).Orders.GetAll().FirstOrDefault();
            if (order == null)
            {
                throw new Exception("Немає активних замовлень");
            }

            id = order.OrderId;
        }

        public double GetSum(ObservableCollection<Requst> collection)
        {
            double sum = 0;

            foreach (var item in collection)
            {
                sum += item.ProductPrice * item.ProductQuantity;
            }

            if (sum <= 0)
            {
                throw new Exception("Неправильно введені дані");
            }

            return sum;
        }

        public void RemoveAll(IList list)
        {
            while (list.Count > 0)
            {
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
