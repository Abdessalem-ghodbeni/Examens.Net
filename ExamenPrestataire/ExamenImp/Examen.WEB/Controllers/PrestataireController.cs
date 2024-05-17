using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.WEB.Controllers
{
    public class PrestataireController : Controller
    {

        IServicePrestataire SP;

        public PrestataireController(IServicePrestataire sP)
        {
            SP = sP;
        }


        // GET: PrestataireController
        public ActionResult Index(string? Nom)
        {
            return View(SP.GetAll().OrderBy(p => p.PrestataireNom));
        }

        // GET: PrestataireController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrestataireController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrestataireController/Create
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

        // GET: PrestataireController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrestataireController/Edit/5
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

        // GET: PrestataireController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrestataireController/Delete/5
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
