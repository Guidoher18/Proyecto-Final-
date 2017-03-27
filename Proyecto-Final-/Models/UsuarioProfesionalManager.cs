using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Proyecto_Final_.Models
{
    public class UsuarioProfesionalManager
    {
        /// <summary>
        /// Inserta un Nuevo Usuario profesional en la BBDD
        /// </summary>
        /// <param name="Usuario"></param>
        public void InsertarUsuarioProfesional(UsuarioProfesional Usuario)
        {
            //Conexion a PsicoLOG (BBDD)
            SqlConnection Conexion = new SqlConnection(ConfigurationManager.AppSettings["ConectarBBDD"]);
            
            //Inicio la Conexión
            Conexion.Open();
            
            // Creo el objeto que permite ingresar la instancia
            SqlCommand Sentencia = Conexion.CreateCommand();
            
            // Escribo la sentencia SQL
            Sentencia.CommandText = "INSERT INTO UsuarioProfesional(Titulo, ApellidoyNombre, Especialidad, DNI, Contraseña, MN, MP, DireccionProfesional, Celular, Telefono, Email, Skype) VALUES(@Titulo, @ApellidoyNombre, @Especialidad, @DNI, @Contraseña, @MN, @MP, @DireccionProfesional, @Celular, @Telefono, @Email, @Skype)";
            
            //Vinculo las variables con los parametros
            Sentencia.Parameters.AddWithValue("@Titulo", Usuario.Titulo);
            Sentencia.Parameters.AddWithValue("@ApellidoyNombre", Usuario.ApellidoyNombre);
            Sentencia.Parameters.AddWithValue("@Especialidad", Usuario.Especialidad);
            Sentencia.Parameters.AddWithValue("@DNI", Usuario.DNI);
            Sentencia.Parameters.AddWithValue("@Contraseña", Usuario.Contraseña);
            Sentencia.Parameters.AddWithValue("@MN", Usuario.MN);
            Sentencia.Parameters.AddWithValue("@MP", Usuario.MP);
            Sentencia.Parameters.AddWithValue("@DireccionProf", Usuario.DireccionProf);
            Sentencia.Parameters.AddWithValue("@Celular", Usuario.Celular);
            Sentencia.Parameters.AddWithValue("@Telefono", Usuario.Telefono);
            Sentencia.Parameters.AddWithValue("@Email", Usuario.Email);
            Sentencia.Parameters.AddWithValue("@Skype", Usuario.Skype);
            
            // Ejecuto
            Sentencia.ExecuteNonQuery();

            //Cierro la Conexión
            Conexion.Close();
        }
    }
}