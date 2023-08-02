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

namespace TesteAlterarBD_01_02082023
{
    public partial class frmTesteAlterarBD_01_02082023 : Form
    {
        string strLinhaLida;
        StreamReader objLeitorTxt;

        OleDbCommand objComando;
        OleDbConnection objConexao;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objLeitorBD;

        DataTable objTabela;

        string strValorAntigo;

        bool bolPrefInc = false;

        public frmTesteAlterarBD_01_02082023()
        {
            InitializeComponent();
        }

        private void btnDesvCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Escolha Sim ou Não", "Escolha", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
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

        private void btnBDCon_Click(object sender, EventArgs e)
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

        private void btnBDDes_Click(object sender, EventArgs e)
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

            foreach (DataRow itemLido in objTabela.Rows)
            {
                lstbxPreferencias.Items.Add(itemLido["Descricao"].ToString());
            }
        }

        private void btnConsBD_Click(object sender, EventArgs e)
        {
            ConsultarBD();
        }

        public void ConsultarBD(string strDescricao = null)
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");

            if (string.IsNullOrEmpty(strDescricao))
            {
                objComando = new OleDbCommand("SELECT Descricao FROM Preferencias_3", objConexao);
            }
            else
            {
                objComando = new OleDbCommand("SELECT Descricao FROM Preferencias_3 WHERE Descricao = '"+ strDescricao +"'", objConexao);
            }

            objAdaptador = new OleDbDataAdapter(objComando);

            objTabela = new System.Data.DataTable();

            objAdaptador.Fill(objTabela);

            bndsrcPreferencias.DataSource = objTabela;
            dtgdvwPreferencias.DataSource = bndsrcPreferencias;
            
        }

        private void btnInsBD_Click(object sender, EventArgs e)
        {
            InserirBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString());
            ConsultarBD();
        }

        public void InserirBD(string strPrefIncluida)
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");
            objConexao.Open();

            objComando = new OleDbCommand("INSERT INTO Preferencias_3 (Descricao) VALUES ('"+ dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() +"')", objConexao);

            if (objComando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Registro incluído com Sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao incluir o Registro");
            }

            objConexao.Close();
        }

        private void btnExcBD_Click(object sender, EventArgs e)
        {
            ExcluirBD(strValorAntigo);
            ConsultarBD();
        }

        public void ExcluirBD(string strPrefExcluida)
        {
            objConexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CURSO PROGRAMAR\C#.NET\Preferencias_1_05072023.mdb'");
            objConexao.Open();

            objComando = new OleDbCommand("DELETE FROM Preferencias_3 WHERE Descricao = '" + dtgdvwPreferencias.CurrentCell.Value.ToString() + "'", objConexao);

            if (objComando.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Registro excluído com Sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao excluir o Registro");
            }

            objConexao.Close();
        }

        private void btnAltBD_Click(object sender, EventArgs e)
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
                MessageBox.Show("Registro alterado com Sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao alterar o Registro");
            }

            objConexao.Close();
        }

        private void frmTesteAlterarBD_01_02082023_Load(object sender, EventArgs e)
        {
            ConsultarBD();
        }

        private void dtgdvwPreferencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strValorAntigo = dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString();
        }

        private void bndnavbtnPesquisar_Click(object sender, EventArgs e)
        {
            ConsultarBD(bndnavtxtPesquisar.Text);
        }

        private void bndnavbtnIncluir_Click(object sender, EventArgs e)
        {
            bolPrefInc = true;
        }

        private void bndnavbtnConfirmar_Click(object sender, EventArgs e)
        {
            if (bolPrefInc)
            {
                if (MessageBox.Show("Confirma a inclusão de '"+ dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() +"'?","Incluir BD", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    InserirBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString());
                }
                bolPrefInc = false;
            }
            else
            {
                if (MessageBox.Show("Confirma a alteração de '" + strValorAntigo + "'?", "Alterar BD", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    AlterarBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString(), strValorAntigo);
                }
            }
            ConsultarBD();
        }

        private void bndnavbtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão de '" + dtgdvwPreferencias.CurrentCell.Value.ToString() + "'?", "Excluir BD", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                ExcluirBD(strValorAntigo);
            }
            ConsultarBD();
        }
    }
}
