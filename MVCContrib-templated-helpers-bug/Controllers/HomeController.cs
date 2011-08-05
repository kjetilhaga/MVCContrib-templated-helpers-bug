using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCContrib_templated_helpers_bug.Models;

namespace MVCContrib_templated_helpers_bug.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(new UserInfo {Name = "Ola", Age = 100});
        }

    }
}
