using ExpensApp.DataAccess.Concrete.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensApp.DataAccess.Absract
{
    public interface IFormDal
    {
        Form GetForm(int FormID);     //get one specific form
        int AddForm(Form entity);
        List<Form> ListForms();
        List<Form> GetFormsForStaff(int EmployeeID);
        List<Form> GetFormsFromStatus(string Status);
        void UpdateForm(Form entity);
        void UpdateFormStatus(int FormId, string Status);
    }
}
