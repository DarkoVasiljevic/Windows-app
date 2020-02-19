using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customers : Member
    {
        private int tblUsersID;
        private string customerId;
        private string companyName;
        private string contactName;
        private string contactTitle;
        private string adress;
        private string city;
        private string region;
        private string postCode;
        private string country;
        private string phone;
        private string fax;

        public Customers()
        {
        }

        public Customers(string customerId, string companyName, string contactName, string contactTitle, string adress, string city, string region, string postCode, string country, string phone, string fax)
        {
            this.customerId = customerId;
            this.companyName = companyName;
            this.contactName = contactName;
            this.contactTitle = contactTitle;
            this.adress = adress;
            this.city = city;
            this.region = region;
            this.postCode = postCode;
            this.country = country;
            this.phone = phone;
            this.fax = fax;
        }

        public Customers(string customerId, string companyName, string contactName)
        {
            this.customerId = customerId;
            this.companyName = companyName;
            this.contactName = contactName;
        }

        //public Customers(string customerId, string companyName, string contactName, string contactTitle, string adress, 
        //                    string city, string region, string postCode, string country, string phone, string fax)
        //    : base(companyName, contactName, contactTitle, adress, city, region, postCode, country, phone, fax)
        //{
        //    this.customerId = customerId;
        //}

        public int TblUsersID
        {
            get { return tblUsersID; }
            set { tblUsersID = value; }
        }

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }

        public string ContactTitle
        {
            get { return contactTitle; }
            set { contactTitle = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        public string PostCode
        {
            get { return postCode; }
            set { postCode = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }
    }
}
