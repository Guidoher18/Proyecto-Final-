using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Final_.Controllers
{
    public class EvolucionController : Controller
    {
        // GET: Evolucion
        public ActionResult Evolucion()
        {
            return View();
        }

        // GET: Evolucion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evolucion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evolucion/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Evolucion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Evolucion/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Evolucion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Evolucion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
