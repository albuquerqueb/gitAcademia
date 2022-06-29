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
    public partial class FormVendas : Form
    {
        private Venda _venda = new Venda();

        public FormVendas()
        {
            InitializeComponent();
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
     
            cbClienteV.Text = "1";
            cbProd.SelectedItem = null;
            cbProd.Text = "Selecione";
            cbClienteV.SelectedItem = null;
            cbClienteV.Text = "Selecione";

        }
        /// <summary>
        /// click do botão de cadastrar as vendas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCadastrarVendas_Click(object sender, EventArgs e)
        {
            if (cbProd.SelectedValue == null)  //testa se o combobox de produto está nulo
            {
                MessageBox.Show("Selecione um produto");
                return;
            }

            if (cbClienteV.SelectedValue == null) //testa se o combobox de cliente está nulo
            {
                MessageBox.Show("Selecione um cliente");
                return;
            }

            int idProduto = Convert.ToInt32(cbProd.SelectedValue);
            string nomeProduto = cbProd.GetItemText(cbProd.SelectedItem);
            int quantidade = Convert.ToInt32(tbValor.Text);
            DataRowView oDataRowView = cbProd.SelectedItem as DataRowView;
            decimal precoProduto = (decimal)(oDataRowView.Row["preco"]);
            int estoque = (int)(oDataRowView.Row["estoque"]);

            if (quantidade == 0)  // testa se a quantidade é igual a 0
            {
                MessageBox.Show("Quantidade de produtos inválida");
                return;
            }

            if (quantidade > estoque) // testa se a quantidade é maior que o estoque
            {
                MessageBox.Show("Quantidade de items acima do estoque!");
                return;
            }
            var itemExistente = _venda.ItemVendas.FirstOrDefault(i => i.IdProduto == idProduto);
            if (itemExistente != null)
            {
                int index = _venda.ItemVendas.IndexOf(itemExistente);
                itemExistente.Quantidade = quantidade;
                itemExistente.PrecoTotal = precoProduto * quantidade;
                _venda.ItemVendas[index] = itemExistente;
                RefreshListBox();
            }
            else
            {
                var itemVenda = new ItemVenda
                {
                    IdProduto = idProduto,
                    NomeProduto = nomeProduto,
                    Quantidade = quantidade,
                    PrecoTotal = precoProduto * quantidade,
                    PrecoUnitario = precoProduto
                };
                _venda.ItemVendas.Add(itemVenda);
                RefreshListBox();
            }
            tbValor.Text = $"R$ {_venda.ValorTotalVenda}";
            MessageBox.Show("Item adicionado a venda");
            cbClienteV.Enabled = false;
        }
        /// <summary>
        /// método que atualiza o listbox de vendas
        /// </summary>
        private void RefreshListBox()
        {
            lbVendas.Items.Clear(); // limpa o listbox de vendas
            foreach (var itemVenda in _venda.ItemVendas)
            {
                lbVendas.Items.Add($" Nome do Produto: {itemVenda.NomeProduto} - Quantidade: {itemVenda.Quantidade} - Preço Unitário: R$ {itemVenda.PrecoUnitario} - Valor Total:  R$ {itemVenda.PrecoTotal}");
            }
        }
        /// <summary>
        /// click do botão de efetuar as vendas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonEfetuarVenda_Click(object sender, EventArgs e)
        {
            if (_venda.ItemVendas.Count == 0) //testa se a quantidade de item venda é igual a 0
            {
                MessageBox.Show("Voce precisa adicionar pelo um produto");
                return;
            }
            int idCliente = Convert.ToInt32(cbClienteV.SelectedValue);
            string nomeCliente = cbClienteV.GetItemText(cbClienteV.SelectedItem);
            _venda.IdCliente = idCliente;
            _venda.NomeCliente = nomeCliente;
            bool sucesso = _venda.gravarVenda();
            if (sucesso)
            {
                MessageBox.Show("Venda efetuada com sucesso");
                this.RefreshForm();
            }
            else
            {
                MessageBox.Show("Ocorreu algum problema na efetuação da venda");
            }
        }
        /// <summary>
        /// método que atualiza o formulário de vendas
        /// </summary>
        public void RefreshForm()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            tbValor.Text = "1";
            cbProd.SelectedItem = null;
            cbProd.Text = "Selecione";
            cbClienteV.Text = "Selecione";
            cbClienteV.SelectedItem = null;


        }
    }
}