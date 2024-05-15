using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Modal;

namespace DAO_BLL
{
    public class FamiliaresDAO : DAO_DAL
    {
        FamiliaresVO objFamiliaresVO;

        OleDbCommand objComando;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objLeitorBD;

        DataTable objTabela;

        bool resultado;

        public override DataTable ConsultarBD(Object objParFamiliaresVO)
        {
            try
            {
                objFamiliaresVO = (FamiliaresVO)objParFamiliaresVO;
                StringBuilder strSql = new StringBuilder();

                strSql.Append("SELECT");
                strSql.Append(" COD,");
                strSql.Append(" Nome,");
                strSql.Append(" Sexo,");
                strSql.Append(" Idade,");
                strSql.Append(" Data_Nascimento,");
                strSql.Append(" Ganho_Mensal_Total,");
                strSql.Append(" Gasto_Mensal_Total,");
                strSql.Append(" Observacao");
                strSql.Append(" FROM");
                strSql.Append(" Familiares_3");

                if (objFamiliaresVO.getCod() > 0)
                {
                    strSql.Append(" WHERE");
                    strSql.Append(" COD = :parCod");
                    objComando = new OleDbCommand(strSql.ToString(), getConexao());
                    objComando.Parameters.AddWithValue("parCod", objFamiliaresVO.getCod());
                }
                else if (!string.IsNullOrEmpty(objFamiliaresVO.getNome()))
                {
                    strSql.Append(" WHERE");
                    strSql.Append(" Nome = :parNome");
                    objComando = new OleDbCommand(strSql.ToString(), getConexao());
                    objComando.Parameters.AddWithValue("parNome", objFamiliaresVO.getNome());
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
                throw new Exception("Erro ao Executar" + ex);
            }
        }

        public override void ConsultarBD(ref Object objParFamiliaresVO)
        {
            try
            {
                objFamiliaresVO = (FamiliaresVO)objParFamiliaresVO;

                StringBuilder strSql = new StringBuilder();

                strSql.Append("SELECT");
                strSql.Append(" COD,");
                strSql.Append(" Nome,");
                strSql.Append(" Sexo,");
                strSql.Append(" Idade,");
                strSql.Append(" Data_Nascimento,");
                strSql.Append(" Ganho_Mensal_Total,");
                strSql.Append(" Gasto_Mensal_Total,");
                strSql.Append(" Observacao");
                strSql.Append(" FROM");
                strSql.Append(" Familiares_3");

                if (!string.IsNullOrEmpty(objFamiliaresVO.getNome()))
                {
                    strSql.Append(" WHERE");
                    strSql.Append(" Nome = :parNome");
                    objComando = new OleDbCommand(strSql.ToString(), getConexao());
                    objComando.Parameters.AddWithValue("parNome", objFamiliaresVO.getNome());
                }
                else if (objFamiliaresVO.getCod() > 0)
                {
                    strSql.Append(" WHERE");
                    strSql.Append(" COD = :parCod");
                    objComando = new OleDbCommand(strSql.ToString(), getConexao());
                    objComando.Parameters.AddWithValue("parCod", objFamiliaresVO.getCod());
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
                    objFamiliaresVO = new FamiliaresVO(Convert.ToInt32(linhaLida["COD"].ToString()), linhaLida["Nome"].ToString(), linhaLida["Sexo"].ToString(), Convert.ToInt32(linhaLida["Idade"].ToString()), Convert.ToDateTime(linhaLida["Data_Nascimento"].ToString()), Convert.ToDouble(linhaLida["Ganho_Mensal_Total"].ToString()), Convert.ToDouble(linhaLida["Gasto_Mensal_Total"].ToString()), linhaLida["Observacao"].ToString());
                    objFamiliaresVO.FamiliaresVOCollection.Add(objFamiliaresVO);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Execurtar" + ex);
            }
        }

        public override bool InserirBD(Object objParFamiliaresVO)
        {
            try
            {
                objFamiliaresVO = (FamiliaresVO)objParFamiliaresVO;

                AbrirConexao();

                StringBuilder strSql = new StringBuilder();

                strSql.Append("INSERT");
                strSql.Append(" INTO");
                strSql.Append(" Familiares_3 (");
                strSql.Append(" Nome,");
                strSql.Append(" Sexo,");
                strSql.Append(" Idade,");
                strSql.Append(" Data_Nascimento,");
                strSql.Append(" Ganho_Mensal_Total,");
                strSql.Append(" Gasto_Mensal_Total,");
                strSql.Append(" Observacao");
                strSql.Append(" ) VALUES (");
                strSql.Append(" :parNome,");
                strSql.Append(" :parSexo,");
                strSql.Append(" :parIdade,");
                strSql.Append(" :parData_Nascimento,");
                strSql.Append(" :parGanho_Mensal_Total,");
                strSql.Append(" :parGasto_Mensal_Total,");
                strSql.Append(" :parObservacao");
                strSql.Append(" )");

                objComando = new OleDbCommand(strSql.ToString(), getConexao());
                objComando.Parameters.AddWithValue("parNome", objFamiliaresVO.getNome());
                objComando.Parameters.AddWithValue("parSexo", objFamiliaresVO.getSexo());
                objComando.Parameters.AddWithValue("parIdade", objFamiliaresVO.getIdade());
                objComando.Parameters.AddWithValue("parData_Nascimento", objFamiliaresVO.getDataNascimento());
                objComando.Parameters.AddWithValue("parGanho_Mensal_Total", objFamiliaresVO.getGanhoTotal());
                objComando.Parameters.AddWithValue("parGasto_Mensal_Total", objFamiliaresVO.getGastoTotal());
                objComando.Parameters.AddWithValue("parObservacao", objFamiliaresVO.getObs());

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
            finally
            {
                FecharConexao();
            }
        }

        public override bool ExcluirBD(Object objParFamiliaresVO)
        {
            try
            {
                objFamiliaresVO = (FamiliaresVO)objParFamiliaresVO;

                AbrirConexao();

                StringBuilder strSql = new StringBuilder();

                strSql.Append("DELETE");
                strSql.Append(" FROM");
                strSql.Append(" Familiares_3");
                strSql.Append(" WHERE");
                strSql.Append(" COD =");
                strSql.Append(" :parCod");

                objComando = new OleDbCommand(strSql.ToString(), getConexao());
                objComando.Parameters.AddWithValue("parCod", objFamiliaresVO.getCod());

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
            finally
            {
                FecharConexao();
            }
        }

        public override bool AlterarBD(Object objParFamiliaresVO)
        {
            try
            {
                objFamiliaresVO = (FamiliaresVO)objParFamiliaresVO;

                AbrirConexao();

                StringBuilder strSql = new StringBuilder();

                strSql.Append("UPDATE");
                strSql.Append(" Familiares_3");
                strSql.Append(" SET");
                strSql.Append(" Nome =");
                strSql.Append(" :parNome,");
                strSql.Append(" Sexo =");
                strSql.Append(" :parSexo,");
                strSql.Append(" Idade =");
                strSql.Append(" :parIdade,");
                strSql.Append(" Data_Nascimento =");
                strSql.Append(" :parData_Nascimento,");
                strSql.Append(" Ganho_Mensal_Total =");
                strSql.Append(" :parGanho_Mensal_Total,");
                strSql.Append(" Gasto_Mensal_Total =");
                strSql.Append(" :parGasto_Mensal_Total,");
                strSql.Append(" Observacao =");
                strSql.Append(" :parObservacao");
                strSql.Append(" WHERE");
                strSql.Append(" COD =");
                strSql.Append(" :parCod");

                objComando = new OleDbCommand(strSql.ToString(), getConexao());
                objComando.Parameters.AddWithValue("parNome", objFamiliaresVO.getNome());
                objComando.Parameters.AddWithValue("parSexo", objFamiliaresVO.getSexo());
                objComando.Parameters.AddWithValue("parIdade", objFamiliaresVO.getIdade());
                objComando.Parameters.AddWithValue("parData_Nascimento", objFamiliaresVO.getDataNascimento());
                objComando.Parameters.AddWithValue("parGanho_Mensal_Total", objFamiliaresVO.getGanhoTotal());
                objComando.Parameters.AddWithValue("parGasto_Mensal_Total", objFamiliaresVO.getGastoTotal());
                objComando.Parameters.AddWithValue("parObservacao", objFamiliaresVO.getObs());
                objComando.Parameters.AddWithValue("parCod", objFamiliaresVO.getCod());

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
            finally
            {
                FecharConexao();
            }
        }
    }
}
