using Proyecto_Final_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Final_.Controllers
{
    public class UsuarioProfesionalController : Controller
    {
        // GET: UsuarioManager

        public ActionResult CrearCuenta()
        {
            return View("~/Views/UsuarioProfesional/Profesional.cshtml");
        }

        /// <summary>
        /// Guarda un nuevo Usuario Profesional
        /// </summary>
        [HttpPost]
        public ActionResult GuardarCuenta(string Titulo, string ApellidoyNombre, string Especialidad, string DNI, string Contraseña, string MN, string MP, string DireccionProf, int Celular, int Telefono, string Email, string Skype)
        {
            UsuarioProfesional Usuario = new UsuarioProfesional();
            Usuario.Titulo = Titulo;
            Usuario.ApellidoyNombre = ApellidoyNombre;
            Usuario.Especialidad = Especialidad;
            Usuario.DNI = DNI;
            Usuario.Contraseña = Contraseña;
            Usuario.MN = MN;
            Usuario.MP = MP;
            Usuario.DireccionProf = DireccionProf;
            Usuario.Celular = Celular;
            Usuario.Telefono = Telefono;
            Usuario.Email = Email;
            Usuario.Skype = Skype;

            UsuarioProfesionalManager Manager = new UsuarioProfesionalManager();
            Manager.InsertarUsuarioProfesional(Usuario);

            return RedirectToAction("Login", "Home");
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
