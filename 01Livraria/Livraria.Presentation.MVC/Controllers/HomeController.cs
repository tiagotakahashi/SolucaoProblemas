using System.Web.Mvc;

namespace Livraria.Presentation.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Livro");
        }
    }
}