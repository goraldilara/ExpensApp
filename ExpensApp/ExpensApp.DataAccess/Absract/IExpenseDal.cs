using ExpensApp.DataAccess.Concrete.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensApp.DataAccess.Absract
{
    public interface IExpenseDal
    {
        //Expense GetExpense(Object entity);   //Getting expense for presentation of the      
        Expense GetExpense(int ExpenseID);     //Getting one expense for updating 
        List<Expense> GetExpensesFortheForm(int FormID);  //Getting expense for presentation of the form.
        void AddExpense(Expense entity);
        List<Expense> ListExpenses();
        void UpdateExpense(Expense entity);

    }
}
