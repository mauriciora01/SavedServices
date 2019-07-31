using System;

namespace Application.Enterprise.CommonObjects
{
    /// <summary>
    /// Summary description for Inventarios.
    /// </summary>

    public class Enumerations
    {

        public enum TipoDocumento
        {
            CC,
            NIT,
            CE,
            NIP,
            PP,
            RC,
            TI,
            CD
        }

        public enum TipoOrden
        {
            Limite = 0x4c,
            Mercado = 0x4d,
            MercadoPorLoMejor = 0x54
        }

        public enum MarketType
        {
            Stocks = 1,
            Futures,
            GlobalMarket,
            Energy,
            Repo
        }

        /// <summary>
        /// Estados Empresarias (Respetar los valores de la base de datos)
        /// </summary>
        public enum EstadosClienteEnum : int
        {
            Prospecto = 0,
            Nuevo = 1,
            Activo = 2,
            PosibleEgreso = 3,
            Egreso = 4,
            Inactivo = 5,
            Retenido = 6,
            Reingreso = 7,
            Retirado = 8,
            Antiguo = 9,
            Retenida = 10,
            InactivaEcu = 21,
            PosibleReingreso = 22
        }

        public enum DuracionEstadosSinPedidoxCampanaClienteEnum : int
        {
            Prospecto = 1,
            Nuevo = 1,
            Activo = 1,
            PosibleEgreso = 1,
            Egreso = 1,
            Inactivo = 6,
            Reingreso = 1,
        }

        /// <summary>
        /// Grupos Usuarios. (Respetar los valores de la base de datos)
        /// </summary>
        public enum GruposUsuariosEnum : int
        {
            EmpresariasWeb = 50,
            Administrador = 51,
            ServicioCliente = 12,
            ServicioClienteEspecial = 15,
            Demanda = 07,
            GerentesZona = 52,
            Recaudo = 17,
            Comercial = 13,
            GerentesRegionales = 53,
            SalaVentas = 56,
            SalaVentasEspecial = 57,
            GerenciaGeneral = 58,
            Lider = 60,
            Despachos = 72,
            Asistentes = 59, //GAVL ASISTENTES
            Contabilidad = 73, //GAVL CONTABILIDAD
            GerentesSubZona = 74,
            CCN = 75

        }

        /// <summary>
        /// Tipo de E-Mail (Registro, Pedido)
        /// </summary>
        public enum TipoMailEnum : int
        {
            /// <summary>
            /// Registro = 1
            /// </summary>
            Registro = 1,
            /// <summary>
            /// Pedido = 2
            /// </summary>
            Pedido = 2,
            /// <summary>
            /// RegistroEmpresaria = 3
            /// </summary>
            RegistroEmpresaria = 4,
            /// <summary>
            /// Recuperacion de Clave = 5
            /// </summary>
            RecuperacionClave = 5,
            /// <summary>
            /// ErrorReservaEnLineae = 6
            /// </summary>
            ErrorReservaEnLinea = 6,
            /// <summary>
            /// ErrorNegativos = 7
            /// </summary>
            ErrorNegativos = 7,
            /// <summary>
            /// ErrorPedidos = 8
            /// </summary>
            ErrorPedidos = 8,
            /// <summary>
            /// ErrorSaldosBodega = 9
            /// </summary>
            ErrorSaldosBodega = 9,

            /// <summary>
            /// GAVL Suprimir Registro = 10
            /// </summary>
            SuprimirRegistro = 10



        }

        /// <summary>
        /// Tipo de Where Reglas Premios
        /// </summary>
        public enum TipoWhereEnum : int
        {
            /// <summary>
            /// Where = 1
            /// </summary>
            Where = 1,
            /// <summary>
            /// Having = 2
            /// </summary>
            Having = 2,
            /// <summary>
            /// StoreProcedure = 3
            /// </summary>
            StoreProcedure = 3
        }

        /// <summary>
        /// Tipos Campos Reglas Premios
        /// </summary>
        public enum TipoCamposEnum : int
        {
            /// <summary>
            /// tcm_id = 1
            /// </summary>
            NINGUNO = 1,
            /// <summary>
            /// tcm_id = 2
            /// </summary>
            SVDN_PREMIOS_PUNTOSCONF = 2
        }

        /// <summary>
        /// Estados Empresarias (Respetar los valores de la base de datos)
        /// </summary>
        public enum EstadosPedidoEnum : int
        {
            /// <summary>
            /// No se ha procesado el pedido.
            /// </summary>
            SinProcesar = 0,
            /// <summary>
            /// El pedido se proceso correctamente.
            /// </summary>
            Procesado = 1,
            /// <summary>
            /// Agotado el inventario. (100% Agotado).
            /// </summary>
            Agotado = 2,
            /// <summary>
            /// Agotado el inventario de premios.
            /// </summary>
            RetenidoPremios = 3,
            /// <summary>
            /// No cumple el nivel de servicio.
            /// </summary>
            NivelServicio = 4,
            /// <summary>
            /// El cliente tiene una deuda en cartera.
            /// </summary>
            Cartera = 5,
            /// <summary>
            /// El cliente es desmantelador.
            /// </summary>
            Desmanteladora = 6,
            /// <summary>
            /// No cumple el valor de Pedido Minimo
            /// </summary>
            PedidoMinimo = 7,
            /// <summary>
            /// Unificado por Oulet/Hogar
            /// </summary>
            Unificado = 8,
            /// <summary>
            /// EnDigitacion
            /// </summary>
            EnDigitacion = 9,
            /// <summary>
            /// ExcluirProcesamiento
            /// </summary>
            ExcluirProcesamiento = 10,
            /// <summary>
            /// Sin Aprobar Empresaria Prospecto
            /// </summary>
            SinAprobarEmpresariaProspecto = 11,
            /// <summary>
            /// En Espera
            /// </summary>
            EnEspera = 12,
            /// <summary>
            /// ErrorProcesamiento
            /// </summary>
            ErrorProcesamiento = 13,
            /// <summary>
            /// Pedido Facturado
            /// </summary>
            PedidoFacturado = 14,
            /// <summary>
            /// Pedido En Reserva en Linea
            /// </summary>
            PedidoEnReserva = 15

        }

        /// <summary>
        /// Lista de parametros del sistema.
        /// </summary>
        public enum ParametrosEnum : int
        {
            /// <summary>
            /// par_id = 1
            /// </summary>
            NivelServicio = 1,
            /// <summary>
            /// par_id = 2
            /// </summary>
            ValorCartera = 2,
            /// <summary>
            /// par_id = 3
            /// </summary>
            TipoNivelServicio = 3,

            /// <summary>
            /// par_id = 4, el valor del pedido para poder solicitar del catalogo outlet.
            /// </summary>
            ValorPedidoOutlet = 4,

            /// <summary>
            /// par_id = 5, el valor del pedido para poder solicitar del catalogo hogar.
            /// </summary>
            ValorPedidoHogar = 5,

            /// <summary>
            /// par_id = 6, el valor del iva en colombia para diferentes parametros del sistema. NO tiene que ver con el iva de los articulos.
            /// </summary>
            ValorIVACOP = 6,

            /// <summary>
            /// par_id = 7, el valor del pedido minimo que se debe realizar por el catalgo  NIVI.
            /// </summary>
            ValorPedidoNivi = 7,

            /// <summary>
            /// par_id = 8, el valor del codigo para la remision de MKT.
            /// </summary>
            CodigoNumeracionMKT = 8,

            /// <summary>
            /// par_id = 9, Campa�as consecutivas para evaluar las empresarias inactivas.
            /// </summary>
            CampanasConsecutivas = 9,

            /// <summary>
            /// par_id = 10, muestra la ventana de notificacion del sistema
            /// </summary>
            VerMensajeNotificacion = 10,

            /// <summary>
            /// par_id = 11, muestra la ventana de notificacion del sistema
            /// </summary>
            TextoMensajeNotificacion = 11,

            /// <summary>
            /// par_id = 12, Timer Servicio Windows Clasificacion por valor de la hora de ejecucion
            /// </summary>
            TimerServicioWindows = 12,

            /// <summary>
            /// par_id = 13, Dias de cierre de Pedido Borrador
            /// </summary>
            DiasCierrePedidoBorrador = 14,

            /// <summary>
            /// par_id = 14, Dias de cierre de Pedido Reservado
            /// </summary>
            DiasCierrePedidoReservado = 15,

            /// <summary>
            /// Cantidad de campa�as para mostrar las empresarias con estado Inactivo.
            /// </summary>
            CantidadCampanasInactividad = 16,

            /// <summary>
            /// Comisiones - Valor Pedido Minimo 
            /// </summary>
            ValorPedidoMinimoComisiones = 17,

            /// <summary>
            /// Tiempo de Anulacion de Pedidos
            /// </summary>
            TiempoAnulacionPedidos = 18,

            /// <summary>
            /// Indica si se debe bloquear el pedido por que no cumple el pedido minimo.
            /// </summary>
            BloquearPedidosPedidoMinimo = 19,

            /// <summary>
            /// Valor de pedido minimo para enviar premio de bienvenida.
            /// </summary>
            ValorPedidoPremioBienvenida = 20,
            /// <summary>
            /// Si el valor del pedido minimo es por defecto o no. (SI: se aplicara solo el tipo de pedido minimo del parametro 22)
            /// </summary>
            PermitirTPedMinimoxDefecto = 21,
            /// <summary>
            /// Valor de pedido minimo por defecto si la variable 21 es SI.
            /// </summary>
            ValorTPedMinimoxDefecto = 22,
            /// <summary>
            /// Mostrar Mensaje Pre-Login SVDN
            /// </summary>
            MensajePreLoginSVDN = 23,
            /// <summary>
            /// Mostrar Mensaje Pre-Login Empresarias
            /// </summary>
            MensajePreLoginEmpresarias = 24,
            /// <summary>
            /// Validar Direccion y Telefono en captura de pedido
            /// </summary>
            ValidarDireccionTelefono = 25,

            /// <summary>
            /// Tiempo de Bloquear Agotados
            /// </summary>
            TiempoBloquearAgotados = 26,

            /// <summary>
            /// GAVL Bloquear Pedidos Desmantelados
            /// </summary>
            BloquearPedidosDesmantelados = 27,

            /// <summary>
            /// Tiempo de Ejecucion del Motor de Auditoria
            /// </summary>
            TiempoMotorAuditoria = 28,

            /// <summary>
            /// GAVL Enviar Correo a empresaria creacion de pedido
            /// </summary>
            EnviaCorroEmpresaria = 29,

            /// <summary>
            /// CANTIDAD MINIMA DE SUSTITUTOS
            /// </summary>
            MinimoSustitutos = 30,

            /// TActivacion Automatica Empresarias
            /// </summary>
            ActivacionAutomaticaEmpresarias = 31,

            /// Tiempo de Servicio liberar memoria SQL
            /// </summary>
            TiempoLiberarMemoriaSQL = 32,

            /// Activa o inactiva la digitacion de pedidos de una empresaria con semaforo.
            /// </summary>
            ActivarSemaforo = 33,

            /// Activa o inactiva la seleccion de bodega para la digitacion de pedidos.
            /// </summary>
            ActivarSeleccionBodega = 34,

            /// valor minimo de saldo para empresarias de norte
            /// </summary>
            saldomin = 36,

            //Carpeta de imagenes de SAVED
            CarpetaImagenesSAVED = 77

        }

        /// <summary>
        /// Lista de procesos que modificar el historial de un cliente
        /// </summary>
        public enum ProcesoClienteEnum : int
        {
            /// <summary>
            /// CreacionCliente = 0
            /// </summary>
            CreacionClientexSVDN = 0,
            /// <summary>
            /// CreacionCliente = 1
            /// </summary>
            CreacionClientexGYG = 1,
            /// <summary>
            /// ProcesoSVDN = 1
            /// </summary>
            ProcesamientoSVDN = 2,
            /// <summary>
            /// FacturacionGYG = 3
            /// </summary>
            FacturacionGYG = 3,
            /// <summary>
            /// par_ProcesoCierreCampanaid = 4
            /// </summary>
            ProcesoCierreCampana = 4
        }


        /// <summary>
        /// Lista los porcentajes de la matriz comercial
        /// </summary>
        public enum PorcentajesMatrizEnum : int
        {
            /// <summary>
            /// Porcentaje_Cumplimiento_Capitalizacion
            /// </summary>
            Porcentaje_Cumplimiento_Capitalizacion = 1,
            /// <summary>
            /// Porcentaje_Cumplimiento_Pedidos
            /// </summary>
            Porcentaje_Cumplimiento_Pedidos = 2,
            /// <summary>
            /// Actividad_Stencil_Final
            /// </summary>
            Actividad_Stencil_Final = 3,
            /// <summary>
            /// Actividad_Stencil_Inicial
            /// </summary>
            Actividad_Stencil_Inicial = 4,
            /// <summary>
            /// Porcentaje_Consecutividad
            /// </summary>
            Porcentaje_Consecutividad = 5,
            /// <summary>
            /// Porcentaje_Consecutividad_Nuevas
            /// </summary>
            Porcentaje_Consecutividad_Nuevas = 6,
            /// <summary>
            /// Porcentaje_Retencion
            /// </summary>
            Porcentaje_Retencion = 7,
            /// <summary>
            /// Porcentaje_Cumplimiento_Presupuesto
            /// </summary>
            Porcentaje_Cumplimiento_Presupuesto = 8,
            /// <summary>
            /// Porcentaje_Devoluciones_Fecha
            /// </summary>
            Porcentaje_Devoluciones_Fecha = 9,
            /// <summary>
            /// Porcentaje_Devolucion_x_Factura
            /// </summary>
            Porcentaje_Devolucion_x_Factura = 10,
            /// <summary>
            /// Porcentaje_Nivel_Servicio
            /// </summary>
            Porcentaje_Nivel_Servicio = 11,
            /// <summary>
            /// Porcentaje_Cumplimiento_Presupuesto_Valor_Facturado
            /// </summary>
            Porcentaje_Cumplimiento_Presupuesto_Valor_Facturado = 12

        }

        /// <summary>
        /// Lista de intermediarios
        /// </summary>
        public enum IntermediarioEnum : int
        {
            /// <summary>
            /// Local = 1
            /// </summary>
            Local = 1,
            /// <summary>
            /// Transportista = 1
            /// </summary>
            Transportista = 2,
            /// <summary>
            /// GerenteZona = 3
            /// </summary>
            GerenteZona = 3,
            /// <summary>
            /// Lider = 4
            /// </summary>
            Lider = 4
        }

        /// <summary>
        /// Tipos de Precio
        /// </summary>
        public enum TipoPrecioEnum : int
        {
            /// <summary>
            /// PrecioCatalogo = 1
            /// </summary>
            PrecioCatalogo = 1,
            /// <summary>
            /// PrecioEmpresaria = 1
            /// </summary>
            PrecioEmpresaria = 2,
            /// <summary>
            /// PrecioEspecial = 3
            /// </summary>
            PrecioEspecial = 3,
            /// <summary>
            /// PrecioCrecito = 4
            /// </summary>
            PrecioCredito = 4,
            /// <summary>
            /// PrecioCatalogoCatalogoPlus = 5
            /// </summary>
            PrecioCatalogoPlus = 5
        }

        /// <summary>
        /// Estados Empresarias (Respetar los valores de la base de datos)
        /// </summary>
        public enum ComoTeEnterasteEnum : int
        {
            AtravesdeFacebook = 1,
            VisitadeunaGerentedeZona = 2,
            VisitadeunaEmpresariaNivi = 3,
            Atravesdeunaamiga = 4,
            ConocilaRevista = 5,
            NavegandoenGoogle = 6,
            Ingresedirectamentealaweb = 7,
            EnunaPublicidad = 8,
            Otro = 9
        }

        /// <summary>
        /// Tipo de cliente
        /// </summary>
        public enum TipoClienteEnum : int
        {
            Nivi = 1,
            Pisame = 2,
            Mixto = 3
        }

        /// <summary>
        /// Unidad de Negocio
        /// </summary>
        public enum UnidadNegocioEnum : int
        {
            Nivi = 1,
            Pisame = 2,
            Mixto = 3
        }

        /// <summary>
        /// Tipo de pedido minimo del cliente.
        /// </summary>
        public enum TipoPedidoMinimoEnum : int
        {
            Nivi = 1,
            Pisame = 2,
            Mezcla = 3
        }

        /// <summary>
        /// Catalogo de Interes
        /// </summary>
        public enum CatalogoInteresEnum : int
        {
            Nivi = 1,
            Pisame = 2,
            Ambos = 3
        }

        /// <summary>
        /// Paises nivi
        /// </summary>
        public enum PaisEnum : int
        {
            /// <summary>
            /// Colombia = 1
            /// </summary>
            Colombia = 1,
            /// <summary>
            /// Ecuador = 2
            /// </summary>
            Ecuador = 2,
            /// <summary>
            /// Peru = 3
            /// </summary>
            Peru = 3
        }

        /// <summary>
        /// Tipo Envio
        /// </summary>
        public enum TipoEnvioEnum : int
        {
            CasaEmpresaria = 1,
            ADirector = 2,
            ALider = 3
        }

        /// <summary>
        /// Tipo Red
        /// </summary>
        public enum TipoRedEnum : int
        {
            Lider = 1,
            Reclutador = 2,
            Director8 = 3,
            Corresponsal = 4,
            DirectorCorresponsal = 5,
            GerenteZona = 6,
            RegistroWeb = 7
        }

        /// <summary>
        /// Semaforo
        /// </summary>
        public enum SemaforoEnum : int
        {
            Verde = 1,
            Amarillo = 2,
            Rojo = 3
        }


        public enum PuntosConceptoEnum : int
        {
            IncrementoPuntosxEstado = 1,
            PuntosExpirados = 2,
            DecrementoPuntosAnulacion = 3,
            OtorgadoMercadeo = 4,
            GastoCompra = 5,
            CompraPortalEmpresarias = 6,
            IncrementoConsecutividad3 = 7,
            IncrementoConsecutividad6 = 8,
            RegistroEmpresarias = 9,
            IncrementoNivelPedido = 10,
            Pruebas = 11,
            VencimientoPuntos = 12,
            RestaPuntosDevolucion = 13,
            PuntosRecuperadosAnulacionPedido = 14,
            PuntosRecuperadosDevolucionPedido = 15,
            ReservaLinea = 16,
            IncrementoNivelCantidad = 17,
            PortalSaved = 18
        }

    }
}
