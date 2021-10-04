using CommonArea;
using CommonArea.Helper;
using ExpensApp.DataAccess.Concrete.EntityFramework.Models;
using ExpensApp.DataAccess.Concrete.EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensApp.Business
{
    public class LoginBusiness
    {
        Employee entry = new Employee();
        Helper helper = new Helper();
        EFEmployeeRepository employeeRepo = new EFEmployeeRepository();

        public EmployeeCommon LoginController(EmployeeCommon entity)
        {
            try
            {
                var CodedPassword = new ToPasswordRepository().Md5(entity.Password);
                entity.Password = CodedPassword;
                entry = employeeRepo.GetEmployee(entity.Username, entity.Password);
                if (entry == null) throw new Exception("Kullanıcı adı veya şifre hatalı!"); //pop-up will come to this place
                else
                {
                    entity = helper.ConvertEmployeeToEmployeeCommon(entry);
                    return entity;
                }
            }
            catch (Exception Error) { throw new Exception(Error.Message); }
        }
    }
}
