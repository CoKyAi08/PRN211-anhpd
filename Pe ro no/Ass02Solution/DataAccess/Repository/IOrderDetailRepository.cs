using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetailObject> GetOrderDetails();
        OrderDetailObject GetOrderDetailById(int orderId);
        int InsertOrderDetail(OrderDetailObject orderDetail);

        int UpdateOrderDetail(OrderDetailObject orderDetail);

        int DeleteOrderDetail(int orderId);
    }
}
