using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppToGitHub.Models;

namespace WebAppToGitHub.Infra
{
    public static class MesSessions
    {
        /// <summary>
        /// Gets or sets the user in the session
        /// </summary>
        /// <value>
        /// The curent user
        /// </value>
        public static LoginModel Patient
        {
            get { return (LoginModel)HttpContext.Current.Session["user"]; }
            set { HttpContext.Current.Session["user"] = value; }
        }
    }
}