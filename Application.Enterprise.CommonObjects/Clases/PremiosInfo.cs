﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Enterprise.CommonObjects
{
    /// <summary>
    /// 
    /// </summary>
    
    public class PremiosInfo
    {
        private int id;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string descripcion;
        /// <summary>
        /// 
        /// </summary>
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private string condiciones;
        /// <summary>
        /// 
        /// </summary>
        public string Condiciones
        {
            get { return condiciones; }
            set { condiciones = value; }
        }

        private int estado;
        /// <summary>
        /// 
        /// </summary>
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private DateTime creado;
        /// <summary>
        /// 
        /// </summary>
        public DateTime Creado
        {
            get { return creado; }
            set { creado = value; }
        }

        private DateTime modificado;
        /// <summary>
        /// 
        /// </summary>
        public DateTime Modificado
        {
            get { return modificado; }
            set { modificado = value; }
        }     

    }
}