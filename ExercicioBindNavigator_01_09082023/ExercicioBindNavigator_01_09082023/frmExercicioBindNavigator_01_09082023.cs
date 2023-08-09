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

namespace ExercicioBindNavigator_01_09082023
{
    public partial class frmExercicioBindNavigator_01_09082023 : Form
    {
        StreamReader objLeitorTxt;
        string strLinhaLida;

        OleDbCommand objComando;
        OleDbConnection objConexao;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objLeitorBD;

        DataTable objTabela;

        string strValorAntigo;

        bool bolPrefInc;

        public frmExercicioBindNavigator_01_09082023()
        {
            InitializeComponent();
        }

        private void btnDesvCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Escolha Sim ou Não", "Escolha", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Você escolheu Sim");
            }
            else
            {
                MessageBox.Show("Você escolheu Não");
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
                lstbxPreferencias.Items.Add(strLinhaLida.ToString());
                strLinhaLida = objLeitorTxt.ReadLine();
            }

            objLeitorTxt.Close();
        }

        private void btnConectadoBD_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impBDConectado();
        }

        public void impBDConectado()
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

        private void btnDesconectadoBD_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impBDDesconectado();
        }

        public void impBDDesconectado()
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");

            objComando = new OleDbCommand("SELECT Descricao FROM Preferencias_3", objConexao);

            objAdaptador = new OleDbDataAdapter(objComando);

            objTabela = new System.Data.DataTable();

            objAdaptador.Fill(objTabela);

            foreach (DataRow item in objTabela.Rows)
            {
                lstbxPreferencias.Items.Add(item["Descricao"].ToString());
            }
        }

        private void btnConsultarBD_Click(object sender, EventArgs e)
        {
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

            objAdaptador = new OleDbDataAdapter(objComando);

            objTabela = new System.Data.DataTable();

            objAdaptador.Fill(objTabela);

            bndsrcPreferencias.DataSource = objTabela;
            dtgdvwPreferencias.DataSource = bndsrcPreferencias;
        }

        private void btnInserirBD_Click(object sender, EventArgs e)
        {
            InserirBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString());
            ConsultarBD();
        }

        public void InserirBD(string strPrefInc)
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");
            objConexao.Open();

            objComando = new OleDbCommand("INSERT INTO Preferencias_3 (Descricao) VALUES ('"+ dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() +"')", objConexao);

            if (objComando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Incluído com Sucesso");
            }
            else
            {
                MessageBox.Show("Problemas ao Incluir");
            }
        }

        private void btnExcluirBD_Click(object sender, EventArgs e)
        {
            ExcluirBD(strValorAntigo);
            ConsultarBD();
        }

        public void ExcluirBD(string strPrefExc)
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");
            objConexao.Open();

            objComando = new OleDbCommand("DELETE FROM Preferencias_3 WHERE Descricao = '" + dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + "'", objConexao);

            if (objComando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Excluído com Sucesso");
            }
            else
            {
                MessageBox.Show("Problemas ao Excluir");
            }
        }

        private void btnAlterarBD_Click(object sender, EventArgs e)
        {
            AlterarBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString(), strValorAntigo);
            ConsultarBD();
        }

        public void AlterarBD(string strPrefNova, string strPrefAntiga)
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");
            objConexao.Open();

            objComando = new OleDbCommand("UPDATE Preferencias_3 SET Descricao = '" + dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + "' WHERE Descricao = '"+ strValorAntigo +"'", objConexao);

            if (objComando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Alterado com Sucesso");
            }
            else
            {
                MessageBox.Show("Problemas ao Alterar");
            }
        }

        private void dtgdvwPreferencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strValorAntigo = dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString();
        }

        private void frmExercicioBindNavigator_01_09082023_Load(object sender, EventArgs e)
        {
            ConsultarBD();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bolPrefInc = true;
        }

        private void bndnavbtnPesquisar_Click(object sender, EventArgs e)
        {
            ConsultarBD(bndnavtxtPreferencias.Text);
        }

        private void bndnavbtnConfirmar_Click(object sender, EventArgs e)
        {
            if (bolPrefInc)
            {
                if (MessageBox.Show("Confirma inclusão de '"+ dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() +"'", "INCLUSÃO BD", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    InserirBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString());
                }
                bolPrefInc = false;
            }
            else
            {
                if (MessageBox.Show("Confirma alteração de '"+ strValorAntigo +"' para '" + dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + "'?", "ALTERAÇÃO BD", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    AlterarBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString(), strValorAntigo);
                }
            }
            ConsultarBD();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma exclusão de '" + dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + "'", "EXCLUSÃO BD", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                ExcluirBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString());
            }
            ConsultarBD();
        }
    }
}
