using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uta.fisei.credito.ContratoRepositorio;
using uta.fisei.credito.dominio;
using uta.fisei.credito.sqlRepositorio;

namespace uta.fisei.credito.fachada
{
    public class CreditoFachada : IDisposable
    {
        public IEnumerable<Credito> ListarCredito()
        {
            ICreditoRepositorio obj = new CreditoRepositorio();
            return obj.ListarCredito();
        }
        public Credito RegistrarCredito(Credito credito)
        {
            ICreditoRepositorio obj = new CreditoRepositorio();
            return obj.RegistrarCredito(credito);
        }
        public Credito ActualizarCredito(Credito credito)
        {
            ICreditoRepositorio obj = new CreditoRepositorio();
            return obj.ActualizarCredito(credito);
        }
        public bool EliminarCredito(string idCredito)
        {
            ICreditoRepositorio obj = new CreditoRepositorio();
            return obj.EliminarCredito(idCredito);
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
