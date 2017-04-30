using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Livraria.Presentation.MVC.Models;

namespace Livraria.Presentation.MVC.Controllers
{
    public class EditoraController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Editora
        public ActionResult Index()
        {
            return View(db.Editora.ToList());
        }

        // GET: Editora/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Editora editora = db.Editora.Find(id);
            if (editora == null)
            {
                return HttpNotFound();
            }
            return View(editora);
        }

        // GET: Editora/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Editora/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomeEditora")] Editora editora)
        {
            if (ModelState.IsValid)
            {
                db.Editora.Add(editora);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(editora);
        }

        // GET: Editora/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Editora editora = db.Editora.Find(id);
            if (editora == null)
            {
                return HttpNotFound();
            }
            return View(editora);
        }

        // POST: Editora/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomeEditora")] Editora editora)
        {
            if (ModelState.IsValid)
            {
                db.Entry(editora).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(editora);
        }

        // GET: Editora/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Editora editora = db.Editora.Find(id);
            if (editora == null)
            {
                return HttpNotFound();
            }
            return View(editora);
        }

        // POST: Editora/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Editora editora = db.Editora.Find(id);
            db.Editora.Remove(editora);
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
