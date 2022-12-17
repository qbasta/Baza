using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Baza.Controllers
{
    public class ZabytekController : Controller
    {

        // GET: ZabytekController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ZabytekController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ZabytekController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZabytekController/Create
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

        // GET: ZabytekController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ZabytekController/Edit/5
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

        // GET: ZabytekController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ZabytekController/Delete/5
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
