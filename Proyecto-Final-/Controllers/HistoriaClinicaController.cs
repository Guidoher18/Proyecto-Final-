using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Final_.Controllers
{
    public class HistoriaClinicaController : Controller
    {
        // GET: HistoriaClinica
        public ActionResult Historia()
        {
            return View();
        }

        // GET: HistoriaClinica/Create
        public ActionResult CrearHistoria()
        {
            return View();
        }

        public ActionResult VerHistoria()
        {
            return View();
        }

        // POST: HistoriaClinica/Create
        /// <summary>
        /// Guarda una nueva Historia Clinica = Paciente
        /// </summary>
        [HttpPost]
        public ActionResult GuardarHistoria(string Titulo, string ApellidoyNombre, string Especialidad, string DNI, string Contraseña, string MN, string MP, string DireccionProf, int Celular, int Telefono, string Email, string Skype)
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




        // GET: HistoriaClinica/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HistoriaClinica/Edit/5
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

        // GET: HistoriaClinica/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HistoriaClinica/Delete/5
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
