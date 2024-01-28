using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Panel.Controllers
{
    public class WriterController : Controller
    {
        // GET: WriterController
        public ActionResult Index()
        {
            return View();
        }

        // GET: WriterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WriterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WriterController/Create
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

        // GET: WriterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WriterController/Edit/5
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

        // GET: WriterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WriterController/Delete/5
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
