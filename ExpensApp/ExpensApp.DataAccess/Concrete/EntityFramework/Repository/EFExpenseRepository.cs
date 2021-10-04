using ExpensApp.DataAccess.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using ExpensApp.DataAccess.Concrete.EntityFramework.Models;

namespace ExpensApp.DataAccess.Concrete.EntityFramework.Repository
{
    public class EFExpenseRepository : IExpenseDal
    {

        MasrafEntities MasrafEntities = new MasrafEntities();

        public void AddExpense(Expense entity)     //Adding expense to data base with form id
        {
            MasrafEntities.Expense.AddOrUpdate(entity);
            MasrafEntities.SaveChanges();
        }

        public Expense GetExpense(int ExpenseID)     //Getting one expense for updating
        {
            return MasrafEntities.Expense.AsNoTracking().Where(x => x.ExpenseID == ExpenseID).SingleOrDefault();   //if expense ID that I sent is equal to expense's ID get one single row or default instead of empty
        }

        public List<Expense> GetExpensesFortheForm(int FormID)    //Getting expense for presentation of the form
        {
            return MasrafEntities.Expense.AsNoTracking().Where(x => x.FormID == FormID).ToList();
        }

        public List<Expense> ListExpenses()
        {
            return MasrafEntities.Expense.AsNoTracking().ToList();
        }

        public void UpdateExpense(Expense entity)
        {
            Expense expense = new Expense();
            expense = MasrafEntities.Expense.AsNoTracking().Where(x => x.ExpenseID == entity.ExpenseID).SingleOrDefault();
            expense.Type = entity.Type;
            expense.Date = entity.Date;
            expense.Explanation = entity.Explanation;
            expense.Cost = entity.Cost;
            MasrafEntities.SaveChanges();
        }

        //THINK ABOUT IT

        ////Adding new expense to database 
        //public Models.Expense AddExpense(Models.Expense entity)
        //{
        //    using (var access = new MasrafEntities())
        //    {
        //        access.Expense.Add(entity);//add expense to database
        //        access.SaveChanges();
        //    }

        //    //MasrafEntities.Expense.Add(entity);   
        //    //MasrafEntities.SaveChanges();
        //    return entity;

        //}
    }
}
