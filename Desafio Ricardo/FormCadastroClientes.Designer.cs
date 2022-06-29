namespace Desafio_vendas
{
    partial class FormCadastroClientes
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastrar1 = new System.Windows.Forms.Button();
            this.btListas = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_BancoDataSet = new Desafio_Ricardo.db_BancoDataSet();
            this.clienteTableAdapter = new Desafio_Ricardo.db_BancoDataSetTableAdapters.clienteTableAdapter();
            this.tbEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_BancoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(24, 219);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(18, 20);
            this.tbId.TabIndex = 0;
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(60, 94);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(153, 20);
            this.tbCpf.TabIndex = 1;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(84, 153);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(129, 20);
            this.tbTel.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(60, 125);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(153, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(60, 64);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(153, 20);
            this.tbNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNome.Location = new System.Drawing.Point(12, 71);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "NOME:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCpf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCpf.Location = new System.Drawing.Point(12, 101);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 6;
            this.lblCpf.Text = "CPF:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(12, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "EMAIL:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTelefone.Location = new System.Drawing.Point(12, 160);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(66, 13);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "TELEFONE:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblId.Location = new System.Drawing.Point(12, 185);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(54, 13);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "ESTADO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "CADASTRO DE CLIENTES";
            // 
            // btCadastrar1
            // 
            this.btCadastrar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btCadastrar1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCadastrar1.Location = new System.Drawing.Point(319, 58);
            this.btCadastrar1.Name = "btCadastrar1";
            this.btCadastrar1.Size = new System.Drawing.Size(146, 31);
            this.btCadastrar1.TabIndex = 11;
            this.btCadastrar1.Text = "CADASTRAR";
            this.btCadastrar1.UseVisualStyleBackColor = false;
            this.btCadastrar1.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btListas
            // 
            this.btListas.Location = new System.Drawing.Point(319, 123);
            this.btListas.Name = "btListas";
            this.btListas.Size = new System.Drawing.Size(146, 23);
            this.btListas.TabIndex = 12;
            this.btListas.Text = "IR PARA LISTAS";
            this.btListas.UseVisualStyleBackColor = true;
            // 
            // btHome
            // 
            this.btHome.Location = new System.Drawing.Point(319, 179);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(146, 23);
            this.btHome.TabIndex = 13;
            this.btHome.Text = "HOME";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 264);
            this.dataGridView1.TabIndex = 14;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.db_BancoDataSet;
            // 
            // db_BancoDataSet
            // 
            this.db_BancoDataSet.DataSetName = "db_BancoDataSet";
            this.db_BancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(72, 179);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(98, 20);
            this.tbEstado.TabIndex = 15;
            // 
            // FormCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(717, 495);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.btListas);
            this.Controls.Add(this.btCadastrar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.tbId);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroClientes";
            this.Text = "FormsCadastroCliente";
            this.Load += new System.EventHandler(this.FormCadastroClientes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_BancoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrar1;
        private System.Windows.Forms.Button btListas;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Desafio_Ricardo.db_BancoDataSet db_BancoDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Desafio_Ricardo.db_BancoDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbEstado;
    }
}