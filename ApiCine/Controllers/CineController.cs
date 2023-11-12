using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCine.Controllers
{
    public class CineController : Controller
    {
        // GET: CineController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CineController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CineController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: CineController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CineController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: CineController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CineController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
