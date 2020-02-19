using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    class RegionRepository : InterfaceDal<Region, int, string>
    {
        public int AddSingle(Region single)
        {
            throw new NotImplementedException();
        }

        public int DeleteSingle(int id)
        {
            throw new NotImplementedException();
        }

        public List<Region> GetAll()
        {
            throw new NotImplementedException();
        }

        public Region GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Region GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public int UpdateSingle(Region single)
        {
            throw new NotImplementedException();
        }
    }
}
