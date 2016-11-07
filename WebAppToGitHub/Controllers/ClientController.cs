using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppToGitHub.Models;

namespace WebAppToGitHub.Controllers
{
    public class ClientController : Controller
    {

        public ActionResult TestAjax()
        {
            return View();
        }

        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ClientModel Cm)
        {
            if (ModelState.IsValid)
            {
                if (Cm.Save())
                {
                    ViewBag.Success = 1;
                    return View();
                }
                else
                {
                    ViewBag.ErrorMsg = "Erreur lors de l'enregistrement";
                    return View();
                }
            }
            else
            {
                              

                ViewBag.ErrorMsg = "Vous ne respectez pas les contraintes";
                return View();
            }
        }

        [HttpPost]
        public ActionResult LogMe(LoginModel lm)
        {
            if (lm.Verif())
            {
                ViewBag.SuccessLogin = "Welcome";
                return View("Index");
            }
            else
            {
                ViewBag.ErrorLogin = "Invalid login/Mot de passe";
                return View("Index");
            }
        }
    }
}