using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Final_.Controllers
{
    public class UsuarioManagerController : Controller
    {
        // GET: UsuarioManager/Create

        public ActionResult CrearCuenta()
        {
            return View("~/Views/UsuarioManager/Profesional.cshtml");
        }



        public ActionResult Index()
        {
            return View();
        }

        // GET: UsuarioManager/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }



        // POST: UsuarioManager/Create
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

        // GET: UsuarioManager/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioManager/Edit/5
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

        // GET: UsuarioManager/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioManager/Delete/5
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
