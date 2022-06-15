using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTOK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei no botão OK");
            MessageBox.Show("Nome: " + TbNOME.Text + "\ne-mail: " + TbEMAIL.Text + "\nEndereço: " + TbEND.Text + "\nBairro: " + TbBAI.Text + "\nCidade: " + TbCID.Text + "\nTelefone: " + TbTELEFONE.Text);
            MessageBox.Show("Cadastro efetuado!");
            TbNOME.Clear();
            TbEMAIL.Clear();
            TbEND.Clear();
            TbBAI.Clear();
            TbCID.Clear();
            TbCID.Clear();
            LblMSG.Text = "CADASTRO EFETUADO COM SUCESSO! INSIRA UM NOVO REGISTRO!";
        }

        private void BTCANCEL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigada");
        }
        private void Forml_load(object sender, EventArgs e)
        {
            MessageBox.Show("BEM VINDO A ESSE LINDO PROGRAMA");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


