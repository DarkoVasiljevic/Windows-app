using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderDetails
    {
        private int ordersId;
        private int productsId;
        private decimal? unitPrice;
        private short quantity;
        private decimal discount;

        public OrderDetails()
        {
        }

        public OrderDetails(int ordersId, int productsId, decimal? unitPrice, short quantity, decimal discount)
        {
            this.ordersId = ordersId;
            this.productsId = productsId;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
            this.discount = discount;
        }

        public int OrdersId
        {
            get { return ordersId; }
            set { ordersId = value; }
        }

        public int ProductsId
        {
            get { return productsId; }
            set { productsId = value; }
        }

        public decimal? UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public short Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal Discount
        {
            get { return discount; }
            set { discount = value; }
        }

    }
}
