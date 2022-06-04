namespace WindowsFormsApp2
{
    partial class btnSalvar
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.tbModeloCarro = new System.Windows.Forms.TextBox();
            this.lblModeloCarro = new System.Windows.Forms.Label();
            this.lblFabrica = new System.Windows.Forms.Label();
            this.tbFabricante = new System.Windows.Forms.TextBox();
            this.lblopção = new System.Windows.Forms.Label();
            this.lbOpcionais = new System.Windows.Forms.CheckedListBox();
            this.cbPortas = new System.Windows.Forms.ComboBox();
            this.lblPortas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(429, 306);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 42);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(294, 306);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(115, 42);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // tbModeloCarro
            // 
            this.tbModeloCarro.Location = new System.Drawing.Point(106, 16);
            this.tbModeloCarro.Name = "tbModeloCarro";
            this.tbModeloCarro.Size = new System.Drawing.Size(205, 20);
            this.tbModeloCarro.TabIndex = 2;
            // 
            // lblModeloCarro
            // 
            this.lblModeloCarro.AutoSize = true;
            this.lblModeloCarro.Location = new System.Drawing.Point(12, 19);
            this.lblModeloCarro.Name = "lblModeloCarro";
            this.lblModeloCarro.Size = new System.Drawing.Size(88, 13);
            this.lblModeloCarro.TabIndex = 3;
            this.lblModeloCarro.Text = "Modelo do Carro:";
            // 
            // lblFabrica
            // 
            this.lblFabrica.AutoSize = true;
            this.lblFabrica.Location = new System.Drawing.Point(12, 45);
            this.lblFabrica.Name = "lblFabrica";
            this.lblFabrica.Size = new System.Drawing.Size(91, 13);
            this.lblFabrica.TabIndex = 4;
            this.lblFabrica.Text = "Fabrica do Carro: ";
            // 
            // tbFabricante
            // 
            this.tbFabricante.Location = new System.Drawing.Point(106, 42);
            this.tbFabricante.Name = "tbFabricante";
            this.tbFabricante.Size = new System.Drawing.Size(205, 20);
            this.tbFabricante.TabIndex = 5;
            // 
            // lblopção
            // 
            this.lblopção.AutoSize = true;
            this.lblopção.Location = new System.Drawing.Point(12, 84);
            this.lblopção.Name = "lblopção";
            this.lblopção.Size = new System.Drawing.Size(54, 13);
            this.lblopção.TabIndex = 6;
            this.lblopção.Text = "Opcionais";
            // 
            // lbOpcionais
            // 
            this.lbOpcionais.FormattingEnabled = true;
            this.lbOpcionais.Items.AddRange(new object[] {
            "Ar condicionado",
            "Direção hidraulica",
            "Freios ABS",
            "Air bag",
            "Vidros eletricos"});
            this.lbOpcionais.Location = new System.Drawing.Point(106, 84);
            this.lbOpcionais.Name = "lbOpcionais";
            this.lbOpcionais.Size = new System.Drawing.Size(205, 79);
            this.lbOpcionais.TabIndex = 7;
            // 
            // cbPortas
            // 
            this.cbPortas.FormattingEnabled = true;
            this.cbPortas.Items.AddRange(new object[] {
            "2 portas",
            "3 portas",
            "4 portas",
            "5 portas"});
            this.cbPortas.Location = new System.Drawing.Point(106, 181);
            this.cbPortas.Name = "cbPortas";
            this.cbPortas.Size = new System.Drawing.Size(205, 21);
            this.cbPortas.TabIndex = 8;
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Location = new System.Drawing.Point(12, 189);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(56, 13);
            this.lblPortas.TabIndex = 9;
            this.lblPortas.Text = "Qtd portas";
            // 
            // btnSalvar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 370);
            this.Controls.Add(this.lblPortas);
            this.Controls.Add(this.cbPortas);
            this.Controls.Add(this.lbOpcionais);
            this.Controls.Add(this.lblopção);
            this.Controls.Add(this.tbFabricante);
            this.Controls.Add(this.lblFabrica);
            this.Controls.Add(this.lblModeloCarro);
            this.Controls.Add(this.tbModeloCarro);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Name = "btnSalvar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox tbModeloCarro;
        private System.Windows.Forms.Label lblModeloCarro;
        private System.Windows.Forms.Label lblFabrica;
        private System.Windows.Forms.TextBox tbFabricante;
        private System.Windows.Forms.Label lblopção;
        private System.Windows.Forms.CheckedListBox lbOpcionais;
        private System.Windows.Forms.ComboBox cbPortas;
        private System.Windows.Forms.Label lblPortas;
    }
}

