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
    public class StaffBusiness
    {
        Expense entry = new Expense();
        Form form = new Form();
        Helper helper = new Helper();
        EFExpenseRepository expenseRepo = new EFExpenseRepository();
        EFFormRepository formRepo = new EFFormRepository();

        public void AddExpenseToForm(List<ExpenseCommon> expenses, int EmployeeID)
        {
            int TotalAmount = helper.CalculateTotalAmount(expenses);

            form.EmployeeID = EmployeeID;
            form.Date = expenses.First().Date;
            form.TotalAmount = TotalAmount;
            form.Status = "Onay Bekliyor";
            int formID = formRepo.AddForm(form);

            foreach (var item in expenses)   //adding each expense to db with formId,expenseId
            {
                item.FormID = formID;
                entry = helper.ConvertExpenseCommonToExpense(item);
                expenseRepo.AddExpense(entry);
            }

            Console.WriteLine("İşlem başarılı");
        }

        public List<ExpenseCommon> GetFilledForms(int FormID)     //Getting all expenses from form ID and converting them to Common type
        {
            List<Expense> expenses = new List<Expense>();
            List<ExpenseCommon> expensesCommon = new List<ExpenseCommon>();

            expenses = expenseRepo.GetExpensesFortheForm(FormID);

            foreach (var item in expenses)
            {
                expensesCommon.Add(helper.ConvertExpenseToExpenseCommon(item));
            }
            return expensesCommon;
        }

        public List<FormCommon> GetFilledFormsFromID(int EmployeeID)
        {
            List<Form> form2 = new List<Form>();
            List<FormCommon> formCommon = new List<FormCommon>();

            form2 = formRepo.GetFormsForStaff(EmployeeID);

            foreach (var item in form2)
            {
                formCommon.Add(helper.ConvertFormToFormCommon(item));
            }
            return formCommon;
        }

         
    }
}
