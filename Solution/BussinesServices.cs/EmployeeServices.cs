using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BussinesServices.cs
{
    public class EmployeeServices
    {
        EmployeesRepository repo = new EmployeesRepository();

        public Employees IsEmployeeExist(string fName, string lName)
        {
            return repo.IsEmployeeExist(fName, lName);
        }

        public int insertEmployeeByName(string fName, string lName, string title)
        {
            return repo.insertEmployeeByName(fName, lName, title);
        }

        public int insertEmployeeToUser(string fName, string lName, string passwd)
        {
            return repo.insertEmployeeToUser(fName, lName, passwd);
        }

        public int updateUserId(int userId, int employeeId)
        {
            return repo.updateUserId(userId, employeeId);
        }
    }
}
