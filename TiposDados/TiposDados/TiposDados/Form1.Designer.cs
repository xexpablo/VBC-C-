
namespace TiposDados
{
    partial class FrmTiposDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(116, 66);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(139, 22);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Primeiro Valor :";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(110, 138);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(145, 22);
            this.lblValor2.TabIndex = 1;
            this.lblValor2.Text = "Segundo Valor :";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(276, 63);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(144, 29);
            this.txtValor1.TabIndex = 2;
            this.txtValor1.Text = "0";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(276, 135);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(144, 29);
            this.txtValor2.TabIndex = 3;
            this.txtValor2.Text = "0";
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(227, 200);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(128, 33);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(276, 278);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(144, 29);
            this.txtResultado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resultado : ";
            // 
            // FrmTiposDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmTiposDados";
            this.Text = "Conversão de Tipos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label1;
    }
}

