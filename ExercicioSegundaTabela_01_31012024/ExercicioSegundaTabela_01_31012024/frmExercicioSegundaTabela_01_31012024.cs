using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_BLL;
using Modal;

namespace ExercicioSegundaTabela_01_31012024
{
    public partial class frmExercicioSegundaTabela_01_31012024 : Form
    {
        Preferencias objPreferencias;
        PreferenciasVO objPreferenciasVO;
        Familiares objFamiliares;
        FamiliaresVO objFamiliaresVO;
        int intValorAntigo;
        int intCodFamiliar;
        bool bolPrefInc;
        bool bolFamInc;
        string strValorAntigo;

        public frmExercicioSegundaTabela_01_31012024()
        {
            InitializeComponent();
        }

        private void btnDesvioCondicional_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Escolha uma opção", "ESCOLHA", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
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
            try
            {
                lstbxPreferencias.Items.Clear();
                objPreferencias = new Preferencias();
                lstbxPreferencias.Items.AddRange(objPreferencias.ImpTxtWhile().ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar" + ex);
            }
        }

        private void btnImportarBancoConectado_Click(object sender, EventArgs e)
        {
            try
            {
                lstbxPreferencias.Items.Clear();
                objPreferencias = new Preferencias();
                lstbxPreferencias.Items.AddRange(objPreferencias.BancoConectado().ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar" + ex);
            }
        }

        private void btnImportarBancoDesconectado_Click(object sender, EventArgs e)
        {
            try
            {
                lstbxPreferencias.Items.Clear();
                objPreferencias = new Preferencias();
                lstbxPreferencias.Items.AddRange(objPreferencias.BancoDesconectado().ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar" + ex);
            }
        }

        private void btnConsultarBD_Click(object sender, EventArgs e)
        {
            ConsultarBD();
            dtgdvwPreferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgdvwPreferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        public void ConsultarBD(int? intId = null, string strDescricao = null)
        {
            try
            {
                objPreferencias = new Preferencias();
                objPreferenciasVO = new PreferenciasVO();
                if (!string.IsNullOrEmpty(strDescricao))
                {
                    objPreferenciasVO.setDescricao(strDescricao);
                }
                if (!string.IsNullOrEmpty(intId.ToString()))
                {
                    objPreferenciasVO.setId(Convert.ToInt32(intId));
                }

                bndsrcPreferencias.DataSource = objPreferencias.ConsultarBD(objPreferenciasVO);
                dtgdvwPreferencias.DataSource = bndsrcPreferencias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar" + ex);
            }
        }

        public void ConsultarBDFam(int? intCod = null, string strNome = null)
        {
            try
            {
                objFamiliaresVO = new FamiliaresVO();
                objFamiliares = new Familiares();

                if (!string.IsNullOrEmpty(intCod.ToString()))
                {
                    objFamiliaresVO.setCod(Convert.ToInt32(intCod));
                }
                objFamiliaresVO.setNome(strNome);

                bndsrcFamiliares.DataSource = objFamiliares.ConsultarBD(objFamiliaresVO);
                dtgdvwFamiliares.Columns.Clear();

                dtgdvwFamiliares.Columns.Add("COD", "Codigo Familiar");
                dtgdvwFamiliares.Columns["COD"].DataPropertyName = "COD";

                dtgdvwFamiliares.Columns.Add("Nome", "Nome Familiar");

                dtgdvwFamiliares.Columns["Nome"].DataPropertyName = "Nome";

                DataGridViewComboBoxColumn objColunaComboBoxSexo = new DataGridViewComboBoxColumn();
                objColunaComboBoxSexo.Name = "Sexo";
                objColunaComboBoxSexo.ValueType = typeof(string);
                objColunaComboBoxSexo.HeaderText = "Sexo do Familiar";
                objColunaComboBoxSexo.Items.Add("MASCULINO");
                objColunaComboBoxSexo.Items.Add("FEMININO");
                objColunaComboBoxSexo.Items.Add("INDEFINIDO");
                objColunaComboBoxSexo.DataPropertyName = "Sexo";

                dtgdvwFamiliares.Columns.Add(objColunaComboBoxSexo);
                dtgdvwFamiliares.Columns["Sexo"].ValueType = typeof(string);

                dtgdvwFamiliares.Columns.Add("Idade", "Idade do Familiar");
                dtgdvwFamiliares.Columns["Idade"].DataPropertyName = "Idade";

                dtgdvwFamiliares.Columns.Add("Data_Nascimento", "Data de Nascimento do Familiar");
                dtgdvwFamiliares.Columns["Data_Nascimento"].DataPropertyName = "Data_Nascimento";

                dtgdvwFamiliares.Columns.Add("Ganho_Mensal_Total", "Ganho do Familiar");
                dtgdvwFamiliares.Columns["Ganho_Mensal_Total"].DataPropertyName = "Ganho_Mensal_Total";

                dtgdvwFamiliares.Columns.Add("Gasto_Mensal_Total", "Gasto do Familiar");
                dtgdvwFamiliares.Columns["Gasto_Mensal_Total"].DataPropertyName = "Gasto_Mensal_Total";

                dtgdvwFamiliares.Columns.Add("Observacao", "Observacao do Familiar");
                dtgdvwFamiliares.Columns["Observacao"].DataPropertyName = "Observacao";

                dtgdvwFamiliares.DataSource = bndsrcFamiliares;
                dtgdvwFamiliares.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar Consultar Familiares" + ex);
            }
        }

        private void btnInserirBD_Click(object sender, EventArgs e)
        {
            InserirBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString());
            ConsultarBD();
            dtgdvwPreferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgdvwPreferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        public void InserirBD(string strPrefInc)
        {
            try
            {
                objPreferencias = new Preferencias();
                objPreferenciasVO = new PreferenciasVO();
                objPreferenciasVO.setDescricao(strPrefInc);

                if (objPreferencias.InserirBD(objPreferenciasVO))
                {
                    MessageBox.Show("Incluído com Sucesso", "Mensagem");
                }
                else
                {
                    MessageBox.Show("Erro ao Incluir", "Mensagem");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar" + ex);
            }
        }

        public void InserirBDFam(string strNome = null, string strSexo = null, int? intIdade = null, DateTime? dtData = null, double? dbGanho = null, double? dbGasto = null, string strObs = null)
        {
            try
            {
                objFamiliares = new Familiares();
                objFamiliaresVO = new FamiliaresVO();

                objFamiliaresVO.setNome(strNome);
                objFamiliaresVO.setSexo(strSexo);
                if (intIdade != null)
                {
                    objFamiliaresVO.setIdade(Convert.ToInt32(intIdade));
                }
                if (dtData.HasValue)
                {
                    objFamiliaresVO.setDataNascimento((DateTime)dtData);
                }

                objFamiliaresVO.setGanhoTotal(Convert.ToDouble(dbGanho == null ? 0 : dbGanho));
                objFamiliaresVO.setGastoTotal(Convert.ToDouble(dbGasto == null ? 0 : dbGasto));
                objFamiliaresVO.setObs(strObs);

                if (objFamiliares.InserirBD(objFamiliaresVO))
                {
                    MessageBox.Show("Incluído com Sucesso", "Mensagem");
                }
                else
                {
                    MessageBox.Show("Erro ao Incluir", "Mensagem");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar" + ex);
            }
        }

        private void btnExcluirBD_Click(object sender, EventArgs e)
        {
            ExcluirBD(intValorAntigo);
            ConsultarBD();
            dtgdvwPreferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgdvwPreferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        public void ExcluirBD(int intIdExc)
        {
            try
            {
                objPreferencias = new Preferencias();
                objPreferenciasVO = new PreferenciasVO();
                objPreferenciasVO.setId(intIdExc);

                if (objPreferencias.ExcluirBD(objPreferenciasVO))
                {
                    MessageBox.Show("Excluído com Sucesso", "Mensagem");
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir", "Mensagem");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar" + ex);
            }
        }

        public void ExcluirBDFam(int intCod)
        {
            try
            {
                objFamiliares = new Familiares();
                objFamiliaresVO = new FamiliaresVO();

                objFamiliaresVO.setCod(intCod);

                if (objFamiliares.ExcluirBD(objFamiliaresVO))
                {
                    MessageBox.Show("Excluído com Sucesso", "Mensagem");
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir", "Mensagem");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar" + ex);
            }
        }

        private void btnAlterarBD_Click(object sender, EventArgs e)
        {
            AlterarBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString(), intValorAntigo);
            ConsultarBD();
            dtgdvwPreferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgdvwPreferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        public void AlterarBD(string strDescricaoNova, int intIdAntigo)
        {
            try
            {
                objPreferencias = new Preferencias();
                objPreferenciasVO = new PreferenciasVO();
                objPreferenciasVO.setDescricao(strDescricaoNova);
                objPreferenciasVO.setId(intIdAntigo);

                if (objPreferencias.AlterarBD(objPreferenciasVO))
                {
                    MessageBox.Show("Alterado com Sucesso", "Mensagem");
                }
                else
                {
                    MessageBox.Show("Erro ao Alterar", "Mensagem");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar" + ex);
            }
        }

        public void AlterarBDFam(int intCod, string strNome, string strSexo, int intIdade, DateTime dtData, double dbGanho, double dbGasto, string strObs)
        {
            try
            {
                objFamiliares = new Familiares();
                objFamiliaresVO = new FamiliaresVO();

                objFamiliaresVO.setCod(intCod);
                objFamiliaresVO.setNome(strNome);
                objFamiliaresVO.setSexo(strSexo);
                objFamiliaresVO.setIdade(Convert.ToInt32(intIdade));
                objFamiliaresVO.setDataNascimento((DateTime)dtData);
                objFamiliaresVO.setGanhoTotal(Convert.ToDouble(dbGanho));
                objFamiliaresVO.setGastoTotal(Convert.ToDouble(dbGasto));
                objFamiliaresVO.setObs(strObs);

                if (objFamiliares.AlterarBD(objFamiliaresVO))
                {
                    MessageBox.Show("alterado com sucesso!", "mensagem");
                }
                else
                {
                    MessageBox.Show("erro ao alterar!", "mensagem");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar Alterar Familiares" + ex);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bolPrefInc = true;
        }

        private void bndnavbtnPesquisar_Click(object sender, EventArgs e)
        {
            ConsultarBD(null, bndnavtxtPreferencias.Text);
        }

        private void bndnavbtnConfirmar_Click(object sender, EventArgs e)
        {
            if (bolPrefInc)
            {
                if (MessageBox.Show("Confirma inclusão de '" + dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString() + "' ?", "inclusão bd", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    InserirBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString());
                }
                bolPrefInc = false;
            }
            else
            {
                if (MessageBox.Show("Confirma alteração de '" + strValorAntigo + "' ?", "alteração bd", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    AlterarBD(dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString(), intValorAntigo);
                }
            }
            ConsultarBD();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma exclusão de '" + strValorAntigo + "' ?", "exclusão bd", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                ExcluirBD(intValorAntigo);
            }
            ConsultarBD();
        }

        private void dtgdvwPreferencias_Click(object sender, EventArgs e)
        {
            strValorAntigo = dtgdvwPreferencias.CurrentCell.EditedFormattedValue.ToString();
            if (!string.IsNullOrEmpty(dtgdvwPreferencias.CurrentRow.Cells["ID"].Value.ToString()))
            {
                intValorAntigo = Convert.ToInt32(dtgdvwPreferencias.CurrentRow.Cells["ID"].Value.ToString());
            }
        }

        private void frmExercicioSegundaTabela_01_31012024_Load(object sender, EventArgs e)
        {
            ConsultarBD();
            dtgdvwPreferencias.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgdvwPreferencias.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ConsultarBDFam();
        }

        private void dtgdvwFamiliares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strValorAntigo = dtgdvwFamiliares.CurrentRow.Cells["Nome"].Value.ToString();
            if (!string.IsNullOrEmpty(dtgdvwFamiliares.CurrentRow.Cells["COD"].Value.ToString()))
            {
                intCodFamiliar = Convert.ToInt32(dtgdvwFamiliares.CurrentRow.Cells["COD"].Value.ToString());
            }
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            bolFamInc = true;
        }

        private void bndnavbtnPesquisarFam_Click(object sender, EventArgs e)
        {
            ConsultarBDFam(null, bndnavtxtFamiliares.Text);
        }

        private void bndnavbtnConfirmarFam_Click(object sender, EventArgs e)
        {
            if (bolFamInc)
            {
                if (MessageBox.Show("Deseja Incluir " + dtgdvwFamiliares.CurrentRow.Cells["Nome"].EditedFormattedValue.ToString(), "Aviso", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    InserirBDFam(dtgdvwFamiliares.CurrentRow.Cells["Nome"].EditedFormattedValue.ToString(),
                                 dtgdvwFamiliares.CurrentRow.Cells["Sexo"].EditedFormattedValue.ToString(),
                                 Convert.ToInt32(dtgdvwFamiliares.CurrentRow.Cells["Idade"].EditedFormattedValue.ToString()),
                                 Convert.ToDateTime(dtgdvwFamiliares.CurrentRow.Cells["Data_Nascimento"].EditedFormattedValue.ToString()),
                                 Convert.ToDouble(dtgdvwFamiliares.CurrentRow.Cells["Ganho_Mensal_Total"].EditedFormattedValue.ToString()),
                                 Convert.ToDouble(dtgdvwFamiliares.CurrentRow.Cells["Gasto_Mensal_Total"].EditedFormattedValue.ToString()),
                                 dtgdvwFamiliares.CurrentRow.Cells["Observacao"].EditedFormattedValue.ToString());
                }
                bolFamInc = false;
                ConsultarBDFam();
            }
            else
            {
                if (MessageBox.Show("Deseja Alterar " + strValorAntigo + " para " + dtgdvwFamiliares.CurrentRow.Cells["Nome"].EditedFormattedValue.ToString(), "Aviso", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    AlterarBDFam(intCodFamiliar,
                                 dtgdvwFamiliares.CurrentRow.Cells["Nome"].EditedFormattedValue.ToString(),
                                 dtgdvwFamiliares.CurrentRow.Cells["Sexo"].EditedFormattedValue.ToString(),
                                 Convert.ToInt32(dtgdvwFamiliares.CurrentRow.Cells["Idade"].EditedFormattedValue.ToString()),
                                 Convert.ToDateTime(dtgdvwFamiliares.CurrentRow.Cells["Data_Nascimento"].EditedFormattedValue.ToString()),
                                 Convert.ToDouble(dtgdvwFamiliares.CurrentRow.Cells["Ganho_Mensal_Total"].EditedFormattedValue.ToString()),
                                 Convert.ToDouble(dtgdvwFamiliares.CurrentRow.Cells["Gasto_Mensal_Total"].EditedFormattedValue.ToString()),
                                 dtgdvwFamiliares.CurrentRow.Cells["Observacao"].EditedFormattedValue.ToString());
                }
                ConsultarBDFam();
            }
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma exclusão de '" + strValorAntigo + "' ?", "AVISO", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                ExcluirBDFam(intCodFamiliar);            
            }
            ConsultarBDFam();
        }
    }
}
