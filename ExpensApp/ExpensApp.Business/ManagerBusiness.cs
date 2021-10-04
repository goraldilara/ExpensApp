using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonArea.Helper;
using ExpensApp.DataAccess.Concrete.EntityFramework.Models;
using ExpensApp.DataAccess.Concrete.EntityFramework.Repository;
using CommonArea;

namespace ExpensApp.Business
{
    public class ManagerBusiness
    { 
        List<int> employeeIDListFirst = new List<int>();
        List<int> employeeIDListSecond = new List<int>();
        List<Form> formList = new List<Form>();
        List<EmployeeCommon> employeeList = new List<EmployeeCommon>();
        Helper helper = new Helper();
        EFFormRepository formRepo = new EFFormRepository();
        EFEmployeeRepository employeeRepo = new EFEmployeeRepository();
        EFExpenseRepository expense = new EFExpenseRepository();

        public List<FormCommon> GetForms()    //GETTING FORMS
        {
            List<FormCommon> formCommon = new List<FormCommon>();    //common area form list
            
            formList = formRepo.GetFormsFromStatus("Onay Bekliyor");   //getting forms with "Waiting For Approve" status

            foreach (var item in formList)
            {
                formCommon.Add(helper.ConvertFormToFormCommon(item));   //converting forms to common forms
            }
            return formCommon;
        }

        public List<EmployeeCommon> GetEmployees(List<FormCommon> comerFormList)
        {
            List<EmployeeCommon> employeeCommon = new List<EmployeeCommon>();    //common area employee list
      
            foreach (var item in comerFormList)
            {
                employeeList.Add(helper.ConvertEmployeeToEmployeeCommon(employeeRepo.GetEmployee(item.EmployeeID)));     //converting employees that are have been taken with their ID to common employees
            }

            return employeeList;
        }

        public EmployeeCommon GetSingleEmployee(int EmployeeId)
        {
            Employee singleEmployee = new Employee();
            EmployeeCommon singleEmployeeCommon = new EmployeeCommon();

            singleEmployee = employeeRepo.GetEmployee(EmployeeId);
            singleEmployeeCommon = helper.ConvertEmployeeToEmployeeCommon(singleEmployee);
            
            return singleEmployeeCommon;
        }

        public List<ExpenseCommon> GetExpenses(int formID)
        {
            List<Expense> expenseList = new List<Expense>();
            List<ExpenseCommon> expenseCommon = new List<ExpenseCommon>();

            expenseList = expense.GetExpensesFortheForm(formID);

            foreach (var item in expenseList)
            {
                expenseCommon.Add(helper.ConvertExpenseToExpenseCommon(item));
            }

            return expenseCommon;
        }

        public List<FormCommon> GetAllForms()
        {
            List<Form> formListAll = new List<Form>();
            List<FormCommon> formListAllCommon = new List<FormCommon>();

            formListAll = formRepo.ListForms();

            foreach (var item in formListAll)
            {
                formListAllCommon.Add(helper.ConvertFormToFormCommon(item));
            }

            return formListAllCommon;
        }

        public void UpdateForm(int FormId, string Status)
        {
            formRepo.UpdateFormStatus(FormId, Status);
        }


    }
}
