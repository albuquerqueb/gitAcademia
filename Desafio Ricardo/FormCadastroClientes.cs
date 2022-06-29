using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_vendas
{
    public partial class FormCadastroClientes : Form
    {
        public FormCadastroClientes()
        {
            InitializeComponent();
        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// click do botao para cadastrar os clientes no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente
            {
                Cpf = tbCpf.Text,
                Email = tbEmail.Text,
                Nome = tbNome.Text,
                Telefone = tbTel.Text,
                Estado = tbEstado.Text
            };
            if (String.IsNullOrEmpty(tbNome.Text))
            {
                MessageBox.Show("Preenchimento obrigatorio");
            }
            else
            {
                bool ok = c.gravarPessoa();
                if (ok) // testa se conseguiu gravar um cliente
                {
                    MessageBox.Show("Cliente cadastrado com sucesso");
                    this.clienteTableAdapter.Fill(this.db_BancoDataSet.cliente);
                    tbCpf.Clear();
                    tbNome.Clear();
                    tbTel.Clear();
                    tbEmail.Clear();
                }
                else
                {
                    MessageBox.Show("Cliente não cadastrado");
                }
            }
        }




        private void dgCadastroClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCadastroClientes_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_BancoDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.db_BancoDataSet.cliente);

        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}