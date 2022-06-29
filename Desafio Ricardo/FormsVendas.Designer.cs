namespace Desafio_vendas
{
    partial class FormVendas
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblQt = new System.Windows.Forms.Label();
            this.lblProdutoV = new System.Windows.Forms.Label();
            this.cbClienteV = new System.Windows.Forms.ComboBox();
            this.cbProd = new System.Windows.Forms.ComboBox();
            this.cbQt = new System.Windows.Forms.ComboBox();
            this.lbVendas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVaT = new System.Windows.Forms.Label();
            this.btCad = new System.Windows.Forms.Button();
            this.btEfV = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCliente.Location = new System.Drawing.Point(38, 70);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // lblQt
            // 
            this.lblQt.AutoSize = true;
            this.lblQt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQt.Location = new System.Drawing.Point(12, 146);
            this.lblQt.Name = "lblQt";
            this.lblQt.Size = new System.Drawing.Size(81, 13);
            this.lblQt.TabIndex = 1;
            this.lblQt.Text = "QUANTIDADE:";
            // 
            // lblProdutoV
            // 
            this.lblProdutoV.AutoSize = true;
            this.lblProdutoV.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProdutoV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProdutoV.Location = new System.Drawing.Point(29, 109);
            this.lblProdutoV.Name = "lblProdutoV";
            this.lblProdutoV.Size = new System.Drawing.Size(64, 13);
            this.lblProdutoV.TabIndex = 2;
            this.lblProdutoV.Text = "PRODUTO:";
            // 
            // cbClienteV
            // 
            this.cbClienteV.FormattingEnabled = true;
            this.cbClienteV.Location = new System.Drawing.Point(99, 62);
            this.cbClienteV.Name = "cbClienteV";
            this.cbClienteV.Size = new System.Drawing.Size(121, 21);
            this.cbClienteV.TabIndex = 3;
            // 
            // cbProd
            // 
            this.cbProd.FormattingEnabled = true;
            this.cbProd.Location = new System.Drawing.Point(99, 101);
            this.cbProd.Name = "cbProd";
            this.cbProd.Size = new System.Drawing.Size(121, 21);
            this.cbProd.TabIndex = 4;
            // 
            // cbQt
            // 
            this.cbQt.FormattingEnabled = true;
            this.cbQt.Location = new System.Drawing.Point(99, 138);
            this.cbQt.Name = "cbQt";
            this.cbQt.Size = new System.Drawing.Size(121, 21);
            this.cbQt.TabIndex = 5;
            // 
            // lbVendas
            // 
            this.lbVendas.FormattingEnabled = true;
            this.lbVendas.Location = new System.Drawing.Point(15, 211);
            this.lbVendas.Name = "lbVendas";
            this.lbVendas.Size = new System.Drawing.Size(477, 95);
            this.lbVendas.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "VENDAS";
            // 
            // lblVaT
            // 
            this.lblVaT.AutoSize = true;
            this.lblVaT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVaT.Location = new System.Drawing.Point(336, 70);
            this.lblVaT.Name = "lblVaT";
            this.lblVaT.Size = new System.Drawing.Size(84, 13);
            this.lblVaT.TabIndex = 8;
            this.lblVaT.Text = "VALOR TOTAL:";
            // 
            // btCad
            // 
            this.btCad.Location = new System.Drawing.Point(210, 182);
            this.btCad.Name = "btCad";
            this.btCad.Size = new System.Drawing.Size(81, 23);
            this.btCad.TabIndex = 9;
            this.btCad.Text = "CADASTRAR";
            this.btCad.UseVisualStyleBackColor = true;
            // 
            // btEfV
            // 
            this.btEfV.Location = new System.Drawing.Point(319, 182);
            this.btEfV.Name = "btEfV";
            this.btEfV.Size = new System.Drawing.Size(120, 23);
            this.btEfV.TabIndex = 10;
            this.btEfV.Text = "EFETUAR VENDA";
            this.btEfV.UseVisualStyleBackColor = true;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(426, 67);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 11;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(552, 318);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.btEfV);
            this.Controls.Add(this.btCad);
            this.Controls.Add(this.lblVaT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbVendas);
            this.Controls.Add(this.cbQt);
            this.Controls.Add(this.cbProd);
            this.Controls.Add(this.cbClienteV);
            this.Controls.Add(this.lblProdutoV);
            this.Controls.Add(this.lblQt);
            this.Controls.Add(this.lblCliente);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVendas";
            this.Text = "FormsVendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblQt;
        private System.Windows.Forms.Label lblProdutoV;
        private System.Windows.Forms.ComboBox cbClienteV;
        private System.Windows.Forms.ComboBox cbProd;
        private System.Windows.Forms.ComboBox cbQt;
        private System.Windows.Forms.ListBox lbVendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVaT;
        private System.Windows.Forms.Button btCad;
        private System.Windows.Forms.Button btEfV;
        private System.Windows.Forms.TextBox tbValor;
    }
}