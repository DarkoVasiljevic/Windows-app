using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace DAL
{
    public class Test

    {
        public static void main()
        {

            Repository<Products> product = (Repository<Products>)Activator.
                                            CreateInstance(typeof(Repository<Products>));

            Repository<Products> p = new Repository<Products>();
            Type p1 = p.GetType();
            Console.WriteLine(p1);
        }
    }
}
