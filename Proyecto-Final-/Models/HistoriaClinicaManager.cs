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
        public HistoriaClinica InsertarHistoriaClinica(HistoriaClinica Paciente)
        {
            //Conexion a PsicoLOG (BBDD)
            SqlConnection Conexion = new SqlConnection(ConfigurationManager.AppSettings["ConectarBBDD"]);

            //Inicio la Conexión
            Conexion.Open();
            
            // Creo el objeto que permite ingresar la instancia
            SqlCommand Sentencia = Conexion.CreateCommand();
            
            // Escribo la sentencia SQL
            Sentencia.CommandText = "INSERT INTO HistoriaClinica(ApellidoyNombre, DNI, Nacionalidad, Genero, EstadoCivil, FechaNacimiento, EstudiosAlcanzados, Carrera, Ocupacion, Residencia, VSVinculo, VSApellidoyNombre, VSFechaNacimiento, VSOcupacion, VSConvive, ObraSocial, OSPlan, Credencial, Observaciones, Sintomas, DFecha, DDSM, DNombre, MApellidoyNombre, Especialidad, Contacto, Droga, Dosis, Celular, Telefono, Email, Skype, Direccion, NRNombreyVinculo, NRNumero) OUTPUT INSERTED.ID VALUES(@ApellidoyNombre, @DNI, @Nacionalidad, @Genero, @EstadoCivil, @FechaNacimiento, @EstudiosAlcanzados, @Carrera, @Ocupacion, @Residencia, @VSVinculo, @VSApellidoyNombre, @VSFechaNacimiento, @VSOcupacion, @VSConvive, @ObraSocial, @OSPlan, @Credencial, @Observaciones, @Sintomas, @DFecha, @DDSM, @DNombre, @MApellidoyNombre, @Especialidad, @Contacto, @Droga, @Dosis, @Celular, @Telefono, @Email, @Skype, @Direccion, @NRNombreyVinculo, @NRNumero)";

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
            Paciente.ID = Sentencia.ExecuteScalar().ToString(); 
            //Cierro la Conexión
            Conexion.Close();

            return Paciente;
        }


        /// <summary>
        /// Permite Consultar en BBDD una Historia Clinica
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public HistoriaClinica ConsultarHistoria(string ID)
        {
            //Conexion a PsicoLOG (BBDD)
            SqlConnection Conexion = new SqlConnection(ConfigurationManager.AppSettings["ConectarBBDD"]);

            //Inicio la Conexión
            Conexion.Open();

            // Creo el objeto que permite ingresar la instancia
            SqlCommand Sentencia = Conexion.CreateCommand();

            // Escribo la sentencia SQL
            Sentencia.CommandText = "SELECT * FROM HistoriaClinica WHERE ID = @ID";

            //Vinculo las variables con los parametros
            Sentencia.Parameters.AddWithValue("@ID", ID);
            // Ejecuto
            SqlDataReader Reader = Sentencia.ExecuteReader();
            HistoriaClinica Paciente = new HistoriaClinica();
            if (Reader.Read())
            {
                Paciente.ID = ID;
                Paciente.ApellidoyNombre = (string)Reader["ApellidoyNombre"];
                Paciente.DNI = (string)Reader["DNI"];
                Paciente.Nacionalidad = (string)Reader["Nacionalidad"];
                Paciente.Genero = (string)Reader["Genero"];
                Paciente.EstadoCivil = (string)Reader["EstadoCivil"];
                Paciente.FechaNacimiento = (string)Reader["FechaNacimiento"];
                Paciente.EstudiosAlcanzados = (string)Reader["EstudiosAlcanzados"];
                Paciente.Carrera = (string)Reader["Carrera"];
                Paciente.Ocupacion = (string)Reader["Ocupacion"];
                Paciente.Residencia = (string)Reader["Residencia"];
                Paciente.VSVinculo = (string)Reader["VSVinculo"];
                Paciente.VSApellidoyNombre = (string)Reader["VSApellidoyNombre"];
                Paciente.VSFechaNacimiento = (string)Reader["VSFechaNacimiento"];
                Paciente.VSOcupacion = (string)Reader["VSOcupacion"];
                Paciente.VSConvive = (string)Reader["VSConvive"];
                Paciente.ObraSocial = (string)Reader["ObraSocial"];
                Paciente.Plan = (string)Reader["OSPlan"];
                Paciente.Credencial = (string)Reader["Credencial"];
                Paciente.Observaciones = (string)Reader["Observaciones"];
                Paciente.Sintomas = (string)Reader["Sintomas"];
                Paciente.DFecha = (string)Reader["DFecha"];
                Paciente.DDSM = (string)Reader["DDSM"];
                Paciente.DNombre = (string)Reader["DNombre"];
                Paciente.MApellidoyNombre = (string)Reader["MApellidoyNombre"];
                Paciente.Especialidad = (string)Reader["Especialidad"];
                Paciente.Contacto = (string)Reader["Contacto"];
                Paciente.Droga = (string)Reader["Droga"];
                Paciente.Dosis = (string)Reader["Dosis"];
                Paciente.Celular = (int)Reader["Celular"];
                Paciente.Telefono = (int)Reader["Telefono"];
                Paciente.Email = (string)Reader["Email"];
                Paciente.Skype = (string)Reader["Skype"];
                Paciente.Direccion = (string)Reader["Direccion"];
                Paciente.NRNombreyVinculo = (string)Reader["NRNombreyVinculo"];
                Paciente.NRNumero = (string)Reader["NRNumero"];

                return Paciente;
            }

            //Cierro el Reader
            Reader.Close();

            //Cierro la Conexión
            Conexion.Close();

            return Paciente;
        }


        /// <summary>
        /// Permite Consultar en BBDD el ID de una Historia Clinica
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public HistoriaClinica ConsultarIDHistoria(string TextBuscar)
        {
            //Conexion a PsicoLOG (BBDD)
            SqlConnection Conexion = new SqlConnection(ConfigurationManager.AppSettings["ConectarBBDD"]);

            //Inicio la Conexión
            Conexion.Open();

            // Creo el objeto que permite ingresar la instancia
            SqlCommand Sentencia = Conexion.CreateCommand();

            // Escribo la sentencia SQL
            Sentencia.CommandText = "SELECT * FROM HistoriaClinica WHERE 'ApellidoyNombre' LIKE '@TextBuscar'";

            //Vinculo las variables con los parametros
            Sentencia.Parameters.AddWithValue("@TextBuscar", TextBuscar);
            // Ejecuto
            SqlDataReader Reader = Sentencia.ExecuteReader();
            HistoriaClinica Paciente = new HistoriaClinica();
            while (Reader.Read())
            {
                Paciente.ID = (string)Reader["ID"];
                Paciente.ApellidoyNombre = (string)Reader["ApellidoyNombre"];
                return Paciente;
            }

            //Cierro el Reader
            Reader.Close();

            //Cierro la Conexión
            Conexion.Close();

            return Paciente;
        }
    }
}
