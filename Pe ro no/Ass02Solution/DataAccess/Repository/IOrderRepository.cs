using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<OrderObject> GetOrders();
        OrderDetailObject GetOrderById(int orderId);
        int InsertOrder(OrderObject order);
        int UpdateOrder(OrderObject order);
        int DeleteOrder(int orderId);

    }
}
