using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class CustomerDemo
    {
        private string customerId;
        private string customerTypeId;

        public CustomerDemo(string customerId, string customerTypeId)
        {
            this.customerId = customerId;
            this.customerTypeId = customerTypeId;
        }

        public string CustomerId
        {
            get { return customerId; }

            set { customerId = value; }
        }

        public string CustomerTypeId
        {
            get { return customerTypeId; }

            set { customerTypeId = value; }
        }

    }
}
