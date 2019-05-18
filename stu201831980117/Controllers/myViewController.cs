using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stu201831980117.Controllers
{
    public class myViewController : Controller
    {
        // GET: myView
        public ActionResult Index()
        {
            return View();
        }
    }
}