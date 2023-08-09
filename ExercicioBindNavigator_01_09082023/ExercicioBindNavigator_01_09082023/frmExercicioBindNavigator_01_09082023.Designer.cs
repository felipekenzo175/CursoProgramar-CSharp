namespace ExercicioBindNavigator_01_09082023
{
    partial class frmExercicioBindNavigator_01_09082023
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercicioBindNavigator_01_09082023));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDesvCond = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnConectadoBD = new System.Windows.Forms.Button();
            this.btnDesconectadoBD = new System.Windows.Forms.Button();
            this.btnConsultarBD = new System.Windows.Forms.Button();
            this.btnInserirBD = new System.Windows.Forms.Button();
            this.btnExcluirBD = new System.Windows.Forms.Button();
            this.btnAlterarBD = new System.Windows.Forms.Button();
            this.lstbxPreferencias = new System.Windows.Forms.ListBox();
            this.dtgdvwPreferencias = new System.Windows.Forms.DataGridView();
            this.bndsrcPreferencias = new System.Windows.Forms.BindingSource(this.components);
            this.bndnavPreferencias = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bndnavbtnConfirmar = new System.Windows.Forms.ToolStripButton();
            this.bndnavtxtPreferencias = new System.Windows.Forms.ToolStripTextBox();
            this.bndnavbtnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdvwPreferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsrcPreferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndnavPreferencias)).BeginInit();
            this.bndnavPreferencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 356);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bndnavPreferencias);
            this.tabPage1.Controls.Add(this.dtgdvwPreferencias);
            this.tabPage1.Controls.Add(this.lstbxPreferencias);
            this.tabPage1.Controls.Add(this.btnAlterarBD);
            this.tabPage1.Controls.Add(this.btnExcluirBD);
            this.tabPage1.Controls.Add(this.btnInserirBD);
            this.tabPage1.Controls.Add(this.btnConsultarBD);
            this.tabPage1.Controls.Add(this.btnDesconectadoBD);
            this.tabPage1.Controls.Add(this.btnConectadoBD);
            this.tabPage1.Controls.Add(this.btnWhile);
            this.tabPage1.Controls.Add(this.btnDesvCond);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(627, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Preferencias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDesvCond
            // 
            this.btnDesvCond.Location = new System.Drawing.Point(8, 6);
            this.btnDesvCond.Name = "btnDesvCond";
            this.btnDesvCond.Size = new System.Drawing.Size(197, 36);
            this.btnDesvCond.TabIndex = 0;
            this.btnDesvCond.Text = "Clique para Desvio Condicional";
            this.btnDesvCond.UseVisualStyleBackColor = true;
            this.btnDesvCond.Click += new System.EventHandler(this.btnDesvCond_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(8, 42);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(197, 36);
            this.btnWhile.TabIndex = 1;
            this.btnWhile.Text = "Clique para Texto While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnConectadoBD
            // 
            this.btnConectadoBD.Location = new System.Drawing.Point(8, 78);
            this.btnConectadoBD.Name = "btnConectadoBD";
            this.btnConectadoBD.Size = new System.Drawing.Size(197, 36);
            this.btnConectadoBD.TabIndex = 2;
            this.btnConectadoBD.Text = "Clique para Banco Conectado";
            this.btnConectadoBD.UseVisualStyleBackColor = true;
            this.btnConectadoBD.Click += new System.EventHandler(this.btnConectadoBD_Click);
            // 
            // btnDesconectadoBD
            // 
            this.btnDesconectadoBD.Location = new System.Drawing.Point(8, 114);
            this.btnDesconectadoBD.Name = "btnDesconectadoBD";
            this.btnDesconectadoBD.Size = new System.Drawing.Size(197, 36);
            this.btnDesconectadoBD.TabIndex = 3;
            this.btnDesconectadoBD.Text = "Clique para Banco Desconectado";
            this.btnDesconectadoBD.UseVisualStyleBackColor = true;
            this.btnDesconectadoBD.Click += new System.EventHandler(this.btnDesconectadoBD_Click);
            // 
            // btnConsultarBD
            // 
            this.btnConsultarBD.Location = new System.Drawing.Point(8, 182);
            this.btnConsultarBD.Name = "btnConsultarBD";
            this.btnConsultarBD.Size = new System.Drawing.Size(197, 36);
            this.btnConsultarBD.TabIndex = 4;
            this.btnConsultarBD.Text = "Clique para Consultar Banco de Dados";
            this.btnConsultarBD.UseVisualStyleBackColor = true;
            this.btnConsultarBD.Click += new System.EventHandler(this.btnConsultarBD_Click);
            // 
            // btnInserirBD
            // 
            this.btnInserirBD.Location = new System.Drawing.Point(8, 218);
            this.btnInserirBD.Name = "btnInserirBD";
            this.btnInserirBD.Size = new System.Drawing.Size(197, 36);
            this.btnInserirBD.TabIndex = 5;
            this.btnInserirBD.Text = "Clique para Inserir no Banco de Dados";
            this.btnInserirBD.UseVisualStyleBackColor = true;
            this.btnInserirBD.Click += new System.EventHandler(this.btnInserirBD_Click);
            // 
            // btnExcluirBD
            // 
            this.btnExcluirBD.Location = new System.Drawing.Point(8, 254);
            this.btnExcluirBD.Name = "btnExcluirBD";
            this.btnExcluirBD.Size = new System.Drawing.Size(197, 36);
            this.btnExcluirBD.TabIndex = 6;
            this.btnExcluirBD.Text = "Clique para Excluir do Banco de Dados";
            this.btnExcluirBD.UseVisualStyleBackColor = true;
            this.btnExcluirBD.Click += new System.EventHandler(this.btnExcluirBD_Click);
            // 
            // btnAlterarBD
            // 
            this.btnAlterarBD.Location = new System.Drawing.Point(8, 290);
            this.btnAlterarBD.Name = "btnAlterarBD";
            this.btnAlterarBD.Size = new System.Drawing.Size(197, 36);
            this.btnAlterarBD.TabIndex = 7;
            this.btnAlterarBD.Text = "Clique para Alterar Banco de Dados";
            this.btnAlterarBD.UseVisualStyleBackColor = true;
            this.btnAlterarBD.Click += new System.EventHandler(this.btnAlterarBD_Click);
            // 
            // lstbxPreferencias
            // 
            this.lstbxPreferencias.FormattingEnabled = true;
            this.lstbxPreferencias.Location = new System.Drawing.Point(211, 6);
            this.lstbxPreferencias.Name = "lstbxPreferencias";
            this.lstbxPreferencias.Size = new System.Drawing.Size(403, 147);
            this.lstbxPreferencias.TabIndex = 8;
            // 
            // dtgdvwPreferencias
            // 
            this.dtgdvwPreferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdvwPreferencias.Location = new System.Drawing.Point(211, 182);
            this.dtgdvwPreferencias.Name = "dtgdvwPreferencias";
            this.dtgdvwPreferencias.Size = new System.Drawing.Size(403, 144);
            this.dtgdvwPreferencias.TabIndex = 9;
            this.dtgdvwPreferencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdvwPreferencias_CellClick);
            // 
            // bndnavPreferencias
            // 
            this.bndnavPreferencias.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bndnavPreferencias.BindingSource = this.bndsrcPreferencias;
            this.bndnavPreferencias.CountItem = this.bindingNavigatorCountItem;
            this.bndnavPreferencias.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bndnavPreferencias.Dock = System.Windows.Forms.DockStyle.None;
            this.bndnavPreferencias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bndnavbtnConfirmar,
            this.bndnavtxtPreferencias,
            this.bndnavbtnPesquisar});
            this.bndnavPreferencias.Location = new System.Drawing.Point(211, 154);
            this.bndnavPreferencias.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bndnavPreferencias.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bndnavPreferencias.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bndnavPreferencias.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bndnavPreferencias.Name = "bndnavPreferencias";
            this.bndnavPreferencias.PositionItem = this.bindingNavigatorPositionItem;
            this.bndnavPreferencias.Size = new System.Drawing.Size(434, 25);
            this.bndnavPreferencias.TabIndex = 1;
            this.bndnavPreferencias.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bndnavbtnConfirmar
            // 
            this.bndnavbtnConfirmar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bndnavbtnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("bndnavbtnConfirmar.Image")));
            this.bndnavbtnConfirmar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bndnavbtnConfirmar.Name = "bndnavbtnConfirmar";
            this.bndnavbtnConfirmar.Size = new System.Drawing.Size(23, 22);
            this.bndnavbtnConfirmar.Text = "toolStripButton1";
            this.bndnavbtnConfirmar.Click += new System.EventHandler(this.bndnavbtnConfirmar_Click);
            // 
            // bndnavtxtPreferencias
            // 
            this.bndnavtxtPreferencias.Name = "bndnavtxtPreferencias";
            this.bndnavtxtPreferencias.Size = new System.Drawing.Size(100, 25);
            // 
            // bndnavbtnPesquisar
            // 
            this.bndnavbtnPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bndnavbtnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("bndnavbtnPesquisar.Image")));
            this.bndnavbtnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bndnavbtnPesquisar.Name = "bndnavbtnPesquisar";
            this.bndnavbtnPesquisar.Size = new System.Drawing.Size(23, 22);
            this.bndnavbtnPesquisar.Text = "toolStripButton2";
            this.bndnavbtnPesquisar.Click += new System.EventHandler(this.bndnavbtnPesquisar_Click);
            // 
            // frmExercicioBindNavigator_01_09082023
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 356);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmExercicioBindNavigator_01_09082023";
            this.Text = "Exercicio Bind Navigator 01 - 09/08/2023";
            this.Load += new System.EventHandler(this.frmExercicioBindNavigator_01_09082023_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdvwPreferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsrcPreferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndnavPreferencias)).EndInit();
            this.bndnavPreferencias.ResumeLayout(false);
            this.bndnavPreferencias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.BindingNavigator bndnavPreferencias;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bndnavbtnConfirmar;
        private System.Windows.Forms.ToolStripTextBox bndnavtxtPreferencias;
        private System.Windows.Forms.ToolStripButton bndnavbtnPesquisar;
        private System.Windows.Forms.DataGridView dtgdvwPreferencias;
        private System.Windows.Forms.ListBox lstbxPreferencias;
        private System.Windows.Forms.Button btnAlterarBD;
        private System.Windows.Forms.Button btnExcluirBD;
        private System.Windows.Forms.Button btnInserirBD;
        private System.Windows.Forms.Button btnConsultarBD;
        private System.Windows.Forms.Button btnDesconectadoBD;
        private System.Windows.Forms.Button btnConectadoBD;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDesvCond;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource bndsrcPreferencias;
    }
}

