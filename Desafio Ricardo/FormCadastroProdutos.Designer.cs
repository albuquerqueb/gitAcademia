namespace Desafio_vendas
{
    partial class FormCadastroProdutos
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
            this.lblIdProdu = new System.Windows.Forms.Label();
            this.lblCodE = new System.Windows.Forms.Label();
            this.lblNomeP = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.tbCodE = new System.Windows.Forms.TextBox();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.tbNomeP = new System.Windows.Forms.TextBox();
            this.tbEstoque = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btListas1 = new System.Windows.Forms.Button();
            this.btHome1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_BancoDataSet1 = new Desafio_Ricardo.db_BancoDataSet1();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new Desafio_Ricardo.db_BancoDataSet1TableAdapters.produtoTableAdapter();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbIdProdu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_BancoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdProdu
            // 
            this.lblIdProdu.AutoSize = true;
            this.lblIdProdu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdProdu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIdProdu.Location = new System.Drawing.Point(12, 57);
            this.lblIdProdu.Name = "lblIdProdu";
            this.lblIdProdu.Size = new System.Drawing.Size(78, 13);
            this.lblIdProdu.TabIndex = 0;
            this.lblIdProdu.Text = "ID PRODUTO:";
            // 
            // lblCodE
            // 
            this.lblCodE.AutoSize = true;
            this.lblCodE.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodE.Location = new System.Drawing.Point(12, 95);
            this.lblCodE.Name = "lblCodE";
            this.lblCodE.Size = new System.Drawing.Size(51, 13);
            this.lblCodE.TabIndex = 1;
            this.lblCodE.Text = "CodEAN:";
            // 
            // lblNomeP
            // 
            this.lblNomeP.AutoSize = true;
            this.lblNomeP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomeP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNomeP.Location = new System.Drawing.Point(12, 135);
            this.lblNomeP.Name = "lblNomeP";
            this.lblNomeP.Size = new System.Drawing.Size(99, 13);
            this.lblNomeP.TabIndex = 2;
            this.lblNomeP.Text = "NOME PRODUTO:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPreco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPreco.Location = new System.Drawing.Point(12, 166);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(50, 13);
            this.lblPreco.TabIndex = 3;
            this.lblPreco.Text = "PREÇO: ";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEstoque.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEstoque.Location = new System.Drawing.Point(12, 198);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(65, 13);
            this.lblEstoque.TabIndex = 4;
            this.lblEstoque.Text = "ESTOQUE: ";
            // 
            // tbCodE
            // 
            this.tbCodE.BackColor = System.Drawing.SystemColors.Window;
            this.tbCodE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCodE.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbCodE.Location = new System.Drawing.Point(119, 95);
            this.tbCodE.Name = "tbCodE";
            this.tbCodE.Size = new System.Drawing.Size(137, 13);
            this.tbCodE.TabIndex = 6;
            // 
            // tbPreco
            // 
            this.tbPreco.BackColor = System.Drawing.SystemColors.Window;
            this.tbPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPreco.Location = new System.Drawing.Point(119, 166);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(137, 13);
            this.tbPreco.TabIndex = 7;
            // 
            // tbNomeP
            // 
            this.tbNomeP.BackColor = System.Drawing.SystemColors.Window;
            this.tbNomeP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNomeP.Location = new System.Drawing.Point(119, 135);
            this.tbNomeP.Name = "tbNomeP";
            this.tbNomeP.Size = new System.Drawing.Size(137, 13);
            this.tbNomeP.TabIndex = 8;
            // 
            // tbEstoque
            // 
            this.tbEstoque.BackColor = System.Drawing.SystemColors.Window;
            this.tbEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEstoque.Location = new System.Drawing.Point(119, 198);
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.Size = new System.Drawing.Size(137, 13);
            this.tbEstoque.TabIndex = 9;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(361, 75);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(121, 23);
            this.btCadastrar.TabIndex = 10;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = true;
            // 
            // btListas1
            // 
            this.btListas1.Location = new System.Drawing.Point(361, 125);
            this.btListas1.Name = "btListas1";
            this.btListas1.Size = new System.Drawing.Size(121, 23);
            this.btListas1.TabIndex = 11;
            this.btListas1.Text = "IR PARA LISTAS";
            this.btListas1.UseVisualStyleBackColor = true;
            // 
            // btHome1
            // 
            this.btHome1.Location = new System.Drawing.Point(361, 188);
            this.btHome1.Name = "btHome1";
            this.btHome1.Size = new System.Drawing.Size(121, 23);
            this.btHome1.TabIndex = 12;
            this.btHome1.Text = "HOME";
            this.btHome1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(97, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "CADASTRAR PRODUTOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.codProdutoDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(16, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 262);
            this.dataGridView1.TabIndex = 15;
            // 
            // db_BancoDataSet1
            // 
            this.db_BancoDataSet1.DataSetName = "db_BancoDataSet1";
            this.db_BancoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.db_BancoDataSet1;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codProdutoDataGridViewTextBoxColumn
            // 
            this.codProdutoDataGridViewTextBoxColumn.DataPropertyName = "codProduto";
            this.codProdutoDataGridViewTextBoxColumn.HeaderText = "codProduto";
            this.codProdutoDataGridViewTextBoxColumn.Name = "codProdutoDataGridViewTextBoxColumn";
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "nomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "nomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "estoque";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // tbIdProdu
            // 
            this.tbIdProdu.Location = new System.Drawing.Point(119, 57);
            this.tbIdProdu.Name = "tbIdProdu";
            this.tbIdProdu.Size = new System.Drawing.Size(137, 20);
            this.tbIdProdu.TabIndex = 16;
            // 
            // FormCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(717, 495);
            this.Controls.Add(this.tbIdProdu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btHome1);
            this.Controls.Add(this.btListas1);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbEstoque);
            this.Controls.Add(this.tbNomeP);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.tbCodE);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNomeP);
            this.Controls.Add(this.lblCodE);
            this.Controls.Add(this.lblIdProdu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroProdutos";
            this.Text = "FormCadastroProdutos";
            this.Load += new System.EventHandler(this.FormCadastroProdutos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_BancoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdProdu;
        private System.Windows.Forms.Label lblCodE;
        private System.Windows.Forms.Label lblNomeP;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox tbCodE;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.TextBox tbNomeP;
        private System.Windows.Forms.TextBox tbEstoque;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btListas1;
        private System.Windows.Forms.Button btHome1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Desafio_Ricardo.db_BancoDataSet1 db_BancoDataSet1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private Desafio_Ricardo.db_BancoDataSet1TableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbIdProdu;
    }
}