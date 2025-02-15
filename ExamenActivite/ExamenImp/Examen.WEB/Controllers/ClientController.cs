﻿using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.WEB.Controllers
{
    public class ClientController : Controller
    {
        IClientService clientService;
        IConseillerServices conseillerServices;

        public ClientController(IClientService clientService, IConseillerServices conseillerServices)
        {
            this.clientService = clientService;
            this.conseillerServices = conseillerServices;
        }

        // GET: ClientController
        public ActionResult Index()
        {
            return View(clientService.GetAll());
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            ViewBag.ConseillerListe = new SelectList(conseillerServices.GetAll(), "ConseillerId", "Nom");
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Client collection, IFormFile file)
        {

            if (file != null)
            {
                //attribuer le nom du fichier à collection->Pilot
                collection.Photo = file.FileName;
                //sauvegarder le fichier dans le dossier uploads
                var path = Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot", "uploads", file.FileName);
                Stream stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);

            }

            try
            {




                clientService.Add(collection);
                clientService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
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

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
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
