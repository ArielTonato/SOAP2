using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uta.fisei.credito.ContratoRepositorio;
using uta.fisei.credito.dominio;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace uta.fisei.credito.sqlRepositorio
{
    public class CreditoRepositorio : ICreditoRepositorio
    {
        public Credito ActualizarCredito(Credito credito)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepository.ObtenerCadenaConexion()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("IdCredito", credito.IdCredito);
                parametros.Add("TipoCredito", credito.TipoCredito);
                parametros.Add("IdCliente", credito.IdCliente);
                parametros.Add("Fecha", credito.Fecha);
                parametros.Add("Monto", credito.Monto);
                parametros.Add("DiaPago", credito.DiaPago);
                parametros.Add("Tasa", credito.Tasa);
                parametros.Add("Comision", credito.Comision);

                var result = conexion.Execute("dbo.sp_credito_actualizar", param: parametros, commandType: CommandType.StoredProcedure);
                return result > 0 ? credito : new Credito();
            }
        }

        public bool EliminarCredito(string idCredito)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepository.ObtenerCadenaConexion()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("IdCredito", idCredito);
                var result = conexion.Execute("dbo.sp_credito_eliminar", param: parametros, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public IEnumerable<Credito> ListarCredito()
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepository.ObtenerCadenaConexion()))
            {
                conexion.Open();
                var credito = conexion.Query<Credito>("dbo.sp_credito_listar", commandType: CommandType.StoredProcedure);
                return credito;
            }
        }

        public Credito RegistrarCredito(Credito credito)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepository.ObtenerCadenaConexion()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("TipoCredito", credito.TipoCredito);
                parametros.Add("IdCliente", credito.IdCliente);
                parametros.Add("Fecha", credito.Fecha);
                parametros.Add("Monto", credito.Monto);
                parametros.Add("DiaPago", credito.DiaPago);
                parametros.Add("Tasa", credito.Tasa);
                parametros.Add("Comision", credito.Comision);
                parametros.Add("IdCredito", credito.IdCredito, DbType.Int32, ParameterDirection.Output);
                var result = conexion.ExecuteScalar("dbo.sp_credito_registrar", param: parametros, commandType: CommandType.StoredProcedure);
                var pIdCredito = parametros.Get<Int32>("IdCredito");
                credito.IdCredito = pIdCredito;
                return credito;
            }
        }
    }
}
