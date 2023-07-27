namespace TesteInicial_01_05072023
{
    partial class TesteInicial_01_05072023
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.btnDesvioCondicional = new System.Windows.Forms.Button();
            this.btnDesvioCondicionalAninhado = new System.Windows.Forms.Button();
            this.btnSwitchCase = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnForEach = new System.Windows.Forms.Button();
            this.lstbxPreferencias = new System.Windows.Forms.ListBox();
            this.btnBancoConectado = new System.Windows.Forms.Button();
            this.btnBancoDesconectado = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBancoDesconectado);
            this.tabPage1.Controls.Add(this.btnBancoConectado);
            this.tabPage1.Controls.Add(this.lstbxPreferencias);
            this.tabPage1.Controls.Add(this.btnForEach);
            this.tabPage1.Controls.Add(this.btnFor);
            this.tabPage1.Controls.Add(this.btnDoWhile);
            this.tabPage1.Controls.Add(this.btnWhile);
            this.tabPage1.Controls.Add(this.btnSwitchCase);
            this.tabPage1.Controls.Add(this.btnDesvioCondicionalAninhado);
            this.tabPage1.Controls.Add(this.btnDesvioCondicional);
            this.tabPage1.Controls.Add(this.btnMensagem);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 432);
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
            // btnMensagem
            // 
            this.btnMensagem.Location = new System.Drawing.Point(8, 15);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(220, 38);
            this.btnMensagem.TabIndex = 0;
            this.btnMensagem.Text = "Clique para Texto";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.btnMensagem_Click);
            // 
            // btnDesvioCondicional
            // 
            this.btnDesvioCondicional.Location = new System.Drawing.Point(8, 53);
            this.btnDesvioCondicional.Name = "btnDesvioCondicional";
            this.btnDesvioCondicional.Size = new System.Drawing.Size(220, 38);
            this.btnDesvioCondicional.TabIndex = 1;
            this.btnDesvioCondicional.Text = "Clique para Desvio Condicional";
            this.btnDesvioCondicional.UseVisualStyleBackColor = true;
            this.btnDesvioCondicional.Click += new System.EventHandler(this.btnDesvioCondicional_Click);
            // 
            // btnDesvioCondicionalAninhado
            // 
            this.btnDesvioCondicionalAninhado.Location = new System.Drawing.Point(8, 91);
            this.btnDesvioCondicionalAninhado.Name = "btnDesvioCondicionalAninhado";
            this.btnDesvioCondicionalAninhado.Size = new System.Drawing.Size(220, 38);
            this.btnDesvioCondicionalAninhado.TabIndex = 2;
            this.btnDesvioCondicionalAninhado.Text = "Clique para Desvio Condicional Aninhado";
            this.btnDesvioCondicionalAninhado.UseVisualStyleBackColor = true;
            this.btnDesvioCondicionalAninhado.Click += new System.EventHandler(this.btnDesvioCondicionalAninhado_Click);
            // 
            // btnSwitchCase
            // 
            this.btnSwitchCase.Location = new System.Drawing.Point(8, 129);
            this.btnSwitchCase.Name = "btnSwitchCase";
            this.btnSwitchCase.Size = new System.Drawing.Size(220, 38);
            this.btnSwitchCase.TabIndex = 3;
            this.btnSwitchCase.Text = "Clique para Switch Case";
            this.btnSwitchCase.UseVisualStyleBackColor = true;
            this.btnSwitchCase.Click += new System.EventHandler(this.btnSwitchCase_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(8, 167);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(220, 38);
            this.btnWhile.TabIndex = 4;
            this.btnWhile.Text = "Clique para importar texto while";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(8, 205);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(220, 38);
            this.btnDoWhile.TabIndex = 5;
            this.btnDoWhile.Text = "Clique para importar texto  do while";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(8, 243);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(220, 38);
            this.btnFor.TabIndex = 6;
            this.btnFor.Text = "Clique para importar texto for";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnForEach
            // 
            this.btnForEach.Location = new System.Drawing.Point(8, 281);
            this.btnForEach.Name = "btnForEach";
            this.btnForEach.Size = new System.Drawing.Size(220, 38);
            this.btnForEach.TabIndex = 7;
            this.btnForEach.Text = "Clique para importar texto foreach";
            this.btnForEach.UseVisualStyleBackColor = true;
            this.btnForEach.Click += new System.EventHandler(this.btnForEach_Click);
            // 
            // lstbxPreferencias
            // 
            this.lstbxPreferencias.FormattingEnabled = true;
            this.lstbxPreferencias.Location = new System.Drawing.Point(245, 15);
            this.lstbxPreferencias.Name = "lstbxPreferencias";
            this.lstbxPreferencias.Size = new System.Drawing.Size(281, 394);
            this.lstbxPreferencias.TabIndex = 8;
            // 
            // btnBancoConectado
            // 
            this.btnBancoConectado.Location = new System.Drawing.Point(8, 325);
            this.btnBancoConectado.Name = "btnBancoConectado";
            this.btnBancoConectado.Size = new System.Drawing.Size(220, 38);
            this.btnBancoConectado.TabIndex = 9;
            this.btnBancoConectado.Text = "Banco de Dados Conectado";
            this.btnBancoConectado.UseVisualStyleBackColor = true;
            this.btnBancoConectado.Click += new System.EventHandler(this.btnBancoConectado_Click);
            // 
            // btnBancoDesconectado
            // 
            this.btnBancoDesconectado.Location = new System.Drawing.Point(8, 369);
            this.btnBancoDesconectado.Name = "btnBancoDesconectado";
            this.btnBancoDesconectado.Size = new System.Drawing.Size(220, 38);
            this.btnBancoDesconectado.TabIndex = 10;
            this.btnBancoDesconectado.Text = "Banco de Dados Desconectado";
            this.btnBancoDesconectado.UseVisualStyleBackColor = true;
            this.btnBancoDesconectado.Click += new System.EventHandler(this.btnBancoDesconectado_Click);
            // 
            // TesteInicial_01_05072023
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 464);
            this.Controls.Add(this.tabControl1);
            this.Name = "TesteInicial_01_05072023";
            this.Text = "Teste Inicial 01 - 05/07/2023";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstbxPreferencias;
        private System.Windows.Forms.Button btnForEach;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnSwitchCase;
        private System.Windows.Forms.Button btnDesvioCondicionalAninhado;
        private System.Windows.Forms.Button btnDesvioCondicional;
        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBancoDesconectado;
        private System.Windows.Forms.Button btnBancoConectado;
    }
}

