using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    class CustomerDemographicRepository : InterfaceDal<CustomerDemographic, int, string>
    {
        public int AddSingle(CustomerDemographic single)
        {
            throw new NotImplementedException();
        }

        public int DeleteSingle(int id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerDemographic> GetAll()
        {
            throw new NotImplementedException();
        }

        public CustomerDemographic GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CustomerDemographic GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public int UpdateSingle(CustomerDemographic single)
        {
            throw new NotImplementedException();
        }
    }
}
