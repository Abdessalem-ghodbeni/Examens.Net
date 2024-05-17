using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.WEB.Controllers
{

   
    public class AdmissionController : Controller
    {
        IChambreService chambreService;
        IAdmissionServices admissionServices;
        IPatientServices patientServices;

        public AdmissionController(IChambreService chambreService, IAdmissionServices admissionServices, IPatientServices patientServices)
        {
            this.chambreService = chambreService;
            this.admissionServices = admissionServices;
            this.patientServices = patientServices;
        }


        // GET: AdmissionController
        public ActionResult Index()
        {
            return View(admissionServices.GetAll().OrderBy(admission=>admission.DateAdmission));
        }

        // GET: AdmissionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdmissionController/Create
        public ActionResult Create()
        {
            ViewBag.PatientListe = new SelectList(patientServices.GetAll(), "CIN", "CIN");
            ViewBag.chambreliste = new SelectList(chambreService.GetAll(), "NumeroChambre", "NumeroChambre");
            return View();
        }

        // POST: AdmissionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Admission admission)
        {
            try
            {
                admissionServices.Add(admission);
                admissionServices.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdmissionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdmissionController/Edit/5
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

        // GET: AdmissionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdmissionController/Delete/5
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
