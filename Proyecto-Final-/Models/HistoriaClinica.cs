using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final_.Models
{
    /// <summary>
    /// Respresenta al Paciente = Historia Clínica
    /// </summary>
    public class HistoriaClinica
    {
        public string ID { get; set; }
        public string ApellidoyNombre { get; set; }
        public string DNI { get; set; }
        public string Nacionalidad { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
        public string FechaNacimiento { get; set; }
        public string EstudiosAlcanzados { get; set; }
        public string Carrera { get; set; }
        public string Ocupacion { get; set; }
        public string Residencia { get; set; }
        public string VSVinculo { get; set; }
        public string VSApellidoyNombre { get; set; }
        public string VSFechaNacimiento { get; set; }
        public string VSOcupacion { get; set; }
        public string VSConvive { get; set; }
        public string ObraSocial { get; set; }
        public string Plan { get; set; }
        public string Credencial { get; set; }
        public string Observaciones { get; set; }
        public string Sintomas { get; set; }
        public string DFecha { get; set; }
        public string DDSM { get; set; }
        public string DNombre { get; set; }
        public string MApellidoyNombre { get; set; }
        public string Especialidad { get; set; }
        public string Contacto { get; set; }
        public string Droga { get; set; }
        public string Dosis { get; set; }
        public int Celular { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string Direccion { get; set; }
        public string NRNombreyVinculo { get; set; }
        public string NRNumero { get; set; }
    }
}