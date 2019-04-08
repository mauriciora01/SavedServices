using System;

namespace Application.Enterprise.CommonObjects
{
    /// <summary>
    /// Provee informaci�n sobre un par�metro de configuraci�n del sistema
    /// </summary>
    
    public class ParametroConfiguracion
    {
        /// <summary>
        /// Nombre o identificador del par�metro de configuraci�n
        /// </summary>
        public string Nombre;

        /// <summary>
        /// Valor del par�metro de configuraci�n
        /// </summary>
        public string Valor;

        /// <summary>
        /// Inicializa una instancia vac�a de la clase ParametroConfiguracion
        /// </summary>
        public ParametroConfiguracion()
        {
        }

        /// <summary>
        /// Inicializa una instancia de la clase ParametroConfiguracion
        /// </summary>
        /// <param name="nombre">Nombre o identificador del par�metro de configuraci�n</param>
        /// <param name="valor">Valor del par�metro de configuraci�n</param>
        public ParametroConfiguracion(string nombre, string valor)
        {
            this.Nombre = nombre;
            this.Valor  = valor;
        }
    }
}