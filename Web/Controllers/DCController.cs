using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class DCController : Controller
    {
        //
        // GET: /DC/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SubmitAdminLogin(string LoginId,string LoginPass)
        {
           
            return Json(new { status = "success", message = "ok" }, JsonRequestBehavior.AllowGet);
        }


       
        public ActionResult AdminLogin()
        {
            return View();
        }

        public ActionResult Test()
        {

            return View();
        }

    }
}
