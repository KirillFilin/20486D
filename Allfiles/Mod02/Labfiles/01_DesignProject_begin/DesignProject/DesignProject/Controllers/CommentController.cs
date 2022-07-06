using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignProject.Controllers
{
    public class CommentController : Controller
    {
        // GET: CommentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CommentController/Details/5
        public ActionResult DisplayComments(int id)
        {
            return View();
        }

        // GET: CommentController/Create
        public ActionResult AddComment()
        {
            return View();
        }

        // POST: CommentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddComment(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
