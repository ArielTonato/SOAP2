using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uta.fisei.credito.dominio;

namespace uta.fisei.credito.ContratoRepositorio
{
    public interface IClienteRepositorio
    {
         Cliente ObtenerCliente(string numeroDocumento);
         IEnumerable<Cliente> ListarCliente();
    }
}
