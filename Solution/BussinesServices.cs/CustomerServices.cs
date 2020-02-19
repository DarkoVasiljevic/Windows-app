using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BussinesServices
{
    public class CustomerServices
    {
        private CustomersRepository repository = new CustomersRepository();

        public List<Customers> GetAllCustomers()
        {
            List<Customers> customer = repository.GetAll();

            if (customer.Count == 0)
            {
                throw new Exception("No avalaible customers");
            }

            return repository.GetAll();
        }

        public string GetCustomerName(string name)
        {
            return repository.GetCustomerName(name);
        }

        public int insertCustomerByContactName(string customerId, string companyName, string contactName)
        {
            return repository.insertCustomerByContactName(customerId, companyName, contactName);
        }

        public int insertCustomerToUser(string firstName, string lastName, string passwd)
        {
            return repository.insertCustomerToUser(firstName, lastName, passwd);
        }

        public int updateUserId(int userId, string customerId)
        {
            return repository.updateUserId(userId, customerId);
        }
    }
}
