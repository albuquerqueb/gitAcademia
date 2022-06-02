namespace PrimeiroWinForms
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
            this.BTOK = new System.Windows.Forms.Button();
            this.BTCANCEL = new System.Windows.Forms.Button();
            this.TbNOME = new System.Windows.Forms.TextBox();
            this.LblNOME = new System.Windows.Forms.Label();
            this.lblEMAIL = new System.Windows.Forms.Label();
            this.TbEMAIL = new System.Windows.Forms.TextBox();
            this.LblSEXO = new System.Windows.Forms.Label();
            this.TbSEXO = new System.Windows.Forms.TextBox();
            this.LblEND = new System.Windows.Forms.Label();
            this.TbEND = new System.Windows.Forms.TextBox();
            this.LblTEEFONE = new System.Windows.Forms.Label();
            this.TbTELEFONE = new System.Windows.Forms.TextBox();
            this.LblBAI = new System.Windows.Forms.Label();
            this.TbBAI = new System.Windows.Forms.TextBox();
            this.LblCID = new System.Windows.Forms.Label();
            this.TbCID = new System.Windows.Forms.TextBox();
            this.LblMSG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTOK
            // 
            this.BTOK.Location = new System.Drawing.Point(91, 222);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(87, 38);
            this.BTOK.TabIndex = 0;
            this.BTOK.Text = "OK";
            this.BTOK.UseVisualStyleBackColor = true;
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // BTCANCEL
            // 
            this.BTCANCEL.Location = new System.Drawing.Point(192, 222);
            this.BTCANCEL.Name = "BTCANCEL";
            this.BTCANCEL.Size = new System.Drawing.Size(87, 41);
            this.BTCANCEL.TabIndex = 1;
            this.BTCANCEL.Text = "CANCELAR";
            this.BTCANCEL.UseVisualStyleBackColor = true;
            this.BTCANCEL.Click += new System.EventHandler(this.BTCANCEL_Click);
            // 
            // TbNOME
            // 
            this.TbNOME.Location = new System.Drawing.Point(60, 6);
            this.TbNOME.Name = "TbNOME";
            this.TbNOME.Size = new System.Drawing.Size(260, 20);
            this.TbNOME.TabIndex = 2;
            // 
            // LblNOME
            // 
            this.LblNOME.AutoSize = true;
            this.LblNOME.Location = new System.Drawing.Point(12, 13);
            this.LblNOME.Name = "LblNOME";
            this.LblNOME.Size = new System.Drawing.Size(42, 13);
            this.LblNOME.TabIndex = 3;
            this.LblNOME.Text = "NOME:";
            // 
            // lblEMAIL
            // 
            this.lblEMAIL.AutoSize = true;
            this.lblEMAIL.Location = new System.Drawing.Point(12, 41);
            this.lblEMAIL.Name = "lblEMAIL";
            this.lblEMAIL.Size = new System.Drawing.Size(42, 13);
            this.lblEMAIL.TabIndex = 4;
            this.lblEMAIL.Text = "EMAIL:";
            // 
            // TbEMAIL
            // 
            this.TbEMAIL.Location = new System.Drawing.Point(60, 34);
            this.TbEMAIL.Name = "TbEMAIL";
            this.TbEMAIL.Size = new System.Drawing.Size(260, 20);
            this.TbEMAIL.TabIndex = 5;
            // 
            // LblSEXO
            // 
            this.LblSEXO.AutoSize = true;
            this.LblSEXO.Location = new System.Drawing.Point(12, 65);
            this.LblSEXO.Name = "LblSEXO";
            this.LblSEXO.Size = new System.Drawing.Size(39, 13);
            this.LblSEXO.TabIndex = 6;
            this.LblSEXO.Text = "SEXO:";
            // 
            // TbSEXO
            // 
            this.TbSEXO.Location = new System.Drawing.Point(60, 58);
            this.TbSEXO.Name = "TbSEXO";
            this.TbSEXO.Size = new System.Drawing.Size(260, 20);
            this.TbSEXO.TabIndex = 7;
            // 
            // LblEND
            // 
            this.LblEND.AutoSize = true;
            this.LblEND.Location = new System.Drawing.Point(12, 123);
            this.LblEND.Name = "LblEND";
            this.LblEND.Size = new System.Drawing.Size(73, 13);
            this.LblEND.TabIndex = 8;
            this.LblEND.Text = "ENDEREÇO: ";
            // 
            // TbEND
            // 
            this.TbEND.Location = new System.Drawing.Point(91, 88);
            this.TbEND.Name = "TbEND";
            this.TbEND.Size = new System.Drawing.Size(229, 20);
            this.TbEND.TabIndex = 9;
            // 
            // LblTEEFONE
            // 
            this.LblTEEFONE.AutoSize = true;
            this.LblTEEFONE.Location = new System.Drawing.Point(12, 95);
            this.LblTEEFONE.Name = "LblTEEFONE";
            this.LblTEEFONE.Size = new System.Drawing.Size(69, 13);
            this.LblTEEFONE.TabIndex = 10;
            this.LblTEEFONE.Text = "TELEFONE: ";
            // 
            // TbTELEFONE
            // 
            this.TbTELEFONE.Location = new System.Drawing.Point(91, 116);
            this.TbTELEFONE.Name = "TbTELEFONE";
            this.TbTELEFONE.Size = new System.Drawing.Size(229, 20);
            this.TbTELEFONE.TabIndex = 11;
            // 
            // LblBAI
            // 
            this.LblBAI.AutoSize = true;
            this.LblBAI.Location = new System.Drawing.Point(12, 151);
            this.LblBAI.Name = "LblBAI";
            this.LblBAI.Size = new System.Drawing.Size(51, 13);
            this.LblBAI.TabIndex = 12;
            this.LblBAI.Text = "BAIRRO:";
            // 
            // TbBAI
            // 
            this.TbBAI.Location = new System.Drawing.Point(91, 144);
            this.TbBAI.Name = "TbBAI";
            this.TbBAI.Size = new System.Drawing.Size(229, 20);
            this.TbBAI.TabIndex = 13;
            // 
            // LblCID
            // 
            this.LblCID.AutoSize = true;
            this.LblCID.Location = new System.Drawing.Point(12, 181);
            this.LblCID.Name = "LblCID";
            this.LblCID.Size = new System.Drawing.Size(53, 13);
            this.LblCID.TabIndex = 14;
            this.LblCID.Text = "CIDADE: ";
            // 
            // TbCID
            // 
            this.TbCID.Location = new System.Drawing.Point(91, 174);
            this.TbCID.Name = "TbCID";
            this.TbCID.Size = new System.Drawing.Size(229, 20);
            this.TbCID.TabIndex = 15;
            // 
            // LblMSG
            // 
            this.LblMSG.AutoSize = true;
            this.LblMSG.Location = new System.Drawing.Point(189, 348);
            this.LblMSG.Name = "LblMSG";
            this.LblMSG.Size = new System.Drawing.Size(0, 13);
            this.LblMSG.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 294);
            this.Controls.Add(this.LblMSG);
            this.Controls.Add(this.TbCID);
            this.Controls.Add(this.LblCID);
            this.Controls.Add(this.TbBAI);
            this.Controls.Add(this.LblBAI);
            this.Controls.Add(this.TbTELEFONE);
            this.Controls.Add(this.LblTEEFONE);
            this.Controls.Add(this.TbEND);
            this.Controls.Add(this.LblEND);
            this.Controls.Add(this.TbSEXO);
            this.Controls.Add(this.LblSEXO);
            this.Controls.Add(this.TbEMAIL);
            this.Controls.Add(this.lblEMAIL);
            this.Controls.Add(this.LblNOME);
            this.Controls.Add(this.TbNOME);
            this.Controls.Add(this.BTCANCEL);
            this.Controls.Add(this.BTOK);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTOK;
        private System.Windows.Forms.Button BTCANCEL;
        private System.Windows.Forms.TextBox TbNOME;
        private System.Windows.Forms.Label LblNOME;
        private System.Windows.Forms.Label lblEMAIL;
        private System.Windows.Forms.TextBox TbEMAIL;
        private System.Windows.Forms.Label LblSEXO;
        private System.Windows.Forms.TextBox TbSEXO;
        private System.Windows.Forms.Label LblEND;
        private System.Windows.Forms.TextBox TbEND;
        private System.Windows.Forms.Label LblTEEFONE;
        private System.Windows.Forms.TextBox TbTELEFONE;
        private System.Windows.Forms.Label LblBAI;
        private System.Windows.Forms.TextBox TbBAI;
        private System.Windows.Forms.Label LblCID;
        private System.Windows.Forms.TextBox TbCID;
        private System.Windows.Forms.Label LblMSG;
    }
}

