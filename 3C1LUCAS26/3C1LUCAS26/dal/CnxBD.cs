using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _3C1LUCAS26.dal
{
    class CnxBD
    {
        MySqlConnection conexaoBanco;
        public void Conectar()
        {
            try
            {
                string conn = "Persist Security Info = false; " +
                              "server = localhost; " +
                              "database = 3c1Lucasvitor26" +
                              "uid = root; pwd=";
                conexaoBanco = new MySqlConnection(conn);
                conexaoBanco.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível conectar ao banco de dados.\n" + ex.Message);
            }
        }
        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                Conectar();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexaoBanco);
                DataTable dt = new DataTable();
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível executar a CONSULTA solicitada.\n" + ex.Message);
            }
            finally
            {
                conexaoBanco.Close();
            }
        }
        public void ExecutarComando(string sql)
        {
            Conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexaoBanco);
            }
            catch (MySqlException ex)
            {
                throw new Exception("A instrução não foi realizada.\n" + ex.Message);
            }
            finally
            {
                conexaoBanco.Close();
            }
        }
    }

    internal class MySqlDataAdapter
    {
        private string sql;
        private MySqlConnection conexaoBanco;

        public MySqlDataAdapter(string sql, MySqlConnection conexaoBanco)
        {
            this.sql = sql;
            this.conexaoBanco = conexaoBanco;
        }

        internal void Fill(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class MySqlException : Exception
    {
        public MySqlException()
        {
        }

        public MySqlException(string message) : base(message)
        {
        }

        public MySqlException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MySqlException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

