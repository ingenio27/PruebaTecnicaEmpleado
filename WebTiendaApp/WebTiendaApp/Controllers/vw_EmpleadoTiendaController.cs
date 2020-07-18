using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebTiendaApp.Models;

namespace WebTiendaApp.Controllers
{
    public class vw_EmpleadoTiendaController : Controller
    {
        private PruebaNetEntities db = new PruebaNetEntities();

        // GET: vw_EmpleadoTienda
        public ActionResult Index()
        {
            return View(db.vw_EmpleadoTienda.ToList());
        }

        // GET: vw_EmpleadoTienda/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_EmpleadoTienda vw_EmpleadoTienda = db.vw_EmpleadoTienda.Find(id);
            if (vw_EmpleadoTienda == null)
            {
                return HttpNotFound();
            }
            return View(vw_EmpleadoTienda);
        }

        // GET: vw_EmpleadoTienda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vw_EmpleadoTienda/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nombres,Cargo,NombreTienda,Mes,Dia")] vw_EmpleadoTienda vw_EmpleadoTienda)
        {
            if (ModelState.IsValid)
            {
                db.vw_EmpleadoTienda.Add(vw_EmpleadoTienda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vw_EmpleadoTienda);
        }

        // GET: vw_EmpleadoTienda/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_EmpleadoTienda vw_EmpleadoTienda = db.vw_EmpleadoTienda.Find(id);
            if (vw_EmpleadoTienda == null)
            {
                return HttpNotFound();
            }
            return View(vw_EmpleadoTienda);
        }

        // POST: vw_EmpleadoTienda/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Nombres,Cargo,NombreTienda,Mes,Dia")] vw_EmpleadoTienda vw_EmpleadoTienda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vw_EmpleadoTienda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vw_EmpleadoTienda);
        }

        // GET: vw_EmpleadoTienda/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_EmpleadoTienda vw_EmpleadoTienda = db.vw_EmpleadoTienda.Find(id);
            if (vw_EmpleadoTienda == null)
            {
                return HttpNotFound();
            }
            return View(vw_EmpleadoTienda);
        }

        // POST: vw_EmpleadoTienda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            vw_EmpleadoTienda vw_EmpleadoTienda = db.vw_EmpleadoTienda.Find(id);
            db.vw_EmpleadoTienda.Remove(vw_EmpleadoTienda);
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
