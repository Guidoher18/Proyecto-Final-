using Proyecto_Final_.Models;
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
        public ActionResult GuardarHistoria(string ApellidoyNombre, string DNI, string Nacionalidad, string Genero, string EstadoCivil, string FechaNacimiento, string EstudiosAlcanzados, string Carrera, string Ocupacion, string Residencia, string VSVinculo, string VSApellidoyNombre, string VSFechaNacimiento, string VSOcupacion, string VSConvive, string ObraSocial, string Plan, string Credencial, string Observaciones, string Sintomas, string DFecha, string DDSM, string DNombre, string MApellidoyNombre, string Especialidad, string Contacto, string Droga, string Dosis, HttpPostedFileBase FotoPerfil, int Celular, int Telefono, string Email, string Skype, string Direccion, string NRNombreyVinculo, string NRNumero)
        {
            HistoriaClinica Paciente = new HistoriaClinica();
            Paciente.ApellidoyNombre = ApellidoyNombre;
            Paciente.DNI = DNI;
            Paciente.Nacionalidad = Nacionalidad;
            Paciente.Genero = Genero;
            Paciente.EstadoCivil = EstadoCivil;
            Paciente.FechaNacimiento = FechaNacimiento;
            Paciente.EstudiosAlcanzados = EstudiosAlcanzados;
            Paciente.Carrera = Carrera;
            Paciente.Ocupacion = Ocupacion;
            Paciente.Residencia = Residencia;
            Paciente.VSVinculo = VSVinculo;
            Paciente.VSApellidoyNombre = VSApellidoyNombre;
            Paciente.VSFechaNacimiento = VSFechaNacimiento;
            Paciente.VSOcupacion = VSOcupacion;
            Paciente.VSConvive = VSConvive;
            Paciente.ObraSocial = ObraSocial;
            Paciente.Plan = Plan;
            Paciente.Credencial = Credencial;
            Paciente.Observaciones = Observaciones;
            Paciente.Sintomas = Sintomas;
            Paciente.DFecha = DFecha;
            Paciente.DDSM = DDSM;
            Paciente.DNombre = DNombre;
            Paciente.MApellidoyNombre = MApellidoyNombre;
            Paciente.Especialidad = Especialidad;
            Paciente.Contacto = Contacto;
            Paciente.Droga = Droga;

            if (FotoPerfil != null)
            {
                FotoPerfil.SaveAs(Server.MapPath("~/Content/FotoPerfilHistoria/" + DNI + ".jpg"));
            }

            Paciente.Dosis = Dosis;
            Paciente.Celular = Celular;
            Paciente.Telefono = Telefono;
            Paciente.Email = Email;
            Paciente.Skype = Skype;
            Paciente.Direccion = Direccion;
            Paciente.NRNombreyVinculo = NRNombreyVinculo;
            Paciente.NRNumero = NRNumero;
            
            HistoriaClinicaManager Manager = new HistoriaClinicaManager();
            Manager.InsertarHistoriaClinica(Paciente);

            return GetHistoria(Paciente.ID);
            //RedirectToAction("GetHistoria", "HistoriaClinica");
        }


        // GET Historia Clinica
        public ActionResult GetHistoria(string ID)
        {
            HistoriaClinicaManager Manager = new HistoriaClinicaManager();
            HistoriaClinica Paciente = Manager.ConsultarHistoria(ID);

            ViewBag.HistoriaClinica = Paciente;

            return View("~/Views/HistoriaClinica/VerHistoria.cshtml");
        }

        // GET IDHistoria
        public ActionResult GetIDHistoria(string TextBuscar)
        {
            HistoriaClinicaManager Manager = new HistoriaClinicaManager();
            HistoriaClinica Paciente = Manager.ConsultarIDHistoria(TextBuscar);

            ViewBag.HistoriaClinica = Paciente;

            return View("~/Views/HistoriaClinica/HistoriaBuscar.cshtml");
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
