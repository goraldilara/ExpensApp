using CommonArea;
using ExpensApp.Business;
using ExpensApp.Presentation.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpensApp.Presentation.Controllers
{
    public class AccountantController : Controller
    {
        List<FormCommon> formList = new List<FormCommon>();
        List<EmployeeCommon> employeeList = new List<EmployeeCommon>();
        List<ExpenseCommon> expenseList = new List<ExpenseCommon>();
        ManagerBusiness manager = new ManagerBusiness();
        MultipleModel2 myModel = new MultipleModel2();

        [AuthFilter, AuthorityControlAccountant]
        public ActionResult AccountantMainPage()
        {
            return View();
        }

        [AuthFilter, AuthorityControlAccountant]
        public ActionResult PayingExpensePage()
        {

            formList = manager.GetForms();     //getting forms 
            employeeList = manager.GetEmployees(formList);   //getting employees

            myModel.listForForms = formList;
            myModel.listForEmployees = employeeList;

            return View(myModel);
        }

        [AuthFilter, AuthorityControlAccountant]
        public ActionResult AccountantReportsPage()
        {
            return View();
        }
    }
}