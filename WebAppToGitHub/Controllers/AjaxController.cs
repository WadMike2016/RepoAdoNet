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
        /// <summary>
        /// Vérifie le pseudo
        /// </summary>
        /// <param name="LeLoginATester">le login a tester.</param>
        /// <returns>return true si le pseudo est libre, false dans le cas contraire</returns>
        public bool CheckPseudo(string LeLoginATester)
        {
           return !ClientModel.verifPseudo(LeLoginATester);
            // Equivalent à
            //if(ClientModel.verifPseudo(LeLoginATester)==true)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}


        }



        // GET: Ajax
        public string Index()
        {
            return DateTime.Now.ToShortDateString();
        }

        public string Image()
        {
            return "wallhaven-16270.jpg";
        }

        //public bool IsValidPseudo(string Pseudo)
        //{
        //    return ClientModel.getOneFromPseudo(Pseudo) != null;
        //}

    }
}