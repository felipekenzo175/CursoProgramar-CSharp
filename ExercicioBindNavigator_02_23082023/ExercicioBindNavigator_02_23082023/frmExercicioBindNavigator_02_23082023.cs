using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using PreferenciasBLL;

namespace ExercicioBindNavigator_02_23082023
{
    public partial class frmExercicioBindNavigator_02_23082023 : Form
    {
        DataTable objTabela;

        OleDbCommand objComando;
        OleDbConnection objConexao;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objLeitorBD;

        bool bolPrefInc;

        string strValorAntigo;

        Preferencias objPreferencias;

        public frmExercicioBindNavigator_02_23082023()
        {
            InitializeComponent();
        }

        private void btnDesvioCondicional_Click(object sender, EventArgs e)
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

        private void btnImportarTextoWhile_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            objPreferencias = new Preferencias();
            lstbxPreferencias.Items.AddRange(objPreferencias.impTxtWhile().ToArray());
        }

        private void btnConsultarBancoConectado_Click(object sender, EventArgs e)
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

        private void btnConsultarBancoDesconectado_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impBancoDesconectado();
        }

        public void impBancoDesconectado()
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");

            objComando = new OleDbCommand("SELECT Descricao FROM Preferencias_3", objConexao);

            objTabela = new System.Data.DataTable();

            objAdaptador = new OleDbDataAdapter(objComando);

            objAdaptador.Fill(objTabela);

            foreach (DataRow linhaLida in objTabela.Rows)
            {
                lstbxPreferencias.Items.Add(linhaLida["Descricao"].ToString());
            }
        }

        private void btnConsultarBancoDados_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            ConsultarBD();
        }

        public void ConsultarBD(string strValor = null)
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");

            if (string.IsNullOrEmpty(strValor))
	        {
                objComando = new OleDbCommand("SELECT Descricao FROM Preferencias_3", objConexao);
	        }
            else
            {
                objComando = new OleDbCommand("SELECT Descricao FROM Preferencias_3 WHERE Descricao = '"+ strValor +"'", objConexao);
            }

            objTabela = new System.Data.DataTable();

            objAdaptador = new OleDbDataAdapter(objComando);

            objAdaptador.Fill(objTabela);

            bndsrcPreferencias.DataSource = objTabela;
            dtgdvwPreferencias.DataSource = bndsrcPreferencias;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InserirBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString());
            ConsultarBD();
        }

        public void InserirBD(string strIncluido)
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");
            objConexao.Open();

            objComando = new OleDbCommand("INSERT INTO Preferencias_3 (Descricao) VALUES ('" + strIncluido + "')", objConexao);

            if (objComando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Incluído com Sucesso");
            }
            else
            {
                MessageBox.Show("Problemas ao Incluir");
            }
            objConexao.Close();
        }

        private void btnExcluirBancoDados_Click(object sender, EventArgs e)
        {
            ExcluirBD(strValorAntigo);
            ConsultarBD();
        }

        public void ExcluirBD(string strExcluido)
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");
            objConexao.Open();

            objComando = new OleDbCommand("DELETE FROM Preferencias_3 WHERE Descricao = '" + strExcluido + "'", objConexao);

            if (objComando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Excluído com Sucesso");
            }
            else
            {
                MessageBox.Show("Problemas ao Excluir");
            }
            objConexao.Close();
        }

        private void btnAlterarBancoDados_Click(object sender, EventArgs e)
        {
            AlterarBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString(), strValorAntigo);
            ConsultarBD();
        }

        public void AlterarBD(string strNovo, string strAntigo)
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");
            objConexao.Open();

            objComando = new OleDbCommand("UPDATE Preferencias_3 SET Descricao = '" + strNovo + "' WHERE Descricao = '" + strAntigo + "'", objConexao);

            if (objComando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Alterado com Sucesso");
            }
            else
            {
                MessageBox.Show("Problemas ao Alterar");
            }
            objConexao.Close();
        }

        private void dtgdvwPreferencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strValorAntigo = dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString();
        }

        private void frmExercicioBindNavigator_02_23082023_Load(object sender, EventArgs e)
        {
            ConsultarBD();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bolPrefInc = true;
        }

        private void bndnavbtnConfirmar_Click(object sender, EventArgs e)
        {
            if (bolPrefInc)
            {
                if (MessageBox.Show("Confirma inclusão de '"+ dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() +"'?", "INCLUSÃO BD", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    InserirBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString());
                }
                ConsultarBD();
                bolPrefInc = false;
            }
            else
            {
                if (MessageBox.Show("Confirma alteração de '" + strValorAntigo + "' para '" + dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + "'?", "ALTERAÇÃO BD", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    AlterarBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString(), strValorAntigo);
                }
                ConsultarBD();
            }
        }

        private void bndnavbtnPesquisar_Click(object sender, EventArgs e)
        {
            ConsultarBD(bndnavtxtPreferencias.Text);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma exclusão de '" + strValorAntigo + "'?", "EXCLUSÃO BD", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                ExcluirBD(strValorAntigo);
            }
            ConsultarBD();
        }
    }
}
