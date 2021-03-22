
namespace telaTipoDados
{
    partial class frmSoma
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnReal = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(73, 11);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(105, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(73, 43);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(105, 20);
            this.txtB.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(53, 14);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(53, 46);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "B";
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(184, 9);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(100, 23);
            this.btnInt.TabIndex = 4;
            this.btnInt.Text = "Meu Botão Inteiro";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnReal
            // 
            this.btnReal.Location = new System.Drawing.Point(184, 41);
            this.btnReal.Name = "btnReal";
            this.btnReal.Size = new System.Drawing.Size(100, 23);
            this.btnReal.TabIndex = 5;
            this.btnReal.Text = "Meu Botão Real";
            this.btnReal.UseVisualStyleBackColor = true;
            this.btnReal.Click += new System.EventHandler(this.btnReal_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 91);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtResultado.Location = new System.Drawing.Point(73, 88);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(181, 20);
            this.txtResultado.TabIndex = 8;
            // 
            // frmSoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 139);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnReal);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "frmSoma";
            this.Text = "Soma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnReal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

