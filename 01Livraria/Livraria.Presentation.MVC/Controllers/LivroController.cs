using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Livraria.Presentation.MVC.Models;

namespace Livraria.Presentation.MVC.Controllers
{
    public class LivroController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Livro
        public ActionResult Index()
        {
            var livro = db.Livro.Include(l => l.Autor).Include(l => l.Categoria).Include(l => l.Editora).OrderBy(x => x.Nome);
            ViewBag.TotalLivros = livro.Count();
            return View(livro);
        }

        // GET: Livro/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Livro livro = db.Livro.Find(id);
            if (livro == null)
            {
                return HttpNotFound();
            }
            return View(livro);
        }

        // GET: Livro/Create
        public ActionResult Create()
        {
            ViewBag.IdAutor = new SelectList(db.Autor, "Id", "NomeAutor");
            ViewBag.IdCategoria = new SelectList(db.Categoria, "Id", "DescricaoCategoria");
            ViewBag.IdEditora = new SelectList(db.Editora, "Id", "NomeEditora");
            return View();
        }

        // POST: Livro/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,IdCategoria,IdAutor,DataLancamento,IdEditora")] Livro livro)
        {
            if (ModelState.IsValid)
            {
                db.Livro.Add(livro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdAutor = new SelectList(db.Autor, "Id", "NomeAutor", livro.IdAutor);
            ViewBag.IdCategoria = new SelectList(db.Categoria, "Id", "DescricaoCategoria", livro.IdCategoria);
            ViewBag.IdEditora = new SelectList(db.Editora, "Id", "NomeEditora", livro.IdEditora);
            return View(livro);
        }

        // GET: Livro/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Livro livro = db.Livro.Find(id);
            if (livro == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdAutor = new SelectList(db.Autor, "Id", "NomeAutor", livro.IdAutor);
            ViewBag.IdCategoria = new SelectList(db.Categoria, "Id", "DescricaoCategoria", livro.IdCategoria);
            ViewBag.IdEditora = new SelectList(db.Editora, "Id", "NomeEditora", livro.IdEditora);
            return View(livro);
        }

        // POST: Livro/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,IdCategoria,IdAutor,DataLancamento,IdEditora")] Livro livro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(livro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdAutor = new SelectList(db.Autor, "Id", "NomeAutor", livro.IdAutor);
            ViewBag.IdCategoria = new SelectList(db.Categoria, "Id", "DescricaoCategoria", livro.IdCategoria);
            ViewBag.IdEditora = new SelectList(db.Editora, "Id", "NomeEditora", livro.IdEditora);
            return View(livro);
        }

        // GET: Livro/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Livro livro = db.Livro.Find(id);
            if (livro == null)
            {
                return HttpNotFound();
            }
            return View(livro);
        }

        // POST: Livro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Livro livro = db.Livro.Find(id);
            db.Livro.Remove(livro);
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
