using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Shippers
    {
        private int shiperId;
        private string companyName;
        private string phone;

        public Shippers(int shiperId, string companyName, string phone)
        {
            this.shiperId = shiperId;
            this.companyName = companyName;
            this.phone = phone;
        }

        public int ShiperId
        {
            get { return shiperId; }
            set { shiperId = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}
