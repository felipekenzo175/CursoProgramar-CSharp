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
using System.IO;

namespace TesteBancoDados_01_12072023
{
    public partial class TesteBancoDados_01_12072023 : Form
    {
        StreamReader objLeitorTxt;
        string strLinhaLida;

        OleDbConnection objConexao;
        OleDbCommand objComando;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objLeitorBD;

        DataTable objTabela;

        public TesteBancoDados_01_12072023()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo!");
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

        private void btnDesvCondEncadeado_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Escolha Sim, Não ou Cancelar", "ESCOLHA", MessageBoxButtons.YesNoCancel);

            if (mensagem == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Você escolheu Sim", "OPÇÃO");
            }
            else if (mensagem == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("Você escolheu Não", "OPÇÃO");
            }
            else
            {
                MessageBox.Show("Você escolheu Cancelar", "OPÇÃO");
            }
        }

        private void btnSwitchCase_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Escolha Sim, Não ou Cancelar", "ESCOLHA", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.No:
                    MessageBox.Show("Você escolheu Não", "OPÇÃO");
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("Você escolheu Sim", "OPÇÃO");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Você escolheu Cancelar", "OPÇÃO");
                    break;
                default:
                    MessageBox.Show("Você escolheu Errado, Escolha Sim, Não ou Cancelar", "OPÇÃO");
                    break;
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

        private void btnFor_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impTxtFor();
        }

        public void impTxtFor()
        {
            objLeitorTxt = new StreamReader(@"C:\CURSO PROGRAMAR\C#.NET\preferencias.txt");

            for (strLinhaLida = objLeitorTxt.ReadLine(); strLinhaLida != null; strLinhaLida = objLeitorTxt.ReadLine())
            {
                lstbxPreferencias.Items.Add(strLinhaLida.ToString());
            }

            objLeitorTxt.Close();
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impTxtForEach();
        }

        public void impTxtForEach()
        {
            objLeitorTxt = new StreamReader(@"C:\CURSO PROGRAMAR\C#.NET\preferencias.txt");
            string[] lista = objLeitorTxt.ReadToEnd().Trim().Split('\n');

            foreach (string item in lista)
            {
                 lstbxPreferencias.Items.Add(item.ToString());
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

            objConexao.Close();
            objLeitorBD.Close();
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

            foreach (DataRow item in objTabela.Rows)
            {
                lstbxPreferencias.Items.Add(item["Descricao"].ToString());
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            impTxtDoWhile();
        }

        public void impTxtDoWhile()
        {
            objLeitorTxt = new StreamReader(@"C:\CURSO PROGRAMAR\C#.NET\preferencias.txt");
            strLinhaLida = objLeitorTxt.ReadLine();

            do
            {
                lstbxPreferencias.Items.Add(strLinhaLida);
                strLinhaLida = objLeitorTxt.ReadLine();
            } while (strLinhaLida != null);

            objLeitorTxt.Close();
        }
    }
}
