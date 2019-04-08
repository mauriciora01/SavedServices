using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Enterprise.CommonObjects
{
    /// <summary>
    /// 
    /// </summary>
    
    public class CxCInfo
    {
        private string numero;
        /// <summary>
        /// 
        /// </summary>
        public string Numero
        {
            get { return numero.Trim(); }
            set { numero = value; }
        }

        private string zona;
        /// <summary>
        /// 
        /// </summary>
        public string Zona
        {
            get { return zona.Trim(); }
            set { zona = value; }
        }

        private string mes;
        /// <summary>
        /// 
        /// </summary>
        public string Mes
        {
            get { return mes.Trim(); }
            set { mes = value; }
        }

        private int anulado;
        /// <summary>
        /// 
        /// </summary>
        public int Anulado
        {
            get { return anulado; }
            set { anulado = value; }
        }

        private string nit;
        /// <summary>
        /// 
        /// </summary>
        public string Nit
        {
            get { return nit.Trim(); }
            set { nit = value; }
        }

        private DateTime fecha;
        /// <summary>
        /// 
        /// </summary>
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private DateTime vencimiento;
        /// <summary>
        /// 
        /// </summary>
        public DateTime Vencimiento
        {
            get { return vencimiento; }
            set { vencimiento = value; }
        }

        private string vendedor;
        /// <summary>
        /// 
        /// </summary>
        public string Vendedor
        {
            get { return vendedor.Trim(); }
            set { vendedor = value; }
        }

        private decimal valor;
        /// <summary>
        /// 
        /// </summary>
        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private decimal saldo_ini_mes;
        /// <summary>
        /// 
        /// </summary>
        public decimal SaldoIniMes
        {
            get { return saldo_ini_mes; }
            set { saldo_ini_mes = value; }
        }

        private decimal debitos;
        /// <summary>
        /// 
        /// </summary>
        public decimal Debitos
        {
            get { return debitos; }
            set { debitos = value; }
        }

        private decimal creditos;
        /// <summary>
        /// 
        /// </summary>
        public decimal Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }

        private int saldo_inicial;
        /// <summary>
        /// 
        /// </summary>
        public int SaldoInicial
        {
            get { return saldo_inicial; }
            set { saldo_inicial = value; }
        }

        private string cuentacontable;
        /// <summary>
        /// 
        /// </summary>
        public string CuentaContable
        {
            get { return cuentacontable.Trim(); }
            set { cuentacontable = value; }
        }

        private decimal tasacambio;
        /// <summary>
        /// 
        /// </summary>
        public decimal TasaCambio
        {
            get { return tasacambio; }
            set { tasacambio = value; }
        }

        private string estadocartera;
        /// <summary>
        /// 
        /// </summary>
        public string EstadoCartera
        {
            get { return estadocartera.Trim(); }
            set { estadocartera = value; }
        }

        private DateTime fechacreacion;
        /// <summary>
        /// 
        /// </summary>
        public DateTime FechaCreacion
        {
            get { return fechacreacion; }
            set { fechacreacion = value; }
        }

        private string hora;
        /// <summary>
        /// 
        /// </summary>
        public string Hora
        {
            get { return hora.Trim(); }
            set { hora = value; }
        }

        private string placa;
        /// <summary>
        /// 
        /// </summary>
        public string Placa
        {
            get { return placa.Trim(); }
            set { placa = value; }
        }

        private DateTime fechasalida;
        /// <summary>
        /// 
        /// </summary>
        public DateTime FechaSalida
        {
            get { return fechasalida; }
            set { fechasalida = value; }
        }

        private string nombre;
        /// <summary>
        /// 
        /// </summary>
        public string Nombre
        {
            get { return nombre.Trim(); }
            set { nombre = value; }
        }

        private string apellido1;
        /// <summary>
        /// 
        /// </summary>
        public string Apellido1
        {
            get { return apellido1.Trim(); }
            set { apellido1 = value; }
        }

        private string apellido2;
        /// <summary>
        /// 
        /// </summary>
        public string Apellido2
        {
            get { return apellido2.Trim(); }
            set { apellido2 = value; }
        }

        private decimal saldototal;
        /// <summary>
        /// 
        /// </summary>
        public decimal SaldoTotal
        {
            get { return saldototal; }
            set { saldototal = value; }
        }


    }
}
