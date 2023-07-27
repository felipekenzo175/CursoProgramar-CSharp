using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.OleDb;

namespace ExercicioAlterarBD_03_26072023
{
    public partial class ExercicioAlterarBD_03_26072023 : Form
    {
        string strLinhaLida;
        StreamReader objLeitorTxt;

        OleDbConnection objConexao;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objLeitorBD;
        OleDbCommand objComando;

        DataTable objTabela;

        string strValorAntigo;

        public ExercicioAlterarBD_03_26072023()
        {
            InitializeComponent();
        }

        private void btnDesvCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Escolha Sim ou Não", "ESCOLHA", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Você escolheu Sim", "OPÇÃO");
            }
            else
            {
                MessageBox.Show("Você escolheu Não", "OPÇÃO");
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impTxtWhile();
        }
        public void impTxtWhile()
        {
            objLeitorTxt = new StreamReader(@"C:\CURSO PROGRAMAR\C#.NET\preferencias.txt");
            strLinhaLida = objLeitorTxt.ReadLine();

            while (strLinhaLida != null)
            {
                lstbxPreferencias.Items.Add(strLinhaLida);
                strLinhaLida = objLeitorTxt.ReadLine();
            }

            objLeitorTxt.Close();
        }

        private void btnBancoConectado_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impBancoConectado();
        }
        public void impBancoConectado()
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");
            objConexao.Open();

            objComando = new OleDbCommand("SELECT Descricao FROM Preferencias_3", objConexao);

            objLeitorBD = objComando.ExecuteReader();

            while (objLeitorBD.Read())
            {
                lstbxPreferencias.Items.Add(objLeitorBD["Descricao"].ToString());
            }

            objLeitorBD.Close();
            objConexao.Close();
        }

        private void btnBancoDesconectado_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impBancoDesconectado();
        }
        public void impBancoDesconectado()
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");

            objComando = new OleDbCommand("SELECT Descricao FROM Preferencias_3", objConexao);

            objAdaptador = new OleDbDataAdapter(objComando);

            objTabela = new System.Data.DataTable();

            objAdaptador.Fill(objTabela);

            foreach (DataRow linhaLida in objTabela.Rows)
            {
                lstbxPreferencias.Items.Add(linhaLida["Descricao"].ToString());
            }
        }

        private void btnConsultarBD_Click(object sender, EventArgs e)
        {
            ConsultarBD();
        }
        public void ConsultarBD()
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");

            objComando = new OleDbCommand("SELECT Descricao FROM Preferencias_3", objConexao);

            objAdaptador = new OleDbDataAdapter(objComando);

            objTabela = new System.Data.DataTable();

            objAdaptador.Fill(objTabela);

            dtgdvwPreferencias.DataSource = objTabela;
        }

        private void btnInserirBD_Click(object sender, EventArgs e)
        {
            InserirBD();
            ConsultarBD();
        }
        public void InserirBD()
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");
            objConexao.Open();

            objComando = new OleDbCommand("INSERT INTO Preferencias_3 (Descricao) VALUES ('" + dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + "')", objConexao);

            if (objComando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Registro incluído com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao incluir o registro");
            }

            objConexao.Close();
        }

        private void btnExcluirBD_Click(object sender, EventArgs e)
        {
            ExcluirBD();
            ConsultarBD();
        }
        public void ExcluirBD()
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");
            objConexao.Open();

            objComando = new OleDbCommand("DELETE FROM Preferencias_3 WHERE Descricao = '" + dtgdvwPreferencias.CurrentCell.Value.ToString() + "'", objConexao);

            if (objComando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Registro excluído com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao excluir o registro");
            }

            objConexao.Close();
        }

        private void btnAlterarBD_Click(object sender, EventArgs e)
        {
            AlterarBD();
            ConsultarBD();
        }
        public void AlterarBD()
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");
            objConexao.Open();

            objComando = new OleDbCommand("UPDATE Preferencias_3 SET Descricao = '" + dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + "' WHERE Descricao = '" + strValorAntigo + "'", objConexao);

            if (objComando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Registro alterado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao alterar o registro");
            }

            objConexao.Close();
        }

        private void ExercicioAlterarBD_03_26072023_Load(object sender, EventArgs e)
        {
            ConsultarBD();
        }

        private void dtgdvwPreferencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strValorAntigo = dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString();
        }
    }
}
