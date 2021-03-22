using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulainicial
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string anoAtual = Convert.ToString(txtAnoAtual.Text);
            string anoNascimento = Convert.ToString(txtNascimento.Text);
            if(Convert.ToInt32(txtAnoAtual.Text) > Convert.ToInt32(txtNascimento.Text)) { 
                int resultado = Convert.ToInt32(anoAtual) - Convert.ToInt32(anoNascimento);
                resultIdade.Text = Convert.ToString(resultado);
            }
            else
            {
                MessageBox.Show("ANO DE NASCIMENTO MAIOR QUE O ATUAL");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "") { 
                MessageBox.Show("Olá Mundo Merda, meu nome é " + txtNome.Text);
            }
            else
            {
                MessageBox.Show("Nome em Branco, Insira Seu Nome");
            }
        }
    }
}
