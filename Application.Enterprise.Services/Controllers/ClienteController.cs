using Application.Enterprise.Business;
using Application.Enterprise.CommonObjects;
using Application.Enterprise.Services.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static Application.Enterprise.CommonObjects.Enumerations;

namespace Application.Enterprise.Services.Controllers
{

    public class ClienteController : BaseController
    {
        private static Lazy<IAutentication> _Instance = new Lazy<IAutentication>(() => new Autentication());
        //private static ITokenServices _TokenServices = new TokenServices();

        public static IAutentication Instance => _Instance.Value;

        [HttpGet]
        [HttpPost]
        public ClienteInfo ListClienteSVDNxNit(ClienteInfo ObjClienteInfo)
        {
            ClienteInfo ObjClienteInfoResponse = new ClienteInfo();

            ClienteEcu objCliente = new ClienteEcu("conexion");
            ClienteInfo objClienteInfo = new ClienteInfo();

            objClienteInfo = objCliente.ListClienteSVDNxNit(ObjClienteInfo.Nit);

            if (objClienteInfo != null)
            {
                ObjClienteInfoResponse.NombreEmpresariaCompleto = objClienteInfo.Nombre1 + " " + objClienteInfo.Nombre2 + " " + objClienteInfo.Apellido1 + " " + objClienteInfo.Apellido2;
            }
            else
            {
                ObjClienteInfoResponse.NombreEmpresariaCompleto = "";
            }

            return ObjClienteInfoResponse;
        }

        [HttpGet]
        [HttpPost]
        public ClienteInfo ListEstadoxNit(ClienteInfo ObjClienteInfo)
        {
            ClienteInfo ObjClienteInfoResponse = new ClienteInfo();

            ClienteEcu objCliente = new ClienteEcu("conexion");
            ClienteInfo objClienteInfo = new ClienteInfo();

            objClienteInfo = objCliente.ListEstadoxNit(ObjClienteInfo.Nit);

            return ObjClienteInfoResponse;
        }

        [HttpGet]
        [HttpPost]
        public ClienteInfo CrearUsuarioyClave(ClienteInfo ObjClienteInfo)
        {
            Usuarios objUsuarios = new Usuarios("conexion");
            UsuariosInfo objUsuariosInfo = new UsuariosInfo();

            objUsuariosInfo.Usuario = ObjClienteInfo.Nit;
            objUsuariosInfo.Clave = objUsuarios.EncriptarCadena(ObjClienteInfo.Nit);
            objUsuariosInfo.Descripcion = objUsuarios.EncriptarCadena(ObjClienteInfo.Nombre1 + " " + ObjClienteInfo.Nombre2 + " " + ObjClienteInfo.Apellido1 + " " + ObjClienteInfo.Apellido2);
            objUsuariosInfo.IdGrupo = Convert.ToString((int)GruposUsuariosEnum.EmpresariasWeb);
            objUsuariosInfo.Vencimiento = DateTime.Now.AddYears(50);
            objUsuariosInfo.Activo = 1;
            objUsuariosInfo.Codigo = "EMP";
            objUsuariosInfo.AccesoWeb = true;
            objUsuariosInfo.IdVendedor = ObjClienteInfo.Vendedor;

            if (ObjClienteInfo.Email != "")
            {
                objUsuariosInfo.Email = ObjClienteInfo.Email;
            }
            else
            {
                objUsuariosInfo.Email = ObjClienteInfo.Nombre1 + ObjClienteInfo.Nombre2 + ObjClienteInfo.Apellido1 + ObjClienteInfo.Apellido2 + "@SVDN";
            }

            try
            {
                if (!objUsuarios.Insert(objUsuariosInfo))
                {
                    ObjClienteInfo.Error = new Error();
                    ObjClienteInfo.Error.Id = -1;
                    ObjClienteInfo.Error.Descripcion = "Error: No se pudo crear usuario y  clave. Nit:" + ObjClienteInfo.Nit + ", Fallo SQL SERVER.";
                    ObjClienteInfo.Nit = ObjClienteInfo.Nit;
                }
            }
            catch (Exception)
            {
                ObjClienteInfo.Error = new Error();
                ObjClienteInfo.Error.Id = -1;
                ObjClienteInfo.Error.Descripcion = "Error: No se pudo crear usuario y  clave. Nit:" + ObjClienteInfo.Nit + ", Fallo SQL SERVER.";
                ObjClienteInfo.Nit = ObjClienteInfo.Nit;
            }

            return ObjClienteInfo;

        }



        [HttpGet]
        [HttpPost]
        public ClienteInfo RegistrarEmpresaria(ClienteInfo ObjClienteInfo)
        {
            ClienteInfo ObjClienteInfoResponse = new ClienteInfo();

            ClienteEcu objCliente = new ClienteEcu("conexion");
            bool okTans = false;

            okTans = objCliente.RegistrarEmpresaria(ObjClienteInfo);

            if (!okTans)
            {
                ObjClienteInfoResponse.Error = new Error();
                ObjClienteInfoResponse.Error.Id = -1;
                ObjClienteInfoResponse.Error.Descripcion = "Error: No se pudo crear empresaria. Nit:" + ObjClienteInfo.Nit + ", Fallo SQL SERVER.";
                ObjClienteInfoResponse.Nit = ObjClienteInfo.Nit;
            }


            return ObjClienteInfoResponse;
        }

        [HttpGet]
        [HttpPost]
        public List<ClienteInfo> ListEmpresariasxGerenteSimple(ClienteInfo ObjClienteInfo)
        {
            List<ClienteInfo> ObjClienteInfoResponse = new List<ClienteInfo>();

            ClienteEcu objCliente = new ClienteEcu("conexion");

            ObjClienteInfoResponse = objCliente.ListEmpresariasxGerenteSimple(ObjClienteInfo.Vendedor);

            return ObjClienteInfoResponse;
        }

        [HttpGet]
        [HttpPost]
        public HttpResponseMessage ValidaExisteEmpresariaNombre(ClienteInfo ObjClienteInfoNit)
        {
            SessionEmpresariaInfo ObjSessionEmpresariaInfo = new SessionEmpresariaInfo();

            Cliente objCliente = new Cliente("conexion");
            ClienteInfo objClienteInfo = new ClienteInfo();

          

            objClienteInfo = objCliente.ListClienteSVDNxNit(ObjClienteInfoNit.Nit);

            if (objClienteInfo != null)
            {
                //MRG: Variables que se utilizan al momento de hacer un pedido.
                ObjSessionEmpresariaInfo.DocumentoEmpresaria = ObjClienteInfoNit.Nit;
                ObjSessionEmpresariaInfo.NombreEmpresariaCompleto = ComponerNombreCompleto(objClienteInfo);
                ObjSessionEmpresariaInfo.TipoPedidoMinimo = objClienteInfo.TipoPedidoMinimo.ToString();
                ObjSessionEmpresariaInfo.CodCiudadCliente = objClienteInfo.CodCiudad;
                ObjSessionEmpresariaInfo.PremioBienvenida = objClienteInfo.Premio.ToString();
                ObjSessionEmpresariaInfo.TipoEnvioCliente = objClienteInfo.TipoEnvio.ToString();
                ObjSessionEmpresariaInfo.Empresaria_Lider = objClienteInfo.Lider; //GAVL Lider para Fletes por Lider 
                ObjSessionEmpresariaInfo.IdZona = objClienteInfo.Zona;
                ObjSessionEmpresariaInfo.Email = objClienteInfo.Email;
                ObjSessionEmpresariaInfo.Vendedor = objClienteInfo.Vendedor;
                ObjSessionEmpresariaInfo.Clasificacion = objClienteInfo.Clasificacion;
                ObjSessionEmpresariaInfo.Telefono1 = objClienteInfo.Telefono1;
                ObjSessionEmpresariaInfo.Celular1 = objClienteInfo.Celular1;
                ObjSessionEmpresariaInfo.CodigoRegional = objClienteInfo.CodigoRegional.ToString();
                ObjSessionEmpresariaInfo.Usuario = objClienteInfo.Usuario;
                ObjSessionEmpresariaInfo.Whatsapp = objClienteInfo.Whatsapp;
                ObjSessionEmpresariaInfo.TipoCliente = objClienteInfo.TipoCliente;
                ObjSessionEmpresariaInfo.TallaPrendaSuperior = objClienteInfo.TallaPrendaSuperior;
                ObjSessionEmpresariaInfo.TallaPrendaInferior = objClienteInfo.TallaPrendaInferior;
                ObjSessionEmpresariaInfo.TallaCalzado = objClienteInfo.TallaCalzado;


                ObjSessionEmpresariaInfo.GrupoDescuento = objClienteInfo.GrupoDescuentoCliente;

                //..........................................................................
                //Bodegas

                Bodegas objBodegas = new Bodegas("conexion");
                BodegasInfo objBodegasInfo = new BodegasInfo();

                ObjSessionEmpresariaInfo.Bodegas = new BodegasInfo();
                objBodegasInfo = objBodegas.ListxBodega(objClienteInfo.Bodega);

                if (objBodegasInfo != null)
                {
                    ObjSessionEmpresariaInfo.Bodegas.Bodega = objBodegasInfo.Bodega;
                    ObjSessionEmpresariaInfo.Bodegas.Nombre = objBodegasInfo.Nombre;
                    ObjSessionEmpresariaInfo.BodegaEmpresaria = objBodegasInfo.Bodega+ "- " + objBodegasInfo.Nombre;
                }
                else
                {
                    ObjSessionEmpresariaInfo.Bodegas.Bodega = "370";
                    ObjSessionEmpresariaInfo.Bodegas.Nombre = "SIN BODEGA";
                    ObjSessionEmpresariaInfo.BodegaEmpresaria = "SIN BODEGA";
                }
                //..........................................................................


                //Se obtiene la campaña de la fecha actual.
                Campana ObjCampana = new Campana("conexion");
                CampanaInfo ObjCampanaInfo = new CampanaInfo();
                //ObjCampanaInfo = ObjCampana.ListxGetDate();


                ObjCampanaInfo = ObjCampana.ListxGetDate();
                //Se valida que exista una campaña activa.
                if (ObjCampanaInfo != null)
                {
                    ObjSessionEmpresariaInfo.Campana = ObjCampanaInfo.Campana.Trim();
                    ObjSessionEmpresariaInfo.Catalogo = ObjCampanaInfo.Catalogo.Trim().ToUpper();
                }
                else
                {
                    ObjSessionEmpresariaInfo.Error = new Error();
                    ObjSessionEmpresariaInfo.Error.Id = -1;
                    ObjSessionEmpresariaInfo.Error.Descripcion = "La campaña se encuentra cerrada o no existe.";
                    ObjSessionEmpresariaInfo.DocumentoEmpresaria = ObjClienteInfoNit.Nit;
                }


                //........................................................................................
                //Path de imagenes

                ParametrosInfo ObjParametrosInfo = new ParametrosInfo();
                Parametros ObjParametros = new Parametros("conexion");
                ObjParametrosInfo = ObjParametros.ListxId((int)ParametrosEnum.CarpetaImagenesSAVED);

                string CarpetaImagenes = "";

                if (ObjParametrosInfo != null)
                {
                    CarpetaImagenes = ObjParametrosInfo.Valor;
                }
                else
                {
                    CarpetaImagenes = "../../../../assets/imagesAplicacion/";
                }

                ObjSessionEmpresariaInfo.CarpetaImagenes = CarpetaImagenes;
                //........................................................................................


                ObjSessionEmpresariaInfo.PuntosEmpresaria = this.actualizarTotalpagermenospuntos(ObjClienteInfoNit.Nit, "002", new List<PLUInfo>(), 0, 9);

                PuntosBo bo = new PuntosBo("conexion");
                ObjSessionEmpresariaInfo.ValorPuntos = bo.getvalorPuntoEnSoles();

                //[][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][
                //Se valida si la ciudad del cliente es exento de iva.
                Ciudad ObjCiudad = new Ciudad("conexion");
                CiudadInfo ObjCiudadInfo = new CiudadInfo();

                ObjCiudadInfo = ObjCiudad.ListCiudadxId(objClienteInfo.CodCiudad);

                if (ObjCiudadInfo != null)
                {
                    if (ObjCiudadInfo.ExcluidoIVA == 1)
                    {
                        ObjSessionEmpresariaInfo.ExcentoIVA = "true";
                    }
                    else
                    {
                        ObjSessionEmpresariaInfo.ExcentoIVA = "false";
                    }
                }
                //[][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][
            }
            else
            {
                ObjSessionEmpresariaInfo.Error = new Error();
                ObjSessionEmpresariaInfo.Error.Id = -1;
                ObjSessionEmpresariaInfo.Error.Descripcion = "No existe la empresaria: " + ObjClienteInfoNit.Nit + ". Por favor realice el registro.";
                ObjSessionEmpresariaInfo.DocumentoEmpresaria = ObjClienteInfoNit.Nit;
            }

            var response = Request.CreateResponse<SessionEmpresariaInfo>(HttpStatusCode.OK, ObjSessionEmpresariaInfo);
            response.Headers.Add("Token", "");
            response.Headers.Add("TokenExpiry", ConfigurationManager.AppSettings["AuthTokenExpiry"]);
            response.Headers.Add("Access-Control-Expose-Headers", "Token,TokenExpiry");

            return response;
        }


        private string ComponerNombreCompleto(ClienteInfo objClienteInfo)
        {
            string nombreempresariacompleto = "";

            if (objClienteInfo.Nombre2 == null)
            {
                if (objClienteInfo.Apellido2 == null)
                {
                    nombreempresariacompleto = objClienteInfo.Nombre1.Trim() + ' ' + objClienteInfo.Apellido1.Trim();
                }
                else
                {
                    nombreempresariacompleto = objClienteInfo.Nombre1.Trim() + ' ' + objClienteInfo.Apellido1.Trim() + ' ' + objClienteInfo.Apellido2.Trim();
                }
            }
            else
            {
                if (objClienteInfo.Apellido2 == null)
                {
                    nombreempresariacompleto = objClienteInfo.Nombre1.Trim() + ' ' + objClienteInfo.Nombre2.Trim() + ' ' + objClienteInfo.Apellido1.Trim();
                }
                else
                {
                    nombreempresariacompleto = objClienteInfo.Nombre1.Trim() + ' ' + objClienteInfo.Nombre2.Trim() + ' ' + objClienteInfo.Apellido1.Trim() + ' ' + objClienteInfo.Apellido2.Trim();
                }
            }

            return nombreempresariacompleto;
        }



        [HttpGet]
        [HttpPost]
        public ClienteInfo CargarDireccionTelefono(ClienteInfo objClienteInfo)
        {
            ClienteInfo ObjClienteInfoResponse = new ClienteInfo();

            if (objClienteInfo.Nit != "" && objClienteInfo.Nit != null && objClienteInfo.Nit != "undefined")
            {
                Cliente ObjCliente = new Cliente("conexion");
                ClienteInfo ObjClienteInfo = new ClienteInfo();

                ObjClienteInfo = ObjCliente.ListTelefonoDireccionxNIT(objClienteInfo.Nit);

                if (ObjClienteInfo != null)
                {
                    ObjClienteInfoResponse.DireccionPedidos = ObjClienteInfo.DireccionPedidos.Trim();

                    string[] split = ObjClienteInfo.Telefono1.Split(new Char[] { '-' });

                    foreach (string s in split)
                    {

                        if (s.Trim() != "")
                            ObjClienteInfo.Telefono1 = s.Trim();
                    }

                    ObjClienteInfoResponse.Telefono1 = ObjClienteInfo.Telefono1.Trim();
                }
                else
                {
                    ObjClienteInfoResponse.Error = new Error();
                    ObjClienteInfoResponse.Error.Id = -1;
                    ObjClienteInfoResponse.Error.Descripcion = "No se puede crear el pedido, verifique el Documento de la empresaria.:" + objClienteInfo.Nit + ", Fallo Envio.";
                    ObjClienteInfoResponse.Nit = objClienteInfo.Nit;
                }

            }
            else
            {
                ObjClienteInfoResponse.Error = new Error();
                ObjClienteInfoResponse.Error.Id = -1;
                ObjClienteInfoResponse.Error.Descripcion = "No se puede crear el pedido, verifique el Documento de la empresaria.:" + objClienteInfo.Nit + ", Fallo Envio.";
                ObjClienteInfoResponse.Nit = objClienteInfo.Nit;
            }

            return ObjClienteInfoResponse;
        }

        [HttpGet]
        [HttpPost]
        public ClienteInfo ValidarTipoEnvioPedido(ClienteInfo ObjClienteInfoReq)
        {
            ClienteInfo ObjClienteInfoResponse = new ClienteInfo();

            //si es 1, es envio a la casa de la empresaria.
            if (ObjClienteInfoReq.TipoEnvio == 1)
            {

                Cliente ObjCliente = new Cliente("conexion");
                ClienteInfo ObjClienteInfo = new ClienteInfo();
                CiudadInfo ObjCiudadInfo = new CiudadInfo();
                Ciudad ObjCiudad = new Ciudad("conexion");

                ObjClienteInfo = ObjCliente.ListxNITSimpleEdit(ObjClienteInfoReq.Nit);

                if (ObjClienteInfo != null)
                {
                    string CodCiudadCliente = "";
                    decimal PorcentajeIvaFlete = 0;

                    decimal ValorFleteSinIva = 0;

                    //Se obtiene el codigo de la ciudad para el flete.
                    ObjClienteInfo = ObjCliente.ListClienteSVDNxNit(ObjClienteInfoReq.Nit);

                    if (ObjClienteInfo != null)
                    {
                        CodCiudadCliente = ObjClienteInfo.CodCiudad;

                    }

                    //se obtiene la info de la ciudad del cliente.
                    ObjCiudadInfo = ObjCiudad.ListCiudadxId(CodCiudadCliente);

                    PorcentajeIvaFlete = ObjCiudadInfo.IVA;
                    ValorFleteSinIva = ObjCiudadInfo.ValorFlete;

                    ObjClienteInfoResponse.PorcentajeIvaFlete = PorcentajeIvaFlete;
                    ObjClienteInfoResponse.ValorFleteSinIva = ValorFleteSinIva;
                    ObjClienteInfoResponse.ValorFlete = (ValorFleteSinIva + (PorcentajeIvaFlete * (ValorFleteSinIva / 100)));
                    ObjClienteInfoResponse.CodCiudadDespacho = "";

                }

            }
            else if (ObjClienteInfoReq.TipoEnvio == 2)
            {
                /*********************SE BUSCA EL VALOR DEL FLETE POR GERENTE/DIRECTOR*************************************************/

                ParametrosInfo ObjParametrosInfo = new ParametrosInfo();
                Parametros ObjParametros = new Parametros("conexion");

                ObjParametrosInfo = ObjParametros.ListxId((int)ParametrosEnum.ValorIVACOP);
                decimal PorcentajeIvaFlete = Convert.ToDecimal(ObjParametrosInfo.Valor.ToString());

                decimal ValorFleteSinIva = 0;

                ZonaInfo objZonaInfo = new ZonaInfo();
                Zona objZona = new Zona("conexion");

                objZonaInfo = objZona.ListxIdZona(ObjClienteInfoReq.Zona.ToString());

                if (objZonaInfo != null)
                {
                    ValorFleteSinIva = objZonaInfo.ValorFlete;
                    ObjClienteInfoResponse.PorcentajeIvaFlete = PorcentajeIvaFlete;
                    ObjClienteInfoResponse.ValorFleteSinIva = ValorFleteSinIva;
                    ObjClienteInfoResponse.ValorFlete = (ValorFleteSinIva + (PorcentajeIvaFlete * (ValorFleteSinIva / 100)));
                    ObjClienteInfoResponse.CodCiudadDespacho = objZonaInfo.CodLocalidad;
                }

            }
            else if (ObjClienteInfoReq.TipoEnvio == 3)
            {
                /*********************SE BUSCA EL VALOR DE FLETE POR LIDER**************************************************/
                FleteLiderInfo FleteLiderInfo = new FleteLiderInfo();
                FleteLider ObjFletes = new FleteLider("conexion");

                FleteLiderInfo = ObjFletes.List(ObjClienteInfoReq.EmpresariaLider);
                decimal PorcentajeIvaFlete = Convert.ToDecimal(FleteLiderInfo.Iva.ToString());

                decimal ValorFleteSinIva = 0;

                if (ObjFletes != null)
                {
                    ValorFleteSinIva = FleteLiderInfo.Valor;

                    ObjClienteInfoResponse.PorcentajeIvaFlete = PorcentajeIvaFlete;
                    ObjClienteInfoResponse.ValorFleteSinIva = ValorFleteSinIva;
                    ObjClienteInfoResponse.ValorFlete = (ValorFleteSinIva + (PorcentajeIvaFlete * (ValorFleteSinIva / 100)));

                }

                Lider ObjLider1 = new Lider("conexion");
                LiderInfo ObjLiderInfo1 = new LiderInfo();

                //Se obtiene el codigo de la ciudad para el flete.
                ObjLiderInfo1 = ObjLider1.ListxIdLider(ObjClienteInfoReq.EmpresariaLider);

                if (ObjLiderInfo1 != null)
                {
                    ObjClienteInfoResponse.CodCiudadDespacho = ObjLiderInfo1.Codciudad;
                }
            }
            else if (ObjClienteInfoReq.TipoEnvio == 4)
            {
                /*********************SE BUSCA EL VALOR DEL FLETE POR PUNTO DE VENTA*************************************************/
                //TODO: PREGUNTAR QUE VALOR DE FLETE VA AQUI
                ParametrosInfo ObjParametrosInfo = new ParametrosInfo();
                Parametros ObjParametros = new Parametros("conexion");

                ObjParametrosInfo = ObjParametros.ListxId((int)ParametrosEnum.ValorIVACOP);
                decimal PorcentajeIvaFlete = Convert.ToDecimal(ObjParametrosInfo.Valor.ToString());

                decimal ValorFleteSinIva = 0;

                ZonaInfo objZonaInfo = new ZonaInfo();
                Zona objZona = new Zona("conexion");

                objZonaInfo = objZona.ListxIdZona(ObjClienteInfoReq.Zona.ToString());

                if (objZonaInfo != null)
                {
                    ValorFleteSinIva = objZonaInfo.ValorFlete;
                    ObjClienteInfoResponse.PorcentajeIvaFlete = PorcentajeIvaFlete;
                    ObjClienteInfoResponse.ValorFleteSinIva = ValorFleteSinIva;
                    ObjClienteInfoResponse.ValorFlete = (ValorFleteSinIva + (PorcentajeIvaFlete * (ValorFleteSinIva / 100)));
                    ObjClienteInfoResponse.CodCiudadDespacho = objZonaInfo.CodLocalidad;
                }
            }
            else
            {
                //TODO: PREGUNTAR QUE VALOR DE FLETE VA POR DEFECTO POR SI ALGO PASA
            }


            return ObjClienteInfoResponse;

        }

        [HttpGet]
        [HttpPost]
        public ClienteInfo ActualizarDireccionTelefono(ClienteInfo objClienteInfo)
        {
            ClienteInfo ObjClienteInfoResponse = new ClienteInfo();

            if (objClienteInfo.Nit != "" && objClienteInfo.Nit != null && objClienteInfo.Nit != "undefined")
            {
                Cliente ObjCliente = new Cliente("conexion");

                bool OkTrans = false;

                OkTrans = ObjCliente.ActualizarDireccionTelefono(objClienteInfo);

                if (OkTrans)
                {
                    ObjClienteInfoResponse = objClienteInfo;
                }
                else
                {
                    ObjClienteInfoResponse.Error = new Error();
                    ObjClienteInfoResponse.Error.Id = -1;
                    ObjClienteInfoResponse.Error.Descripcion = "No se puede crear actualizar la informacion, verifique el Documento de la empresaria.:" + objClienteInfo.Nit + ", Fallo Envio.";
                    ObjClienteInfoResponse.Nit = objClienteInfo.Nit;
                }

            }
            else
            {
                ObjClienteInfoResponse.Error = new Error();
                ObjClienteInfoResponse.Error.Id = -1;
                ObjClienteInfoResponse.Error.Descripcion = "No se puede crear actualizar la informacion, verifique el Documento de la empresaria.:" + objClienteInfo.Nit + ", Fallo Envio.";
                ObjClienteInfoResponse.Nit = objClienteInfo.Nit;
            }

            return ObjClienteInfoResponse;
        }


        #region "Puntos"
        public int actualizarTotalpagermenospuntos(string NumeroDocumento, string BodegaEmpresaria, List<PLUInfo> PLUList, int PuntosUsar, decimal totalPagarEmprep)
        {
            Inventario inventario = new Inventario("conexion");
            InventarioInfo objA = new InventarioInfo();
            int num = 0;
            int num2 = 0;
            decimal d = 0M;
            int num4 = new PuntosBo("conexion").getPuntosEfectivoEmpresaria(NumeroDocumento);
            string bodega = "";
            if (BodegaEmpresaria != null)
            {
                bodega = BodegaEmpresaria;
            }
            int num6 = 0;
            while (true)
            {
                if (num6 >= PLUList.Count)
                {
                    int num1;
                    if (totalPagarEmprep > 0)
                    {
                        d = totalPagarEmprep;
                    }
                    if ((PuntosUsar != 0) && (PuntosUsar >= 1))
                    {
                        num2 = PuntosUsar;
                        if (PuntosUsar > num4)
                        {
                            //this.LabelPuntosaUsar.ForeColor = System.Drawing.Color.Tomato;
                            //this.LabelPuntosaUsar.Text = "<strong>Ingresa una cantidad menor a los puntos efectivos : " + num4 + "</strong>";
                            //this.RadNumericPuntosUsar.Text = "0";
                            return 0;
                        }
                        if (PuntosUsar > num)
                        {
                            //this.LabelPuntosaUsar.ForeColor = System.Drawing.Color.Tomato;
                            // this.LabelPuntosaUsar.Text = "<strong>Ingresa una cantidad menor al valor del pedido en puntos: " + num + "</strong>";
                            // this.RadNumericPuntosUsar.Text = "0";
                            d = Math.Round(d, 0);
                            //this.RadComboBoxTotalpagardespuesPuntos.Items.Insert(0, new RadComboBoxItem("$ " + d, "1"));
                            //this.RadComboBoxTotalpagardespuesPuntos.SelectedIndex = 0;
                        }
                    }
                    if (num4 == 0)
                    {
                        // this.LabelPuntosaUsar.ForeColor = System.Drawing.Color.Tomato;
                        // this.LabelPuntosaUsar.Text = "<strong>No tienes puntos efectivos</strong>";
                        // this.RadNumericPuntosUsar.Text = "0";
                        d = Math.Round(d, 0);
                        //this.RadComboBoxTotalpagardespuesPuntos.Items.Insert(0, new RadComboBoxItem("$ " + d, "1"));
                        // this.RadComboBoxTotalpagardespuesPuntos.SelectedIndex = 0;
                    }
                    if (((num4 <= 0) || (num2 > num)) || (d <= 0M))
                    {
                        num1 = 1;
                    }
                    else
                    {
                        //num1 = (int)(num <= 0);
                    }
                    /*if (num1 == 0)
                    {
                        //this.LabelPuntosaUsar.Text = "\x00bfCuantos Puntos Usaras?";
                        d = Math.Round((decimal)(d - ((d / num) * num2)), 0);
                        //this.RadComboBoxTotalpagardespuesPuntos.Text = "";
                        //this.RadComboBoxTotalpagardespuesPuntos.Items.Clear();
                        //this.RadComboBoxTotalpagardespuesPuntos.ClearSelection();
                        //this.RadComboBoxTotalpagardespuesPuntos.Items.Insert(0, new RadComboBoxItem("$ " + d, "1"));
                        //this.RadComboBoxTotalpagardespuesPuntos.SelectedIndex = 0;
                    }*/
                    //this.Session["totalPedidoPuntos"] = num;
                    return num4;
                }
                objA = inventario.ListSaldosBodegaxPLUxEmpresaria(bodega, PLUList[num6].PLU);
                if (!ReferenceEquals(objA, null) && (objA.Saldo > 0M))
                {
                    num += Convert.ToInt32(PLUList[num6].Pagopuntos);
                }
                num6++;
            }
        }
        #endregion

    }
}
