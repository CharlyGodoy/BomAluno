using BaseModel;
using BomAlunoNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BomAlunoNew.Controllers
{
    public class LoginController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        // GET: Login
        public ActionResult IndexLogin()
        {
            Session.Remove("loginID"); //Não delete essa linha Vitor
            return View();
        }
        // GET: Materias/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IndexLogin([Bind(Include = "LoginID,Usuario,Senha")] Login login)
        {
            if (!ModelState.IsValid)
            {
                List<Login> loglist = db.Logins.Where(x => x.Usuario == login.Usuario).ToList();

                Login logincerto = null;

                foreach (Login l in loglist)
                {
                    logincerto = l;
                }

                if (logincerto != null)
                {
                    if (login.Senha == logincerto.Senha)
                    {
                        Session.Add("loginID", login.LoginID);
                        return RedirectToAction("../Materias/Index");
                    }
                    else
                    {
                        return View();
                    }

                }
                else
                {
                    return View();
                }


            }
            return View();
        }


        // GET: Materias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Materias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Login login)
        {
            if (ModelState.IsValid)
            {
                db.Logins.Add(login);
                db.SaveChanges();
                return RedirectToAction("../Materias/Index");
            }
            else
            {
                return View(login);

            }

        }

       




    }
}