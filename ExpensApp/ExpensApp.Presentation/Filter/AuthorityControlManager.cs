using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpensApp.Presentation.Filter
{
    public class AuthorityControlManager : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["usertype"] != "Manager")
            {
                filterContext.Result = new RedirectResult("/Home/NotAllowed");
            }
        }
    }
}