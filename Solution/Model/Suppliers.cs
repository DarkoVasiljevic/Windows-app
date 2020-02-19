using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Suppliers : Member
    {
        private int supplierId;
        protected string companyName;
        protected string contactName;
        protected string contactTitle;
        protected string adress;
        protected string city;
        protected string region;
        protected string postCode;
        protected string country;
        protected string phone;
        protected string fax;
        private string homepage;

        public Suppliers()
        {

        }

        public Suppliers(int supplierId, string companyName, string contactName, string contactTitle, string adress, string city,
                   string region, string postCode, string country, string phone, string fax, string homepage)
            : base(companyName, contactName, contactTitle, adress, city, region, postCode, country, phone, fax)
        {
            this.supplierId = supplierId;
            this.homepage = homepage;
        }

        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
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

        public string AdressSupplier
        {
            get { return adress; }
            set { adress = value; }
        }

        public string CitySupplier
        {
            get { return city; }
            set { city = value; }
        }

        public string RegionSupplier
        {
            get { return region; }
            set { region = value; }
        }

        public string PostCode
        {
            get { return postCode; }
            set { postCode = value; }
        }

        public string CountrySupplier
        {
            get { return country; }
            set { country = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string FaxSupplier
        {
            get { return fax; }
            set { fax = value; }
        }

        public string Homepage
        {
            get { return homepage; }
            set { homepage = value; }
        }
    }
}
