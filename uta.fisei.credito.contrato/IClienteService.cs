using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using uta.fisei.credito.dominio;
using System.ServiceModel.Web;

namespace uta.fisei.credito.contrato
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ObtenerCliente/{numeroDocumento}", BodyStyle = WebMessageBodyStyle.Bare)]
        Cliente ObtenerCliente(string numeroDocumento);
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarCliente", BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Cliente> ListarCliente();
    }
}
