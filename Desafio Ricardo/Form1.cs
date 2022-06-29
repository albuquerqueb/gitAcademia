using Desafio_vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Ricardo
{
    public partial class Form1 : Form
    {
        private Form frmAtivo;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// método que faz passar de um formulário para o outro
        /// </summary>
        /// <param name="frm"></param>
        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            pnHome.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        /// <summary>
        /// método para quando clicar em uma formulário fechar o outro
        /// </summary>
        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }
        /// <summary>
        /// método para mudar de cor a parte do menu selecionada
        /// </summary>
        /// <param name="frmAtivo"></param>
        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in pnHome.Controls)
            {
                ctrl.ForeColor = Color.Black;
            }

        }

        private void btCadastrarC_Click(object sender, EventArgs e)
        {
            ActiveButton(btCadastrarC);
            FormShow(new FormCadastroClientes());
        }

        private void btCadastrarP_Click(object sender, EventArgs e)
        {
            ActiveButton(btCadastrarP);
            FormShow(new FormCadastroProdutos());
        }

        private void btVendas_Click_1(object sender, EventArgs e)
        {
            ActiveButton(btVendas);
            FormShow(new FormVendas());
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AGRADECEMOS SUA CONFIANÇA!! \n VOLTE SEMPRE!");
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnHome_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
