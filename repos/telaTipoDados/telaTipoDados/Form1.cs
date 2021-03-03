using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telaTipoDados
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;   
            if(txtA.Text != "" && txtB.Text != "")
            {
                try
                {
                    a = Convert.ToInt32(txtA.Text);
                    b = Convert.ToInt32(txtB.Text);
                }
                catch (Exception)
                {
                    if (!Regex.IsMatch(txtA.Text, @"^\d+$") && !Regex.IsMatch(txtB.Text, @"^\d+$"))
                    {
                        MessageBox.Show("A e B tem que ser INTEIRO" + " " + txtA.Text + " " + txtB.Text);
                    }
                    else if (!Regex.IsMatch(txtB.Text, @"^\d+$"))
                    {
                        MessageBox.Show("B tem que ser INTEIRO" + " " + txtB.Text);
                    }
                    else if (!Regex.IsMatch(txtA.Text, @"^\d+$"))
                    {
                        MessageBox.Show("A tem que ser INTEIRO" + " " + txtA.Text);
                    }
                }
                int resultado = a + b;
                lblResultado.Text = "O numero " + resultado + " é Inteiro";
            }
            else if(txtA.Text == "" && txtB.Text == "")
            {
                MessageBox.Show("A e B tem que ser INSERIDO");

            }
            else if (txtB.Text == "")
            {
                MessageBox.Show("B tem que ser INSERIDO");    
            }
            else if(txtA.Text == "")
            {
                MessageBox.Show("A tem que ser INSERIDO");
            }
        }

        private void btnReal_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0;
            if (txtA.Text != "" && txtB.Text != "")
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                double resultado = a + b;
                lblResultado.Text = "O numero " + resultado + " é Real";
            }
            else if (txtA.Text == "" && txtB.Text == "")
            {
                MessageBox.Show("A e B tem que ser INSERIDO");
            }
            else if (txtB.Text == "")
            {
                MessageBox.Show("B tem que ser INSERIDO");
            }
            else if (txtA.Text == "")
            {
                MessageBox.Show("A tem que ser INSERIDO");
            }
        }
    }
}
