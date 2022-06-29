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
    public partial class FormCadastroProdutos : Form
    {
        public FormCadastroProdutos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// click do botao para cadastrar os produtos no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCadastrarProdutos_Click(object sender, EventArgs e)
        {
            Produto c = new Produto
            {
                CodEAN = tbCodE.Text,
                Nome = tbNomeP.Text,
                Preco = tbPreco.Text,
                Estoque = tbEstoque.Text,

            };
            if (String.IsNullOrEmpty(tbNomeP.Text))
            {
                MessageBox.Show("Preenchimento obrigatorio");
            }
            else
            {
                bool ok = c.gravarProduto();
                if (ok) // testa se conseguiu gravar o produto
                {
                    MessageBox.Show("Produto cadastrado com sucesso");

                    this.produtoTableAdapter.Fill(this.db_BancoDataSet1.produto);
                    tbCodE.Clear();
                    tbNomeP.Clear();
                    tbPreco.Clear();
                    tbEstoque.Clear();

                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCadastroProdutos_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_BancoDataSet1.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.db_BancoDataSet1.produto);

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btHome1_Click(object sender, EventArgs e)
        {

        }
    }
}