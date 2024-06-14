using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uta.fisei.credito.dominio;

namespace uta.fisei.credito.ContratoRepositorio
{
    public interface ICreditoRepositorio
    {
        IEnumerable<Credito> ListarCredito();
        Credito RegistrarCredito(Credito credito);
        Credito ActualizarCredito(Credito credito);
        bool EliminarCredito(string idCredito);
    }
}
