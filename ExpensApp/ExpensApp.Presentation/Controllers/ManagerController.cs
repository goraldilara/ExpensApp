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
    public class ManagerController : Controller
    {

        List<FormCommon> formList = new List<FormCommon>();
        List<EmployeeCommon> employeeList = new List<EmployeeCommon>();
        List<ExpenseCommon> expenseList = new List<ExpenseCommon>();
        ManagerBusiness manager = new ManagerBusiness();
        MultipleModel2 myModel = new MultipleModel2();
        MultipleModel3 myModel3 = new MultipleModel3();

        // GET: Manager
        [AuthFilter, AuthorityControlManager]
        public ActionResult ManagerMainPage()
        {
            return View();
        }
        // GET: Manager
        [AuthFilter, AuthorityControlManager]
        public ActionResult ManagerDetailPage(int FormId, int EmployeeId)
        {
            List<ExpenseCommon> expenseList2 = new List<ExpenseCommon>();
            EmployeeCommon employee = new EmployeeCommon();

            expenseList2 = manager.GetExpenses(FormId);
            employee = manager.GetSingleEmployee(EmployeeId);

            myModel3.listForExpenses = expenseList2;
            myModel3.employee = employee;

            return View(myModel3);
        }


        [AuthFilter, AuthorityControlManager]
        public ActionResult ApprovingExpenseFormPage()
        {
            formList = manager.GetForms();     //getting forms 
            employeeList = manager.GetEmployees(formList);   //getting employees

            myModel.listForForms = formList;
            myModel.listForEmployees = employeeList;

            return View(myModel);
        }

        [AuthFilter, AuthorityControlManager]
        public ActionResult OpenExpensePage(int formId)
        {
            expenseList = manager.GetExpenses(formId);
            return View(expenseList);
        }


        [AuthFilter, AuthorityControlManager]
        public ActionResult ManagerReportsPage()
        {
            List<FormCommon> formListAll = new List<FormCommon>();
            List<EmployeeCommon> employeeListAll = new List<EmployeeCommon>();
            MultipleModel2 myModel2 = new MultipleModel2();

            formListAll = manager.GetAllForms();
            employeeListAll = manager.GetEmployees(formListAll);

            myModel2.listForForms = formListAll;
            myModel2.listForEmployees = employeeListAll;

            return View(myModel2);
        }

        [HttpPost]
        [AuthFilter, AuthorityControlManager]
        public ActionResult UpdateForm()
        {
            int FormId = int.Parse(Request["FormId"]);
            string Status = Request["Status"];
            ExpenseCommon singleExpense = new ExpenseCommon();
            
            string newStatus = Status;

            manager.UpdateForm(FormId, Status);


            return null;
        }
    }
}