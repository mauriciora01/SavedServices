namespace Application.Enterprise.CommonObjects
{

    public class SessionEmpresariaInfo
    {
        public virtual string DocumentoEmpresaria
        {
            get;
            set;
        }

        public virtual string NombreEmpresariaCompleto
        {
            get;
            set;
        }

        public virtual string TipoPedidoMinimo
        {
            get;
            set;
        }

        public virtual string CodCiudadCliente
        {
            get;
            set;
        }

        public virtual string PremioBienvenida
        {
            get;
            set;
        }

        public virtual string TipoEnvioCliente
        {
            get;
            set;
        }

        public virtual string Empresaria_Lider
        {
            get;
            set;
        }

        public virtual string ExcentoIVA
        {
            get;
            set;
        }
       

        public virtual Error Error
        {
            get;
            set;
        }



    }
}
