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

        public ActionResult CrearCuenta()
        {
            return View("~/Views/UsuarioProfesional/Profesional.cshtml");
        }

        /// <summary>
        /// Guarda un nuevo Usuario Profesional
        /// </summary>
        [HttpPost]
        public ActionResult GuardarCuenta(string Titulo, string ApellidoyNombre, string Especialidad, string DNI, string Contraseña, string MN, string MP, HttpPostedFileBase Firma,string DireccionProf, HttpPostedFileBase FotoPerfil, int Celular, int Telefono, string Email, string Skype)
        {
            UsuarioProfesional Usuario = new UsuarioProfesional();
            Usuario.Titulo = Titulo;
            Usuario.ApellidoyNombre = ApellidoyNombre;
            Usuario.Especialidad = Especialidad;
            Usuario.DNI = DNI;
            Usuario.Contraseña = Contraseña;
            Usuario.MN = MN;
            Usuario.MP = MP;

            if (Firma != null)
            {
                Firma.SaveAs(Server.MapPath("~/Content/FirmaProfesional/" + DNI + ".png"));
            }
            
            Usuario.DireccionProf = DireccionProf;

            if (FotoPerfil != null)
            {
                FotoPerfil.SaveAs(Server.MapPath("~/Content/FotoPerfilProfesional/" + DNI + ".jpg"));
            }

            Usuario.Celular = Celular;
            Usuario.Telefono = Telefono;
            Usuario.Email = Email;
            Usuario.Skype = Skype;

            UsuarioProfesionalManager Manager = new UsuarioProfesionalManager();
            Manager.InsertarUsuarioProfesional(Usuario);

            return RedirectToAction("Login", "Home");
        }

        // GET Usuario Profesional
        public ActionResult GetUsuario(string DNI, string Contraseña)
        {
            UsuarioProfesionalManager Manager = new UsuarioProfesionalManager();
            UsuarioProfesional usuario = Manager.ConsultarUsuario(DNI, Contraseña);

            ViewBag.UsuarioProfesional = usuario;

            return View("~/Views/Main/Main.cshtml");
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


    }
}
