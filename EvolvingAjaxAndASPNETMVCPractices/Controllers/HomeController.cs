using System;
using System.Web.Mvc;
using EvolvingAjaxAndASPNETMVCPractices.Code;

namespace EvolvingAjaxAndASPNETMVCPractices.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        private IBookRepository _bookRepository;

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Books()
        {
            return View();
        }

        public JsonResult GetAuthors()
        {
            var authors = _bookRepository.GetAuthors();

            return Json(authors, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetBooksByAuthor(string author)
        {
            var books = _bookRepository.GetBooksByAuthor(author);

            return Json(books, JsonRequestBehavior.AllowGet);
        }
    }
}
