using System;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso = 0;
            double altura = 0;
            try
            {
                peso = Convert.ToDouble(txtPeso.Text);
                altura = Convert.ToDouble(txtAltura.Text);
                double imc = peso / (altura * altura);
                if (imc < 17)
                {
                    lblIdeal.Text = "Muito abaixo do Peso";
                }
                else if(imc >= 17 && imc < 18.50)
                {
                    lblIdeal.Text = "Abaixo do Peso";
                }
                else if(imc >= 18.50 && imc < 25)
                {
                    lblIdeal.Text = "Peso Ideal";
                }
                else if(imc >= 25 && imc < 30)
                {
                    lblIdeal.Text = "Acima do Peso";
                }
                else if(imc >= 30 && imc < 35)
                {
                    lblIdeal.Text = "Obesidade I";
                }
                else if(imc >= 35 && imc < 40)
                {
                    lblIdeal.Text = "Obesidade II (Sevéra)";
                }
                else if(imc >= 40)
                {
                    lblIdeal.Text = "Obesidade III (Mórbida)";
                }
                lblPesoResult.Text = String.Format("{0:0.00}", imc);
                lblMin.Text = (18.5 * (altura * altura)).ToString("F2") + " Kg";
                lblMax.Text = (25 * (altura * altura)).ToString("F2") + " Kg";
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os Campos");
            }
        }
    }
}
