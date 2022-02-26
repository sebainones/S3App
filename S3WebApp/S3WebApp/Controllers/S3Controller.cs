using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace S3WebApp.Controllers
{
    public class S3Controller : Controller
    {
        // GET: S3Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: S3Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: S3Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: S3Controller/Create
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

        // GET: S3Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: S3Controller/Edit/5
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

        // GET: S3Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: S3Controller/Delete/5
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
