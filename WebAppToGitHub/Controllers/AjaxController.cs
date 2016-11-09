using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppToGitHub.Models;

namespace WebAppToGitHub.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public string Index()
        {
            return DateTime.Now.ToShortDateString();
        }

        public string Image()
        {
            return "wallhaven-16270.jpg";
        }

        public bool IsValidPseudo(string Pseudo)
        {
            return ClientModel.getOneFromPseudo(Pseudo) != null;
        }

    }
}