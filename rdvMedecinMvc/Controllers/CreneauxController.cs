using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RDVMedecin.DAL;

namespace rdvMedecinMvc.Controllers
{
    public class CreneauxController : Controller
    {
        private RdvMedecinContext db = new RdvMedecinContext();

        // GET: Creneaux
        public ActionResult Index()
        {
            var creneaux = db.Creneaux.Include(c => c.Medecin);
            return View(creneaux.ToList());
        }

        // GET: Creneaux/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Creneau creneau = db.Creneaux.Find(id);
            if (creneau == null)
            {
                return HttpNotFound();
            }
            return View(creneau);
        }

        // GET: Creneaux/Create
        public ActionResult Create()
        {
            ViewBag.MedecinId = new SelectList(db.Medecins, "Id", "Titre");
            return View();
        }

        // POST: Creneaux/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Hdebut,Mdebut,Hfin,Mfin,MedecinId,Timestamp")] Creneau creneau)
        {
            if (ModelState.IsValid)
            {
                db.Creneaux.Add(creneau);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MedecinId = new SelectList(db.Medecins, "Id", "Titre", creneau.MedecinId);
            return View(creneau);
        }

        // GET: Creneaux/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Creneau creneau = db.Creneaux.Find(id);
            if (creneau == null)
            {
                return HttpNotFound();
            }
            ViewBag.MedecinId = new SelectList(db.Medecins, "Id", "Titre", creneau.MedecinId);
            return View(creneau);
        }

        // POST: Creneaux/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Hdebut,Mdebut,Hfin,Mfin,MedecinId,Timestamp")] Creneau creneau)
        {
            if (ModelState.IsValid)
            {
                db.Entry(creneau).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MedecinId = new SelectList(db.Medecins, "Id", "Titre", creneau.MedecinId);
            return View(creneau);
        }

        // GET: Creneaux/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Creneau creneau = db.Creneaux.Find(id);
            if (creneau == null)
            {
                return HttpNotFound();
            }
            return View(creneau);
        }

        // POST: Creneaux/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Creneau creneau = db.Creneaux.Find(id);
            db.Creneaux.Remove(creneau);
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
