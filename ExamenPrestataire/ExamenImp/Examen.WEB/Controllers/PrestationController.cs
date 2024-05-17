using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.WEB.Controllers
{
    public class PrestationController : Controller
    {
        IPrestationServic prestationservice;
        IServicePrestataire prestataire_service;

        public PrestationController(IPrestationServic prestationservice,
            IServicePrestataire prestataire_service)
        {
            this.prestationservice = prestationservice;
            this.prestataire_service = prestataire_service;
        }

        // GET: PrestationController
        public ActionResult Index()
        {
            return View(prestationservice.GetAll());
        }

        // GET: PrestationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrestationController/Create
        public ActionResult Create()
        {
            ViewBag.PrestataireListe = new SelectList(prestataire_service.GetAll(), "PrestataireId", "PrestataireNom");

            return View();
        }

        // POST: PrestationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Prestation collection)
        {
            try
            {
                prestationservice.Add(collection);
                prestationservice.Commit();
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrestationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrestationController/Edit/5
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

        // GET: PrestationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrestationController/Delete/5
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
