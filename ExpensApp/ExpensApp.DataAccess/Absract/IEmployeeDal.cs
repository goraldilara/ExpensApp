using ExpensApp.DataAccess.Concrete.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensApp.DataAccess.Absract
{
    public interface IEmployeeDal
    {
        Employee GetEmployee(string Username, string password);
        Employee GetEmployee(Employee entity);

        Employee GetEmployee(int EmployeeID);
        Employee Login(string Username, string CodedPassword);
    }
}
