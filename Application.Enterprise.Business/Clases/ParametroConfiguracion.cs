using System;
using System.Data;

namespace Application.Enterprise.Business
{
    [Serializable]
    public class ParametroConfiguracion
    {
        #region Contructores

        static ParametroConfiguracion()
        { 
        }
        public ParametroConfiguracion()
        {
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo para actualizar un Par�metro de Configuraci�n
        /// </summary>
        /// <param name="parametro">Par�metro que se Modificar�</param>
        /// <param name="usuario">Usuario que realiza la modificaci�n</param>
        /// <returns>Verdadero si se actualiza, Falso de lo contrario</returns>
        public static bool Actualizar(CommonObjects.ParametroConfiguracion parametro, CommonObjects.InfoUsuario usuario)
        {
            bool actualizado = false;

            try
            {
                Data.ParametroConfiguracion.Actualizar(parametro.Nombre, parametro.Valor);

                //Registrar en el Log de Negocio
               /* Data.LogNegocio.Adicionar((short)CommonObjects.EventoNegocioSistema.ActualizaParametroConfiguracion,
                    DateTime.Now, usuario.Id,
                    "Se cambio el Par�metro de Configuraci�n " + parametro.Nombre + " a " + parametro.Valor);*/
                actualizado = true;
            }
            catch (Exception ex)
            {
                /*Data.Error.Adicionar(DateTime.Now,
                    usuario.Id, ex.GetHashCode().ToString(),
                    ex.Message);*/
            }

            return actualizado;
        }

		/// <summary>
		/// M�todo para consultar los Par�metros de Configuraci�n
		/// </summary>
		/// <param name="usuario">Usuario que realiza la consulta</param>
		/// <returns>Tabla con los Par�metros de Configuraci�n</returns>
		public static DataTable Obtener(CommonObjects.InfoUsuario usuario)
		{
			DataTable dtParametros = new DataTable();

			try
			{
				dtParametros = Data.ParametroConfiguracion.Consultar();
			}
			catch (Exception ex)
			{
                /*Data.Error.Adicionar(DateTime.Now,
					usuario.Id, ex.GetHashCode().ToString(),
					ex.Message); */

            }

            return dtParametros;
		}

        public static bool VerificarMercadoAbierto()
        {
            
            try
            {
                return Data.ParametroConfiguracion.VerificarMercadoAbierto();
            }
            catch (Exception ex)
            {
                /*Data.Error.Adicionar(DateTime.Now,
                    "Consultar horario mercado", ex.GetHashCode().ToString(),
                    ex.Message); */
            }

            return false;
        }

        public static string ObtenerParametro(string parametro)
        {

            try
            {
                return Data.ParametroConfiguracion.Consultar(parametro);
            }
            catch (Exception ex)
            {
                /*Data.Error.Adicionar(DateTime.Now,
                    "ObtenerParametros", ex.GetHashCode().ToString(),
                    ex.Message); */
            }

            return null;
        }

        /// <summary>
        /// Utilice este metodo para saber si la aplicacion se debe ejecutar en modo debug, esto habilita un detalle mas profundo de registro de datos.
        /// </summary>
        /// <returns></returns>
        public static bool EsModoDebug()
        {
            try
            {
                var parametrosConf = Obtener(new CommonObjects.InfoUsuario());
                int pos = ObtenerPosicionTabla("Nombre", "ModoDebug", parametrosConf);
                return parametrosConf.Rows[pos]["Valor"].ToString() == "1";
            }
            catch 
            {
                return false;
            }

        }

        public static int ObtenerPosicionTabla(string nombreColumna, string valorColumna, DataTable tabla)
        {
            int pos = -1;
            try
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    if (tabla.Rows[i][nombreColumna].ToString() == valorColumna)
                        pos = i;
                }
            }
            catch { }
            return pos;
        }

        /// <summary>
        /// Obtiene la �ltima versi�n del Sw
        /// </summary>
        /// <param name="usuario">Usuario que realiza la consulta</param>
        /// <returns>Versi�n del Sw</returns>
        public static string ObtenerVersion(CommonObjects.InfoUsuario usuario)
		{
			string version = "" ;

			try
			{
				version = Data.ParametroConfiguracion.ConsultarVersion() ;
			}
			catch (Exception ex)
			{
                /*Data.Error.Adicionar(DateTime.Now,
					usuario.Id, ex.GetHashCode().ToString(),
					ex.Message); */

            }

            return version;
		}

		/// <summary>
		/// Obtiene la �ltima versi�n del Sw
		/// </summary>
		/// <param name="usuario">Usuario que realiza la consulta</param>
		/// <param name="perfil">Perfil que se busca para la obtenci�n de la versi�n</param>
		/// <returns>Versi�n del Sw</returns>
		public static string ObtenerVersion(CommonObjects.InfoUsuario usuario, string perfil)
		{
			string version = "" ;

			try
			{
				version = Data.ParametroConfiguracion.ConsultarVersion(perfil) ;
			}
			catch (Exception ex)
			{
                /*Data.Error.Adicionar(DateTime.Now,
					usuario.Id, ex.GetHashCode().ToString(),
					ex.Message); */

            }

            return version;
		}


        public static DataTable ObtenerContactosFirma(CommonObjects.InfoUsuario usuario)
        {

            DataTable dtParametros = new DataTable();

            try
            {
                dtParametros = Data.ParametroConfiguracion.ConsultarContactosFirma();
            }
            catch (Exception ex)
            {
                /*Data.Error.Adicionar(DateTime.Now,
                    usuario.Id, ex.GetHashCode().ToString(),
                    ex.Message); */
            }

            return dtParametros;
        }
        #endregion
    }
}