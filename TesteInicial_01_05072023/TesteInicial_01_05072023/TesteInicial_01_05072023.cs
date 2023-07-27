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

namespace TesteInicial_01_05072023
{
    public partial class TesteInicial_01_05072023 : Form
    {
        StreamReader objLeitorTxt;
        string strLinhaLida;

        OleDbCommand objComando;
        OleDbConnection objConexao;
        OleDbDataAdapter objAdaptador;
        OleDbDataReader objLeitorBD;

        DataTable objTabela;

        public TesteInicial_01_05072023()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá, Mundo", "Mensagem");
        }

        private void btnDesvioCondicional_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Escolha Sim ou Não", "Escolha", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Você escolheu Sim", "Opção");
            }
            else
            {
                MessageBox.Show("Você escolheu Não", "Opção");
            }
        }

        private void btnDesvioCondicionalAninhado_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Escolha Sim, Não ou Cancelar", "Escolha", MessageBoxButtons.YesNoCancel);

            if (mensagem == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Você escolheu Sim", "Opção");
            }
            else if (mensagem == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("Você escolheu Não", "Opção");
            }
            else
            {
                MessageBox.Show("Você escolheu Cancelar", "Opção");
            }
        }

        private void btnSwitchCase_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Escolha Sim, Não ou Cancelar", "Escolha", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Cancel:
                    MessageBox.Show("Você escolheu Cancelar", "Opção");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Você escolheu Não", "Opção");
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("Você escolheu Sim", "Opção");
                    break;
                default:
                    MessageBox.Show("Você escolheu Errado, Escolha Sim, Não ou Cancelar", "Errado");
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
                lstbxPreferencias.Items.Add(strLinhaLida).ToString();
                strLinhaLida = objLeitorTxt.ReadLine();
            }

            objLeitorTxt.Close();
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
                lstbxPreferencias.Items.Add(strLinhaLida);
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
                lstbxPreferencias.Items.Add(item);
            }

            objLeitorTxt.Close();
        }

        private void btnBancoConectado_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            importarBancoConectado(); // chamada do método 
        }

        public void importarBancoConectado() // assinatura do método
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
            importarBancoDesconectado();
        }

        public void importarBancoDesconectado()
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
    }
}
