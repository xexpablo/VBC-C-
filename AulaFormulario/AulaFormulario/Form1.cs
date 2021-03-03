using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaFormulario
{
    public partial class frmPrincipal : Form
    {
        int cont = 1;
        bool isAtivadoCOR = false;
        bool isAtivadoCOPIA = false;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            string Name = "", Address = "", City = "";
            int Age = 0;
            
            if(txtName.Text != "" && txtAddress.Text != "" && txtCity.Text != "" && txtAge.Text != "")
            {
                try
                {
                    Name = txtName.Text;
                    Address = txtAddress.Text;
                    City = txtCity.Text;
                    Age = Convert.ToInt32(txtAge.Text);
                    MessageBox.Show("Seu nome é " + Name + "\nVocê mora no Endereço: " + Address + ", " + City + "\nTem " + Age + " Anos");
                }
                catch (Exception)
                {
                    MessageBox.Show("UM ERRO OCORREU, REVISE AS INFORMAÇÕES");
                }    
            }
            else
            {
                MessageBox.Show("UM ERRO OCORREU, REVISE AS INFORMAÇÕES");
            }
            
        }

        async private void btnCopy_Click(object sender, EventArgs e)
        {
            
            //--------------------------------------------------------------------------
            if (isAtivadoCOR == false)
            {
                isAtivadoCOPIA = true;
                if (txtName.Text != txtCopyName.Text)
                {
                    txtCopyName.ReadOnly = true;
                    txtCopyName.Text = txtName.Text;
                    txtName.BackColor = Color.FromArgb(0, 192, 192);
                    txtCopyName.BackColor = Color.FromArgb(0, 192, 192);
                    await Task.Delay(300);
                    txtName.BackColor = Color.FromArgb(128, 128, 255);
                    txtCopyName.BackColor = Color.FromArgb(128, 128, 255);
                }

                if (txtAddress.Text != txtCopyAddress.Text)
                {
                    txtCopyAddress.ReadOnly = true;
                    txtCopyAddress.Text = txtAddress.Text;
                    txtAddress.BackColor = Color.FromArgb(0, 192, 192);
                    txtCopyAddress.BackColor = Color.FromArgb(0, 192, 192);
                    await Task.Delay(300);
                    txtAddress.BackColor = Color.FromArgb(128, 128, 255);
                    txtCopyAddress.BackColor = Color.FromArgb(128, 128, 255);
                }

                if (txtCity.Text != txtCopyCity.Text)
                {
                    txtCopyCity.ReadOnly = true;
                    txtCopyCity.Text = txtCity.Text;
                    txtCity.BackColor = Color.FromArgb(0, 192, 192);
                    txtCopyCity.BackColor = Color.FromArgb(0, 192, 192);
                    await Task.Delay(300);
                    txtCity.BackColor = Color.FromArgb(128, 128, 255);
                    txtCopyCity.BackColor = Color.FromArgb(128, 128, 255);
                }

                if (txtAge.Text != txtCopyAge.Text)
                {
                    txtCopyAge.ReadOnly = true;
                    txtCopyAge.Text = txtAge.Text;
                    txtAge.BackColor = Color.FromArgb(0, 192, 192);
                    txtCopyAge.BackColor = Color.FromArgb(0, 192, 192);
                    await Task.Delay(300);
                    txtAge.BackColor = Color.FromArgb(128, 128, 255);
                    txtCopyAge.BackColor = Color.FromArgb(128, 128, 255);
                }
                await Task.Delay(100);
                isAtivadoCOPIA = false;
            }
            else
            {
                MessageBox.Show("Desative a COR ROTATIVA primeiro");
            }  
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCopyName.Text = "";
            txtCopyAddress.Text = "";
            txtCopyCity.Text = "";
            txtCopyAge.Text = "";
        }

        async private void btnColor_Click(object sender, EventArgs e)
        {
            
            if(isAtivadoCOPIA == false)
            {
                cont += 1;
                if (isAtivadoCOR == false)
                {
                    isAtivadoCOR = true;
                }
                else
                {
                    isAtivadoCOR = false;
                }
                //---------------------------------------------------------------
                while (cont % 2 == 0)
                { 
                    txtName.BackColor = Color.FromArgb(0, 192, 192);
                    txtAddress.BackColor = Color.FromArgb(0, 192, 192);
                    txtCity.BackColor = Color.FromArgb(0, 192, 192);
                    txtAge.BackColor = Color.FromArgb(0, 192, 192);
                    await Task.Delay(100);
                    txtName.BackColor = Color.FromArgb(50, 170, 200);
                    txtAddress.BackColor = Color.FromArgb(50, 170, 200);
                    txtCity.BackColor = Color.FromArgb(50, 170, 200);
                    txtAge.BackColor = Color.FromArgb(50, 170, 200);
                    await Task.Delay(100);
                    txtName.BackColor = Color.FromArgb(100, 140, 215);
                    txtAddress.BackColor = Color.FromArgb(100, 140, 215);
                    txtCity.BackColor = Color.FromArgb(100, 140, 215);
                    txtAge.BackColor = Color.FromArgb(100, 140, 215);
                    await Task.Delay(100);
                    txtName.BackColor = Color.FromArgb(128, 128, 255);
                    txtAddress.BackColor = Color.FromArgb(128, 128, 255);
                    txtCity.BackColor = Color.FromArgb(128, 128, 255);
                    txtAge.BackColor = Color.FromArgb(128, 128, 255);
                    await Task.Delay(100);
                }
            }
            else
            {
                MessageBox.Show("Aguarde ser feita a CÓPIA primeiro");
            }
        }
    }
}
