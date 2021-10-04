using ExpensApp.DataAccess.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpensApp.DataAccess.Concrete.EntityFramework.Models;

namespace ExpensApp.DataAccess.Concrete.EntityFramework.Repository
{
    public class EFEmployeeRepository : IEmployeeDal
    {

        MasrafEntities MasrafEntities = new MasrafEntities();

        public Employee GetEmployee(string Username, string password)
        {
            return MasrafEntities.Employee.AsNoTracking().Where(x => x.Username == Username && x.Password == password).SingleOrDefault();   //if employee ID that I sent is equal to employee's ID get one single row or default instead of empty
        }

        public Employee GetEmployee(Employee entity)
        {
            return MasrafEntities.Employee.AsNoTracking().Where(x => x.EmployeeID == entity.EmployeeID).SingleOrDefault();   //if employee ID that I sent is equal to employee's ID get one single row or default instead of empty
        }

        public Employee GetEmployee(int EmployeeID)
        {
            return MasrafEntities.Employee.AsNoTracking().Where(x => x.EmployeeID == EmployeeID).SingleOrDefault();   //if employee ID that I sent is equal to employee's ID get one single row or default instead of empty
        }

        //UPDATE IT
        public Employee Login(string Username, string CodedPassword)
        {
            throw new NotImplementedException();
        }

        ////Getting employee when he/her login in.
        //public Employee GetEmployee(string Username, string Password)
        //{
        //    Employee entity = MasrafEntities.Employee.AsNoTracking().Where(x => x.Username == Username && x.Password == Password).SingleOrDefault();   //if form ID that I sent is equal to expense's form ID foreign key get one single row or default instead of empty
        //    return entity;
        //}

        //public Employee GetEmployee(Employee entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Employee GetEmployee(string Username)
        //{
        //    throw new NotImplementedException();
        //}

        //public void GetEmployeeCommon(object entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Employee Login(string Username, string CodedPassword)
        //{
        //    return MasrafEntities.Employee.Where(x => x.Username == Username && x.Password == CodedPassword).SingleOrDefault();
        //}

        //public Employee SendToEmployeeCommon()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
