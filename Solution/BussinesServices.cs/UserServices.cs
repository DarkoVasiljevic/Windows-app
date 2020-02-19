using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BussinesServices.cs
{
    public class UserServices
    {
        UserRepository userRepo = new UserRepository();

        public Users GetUserByName(string name)
        {
            return userRepo.GetUserByName(name);
        }

        public int UpdateUser(Users user)
        {
            return userRepo.UpdateUser(user);
        }
    }
}
