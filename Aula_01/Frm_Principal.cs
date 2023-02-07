using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_01
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", 
                                "Aula 01", 
                                MessageBoxButtons.YesNo, 
                             MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btn_Mensagem_Click(object sender, EventArgs e)
        {
            lbl_Mensagem.Text = "Bem vindo ao C#";
            lbl_Mensagem.ForeColor = Color.Red;

            btn_Mensagem.Enabled = false;
            btn_Limpar.Enabled = true;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            //Limpa o Texto da Lbl_Mensagem
            lbl_Mensagem.Text = "";

            //Ativa e Desativa os botões
            btn_Limpar.Enabled = false;
            btn_Mensagem.Enabled = true;
        }
    }
}
