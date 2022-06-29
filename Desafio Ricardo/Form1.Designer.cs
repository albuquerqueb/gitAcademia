namespace Desafio_Ricardo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCadastrarC = new System.Windows.Forms.Button();
            this.btCadastrarP = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btVendas = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnHome = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCadastrarC
            // 
            this.btCadastrarC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btCadastrarC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCadastrarC.Location = new System.Drawing.Point(12, 105);
            this.btCadastrarC.Name = "btCadastrarC";
            this.btCadastrarC.Size = new System.Drawing.Size(137, 35);
            this.btCadastrarC.TabIndex = 0;
            this.btCadastrarC.Text = "CADASTRAR CLIENTES";
            this.btCadastrarC.UseVisualStyleBackColor = false;
            this.btCadastrarC.Click += new System.EventHandler(this.btCadastrarC_Click);
            // 
            // btCadastrarP
            // 
            this.btCadastrarP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btCadastrarP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCadastrarP.Location = new System.Drawing.Point(12, 146);
            this.btCadastrarP.Name = "btCadastrarP";
            this.btCadastrarP.Size = new System.Drawing.Size(137, 46);
            this.btCadastrarP.TabIndex = 1;
            this.btCadastrarP.Text = "CADASTRAR PRODUTOS";
            this.btCadastrarP.UseVisualStyleBackColor = false;
            this.btCadastrarP.Click += new System.EventHandler(this.btCadastrarP_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btConsultar.Location = new System.Drawing.Point(12, 198);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(137, 23);
            this.btConsultar.TabIndex = 2;
            this.btConsultar.Text = "CONSULTAR";
            this.btConsultar.UseVisualStyleBackColor = false;
            // 
            // btVendas
            // 
            this.btVendas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btVendas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btVendas.Location = new System.Drawing.Point(12, 227);
            this.btVendas.Name = "btVendas";
            this.btVendas.Size = new System.Drawing.Size(137, 23);
            this.btVendas.TabIndex = 3;
            this.btVendas.Text = "VENDAS";
            this.btVendas.UseVisualStyleBackColor = false;
            this.btVendas.Click += new System.EventHandler(this.btVendas_Click_1);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSair.Location = new System.Drawing.Point(12, 256);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(137, 23);
            this.btSair.TabIndex = 4;
            this.btSair.Text = "SAIR";
            this.btSair.UseVisualStyleBackColor = false;
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.btCadastrarC);
            this.pnMenu.Controls.Add(this.btSair);
            this.pnMenu.Controls.Add(this.btCadastrarP);
            this.pnMenu.Controls.Add(this.btVendas);
            this.pnMenu.Controls.Add(this.btConsultar);
            this.pnMenu.Location = new System.Drawing.Point(0, 1);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(152, 495);
            this.pnMenu.TabIndex = 5;
            // 
            // pnHome
            // 
            this.pnHome.Location = new System.Drawing.Point(155, 1);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(802, 495);
            this.pnHome.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(962, 495);
            this.Controls.Add(this.pnHome);
            this.Controls.Add(this.pnMenu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.Text = "Tabela Cadastro";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarC;
        private System.Windows.Forms.Button btCadastrarP;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btVendas;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnHome;
    }
}

