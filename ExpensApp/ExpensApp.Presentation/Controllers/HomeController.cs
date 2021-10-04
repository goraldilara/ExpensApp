using CommonArea;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using ExpensApp.Business;
using System.Web.Security;

namespace ExpensApp.Presentation.Controllers
{
    public class HomeController : Controller
    {
        //EFEmployeeRepository _employeeService = new EmployeeBusiness(new EFEmployeeRepository);

        // GET: Home
        public ActionResult Homepage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Homepage(EmployeeCommon employee)
        {
            LoginBusiness login = new LoginBusiness();
            employee = login.LoginController(employee);

            Session["Username"] = employee.Username;
            Session["Password"] = employee.Password;
            Session["EmployeeId"] = employee.EmployeeID;
            Session["login"] = employee;

            if (employee.UserType == "Staff")
            {
                Session["usertype"] = "Staff";
                return Redirect("/Staff/StaffMainPage");
            }
            else if (employee.UserType == "Manager")
            {
                Session["usertype"] = "Manager";
                return Redirect("/Manager/ManagerMainPage");
            }
            else
            {
                Session["usertype"] = "Accountant";
                return Redirect("/Accountant/AccountantMainPage");
            }
        }

        public ActionResult NotAllowed()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session["login"] = null;
            return RedirectToAction("Homepage");
        }


        public ActionResult Sayfa2()
        {
            ViewBag.Value = Session["Username"].ToString();
            ViewBag.Val2 = Session["Password"].ToString();
            return View();

        }
    }
}
