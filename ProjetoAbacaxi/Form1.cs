using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAbacaxi
{
    public partial class FrmAbacaxi : Form
    {
        float soma = 0;
        public FrmAbacaxi()
        {
            InitializeComponent();
        }

        private void FrmAbacaxi_Load(object sender, EventArgs e)
        {
            CmbFrutas.Items.Add("Abacaxi");
            CmbFrutas.Items.Add("Limão");
            CmbFrutas.Items.Add("Amora");

            CmbPreco.Items.Add("3,56");
            CmbPreco.Items.Add("4,56");
            CmbPreco.Items.Add("7,99");
        }

        private void CmbFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
          CmbPreco.SelectedIndex  = CmbFrutas.SelectedIndex;
          LstSelecionados.Items.Add(TxtQuantidade.Text + " - " + CmbFrutas.Text + " - " + CmbPreco.Text );

          int quantidade = Convert.ToInt32(TxtQuantidade.Text);
          float preco = float.Parse(CmbPreco.Text);
          float ptotal = (preco * quantidade);
          string arr = CmbPreco.SelectedItem.ToString();
          soma = soma + (float.Parse(arr) * quantidade);
          lblMensagem.Text = soma.ToString();
        }

        private void TxtQuantidade_Leave(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(TxtQuantidade.Text, out id) == false)
            {
                MessageBox.Show(" Digite um número", "Campo Quantidade");
                TxtQuantidade.Focus();
                return;
            }

            if (Convert.ToInt16(TxtQuantidade.Text) <= 0)
            {
                MessageBox.Show("Quantidade deve ser maior que 0", "Campo Quantidade");
                TxtQuantidade.Focus();
                return;

            }

        }
    }
}
