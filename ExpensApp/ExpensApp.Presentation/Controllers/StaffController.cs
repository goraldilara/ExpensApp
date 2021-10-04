using CommonArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpensApp.Business;
using System.Dynamic;
using ExpensApp.Presentation.Filter;

namespace ExpensApp.Presentation.Controllers
{
    public class StaffController : Controller
    {
        List<SelectListItem> items = new List<SelectListItem>();
        static List<ExpenseCommon> expensesList = new List<ExpenseCommon>();
        static List<FormCommon> formList2 = new List<FormCommon>();
        StaffBusiness staff = new StaffBusiness();
        MultipleModel myModel = new MultipleModel();

        // GET: Staff
        [AuthFilter, AuthorityControlStaff]
        public ActionResult StaffMainPage()
        {
            return View();
        }

        [AuthFilter, AuthorityControlStaff]
        public ActionResult FillingExpenseFormPage()     //First expense operation
        {
            items.Add(new SelectListItem { Text = "Yemek", Value = "Yemek" });

            items.Add(new SelectListItem { Text = "Ulaşım", Value = "Ulaşım" });

            items.Add(new SelectListItem { Text = "Benzin", Value = "Benzin", Selected = true });

            items.Add(new SelectListItem { Text = "Diğer", Value = "Diğer" });

            ViewBag.Types = items;

            myModel.list = expensesList;
            myModel.expense = new ExpenseCommon();

            return View(myModel);
        }

        [HttpPost]
        public ActionResult FillingExpenseFormPage(MultipleModel entityModel)   //gride ekleme için dönüş
        {
            items.Add(new SelectListItem { Text = "Yemek", Value = "Yemek" });

            items.Add(new SelectListItem { Text = "Ulaşım", Value = "Ulaşım" });

            items.Add(new SelectListItem { Text = "Benzin", Value = "Benzin", Selected = true });

            items.Add(new SelectListItem { Text = "Diğer", Value = "Diğer" });

            ViewBag.Types = items;
            //myModel.list = expensesList;

            expensesList.Add(entityModel.expense);
            myModel.list = expensesList;
            //myModel.list.Add(entityModel.expense);

            return View(myModel);
        }

        [HttpPost]
        public ActionResult AddingExpensesToDataBase(MultipleModel model)
        {
            //staff.AddExpenseToForm(myModel.list, ((int)Session["EmployeeId"]));

            var sample = expensesList;
            staff.AddExpenseToForm(sample, ((int)Session["EmployeeId"]));
            return RedirectToAction("StaffMainPage");
        }


        [AuthFilter]
        public ActionResult ExpenseFormsPage()
        {
            return View();
        }


        [AuthFilter, AuthorityControlStaff]
        public ActionResult StaffReportsPage()
        {
            formList2 = staff.GetFilledFormsFromID((int) Session["EmployeeId"]);
            return View(formList2);
        }
    }
}