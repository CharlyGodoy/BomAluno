using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BaseModel;
using BomAlunoNew.Models;

namespace BomAlunoNew.Controllers
{
    public class AtividadeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Atividade
        public ActionResult Index(int? id)
        {
            Materia materia = db.Materias.Find(id);

            if (materia != null)
            {
                var todasMaterias = db.Atividades.Where(mat => mat.MateriaID == materia.MateriaID).ToList();
                return View(todasMaterias);
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }

        // GET: Atividade/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Atividade atividade = db.Atividades.Find(id);
            if (atividade == null)
            {
                return HttpNotFound();
            }
            return View(atividade);
        }

        // GET: Atividade/Create
        public ActionResult Create()
        {
            ViewBag.MateriaID = new SelectList(db.Materias, "MateriaID", "Nome");
            ViewBag.TipoID = new SelectList(db.Tipoes, "TipoID", "Nome");
            return View();
        }

        // POST: Atividade/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AtividadeID,Nome,Data,Descricao,Ativo,TipoID,MateriaID")] Atividade atividade)
        {
            if (ModelState.IsValid)
            {
                db.Atividades.Add(atividade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MateriaID = new SelectList(db.Materias, "MateriaID", "Nome", atividade.MateriaID);
            ViewBag.TipoID = new SelectList(db.Tipoes, "TipoID", "Nome", atividade.TipoID);
            return View(atividade);
        }

        // GET: Atividade/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Atividade atividade = db.Atividades.Find(id);
            if (atividade == null)
            {
                return HttpNotFound();
            }
            ViewBag.MateriaID = new SelectList(db.Materias, "MateriaID", "Nome", atividade.MateriaID);
            ViewBag.TipoID = new SelectList(db.Tipoes, "TipoID", "Nome", atividade.TipoID);
            return View(atividade);
        }

        // POST: Atividade/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AtividadeID,Nome,Data,Descricao,Ativo,TipoID,MateriaID")] Atividade atividade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(atividade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MateriaID = new SelectList(db.Materias, "MateriaID", "Nome", atividade.MateriaID);
            ViewBag.TipoID = new SelectList(db.Tipoes, "TipoID", "Nome", atividade.TipoID);
            return View(atividade);
        }

        // GET: Atividade/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Atividade atividade = db.Atividades.Find(id);
            if (atividade == null)
            {
                return HttpNotFound();
            }
            return View(atividade);
        }

        // POST: Atividade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Atividade atividade = db.Atividades.Find(id);
            db.Atividades.Remove(atividade);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
