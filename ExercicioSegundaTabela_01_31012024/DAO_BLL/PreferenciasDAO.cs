using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modal;
using System.Data;
using System.Data.OleDb;

namespace DAO_BLL
{
    public class PreferenciasDAO : DAO_DAL
    {
        PreferenciasVO objPreferenciasVO;

        OleDbCommand objComando;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objLeitorBD;

        DataTable objTabela;

        bool resultado;

        public List<String> BancoConectado()
        {
            try
            {
                List<String> resultado = new List<String>();

                AbrirConexao();

                StringBuilder strSql = new StringBuilder();

                strSql.Append("SELECT");
                strSql.Append(" Descricao");
                strSql.Append(" FROM");
                strSql.Append(" Preferencias_3");

                objComando = new OleDbCommand(strSql.ToString(), getConexao());

                objLeitorBD = objComando.ExecuteReader();

                while (objLeitorBD.Read())
                {
                    resultado.Add(objLeitorBD["Descricao"].ToString());
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
            finally
            {
                objLeitorBD.Close();
                FecharConexao();
            }
        }

        public List<String> BancoDesconectado()
        {
            try
            {
                List<String> resultado = new List<String>();

                StringBuilder strSql = new StringBuilder();

                strSql.Append("SELECT");
                strSql.Append(" Descricao");
                strSql.Append(" FROM");
                strSql.Append(" Preferencias_3");

                objComando = new OleDbCommand(strSql.ToString(), getConexao());

                objAdaptador = new OleDbDataAdapter(objComando);

                objTabela = new DataTable();

                objAdaptador.Fill(objTabela);

                foreach (DataRow linhaLida in objTabela.Rows)
                {
                    resultado.Add(linhaLida["Descricao"].ToString());
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }

        public override DataTable ConsultarBD(Object objParPreferenciasVO)
        {
            try
            {
                objPreferenciasVO = (PreferenciasVO)objParPreferenciasVO;

                StringBuilder strSql = new StringBuilder();

                strSql.Append("SELECT");
                strSql.Append(" ID,");
                strSql.Append(" Descricao");
                strSql.Append(" FROM");
                strSql.Append(" Preferencias_3");

                if (!string.IsNullOrEmpty(objPreferenciasVO.getDescricao()))
                {
                    strSql.Append(" WHERE");
                    strSql.Append(" Descricao = :parDescricao");
                    objComando = new OleDbCommand(strSql.ToString(), getConexao());
                    objComando.Parameters.AddWithValue("parDescricao", objPreferenciasVO.getDescricao());
                }
                else if (objPreferenciasVO.getId() > 0)
                {
                    strSql.Append(" WHERE");
                    strSql.Append(" ID = :parId");
                    objComando = new OleDbCommand(strSql.ToString(), getConexao());
                    objComando.Parameters.AddWithValue("parId", objPreferenciasVO.getId());
                }
                else
                {
                    objComando = new OleDbCommand(strSql.ToString(), getConexao());
                }

                objAdaptador = new OleDbDataAdapter(objComando);

                objTabela = new DataTable();

                objAdaptador.Fill(objTabela);

                return objTabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }

        public override void ConsultarBD(ref Object objParPreferenciasVO)
        {
            try
            {
                objPreferenciasVO = (PreferenciasVO)objParPreferenciasVO;

                StringBuilder strSql = new StringBuilder();

                strSql.Append("SELECT");
                strSql.Append(" ID,");
                strSql.Append(" Descricao");
                strSql.Append(" FROM");
                strSql.Append(" Preferencias_3");

                if (!string.IsNullOrEmpty(objPreferenciasVO.getDescricao()))
                {
                    strSql.Append(" WHERE");
                    strSql.Append(" Descricao = :parDescricao");
                    objComando = new OleDbCommand(strSql.ToString(), getConexao());
                    objComando.Parameters.AddWithValue("parDescricao", objPreferenciasVO.getDescricao());
                }
                else if (objPreferenciasVO.getId() > 0)
                {
                    strSql.Append(" WHERE");
                    strSql.Append(" ID = :parId");
                    objComando = new OleDbCommand(strSql.ToString(), getConexao());
                    objComando.Parameters.AddWithValue("parId", objPreferenciasVO.getId());
                }
                else
                {
                    objComando = new OleDbCommand(strSql.ToString(), getConexao());
                }

                objAdaptador = new OleDbDataAdapter(objComando);

                objTabela = new DataTable();

                objAdaptador.Fill(objTabela);

                foreach (DataRow linhaLida in objTabela.Rows)
                {
                    objPreferenciasVO = new PreferenciasVO(Convert.ToInt32(linhaLida["ID"].ToString()), linhaLida["Descricao"].ToString());
                    objPreferenciasVO.PreferenciasVOCollection.Add(objPreferenciasVO);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }

        public override bool InserirBD(Object objParPreferenciasVO)
        {
            try
            {
                AbrirConexao();

                StringBuilder strSql = new StringBuilder();

                objPreferenciasVO = (PreferenciasVO)objParPreferenciasVO;

                strSql.Append("INSERT");
                strSql.Append(" INTO");
                strSql.Append(" Preferencias_3 (");
                strSql.Append(" Descricao");
                strSql.Append(" ) VALUES (");
                strSql.Append(" :parDescricao");
                strSql.Append(" )");

                objComando = new OleDbCommand(strSql.ToString(), getConexao());
                objComando.Parameters.AddWithValue("parDescricao", objPreferenciasVO.getDescricao());

                if (objComando.ExecuteNonQuery() > 0)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Executar" + ex);
            }
        }

        public override bool ExcluirBD(Object objParPreferenciasVO)
        {
            try
            {
                AbrirConexao();

                StringBuilder strSql = new StringBuilder();

                objPreferenciasVO = (PreferenciasVO)objParPreferenciasVO;

                strSql.Append("DELETE");
                strSql.Append(" FROM");
                strSql.Append(" Preferencias_3");
                strSql.Append(" WHERE");
                strSql.Append(" ID =");
                strSql.Append(" :parId");

                objComando = new OleDbCommand(strSql.ToString(), getConexao());
                objComando.Parameters.AddWithValue("parId", objPreferenciasVO.getId());
                if (objComando.ExecuteNonQuery() > 0)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Executar" + ex);
            }
        }

        public override bool AlterarBD(Object objParPreferenciasVO)
        {
            try
            {
                AbrirConexao();

                StringBuilder strSql = new StringBuilder();

                objPreferenciasVO = (PreferenciasVO)objParPreferenciasVO;

                strSql.Append("UPDATE");
                strSql.Append(" Preferencias_3");
                strSql.Append(" SET");
                strSql.Append(" Descricao =");
                strSql.Append(" :parDescricao");
                strSql.Append(" WHERE");
                strSql.Append(" ID =");
                strSql.Append(" :parId");

                objComando = new OleDbCommand(strSql.ToString(), getConexao());
                objComando.Parameters.AddWithValue("parDescricao", objPreferenciasVO.getDescricao());
                objComando.Parameters.AddWithValue("parId", objPreferenciasVO.getId());
                if (objComando.ExecuteNonQuery() > 0)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Executar" + ex);
            }
        }

    }
}
