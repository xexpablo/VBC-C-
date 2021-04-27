using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diasdasemana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboDiaSemana.Items.Add("Domingo");
            cboDiaSemana.Items.Add("Segunda-Feira");
            cboDiaSemana.Items.Add("Terça-Feira");
            cboDiaSemana.Items.Add("Quarta-Feira");
            cboDiaSemana.Items.Add("Quinta-Feira");
            cboDiaSemana.Items.Add("Sexta-Feira");
            cboDiaSemana.Items.Add("Sábado");
        }

        private void cboDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numReal = cboDiaSemana.SelectedIndex + 1;
            lblEscolhido.Text = numReal + " - " + cboDiaSemana.Text;
            switch (cboDiaSemana.SelectedIndex)
            {
                case 0:
                    picDiaSemana.Load("domingo.jpg");
                    break;
                case 1:
                    picDiaSemana.Load("segunda.jpg");
                    break;
                case 2:
                    picDiaSemana.Load("terça.jpg");
                    break;
                case 3:
                    picDiaSemana.Load("quarta.jpg");
                    break;
                case 4:
                    picDiaSemana.Load("quinta.png");
                    break;
                case 5:
                    picDiaSemana.Load("sexta.jpg");
                    break;
                case 6:
                    picDiaSemana.Load("sabado.jpg");
                    break;
                default:
                    picDiaSemana.Load("segunda.jpg");
                    break;
            }
        }
    }
}
