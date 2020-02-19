using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public interface InterfaceDal<T, I, S>
    {
        List<T> GetAll();
        T GetById(I id);
        T GetByName(S name);
        I AddSingle(T single);
        I UpdateSingle(T single);
        I DeleteSingle(I id);
    }
}
