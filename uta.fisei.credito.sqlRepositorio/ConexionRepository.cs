using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace uta.fisei.credito.sqlRepositorio
{
    public class ConexionRepository
    {
        public static string ObtenerCadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["Creditos"].ToString();
        }
    }
}
