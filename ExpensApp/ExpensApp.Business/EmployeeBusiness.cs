
using ExpensApp.DataAccess.Absract;
using ExpensApp.DataAccess.Concrete.EntityFramework.Models;
using ExpensApp.DataAccess.Concrete.EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonArea;

namespace ExpensApp.Business
{
    public class EmployeeBusiness
    {



        //IEmployeeDal _employeeDal;

        //public EmployeeBusiness(IEmployeeDal employeeDal)
        //{
        //    this._employeeDal = employeeDal;
        //}

        //public Employee GetEmployee(string Username, string password)
        //{
        //    return _employeeDal.GetEmployee(Username,password);
        //}

        //public Employee Login(string Username, string Password)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(Username.Trim()) || string.IsNullOrEmpty(Password.Trim()))
        //        {
        //            throw new Exception("Kullanıcı adı veya şifre boş bırakılamaz!");
        //        }
        //        var CodedPassword = new ToPasswordRepository().Md5(Password);
        //        var employee = _employeeDal.Login(Username, CodedPassword);
        //        _employeeDal.
        //        if (employee == null) throw new Exception("Kullanıcı adı veya şifre hatalı!");
        //        else return employee;
        //    }

        //    catch (Exception Error)
        //    {
        //        throw new Exception(Error.Message);
        //    }
        //}

        //public void AddEmployee(EmployeeCommon employee)
        //{
        //    employee.
        //    throw new NotImplementedException();

        //gelen business nesnesini çevir
        //data access içindeki repositorye ilet
    }
}

