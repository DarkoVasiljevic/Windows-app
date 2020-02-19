using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Orders
    {
        private int orderId;
        private string customerId;
        private int? employeeId;
        private DateTime? orderDate;
        private DateTime? requiredDate;
        private DateTime? shippedDate;
        private int? shipVia;
        private decimal? freight;
        private string shipName;
        private string shipAdress;
        private string shipCity;
        private string shipPostalCode;
        private string shipCountry;
        private string shipRegion;

        public Orders()
        {
        }

        public Orders(string customerId, int? employeeId)
        {
            this.customerId = customerId;
            this.employeeId = employeeId;
        }

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public int? EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public DateTime? OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public DateTime? RequiredDate
        {
            get { return requiredDate; }
            set { requiredDate = value; }
        }

        public DateTime? ShippedDate
        {
            get { return shippedDate; }
            set { shippedDate = value; }
        }

        public int? ShipVia
        {
            get { return shipVia; }
            set { shipVia = value; }
        }

        public decimal? Freight
        {
            get { return freight; }
            set { freight = value; }
        }

        public string ShipName
        {
            get { return shipName; }
            set { shipName = value; }
        }

        public string ShipAdress
        {
            get { return shipAdress; }
            set { shipAdress = value; }
        }

        public string ShipCity
        {
            get { return shipCity; }
            set { shipCity = value; }
        }

        public string ShipRegion
        {
            get { return shipRegion; }
            set { shipRegion = value; }
        }

        public string ShipPostalCode
        {
            get { return shipPostalCode; }
            set { shipPostalCode = value; }
        }

        public string ShipCountry
        {
            get { return shipCountry; }
            set { shipCountry = value; }
        }
    }
}
