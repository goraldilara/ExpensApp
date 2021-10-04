using ExpensApp.DataAccess.Concrete.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonArea.Helper
{
    public class Helper
    {

        public Employee ConvertEmployeeCommonToEmployee(EmployeeCommon entity)
        {
            return new Employee
            {
                EmployeeID = entity.EmployeeID,
                Name = entity.Name,
                Surname = entity.Surname,
                Username = entity.Username,
                Password = entity.Password,
                Email = entity.Email,
                UserType = entity.UserType
            };
        }
        public EmployeeCommon ConvertEmployeeToEmployeeCommon(Employee entity)
        {
            int EmployeeID = entity.EmployeeID;
            string Name = entity.Name;
            string Surname = entity.Surname;
            string Username = entity.Username;
            string Password = entity.Password;
            string Email = entity.Email;
            string UserType = entity.UserType;

            return new EmployeeCommon(EmployeeID, Name, Surname, Username, Password, Email, UserType);
        }

        public Expense ConvertExpenseCommonToExpense(ExpenseCommon entity)
        {
            return new Expense
            {
                Cost = entity.Cost,
                Type = entity.Type,
                Explanation = entity.Explanation,
                Date = entity.Date,
                ExpenseID = entity.ExpenseID,
                FormID = entity.FormID
            };
        }

        public ExpenseCommon ConvertExpenseToExpenseCommon(Expense entity)
        {
            int ExpenseID = entity.ExpenseID;
            int FormID = entity.FormID;
            DateTime Date = entity.Date;
            int Cost = entity.Cost;
            string Explanation = entity.Explanation;
            string Type = entity.Type;

            return new ExpenseCommon(ExpenseID, FormID, Date, Cost, Explanation, Type);
        }

        public Form ConvertFormCommonToForm(FormCommon entity)
        {
            return new Form
            {
                FormID = entity.FormID,
                EmployeeID = entity.EmployeeID,
                Date = entity.Date,
                TotalAmount = entity.TotalAmount,
                Status = entity.Status
            };
        }

        public FormCommon ConvertFormToFormCommon(Form entity)
        {
            int FormID = entity.FormID;
            int EmployeeID = entity.EmployeeID;
            DateTime Date = entity.Date;
            int TotalAmount = entity.TotalAmount;
            string Status = entity.Status;

            return new FormCommon(FormID, EmployeeID, Date, TotalAmount, Status);
        }

        public int CalculateTotalAmount(List<ExpenseCommon> list)
        {
            int TotalAmount = 0;

            foreach (var item in list)
            {
                TotalAmount += item.Cost;
            }

            return TotalAmount;
        }


    }
}
