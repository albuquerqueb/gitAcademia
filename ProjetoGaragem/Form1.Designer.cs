namespace ProjetoGaragem
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
            this.BtCadastrar = new System.Windows.Forms.Button();
            this.LblPlaca = new System.Windows.Forms.Label();
            this.TbPlaca = new System.Windows.Forms.TextBox();
            this.LblDEntrada = new System.Windows.Forms.Label();
            this.LblDSaida = new System.Windows.Forms.Label();
            this.TbDEntrada = new System.Windows.Forms.TextBox();
            this.TbDSaida = new System.Windows.Forms.TextBox();
            this.LblHEntrada = new System.Windows.Forms.Label();
            this.LblHSaida = new System.Windows.Forms.Label();
            this.TbHEntrada = new System.Windows.Forms.TextBox();
            this.TbHSaida = new System.Windows.Forms.TextBox();
            this.BtSaida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.dataSet1 = new System.Data.DataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtCadastrar
            // 
            this.BtCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtCadastrar.Location = new System.Drawing.Point(5, 122);
            this.BtCadastrar.Name = "BtCadastrar";
            this.BtCadastrar.Size = new System.Drawing.Size(81, 23);
            this.BtCadastrar.TabIndex = 0;
            this.BtCadastrar.Text = "CADASTRAR";
            this.BtCadastrar.UseVisualStyleBackColor = false;
            // 
            // LblPlaca
            // 
            this.LblPlaca.AutoSize = true;
            this.LblPlaca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblPlaca.Location = new System.Drawing.Point(2, 77);
            this.LblPlaca.Name = "LblPlaca";
            this.LblPlaca.Size = new System.Drawing.Size(41, 13);
            this.LblPlaca.TabIndex = 1;
            this.LblPlaca.Text = "PLACA";
            // 
            // TbPlaca
            // 
            this.TbPlaca.Location = new System.Drawing.Point(5, 93);
            this.TbPlaca.Name = "TbPlaca";
            this.TbPlaca.Size = new System.Drawing.Size(100, 20);
            this.TbPlaca.TabIndex = 2;
            // 
            // LblDEntrada
            // 
            this.LblDEntrada.AutoSize = true;
            this.LblDEntrada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblDEntrada.Location = new System.Drawing.Point(136, 100);
            this.LblDEntrada.Name = "LblDEntrada";
            this.LblDEntrada.Size = new System.Drawing.Size(91, 13);
            this.LblDEntrada.TabIndex = 3;
            this.LblDEntrada.Text = "DATA ENTRADA";
            // 
            // LblDSaida
            // 
            this.LblDSaida.AutoSize = true;
            this.LblDSaida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblDSaida.Location = new System.Drawing.Point(138, 139);
            this.LblDSaida.Name = "LblDSaida";
            this.LblDSaida.Size = new System.Drawing.Size(71, 13);
            this.LblDSaida.TabIndex = 4;
            this.LblDSaida.Text = "DATA SAIDA";
            // 
            // TbDEntrada
            // 
            this.TbDEntrada.Location = new System.Drawing.Point(139, 116);
            this.TbDEntrada.Name = "TbDEntrada";
            this.TbDEntrada.Size = new System.Drawing.Size(100, 20);
            this.TbDEntrada.TabIndex = 5;
            // 
            // TbDSaida
            // 
            this.TbDSaida.Location = new System.Drawing.Point(139, 153);
            this.TbDSaida.Name = "TbDSaida";
            this.TbDSaida.Size = new System.Drawing.Size(100, 20);
            this.TbDSaida.TabIndex = 6;
            // 
            // LblHEntrada
            // 
            this.LblHEntrada.AutoSize = true;
            this.LblHEntrada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblHEntrada.Location = new System.Drawing.Point(136, 19);
            this.LblHEntrada.Name = "LblHEntrada";
            this.LblHEntrada.Size = new System.Drawing.Size(93, 13);
            this.LblHEntrada.TabIndex = 7;
            this.LblHEntrada.Text = "HORA ENTRADA";
            // 
            // LblHSaida
            // 
            this.LblHSaida.AutoSize = true;
            this.LblHSaida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblHSaida.Location = new System.Drawing.Point(136, 58);
            this.LblHSaida.Name = "LblHSaida";
            this.LblHSaida.Size = new System.Drawing.Size(73, 13);
            this.LblHSaida.TabIndex = 8;
            this.LblHSaida.Text = "HORA SAIDA";
            // 
            // TbHEntrada
            // 
            this.TbHEntrada.Location = new System.Drawing.Point(139, 35);
            this.TbHEntrada.Name = "TbHEntrada";
            this.TbHEntrada.Size = new System.Drawing.Size(100, 20);
            this.TbHEntrada.TabIndex = 9;
            // 
            // TbHSaida
            // 
            this.TbHSaida.Location = new System.Drawing.Point(139, 74);
            this.TbHSaida.Name = "TbHSaida";
            this.TbHSaida.Size = new System.Drawing.Size(100, 20);
            this.TbHSaida.TabIndex = 10;
            // 
            // BtSaida
            // 
            this.BtSaida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtSaida.Location = new System.Drawing.Point(5, 151);
            this.BtSaida.Name = "BtSaida";
            this.BtSaida.Size = new System.Drawing.Size(75, 23);
            this.BtSaida.TabIndex = 11;
            this.BtSaida.Text = "SAIDA";
            this.BtSaida.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(278, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lista de veiculos no estabelecimento";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(281, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 173);
            this.listBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(478, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lista de veiculos que sairam do estabecimento";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(481, 48);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(178, 173);
            this.listBox2.TabIndex = 15;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(2, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "MODELO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(704, 241);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtSaida);
            this.Controls.Add(this.TbHSaida);
            this.Controls.Add(this.TbHEntrada);
            this.Controls.Add(this.LblHSaida);
            this.Controls.Add(this.LblHEntrada);
            this.Controls.Add(this.TbDSaida);
            this.Controls.Add(this.TbDEntrada);
            this.Controls.Add(this.LblDSaida);
            this.Controls.Add(this.LblDEntrada);
            this.Controls.Add(this.TbPlaca);
            this.Controls.Add(this.LblPlaca);
            this.Controls.Add(this.BtCadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtCadastrar;
        private System.Windows.Forms.Label LblPlaca;
        private System.Windows.Forms.TextBox TbPlaca;
        private System.Windows.Forms.Label LblDEntrada;
        private System.Windows.Forms.Label LblDSaida;
        private System.Windows.Forms.TextBox TbDEntrada;
        private System.Windows.Forms.TextBox TbDSaida;
        private System.Windows.Forms.Label LblHEntrada;
        private System.Windows.Forms.Label LblHSaida;
        private System.Windows.Forms.TextBox TbHEntrada;
        private System.Windows.Forms.TextBox TbHSaida;
        private System.Windows.Forms.Button BtSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

