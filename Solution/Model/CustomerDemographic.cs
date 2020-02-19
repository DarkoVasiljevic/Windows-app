using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CustomerDemographic
    {
        private string customerTypeId;
        private string description;

        public CustomerDemographic(string customerTypeId, string description)
        {
            this.customerTypeId = customerTypeId;
            this.description = description;
        }

        public string CustomerTypeId
        {
            get { return customerTypeId; }
            set { customerTypeId = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


    }
}
