using Proyecto_Final_.Models;
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
        /// Inserta un Nuevo Usuario Profesional en la BBDD
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
            Sentencia.CommandText = "INSERT INTO UsuarioProfesional(Titulo, ApellidoyNombre, Especialidad, DNI, Contraseña, MN, MP, DireccionProfesional, Celular, Telefono, Email, Skype) VALUES(@Titulo, @ApellidoyNombre, @Especialidad, @DNI, @Contraseña, @MN, @MP, @DireccionProf, @Celular, @Telefono, @Email, @Skype)";

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

        /// <summary>
        /// Permite Consultar en BBDD un Usuario Profesional
        /// </summary>
        /// <param name="DNI"></param>
        /// <returns></returns>
        public UsuarioProfesional ConsultarUsuario(string DNI, string Contraseña)
        {
            //Conexion a PsicoLOG (BBDD)
            SqlConnection Conexion = new SqlConnection(ConfigurationManager.AppSettings["ConectarBBDD"]);

            //Inicio la Conexión
            Conexion.Open();

            // Creo el objeto que permite ingresar la instancia
            SqlCommand Sentencia = Conexion.CreateCommand();

            // Escribo la sentencia SQL
            Sentencia.CommandText = "SELECT * FROM UsuarioProfesional WHERE DNI = @DNI";

            //Vinculo las variables con los parametros
            Sentencia.Parameters.AddWithValue("@DNI", DNI);
            // Ejecuto
            SqlDataReader Reader = Sentencia.ExecuteReader();

            UsuarioProfesional Usuario = new UsuarioProfesional();

            if (Reader.Read() && (string) Reader["DNI"] == DNI) 
            {              
                if ((string) Reader["Contraseña"] == Contraseña)
                {
                    Usuario.Titulo = (string) Reader["Titulo"];
                    Usuario.ApellidoyNombre = (string) Reader["ApellidoyNombre"];
                    Usuario.Especialidad = Reader["Especialidad"].ToString();
                    Usuario.DNI = (string) Reader["DNI"];
                    Usuario.MN = (string) Reader["MN"];
                    Usuario.MP = (string) Reader["MP"];
                    Usuario.DireccionProf = (string) Reader["DireccionProfesional"];
                    Usuario.Celular = (int) Reader["Celular"];
                    Usuario.Telefono = (int) Reader["Telefono"];
                    Usuario.Email = (string) Reader["Email"];
                    Usuario.Skype = (string) Reader["Skype"];

                    return Usuario;
                }
                else
                {
                    //Contraseña Erronea
                }
            } 
            else
            {
                //Usuario Erroneo
            }

            //Cierro el Reader
            Reader.Close();

            //Cierro la Conexión
            Conexion.Close();

            return Usuario;
        }
    }


    
}