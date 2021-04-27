using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSelecao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDiaSemana_TextChanged(object sender, EventArgs e)
        {
            byte dia;

            if(String.IsNullOrEmpty(txtDiaSemana.Text) == false)
            {
                dia = Convert.ToByte(txtDiaSemana.Text);
                if(dia == 1)
                {
                    lblDiaSemana.Text = "- Domingo";
                }else if(dia == 2)
                {
                    lblDiaSemana.Text = "- Segunda";
                }else if(dia == 3)
                {
                    lblDiaSemana.Text = "- Terça";
                }else if(dia == 4)
                {
                    lblDiaSemana.Text = "- Quarta";
                }else if(dia == 5)
                {
                    lblDiaSemana.Text = "- Quinta";
                }else if(dia == 6)
                {
                    lblDiaSemana.Text = "- Sexta";
                }else if(dia == 7)
                {
                    lblDiaSemana.Text = "- Sábado";
                }else if(dia < 1 || dia > 7)
                {
                    lblDiaSemana.Text = "- Invalido";
                }else
                {
                    lblDiaSemana.Text = "- Aguardando";
                }
            }
        }
    }
}
