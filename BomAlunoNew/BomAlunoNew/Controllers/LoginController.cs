using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BomAlunoNew.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult IndexLogin()
        {
            Session.Remove("loginID"); //Não delete essa linha Vitor
            return View();
        }
    }
}