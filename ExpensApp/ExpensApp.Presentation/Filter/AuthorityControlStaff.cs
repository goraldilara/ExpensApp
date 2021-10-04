using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace ExpensApp.Presentation.Filter
{
    public class AuthorityControlStaff : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["usertype"] != "Staff")
            {
                filterContext.Result = new RedirectResult("/Home/NotAllowed");
            }
        }

    }
}