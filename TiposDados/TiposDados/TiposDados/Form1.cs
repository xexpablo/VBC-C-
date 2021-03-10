using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiposDados
{
    public partial class FrmTiposDados : Form
    {
        public FrmTiposDados()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(txtValor1.Text);
            int v2 = Convert.ToInt32(txtValor2.Text);
            int resultado = v1 + v2;

            txtResultado.Text = resultado.ToString();

        }
    }
}
