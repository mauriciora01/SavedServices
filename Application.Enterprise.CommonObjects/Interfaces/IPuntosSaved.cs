using System;
using System.Collections.Generic;
using System.Text;
using Application.Enterprise.CommonObjects;

namespace Application.Enterprise.CommonObjects.Interfaces
{
    /// <summary>
    /// Interface de IPuntosSaved
    /// </summary>
    public interface IPuntosSaved
    {
        #region "Metodos de IPuntosSaved"

        bool InsertDetallePuntos(PuntosSavedInfo item);


        #endregion
    }
}

