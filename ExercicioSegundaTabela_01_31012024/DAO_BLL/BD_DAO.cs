using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;

namespace DAO_BLL
{
    public class BD_DAO
    {
        private static OleDbConnection objConexao;
        public static OleDbConnection getConexao() 
        {
            if (objConexao == null)
            {
                objConexao = new OleDbConnection(ConfigurationSettings.AppSettings["connectionString"].ToString());
            }
            return objConexao;
        }

        public void AbrirConexao() 
        {
            if (getConexao().State == System.Data.ConnectionState.Closed)
            {
                objConexao.Open();
            }
        }

        public void FecharConexao() 
        {
            if (getConexao().State == System.Data.ConnectionState.Open)
            {
                objConexao.Close();
                objConexao.Dispose();
                objConexao = null;
            }
        }
    }
}
