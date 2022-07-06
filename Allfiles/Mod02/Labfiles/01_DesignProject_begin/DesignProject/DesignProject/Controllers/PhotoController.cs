using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignProject.Controllers
{
    public class PhotoController : Controller
    {
        // GET: PhotoController/DisplayGallery
        public ActionResult Index()
        {
            return View();
        }

        // GET: PhotoController/DisplayRecent
        public ActionResult DisplayRecent()
        {
            return View();
        }

        // GET: PhotoController/DisplayPhoto/5
        public ActionResult DisplayPhoto(int id)
        {
            return View();
        }

        // GET: PhotoController/AddPhoto
        public ActionResult AddPhoto()
        {
            return View();
        }

        // POST: PhotoController/AddPhoto
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPhoto(IFormCollection collection)
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

        // GET: PhotoController/DeletePhoto/5
        public ActionResult DeletePhoto(int id)
        {
            return View();
        }

        // POST: PhotoController/DeletePhoto/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePhoto(int id, IFormCollection collection)
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
