using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BussinesServices
{
    class SupplierServices
    {
        private SuppliersRepository repository = new SuppliersRepository();

        private bool checkById(int id)
        {
            List<Suppliers> supplier = repository.GetAll();

            bool ind = false;
            foreach (var item in supplier)
            {
                if (item.SupplierId == id)
                {
                    ind = true;
                    break;
                }
            }

            return ind;
        }

        private bool checkByName(string name)
        {
            bool check = false;

            List<Suppliers> supplier = repository.GetAll();

            foreach (var item in supplier)
            {
                if (item.CompanyName == name)
                {
                    check = true;
                    break;
                }
            }

            return check;
        }

        public int AddSupplier( int supplierId, string companyName, string contactName, string contactTitle, 
                                string adress, string city, string region, string postCode, string country, 
                                string phone, string fax, string homepage )
        {

            Suppliers supplier = new Suppliers();

            bool checkId = checkById(supplierId);
            bool checkName = checkByName(companyName);

            if (checkId)
            {
                throw new Exception("Supplier Id already exists");
            }
            else if (checkName)
            {
                throw new Exception("Supplier name alredy exist");
            }
            else
            {
                supplier = new Suppliers(supplierId, companyName, contactName, contactTitle,
                                         adress, city, region, postCode, country, phone, fax, homepage);
            }

            return repository.AddSingle(supplier);
        }

        public int DeleteSupplier(int id)
        {
            int result = 0;

            bool checkId = checkById(id);

            if (checkId)
            {
                result = repository.DeleteSingle(id);
            }
            else
            {
                throw new Exception("Supplier Id do not exists");
            }

            return result;
        }

        public List<Suppliers> GetAllSuppliers()
        {
            List<Suppliers> supplier = repository.GetAll();

            if (supplier.Count == 0)
            {
                throw new Exception("No avalaible suplliers");
            }

            return repository.GetAll();
        }

        public Suppliers GetByIdSupplier(int id)
        {
            Suppliers supplier = new Suppliers();

            bool checkId = checkById(id);

            if (checkId)
            {
                supplier = repository.GetById(id);
            }
            else
            {
                throw new Exception("Category Id not exist");
            }

            return supplier;
        }

        public int UpdateSupplier(int supplierId, string companyName, string contactName, string contactTitle,
                                  string adress, string city, string region, string postCode, string country,
                                  string phone, string fax, string homepage)
        {
            Suppliers supplier = new Suppliers();

            bool checkId = checkById(supplierId);
            bool checkName = checkByName(companyName);

            if (!checkId)
            {
                throw new Exception("Supplier Id do not exists");
            }
            else if (checkName)
            {
                throw new Exception("Supplier name already exists");
            }
            else
            {
                supplier = new Suppliers(supplierId, companyName, contactName, contactTitle,
                                         adress, city, region, postCode, country, phone, fax, homepage);
            }

            return repository.UpdateSingle(supplier);
        }
    }
}
