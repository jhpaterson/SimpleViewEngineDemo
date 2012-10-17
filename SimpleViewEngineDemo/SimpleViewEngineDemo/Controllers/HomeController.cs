using System;
using System.Web.Mvc;

namespace SimpleViewEngineDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            ViewData["Message"] = "Hello, World";
            ViewData["Time"] = DateTime.Now.ToShortTimeString();

            return View("DebugData");
            //return View();             // view doesn't exist, will show error page with view engine search results
        } 

    }
}
