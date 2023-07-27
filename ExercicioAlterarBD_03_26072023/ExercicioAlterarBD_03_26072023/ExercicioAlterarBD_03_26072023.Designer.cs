namespace ExercicioAlterarBD_03_26072023
{
    partial class ExercicioAlterarBD_03_26072023
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgdvwPreferencias = new System.Windows.Forms.DataGridView();
            this.lstbxPreferencias = new System.Windows.Forms.ListBox();
            this.btnAlterarBD = new System.Windows.Forms.Button();
            this.btnExcluirBD = new System.Windows.Forms.Button();
            this.btnInserirBD = new System.Windows.Forms.Button();
            this.btnConsultarBD = new System.Windows.Forms.Button();
            this.btnBancoDesconectado = new System.Windows.Forms.Button();
            this.btnBancoConectado = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDesvCond = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdvwPreferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(489, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgdvwPreferencias);
            this.tabPage1.Controls.Add(this.lstbxPreferencias);
            this.tabPage1.Controls.Add(this.btnAlterarBD);
            this.tabPage1.Controls.Add(this.btnExcluirBD);
            this.tabPage1.Controls.Add(this.btnInserirBD);
            this.tabPage1.Controls.Add(this.btnConsultarBD);
            this.tabPage1.Controls.Add(this.btnBancoDesconectado);
            this.tabPage1.Controls.Add(this.btnBancoConectado);
            this.tabPage1.Controls.Add(this.btnWhile);
            this.tabPage1.Controls.Add(this.btnDesvCond);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(481, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Preferencias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgdvwPreferencias
            // 
            this.dtgdvwPreferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdvwPreferencias.Location = new System.Drawing.Point(215, 207);
            this.dtgdvwPreferencias.Name = "dtgdvwPreferencias";
            this.dtgdvwPreferencias.Size = new System.Drawing.Size(263, 175);
            this.dtgdvwPreferencias.TabIndex = 9;
            this.dtgdvwPreferencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdvwPreferencias_CellClick);
            // 
            // lstbxPreferencias
            // 
            this.lstbxPreferencias.FormattingEnabled = true;
            this.lstbxPreferencias.Location = new System.Drawing.Point(215, 0);
            this.lstbxPreferencias.Name = "lstbxPreferencias";
            this.lstbxPreferencias.Size = new System.Drawing.Size(263, 173);
            this.lstbxPreferencias.TabIndex = 8;
            // 
            // btnAlterarBD
            // 
            this.btnAlterarBD.Location = new System.Drawing.Point(0, 339);
            this.btnAlterarBD.Name = "btnAlterarBD";
            this.btnAlterarBD.Size = new System.Drawing.Size(209, 44);
            this.btnAlterarBD.TabIndex = 7;
            this.btnAlterarBD.Text = "Clique para Alterar no Banco de Dados";
            this.btnAlterarBD.UseVisualStyleBackColor = true;
            this.btnAlterarBD.Click += new System.EventHandler(this.btnAlterarBD_Click);
            // 
            // btnExcluirBD
            // 
            this.btnExcluirBD.Location = new System.Drawing.Point(0, 295);
            this.btnExcluirBD.Name = "btnExcluirBD";
            this.btnExcluirBD.Size = new System.Drawing.Size(209, 44);
            this.btnExcluirBD.TabIndex = 6;
            this.btnExcluirBD.Text = "Clique para Excluir no Banco de Dados";
            this.btnExcluirBD.UseVisualStyleBackColor = true;
            this.btnExcluirBD.Click += new System.EventHandler(this.btnExcluirBD_Click);
            // 
            // btnInserirBD
            // 
            this.btnInserirBD.Location = new System.Drawing.Point(0, 251);
            this.btnInserirBD.Name = "btnInserirBD";
            this.btnInserirBD.Size = new System.Drawing.Size(209, 44);
            this.btnInserirBD.TabIndex = 5;
            this.btnInserirBD.Text = "Clique para Inserir no Banco de Dados";
            this.btnInserirBD.UseVisualStyleBackColor = true;
            this.btnInserirBD.Click += new System.EventHandler(this.btnInserirBD_Click);
            // 
            // btnConsultarBD
            // 
            this.btnConsultarBD.Location = new System.Drawing.Point(0, 207);
            this.btnConsultarBD.Name = "btnConsultarBD";
            this.btnConsultarBD.Size = new System.Drawing.Size(209, 44);
            this.btnConsultarBD.TabIndex = 4;
            this.btnConsultarBD.Text = "Clique para Consultar Banco de Dados";
            this.btnConsultarBD.UseVisualStyleBackColor = true;
            this.btnConsultarBD.Click += new System.EventHandler(this.btnConsultarBD_Click);
            // 
            // btnBancoDesconectado
            // 
            this.btnBancoDesconectado.Location = new System.Drawing.Point(0, 132);
            this.btnBancoDesconectado.Name = "btnBancoDesconectado";
            this.btnBancoDesconectado.Size = new System.Drawing.Size(209, 44);
            this.btnBancoDesconectado.TabIndex = 3;
            this.btnBancoDesconectado.Text = "Clique para Banco de Dados Desconectado";
            this.btnBancoDesconectado.UseVisualStyleBackColor = true;
            this.btnBancoDesconectado.Click += new System.EventHandler(this.btnBancoDesconectado_Click);
            // 
            // btnBancoConectado
            // 
            this.btnBancoConectado.Location = new System.Drawing.Point(0, 88);
            this.btnBancoConectado.Name = "btnBancoConectado";
            this.btnBancoConectado.Size = new System.Drawing.Size(209, 44);
            this.btnBancoConectado.TabIndex = 2;
            this.btnBancoConectado.Text = "Clique para Banco de Dados Conectado";
            this.btnBancoConectado.UseVisualStyleBackColor = true;
            this.btnBancoConectado.Click += new System.EventHandler(this.btnBancoConectado_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(0, 44);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(209, 44);
            this.btnWhile.TabIndex = 1;
            this.btnWhile.Text = "Clique para importar texto while";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDesvCond
            // 
            this.btnDesvCond.Location = new System.Drawing.Point(0, 0);
            this.btnDesvCond.Name = "btnDesvCond";
            this.btnDesvCond.Size = new System.Drawing.Size(209, 44);
            this.btnDesvCond.TabIndex = 0;
            this.btnDesvCond.Text = "Clique para Escolha";
            this.btnDesvCond.UseVisualStyleBackColor = true;
            this.btnDesvCond.Click += new System.EventHandler(this.btnDesvCond_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(481, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ExercicioAlterarBD_03_26072023
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 408);
            this.Controls.Add(this.tabControl1);
            this.Name = "ExercicioAlterarBD_03_26072023";
            this.Text = "Exercicio Alterar BD 03 - 26/07/2023";
            this.Load += new System.EventHandler(this.ExercicioAlterarBD_03_26072023_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdvwPreferencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgdvwPreferencias;
        private System.Windows.Forms.ListBox lstbxPreferencias;
        private System.Windows.Forms.Button btnAlterarBD;
        private System.Windows.Forms.Button btnExcluirBD;
        private System.Windows.Forms.Button btnInserirBD;
        private System.Windows.Forms.Button btnConsultarBD;
        private System.Windows.Forms.Button btnBancoDesconectado;
        private System.Windows.Forms.Button btnBancoConectado;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDesvCond;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

