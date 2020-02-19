using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BussinesServices.cs
{
    public class OrderDetailsServices
    {
        private OrderDetailsRepository repo = new OrderDetailsRepository();

        public int AddProduct(int ordersId, int productsId, decimal? unitPrice, short quantity, decimal discount)
        {

            return repo.AddSingle(new OrderDetails(ordersId, productsId, unitPrice, quantity, discount));
        }

        public int InsertNewOrder(string customerId, int employeeId)
        {
            return repo.InsertNewOrder(customerId, employeeId);
        }

        public int GetOrderId(string customerId, int employeeId)
        {
            return repo.GetOrderId(customerId, employeeId);
        }

        public int InsertNewOrderDetails(int orderId, int productId, decimal price, short quantity, decimal discount)
        {
            return repo.InsertNewOrderDetails(orderId, productId, price, quantity, discount);
        }
    }
}
