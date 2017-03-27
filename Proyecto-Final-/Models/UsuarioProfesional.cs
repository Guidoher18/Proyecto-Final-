using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final_.Models
{
    /// <summary>
    /// Representa al Usuario Psicólogo
    /// </summary>
    public class UsuarioProfesional
    {
        public string Titulo { get; set; }
        public string ApellidoyNombre { get; set; }
        public string Especialidad { get; set; }
        public string DNI { get; set; }
        public string Contraseña { get; set; }
        public string MN { get; set; }
        public string MP { get; set; }
        public string DireccionProf { get; set; }
        public int Celular { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
    }
}