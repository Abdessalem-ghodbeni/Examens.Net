using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.WEB.Controllers
{
    public class InfirmierController : Controller
    {

        IIfermiereServices infirmierServices;
        ILaboratoireServices ilaboratoireServices;

        public InfirmierController(IIfermiereServices infirmierServices, ILaboratoireServices ilaboratoireServices)
        {
            this.infirmierServices = infirmierServices;
            this.ilaboratoireServices = ilaboratoireServices;
        }

        // GET: InfirmierController
        public ActionResult Index()
        {
            return View(infirmierServices.GetAll());
        }

        // GET: InfirmierController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InfirmierController/Create
        public ActionResult Create()
        {
            ViewBag.LaboListe = new SelectList(ilaboratoireServices.GetAll(), "LaboratoireId", "Intitule");
            return View();
        }

        // POST: InfirmierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Infirmier collection)
        {
            try
            {
                infirmierServices.Add(collection);
                infirmierServices.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InfirmierController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InfirmierController/Edit/5
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

        // GET: InfirmierController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InfirmierController/Delete/5
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
