using System;
using System.Text;
using System.Data;
using System.Security.Cryptography;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;

namespace Application.Enterprise.Data
{
    public class ParametroConfiguracion
    {
        static ParametroConfiguracion()
        {
        }

        /// <summary>
        /// M�todo para adicionar un Par�metro de Configuraci�n
        /// </summary>
        /// <param name="nombre">Nombre del Par�metro</param>
        /// <param name="valor">Valor del Par�metro</param>
        /// <returns>N�mero de registros afectados en la Base de Datos</returns>
        public static int Adicionar(string nombre, string valor)
        {
            int numLineas = 0;

            try
            {
                // Recuperar objeto de conexi�n
                Database dbTrader = DatabaseFactory.CreateDatabase("CONNTRADER_ADMIN");
                
                // Crear objeto SP
                DbCommand spAdicionarParametroConfiguracion = dbTrader.GetStoredProcCommand("AdicionarParametroConfiguracion");
                
                // Adicionar par�metros necesarios para ejecutar el SP
                dbTrader.AddInParameter(spAdicionarParametroConfiguracion,"@nombre", DbType.String, nombre);
                dbTrader.AddInParameter(spAdicionarParametroConfiguracion,"@valor", DbType.String, valor);
                
                dbTrader.ExecuteNonQuery(spAdicionarParametroConfiguracion);
			}
            catch (Exception ex)
            {
                throw new Exception("Excepcion en la funcion iTraderData.AdicionarParametroConfiguracion \n" + ex.Message);
            }

            return numLineas;
        }

        /// <summary>
        /// M�todo para consultar los Par�metros de Configuraci�n de la Plataforma
        /// </summary>
        /// <returns>Tabla con los datos de los Par�metros</returns>
        public static DataTable Consultar()
        {
            DataSet datos;
            DataTable parametros = new DataTable();

            try
            {
                // Recuperar objeto de conexi�n
                Database dbTrader = DatabaseFactory.CreateDatabase("CONNTRADER_ADMIN");

                // Crear objeto SP
                DbCommand spConsultarParametrosConfiguracion = dbTrader.GetStoredProcCommand("ConsultarParametrosConfiguracion");

                datos = dbTrader.ExecuteDataSet(spConsultarParametrosConfiguracion);
                parametros = datos.Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Excepcion en la funcion iTraderData.ConsultarParametrosConfiguracion \n" + ex.Message);
            }

            return parametros;
        }

        public static bool VerificarMercadoAbierto()
        {
            
            try
            {
                var dbTrader = DatabaseFactory.CreateDatabase("CONNTRADER_ADMIN");
                var sp = dbTrader.GetStoredProcCommand("Verificar_Horario_Mercado");


                return Convert.ToInt32(dbTrader.ExecuteScalar(sp)) == 1 ;

            }
            catch (Exception ex)
            {
                throw new Exception("Excepcion en la funcion iTraderData.Verificar_Horario_Mercado \n" + ex.Message);
            }
        }

        /// <summary>
        /// M�todo para consultar la �ltima versi�n de la Aplicaci�n
        /// </summary>
        /// <returns>Version de la Aplicacion</returns>
        public static string ConsultarVersion()
		{
			string version = "" ;

			try
			{
				// Recuperar objeto de conexi�n
				Database dbTrader = DatabaseFactory.CreateDatabase("CONNTRADER_ADMIN");

				// Crear objeto SP
				DbCommand spConsultar = dbTrader.GetStoredProcCommand("ConsultarUltimaVersion");

                dbTrader.AddOutParameter(spConsultar,"@version", DbType.String, 15);

				dbTrader.ExecuteNonQuery(spConsultar);

                version = (string)dbTrader.GetParameterValue(spConsultar,"@version");

			}
			catch (Exception ex)
			{
				throw new Exception("Excepcion en la funcion Application.Enterprise.Data.ParametroConfiguracion.ConsultarVersion \n" + ex.Message);
			}

			return version;
		}

		/// <summary>
		/// M�todo para consultar la �ltima versi�n de la Aplicaci�n
		/// </summary>
		/// <param name="perfil">Perfil a consultar</param>
		/// <returns>Version de la Aplicacion</returns>
		public static string ConsultarVersion(string perfil)
		{
			string version = "" ;

			try
			{
				// Recuperar objeto de conexi�n
				Database dbTrader = DatabaseFactory.CreateDatabase("CONNTRADER_ADMIN");

				// Crear objeto SP
				DbCommand spConsultar = dbTrader.GetStoredProcCommand("ConsultarVersionPorPerfil");

                dbTrader.AddInParameter(spConsultar,"@perfil", DbType.String, perfil);
                dbTrader.AddOutParameter(spConsultar,"@version", DbType.String, 15);

				dbTrader.ExecuteNonQuery(spConsultar);

                version = (string)dbTrader.GetParameterValue(spConsultar,"@version");

			}
			catch (Exception ex)
			{
				throw new Exception("Excepcion en la funcion Application.Enterprise.Data.ParametroConfiguracion.ConsultarVersion \n" + ex.Message);
			}

			return version;
		}

        /// <summary>
        /// M�todo para consultar un Par�metro de Configuraci�n
        /// </summary>
        /// <param name="nombre">Nombre del Par�metro</param>
        /// <returns>Valor del Par�metro de Configuraci�n</returns>
        public static string Consultar(string nombre)
        {
            string valor;
            try
            { 
                // Recuperar objeto de conexi�n
                Database dbTrader = DatabaseFactory.CreateDatabase("CONNTRADER_ADMIN");

                // Crear objeto SP
                DbCommand spConsultarParametroConfiguracion = dbTrader.GetStoredProcCommand("ConsultarParametroConfiguracion");

                dbTrader.AddInParameter(spConsultarParametroConfiguracion,"@nombre", DbType.String, nombre);
                dbTrader.AddOutParameter(spConsultarParametroConfiguracion,"@valor", DbType.String, 10);

                dbTrader.ExecuteNonQuery(spConsultarParametroConfiguracion);
                valor = dbTrader.GetParameterValue(spConsultarParametroConfiguracion,"@valor").ToString();

            }
            catch (Exception ex)
            {
                throw new Exception("Excepcion en la funcion iTraderData.ConsultarParametroConfiguracion \n" + ex.Message);
            }

            return valor;
        }


        public static DataTable ConsultarContactosFirma()
        {
            DataSet datos;
            DataTable parametros = new DataTable();

            try
            {
                Database dbTrader = DatabaseFactory.CreateDatabase("CONNTRADER_ADMIN");
                DbCommand spConsultarParametroConfiguracion = dbTrader.GetStoredProcCommand("ConsultarContactosFirmaComisionista");

                datos = dbTrader.ExecuteDataSet(spConsultarParametroConfiguracion);
                parametros = datos.Tables[0];
              
            }
            catch (Exception ex)
            {
                throw new Exception("Excepcion en la funcion eTrader.Datos.ParametroConfiguracion.ConsultarContactosFirma \n" + ex.Message);
            }

            return parametros;
        }

        /// <summary>
        /// M�todo para actualizar un par�metro de Configuraci�n
        /// </summary>
        /// <param name="nombre">Nombre del Par�metro</param>
        /// <param name="valor">Valor del par�metro</param>
        /// <returns>N�mero de registros afectados en la Base de Datos</returns>
        public static int Actualizar(string nombre, string valor)
        {
            int numLineas = 0;

            try
            {
                // Recuperar objeto de conexi�n
                Database dbTrader = DatabaseFactory.CreateDatabase("CONNTRADER_ADMIN");

                // Crear objeto SP
                DbCommand spActualizarParametroConfiguracion = dbTrader.GetStoredProcCommand("ActualizarParametroConfiguracion");

                // Adicionar par�metros necesarios para ejecutar el SP
                dbTrader.AddInParameter(spActualizarParametroConfiguracion,"@nombre", DbType.String, nombre);
                dbTrader.AddInParameter(spActualizarParametroConfiguracion,"@valor", DbType.String, valor);
				
				spActualizarParametroConfiguracion.CommandTimeout = 900000000;

                dbTrader.ExecuteNonQuery(spActualizarParametroConfiguracion);
			}
            catch (Exception ex)
            {
                throw new Exception("Excepcion en la funcion iTraderData.ActualizarParametroConfiguracion \n" + ex.Message);
            }

            return numLineas;       
        }
    }
}