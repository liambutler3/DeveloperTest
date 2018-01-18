using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testWebApp.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index (FormCollection form)
        {
            string name = Request.Form["Name"];
            string surname = Request.Form["LastName"];

            return View();
        }


        //public FormCollection UserInsert()
        //{

        //    return View("index.cshtml");
        //}
        

    }
}