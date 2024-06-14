using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uta.fisei.credito.contrato;
using uta.fisei.credito.dominio;
using uta.fisei.credito.fachada;

namespace uta.fisei.credito.implementacion
{
    public class ClienteService : IClienteService
    {
        public Cliente ObtenerCliente(string numeroDocumento)
        {
            using (var obj = new ClienteFachada())
            {
                return obj.ObtenerCliente(numeroDocumento);
            }
        }
        public IEnumerable<Cliente> ListarCliente()
        {
            using (var obj = new ClienteFachada())
            {
                return obj.ListarCliente();
            }
        }
    }
}
