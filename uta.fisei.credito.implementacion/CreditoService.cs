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
    public class CreditoService : ICreditoService
    {
        public Credito ActualizarCredito(Credito credito)
        {
            using (var obj = new CreditoFachada())
            {
                return obj.ActualizarCredito(credito);
            }
        }

        public bool EliminarCredito(string idCredito)
        {
            using (var obj = new CreditoFachada())
            {
                return obj.EliminarCredito(idCredito);
            }
        }

        public IEnumerable<Credito> ListarCredito()
        {
            using (var obj = new CreditoFachada())
            {
                return obj.ListarCredito();
            }
        }

        public Credito RegistrarCredito(Credito credito)
        {
            using (var obj = new CreditoFachada())
            {
                return obj.RegistrarCredito(credito);
            }
        }
    }
}
