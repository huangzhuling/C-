using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.comm;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           var data = WeaterHelper.GetWeatherByCityName("柳州");
            return View(data);
        }
        public JsonResult getweather(string City)
        {
            var data = WeaterHelper.GetWeatherByCityName(City);
            var json = Json(data);
            return json;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}