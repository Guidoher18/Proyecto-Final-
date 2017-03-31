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
        public ActionResult GuardarHistoria( )
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
            Paciente.residencia = Residencia;
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

            return View("@Url.Action("Main", "Main")");
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
