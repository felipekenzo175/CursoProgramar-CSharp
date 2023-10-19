using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace Business_BLL
{
    public class Preferencias
    {
        OleDbCommand objComando;
        OleDbConnection objConexao;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objLeitorBD;

        DataTable objTabela;

        StreamReader objLeitorTxt;
        string strLinhaLida;

        public List<String> impTxtWhile()
        {
            List<String> lista = new List<string>();

            objLeitorTxt = new StreamReader(@"C:\CURSO PROGRAMAR\C#.NET\preferencias.txt");
            strLinhaLida = objLeitorTxt.ReadLine();

            while (strLinhaLida != null)
            {
                lista.Add(strLinhaLida.ToString());
                strLinhaLida = objLeitorTxt.ReadLine();
            }

            return lista;
        }

        public List<String> impBDConectado()
        {
            List<String> lista = new List<string>();

            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");
            objConexao.Open();

            objComando = new OleDbCommand("SELECT Descricao FROM Preferencias_3", objConexao);

            objLeitorBD = objComando.ExecuteReader();

            while (objLeitorBD.Read())
            {
                lista.Add(objLeitorBD["Descricao"].ToString());
            }

            objConexao.Close();

            return lista;
        }

        public List<String> impBDDesconectado()
        {
            List<String> lista = new List<string>();

            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");

            objComando = new OleDbCommand("SELECT Descricao FROM Preferencias_3", objConexao);

            objAdaptador = new OleDbDataAdapter(objComando);

            objTabela = new DataTable();

            objAdaptador.Fill(objTabela);

            foreach (DataRow linhaLida in objTabela.Rows)
            {
                lista.Add(linhaLida["Descricao"].ToString());
            }

            return lista;
        }
    }
}
