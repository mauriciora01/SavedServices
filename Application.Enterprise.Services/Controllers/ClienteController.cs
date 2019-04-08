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


        private string ComponerNombreCompleto(ClienteInfo objClienteInfo )
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


    }
}
