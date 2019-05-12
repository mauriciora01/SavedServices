using Application.Enterprise.Business;
using Application.Enterprise.CommonObjects;
using Application.Enterprise.Services.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static Application.Enterprise.CommonObjects.Enumerations;
using System.Web.Http.Cors;

namespace Application.Enterprise.Services.Controllers
{

    public class PLUController : BaseController
    {
        private static Lazy<IAutentication> _Instance = new Lazy<IAutentication>(() => new Autentication());

        public static IAutentication Instance => _Instance.Value;

        [HttpGet]
        [HttpPost]
        public PLUInfo ListarxCodigoRapido(PLUInfo ObjPLUInfo)
        {
            PLUInfo lista = new PLUInfo();
           
            bool ExcentoIVA = false;
            string CodCiudadCliente = ObjPLUInfo.SessionEmpresaria.CodCiudadCliente.Trim();
            decimal PrecioCat = 0;
            decimal IVAPrecioCat = 0;
            int CantidadSeleccionada = 0;
            decimal PrecioTotal = 0;
            decimal PrecioUnitario = 0;
            int Cantidad = 1;


            PLUInfo objPLU = new PLUInfo();
            PLU module = new PLU("conexion");

            PLUInfo objPLUPrecioCat = new PLUInfo();

            CatalogoPluInfo objCatalogoPluInfo = new CatalogoPluInfo();
            CatalogoPlu objCatalogoPlu = new CatalogoPlu("conexion");


            objCatalogoPluInfo = objCatalogoPlu.ListxCodigoRapidoSinCatalogo(ObjPLUInfo.CodigoRapido.ToUpper());

            if (objCatalogoPluInfo != null)
            {
                objPLU = module.ListxArticulosxPLUxTipoPrecio(objCatalogoPluInfo.PLU, ((int)TipoPrecioEnum.PrecioEmpresaria).ToString());

                if (objPLU != null)
                {
                    objPLU.CatalogoReal = objCatalogoPluInfo.CatalogoReal;
                    objPLU.CodigoRapido = ObjPLUInfo.CodigoRapido.ToUpper();
                    string strProducto = objPLU.NombreProducto.Trim().ToUpper();
                    string[] strProductoList = strProducto.Split(',');
                    objPLU.NombreProducto = strProductoList[0].Trim().ToUpper();
                    objPLU.NombreColor = strProductoList[1].Trim().ToUpper();
                    objPLU.NombreTalla = strProductoList[2].Trim().ToUpper();
                    objPLU.IdZona = ObjPLUInfo.SessionEmpresaria.IdZona.Trim().ToUpper();
                    objPLU.PLU = objCatalogoPluInfo.PLU;
                    objPLU.Referencia = objCatalogoPluInfo.Referencia.Trim().ToUpper();
                    objPLU.Campana = "0919"; //MRG: Cambiar por la campana cargada.

                    objPLUPrecioCat = module.ListxArticulosxPLUxTipoPrecio(objCatalogoPluInfo.PLU, ((int)TipoPrecioEnum.PrecioCatalogo).ToString());

                    if (!ExcentoIVA)
                    {
                        //()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()
                        ArtExcentosxCiudad objArtExcentosxCiudad = new ArtExcentosxCiudad("conexion");
                        ArtExcentosxCiudadInfo objArtExcentosxCiudadInfo = new ArtExcentosxCiudadInfo();
                        //()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()

                        //()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()
                        //Se valida si el articulo se encuentra excento de iva en la ciudad del cliente.

                        objArtExcentosxCiudadInfo = objArtExcentosxCiudad.ListxCiudadxPlu(ObjPLUInfo.SessionEmpresaria.CodCiudadCliente.Trim(), objPLU.PLU);

                        //Si se encuentra exento el iva debe ser 0.
                        if (objArtExcentosxCiudadInfo != null)
                        {

                            PrecioCat = objPLUPrecioCat.PrecioSinIVA;
                            IVAPrecioCat = 0;

                            PrecioUnitario = objPLUPrecioCat.PrecioSinIVA;

                            // rcb_preciounitario.Items.Insert(0, new RadComboBoxItem(String.Format("{0:C}", objPLUPrecioCat.PrecioSinIVA), objPLU.PLU.ToString()));
                            // rcb_preciounitario.SelectedIndex = 0;

                            //rcb_preciototal.Items.Insert(0, new RadComboBoxItem(String.Format("{0:C}", objPLUPrecioCat.PrecioSinIVA), objPLU.PLU.ToString()));
                            //rcb_preciototal.SelectedIndex = 0;
                        }
                        else
                        {
                            PrecioCat = objPLUPrecioCat.PrecioSinIVA;
                            IVAPrecioCat = objPLUPrecioCat.IVA;

                            PrecioUnitario = objPLUPrecioCat.PrecioConIVA;


                            // rcb_preciounitario.Items.Insert(0, new RadComboBoxItem(String.Format("{0:C}", objPLUPrecioCat.PrecioConIVA), objPLU.PLU.ToString()));
                            //rcb_preciounitario.SelectedIndex = 0;

                            //rcb_preciototal.Items.Insert(0, new RadComboBoxItem(String.Format("{0:C}", objPLUPrecioCat.PrecioConIVA), objPLU.PLU.ToString()));
                            //rcb_preciototal.SelectedIndex = 0;
                        }

                        //()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()
                        //()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()
                    }
                    else
                    {
                        PrecioCat = objPLUPrecioCat.PrecioSinIVA;
                        IVAPrecioCat = 0;

                        PrecioUnitario = objPLU.PrecioSinIVA;

                        //rcb_preciounitario.Items.Insert(0, new RadComboBoxItem(String.Format("{0:C}", objPLU.PrecioSinIVA), objPLU.PLU.ToString()));
                        //rcb_preciounitario.SelectedIndex = 0;

                        //rcb_preciototal.Items.Insert(0, new RadComboBoxItem(String.Format("{0:C}", objPLU.PrecioSinIVA), objPLU.PLU.ToString()));
                        //rcb_preciototal.SelectedIndex = 0;
                    }

                    PrecioTotal = PrecioUnitario * Cantidad;
                    CantidadSeleccionada = Cantidad;
                    objPLU.PrecioTotalConIVA = PrecioTotal;
                    objPLU.Cantidad = Cantidad;
                    //ValorTotal(Convert.ToInt32(rcb_cantidad.SelectedItem.Value));
                }

                //rcb_cantidad.SelectedValue = "1";
                //ValorTotal(Convert.ToInt32(rcb_cantidad.SelectedItem.Value));

               

            }
            else
            {

                objCatalogoPluInfo = objCatalogoPlu.ListxCodigoRapidoSinCatalogoAgotadoAnunciado(ObjPLUInfo.CodigoRapido.ToUpper());

                if (objCatalogoPluInfo != null)
                {

                    //string IdZona = "";

                    // -----------------------------------------------------------------------------------------------------
                    /*if (Session["IdGrupo"].ToString() == Convert.ToString((int)GruposUsuariosEnum.GerentesZona))
                    {
                        IdZona = Session["IdZona"].ToString().Trim();
                    }
                    else if (Session["IdGrupo"].ToString() == Convert.ToString((int)GruposUsuariosEnum.GerentesRegionales))
                    {
                        Cliente objCliente = new Cliente("conexion");
                        ClienteInfo objClienteInfo = new ClienteInfo();

                        objClienteInfo = objCliente.ListClienteNivixNit(txt_nodocumento.Text);

                        IdZona = objClienteInfo.Zona.Trim();
                    }*/

                    //Se guarda historial de articulos digitados con estado de agotado anunciado.
                    CicloxPlu objCicloxPlu = new CicloxPlu("conexion");
                    CicloxPluInfo objCicloxPluInfo = new CicloxPluInfo();

                    objCicloxPluInfo.Referencia = objCatalogoPluInfo.Referencia.Trim();
                    objCicloxPluInfo.CCostos = "P000-" + objCatalogoPluInfo.PLU.ToString();
                    objCicloxPluInfo.PLU = objCatalogoPluInfo.PLU;
                    objCicloxPluInfo.Usuario = ObjPLUInfo.Usuario.Trim();
                    objCicloxPluInfo.CodigoRapido = ObjPLUInfo.CodigoRapido.ToUpper();
                    objCicloxPluInfo.Campana = ObjPLUInfo.Campana;
                    objCicloxPluInfo.Zona = ObjPLUInfo.IdZona.Trim();

                    int Id = objCicloxPlu.Insert(objCicloxPluInfo);

                    //---------------------------------------------------------------------------------------------------------------
                    //Mensaje de Advertencia.              
                    //RadWindowManager1.RadAlert("El articulo se encuentra agotado. <br><b>No disponible para la digitacion.</b>", 330, 130, "SVDN - Pedidos", "MensajeSistema", "../images/warning.gif");

                    objPLU.Error = new Error();
                    objPLU.Error.Id = -1;
                    objPLU.Error.Descripcion = "El articulo se encuentra agotado. <br><b>No disponible para la digitacion.</b>. Codigo Rapido: " + ObjPLUInfo.CodigoRapido.ToUpper();
                    objPLU.CodigoRapido = ObjPLUInfo.CodigoRapido.ToUpper();
                }
                else
                {
                    objPLU.PLU = -1;

                    objPLU.Error = new Error();
                    objPLU.Error.Id = -1;
                    objPLU.Error.Descripcion = "No se encontraron resultados. Por favor verifique. Codigo Rapido: " + ObjPLUInfo.CodigoRapido.ToUpper();
                    objPLU.CodigoRapido = ObjPLUInfo.CodigoRapido.ToUpper();
                }
            }
            ObjPLUInfo.SessionEmpresaria.Campana = "0919"; //MRG: Cambiar por la campana cargada.
            ObjPLUInfo.SessionEmpresaria.Catalogo = "124"; //MRG: Cambiar por la campana cargada.
            objPLU.SessionEmpresaria = ObjPLUInfo.SessionEmpresaria;

            return objPLU;
        }

    }
}
