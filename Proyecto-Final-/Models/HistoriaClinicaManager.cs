using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Proyecto_Final_.Models
{
    public class HistoriaClinicaManager
    {
        /// <summary>
        /// Inserta una Nueva Historia Clinica = Nuevo Paciente en la BBDD
        /// </summary>
        /// <param name="HistoriaClinica"></param>
        public void InsertarHistoriaClinica(HistoriaClinica Paciente)
        {
            //Conexion a PsicoLOG (BBDD)
            SqlConnection Conexion = new SqlConnection(ConfigurationManager.AppSettings["ConectarBBDD"]);

            //Inicio la Conexión
            Conexion.Open();
            
            // Creo el objeto que permite ingresar la instancia
            SqlCommand Sentencia = Conexion.CreateCommand();
            
            // Escribo la sentencia SQL
            Sentencia.CommandText = "INSERT INTO HistoriaClinica(ApellidoyNombre, DNI, Nacionalidad, Genero, EstadoCivil, FechaNacimiento, EstudiosAlcanzados, Carrera, Ocupacion, Residencia, VSVinculo, VSApellidoyNombre, VSFechaNacimiento, VSOcupacion, VSConvive, ObraSocial, OSPlan, Credencial, Observaciones, Sintomas, DFecha, DDSM, DNombre, MApellidoyNombre, Especialidad, Contacto, Droga, Dosis, Celular, Telefono, Email, Skype, Direccion, NRNombreyVinculo, NRNumero) VALUES(@ApellidoyNombre, @DNI, @Nacionalidad, @Genero, @EstadoCivil, @FechaNacimiento, @EstudiosAlcanzados, @Carrera, @Ocupacion, @Residencia, @VSVinculo, @VSApellidoyNombre, @VSFechaNacimiento, @VSOcupacion, @VSConvive, @ObraSocial, @OSPlan, @Credencial, @Observaciones, @Sintomas, @DFecha, @DDSM, @DNombre, @MApellidoyNombre, @Especialidad, @Contacto, @Droga, @Dosis, @Celular, @Telefono, @Email, @Skype, @Direccion, @NRNombreyVinculo, @NRNumero)";

            //Vinculo las variables con los parametros
            Sentencia.Parameters.AddWithValue("@ApellidoyNombre", Paciente.ApellidoyNombre);
            Sentencia.Parameters.AddWithValue("@DNI", Paciente.DNI); 
            Sentencia.Parameters.AddWithValue("@Nacionalidad", Paciente.Nacionalidad);
            Sentencia.Parameters.AddWithValue("@Genero", Paciente.Genero);
            Sentencia.Parameters.AddWithValue("@EstadoCivil", Paciente.EstadoCivil); 
            Sentencia.Parameters.AddWithValue("@FechaNacimiento", Paciente.FechaNacimiento); 
            Sentencia.Parameters.AddWithValue("@EstudiosAlcanzados", Paciente.EstudiosAlcanzados); 
            Sentencia.Parameters.AddWithValue("@Carrera", Paciente.Carrera); 
            Sentencia.Parameters.AddWithValue("@Ocupacion", Paciente.Ocupacion); 
            Sentencia.Parameters.AddWithValue("@Residencia", Paciente.Residencia); 
            Sentencia.Parameters.AddWithValue("@VSVinculo", Paciente.VSVinculo); 
            Sentencia.Parameters.AddWithValue("@VSApellidoyNombre", Paciente.VSApellidoyNombre); 
            Sentencia.Parameters.AddWithValue("@VSFechaNacimiento", Paciente.VSFechaNacimiento); 
            Sentencia.Parameters.AddWithValue("@VSOcupacion", Paciente.VSOcupacion); 
            Sentencia.Parameters.AddWithValue("@VSConvive", Paciente.VSConvive); 
            Sentencia.Parameters.AddWithValue("@ObraSocial", Paciente.ObraSocial); 
            Sentencia.Parameters.AddWithValue("@OSPlan", Paciente.Plan); 
            Sentencia.Parameters.AddWithValue("@Credencial", Paciente.Credencial); 
            Sentencia.Parameters.AddWithValue("@Observaciones", Paciente.Observaciones); 
            Sentencia.Parameters.AddWithValue("@Sintomas", Paciente.Sintomas); 
            Sentencia.Parameters.AddWithValue("@DFecha", Paciente.DFecha); 
            Sentencia.Parameters.AddWithValue("@DDSM", Paciente.DDSM); 
            Sentencia.Parameters.AddWithValue("@DNombre", Paciente.DNombre); 
            Sentencia.Parameters.AddWithValue("@MApellidoyNombre", Paciente.MApellidoyNombre); 
            Sentencia.Parameters.AddWithValue("@Especialidad", Paciente.Especialidad); 
            Sentencia.Parameters.AddWithValue("@Contacto", Paciente.Contacto); 
            Sentencia.Parameters.AddWithValue("@Droga", Paciente.Droga); 
            Sentencia.Parameters.AddWithValue("@Dosis", Paciente.Dosis); 
            Sentencia.Parameters.AddWithValue("@Celular", Paciente.Celular);
            Sentencia.Parameters.AddWithValue("@Telefono", Paciente.Telefono);
            Sentencia.Parameters.AddWithValue("@Email", Paciente.Email);
            Sentencia.Parameters.AddWithValue("@Skype", Paciente.Skype);
            Sentencia.Parameters.AddWithValue("@Direccion", Paciente.Direccion); 
            Sentencia.Parameters.AddWithValue("@NRNombreyVinculo", Paciente.NRNombreyVinculo); 
            Sentencia.Parameters.AddWithValue("@NRNumero", Paciente.NRNumero);
                        
            // Ejecuto
            Sentencia.ExecuteNonQuery();

            //Cierro la Conexión
            Conexion.Close();
        }
    }
}