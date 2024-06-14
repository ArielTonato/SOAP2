using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uta.fisei.credito.dominio;
using uta.fisei.credito.ContratoRepositorio;
using uta.fisei.credito.sqlRepositorio;

namespace uta.fisei.credito.fachada
{
    public class ClienteFachada : IDisposable
    {
        public Cliente ObtenerCliente(string numeroDocumento)
        {
            IClienteRepositorio obj = new ClienteRepositorio();
            return obj.ObtenerCliente(numeroDocumento);
        }
        public IEnumerable<Cliente> ListarCliente()
        {
            IClienteRepositorio obj = new ClienteRepositorio();
            return obj.ListarCliente();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
