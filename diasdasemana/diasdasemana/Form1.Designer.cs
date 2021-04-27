
namespace diasdasemana
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDiaSemana = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEscolhido = new System.Windows.Forms.Label();
            this.picDiaSemana = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDiaSemana)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picDiaSemana);
            this.groupBox1.Controls.Add(this.lblEscolhido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboDiaSemana);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 593);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dias da Semana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha um dia da Semana:";
            // 
            // cboDiaSemana
            // 
            this.cboDiaSemana.FormattingEnabled = true;
            this.cboDiaSemana.Location = new System.Drawing.Point(34, 60);
            this.cboDiaSemana.Name = "cboDiaSemana";
            this.cboDiaSemana.Size = new System.Drawing.Size(378, 30);
            this.cboDiaSemana.TabIndex = 1;
            this.cboDiaSemana.Text = " Qual dia da semana quer selecionar?";
            this.cboDiaSemana.SelectedIndexChanged += new System.EventHandler(this.cboDiaSemana_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dia Escolhido:";
            // 
            // lblEscolhido
            // 
            this.lblEscolhido.AutoSize = true;
            this.lblEscolhido.Location = new System.Drawing.Point(198, 110);
            this.lblEscolhido.Name = "lblEscolhido";
            this.lblEscolhido.Size = new System.Drawing.Size(26, 22);
            this.lblEscolhido.TabIndex = 3;
            this.lblEscolhido.Text = "  -";
            // 
            // picDiaSemana
            // 
            this.picDiaSemana.Location = new System.Drawing.Point(146, 162);
            this.picDiaSemana.Name = "picDiaSemana";
            this.picDiaSemana.Size = new System.Drawing.Size(400, 400);
            this.picDiaSemana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiaSemana.TabIndex = 4;
            this.picDiaSemana.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 627);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Dias da Semana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDiaSemana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEscolhido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDiaSemana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picDiaSemana;
    }
}

