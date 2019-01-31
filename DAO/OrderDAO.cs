using System;
using System.Collections.Generic;
using Models;
using System.IO;
using System.Data.Entity;
using System.Linq;
using System.Data;

namespace DAO
{
    public class OrderDAO
    {
        UnitOfWork unitOfWork;

        public OrderDAO()
        {
            unitOfWork = new UnitOfWork();
        }

        public IEnumerable<Requst> ReadOrder(int id)
        {
            return unitOfWork.GetRequsts(id);
        }

        public void DeleteOrder(int id)
        {
            unitOfWork.Delete(id);
            unitOfWork.Save();
        }

    }
}
