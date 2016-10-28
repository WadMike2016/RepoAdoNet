using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppToGitHub.Models;

namespace WebAppToGitHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HoraireModel h = new HoraireModel();
            List<HoraireModel> lm = h.GetAll();
            return View(lm);
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