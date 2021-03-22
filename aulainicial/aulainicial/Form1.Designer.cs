
namespace aulainicial
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
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.txtAnoAtual = new System.Windows.Forms.TextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblAnoAtual = new System.Windows.Forms.Label();
            this.resultIdade = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNascimento
            // 
            this.txtNascimento.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtNascimento.BackColor = System.Drawing.SystemColors.Window;
            this.txtNascimento.Location = new System.Drawing.Point(303, 76);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtNascimento.TabIndex = 0;
            // 
            // txtAnoAtual
            // 
            this.txtAnoAtual.Location = new System.Drawing.Point(303, 126);
            this.txtAnoAtual.Name = "txtAnoAtual";
            this.txtAnoAtual.Size = new System.Drawing.Size(100, 20);
            this.txtAnoAtual.TabIndex = 1;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(183, 79);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(103, 13);
            this.lblNascimento.TabIndex = 2;
            this.lblNascimento.Text = "Ano de Nascimento:";
            // 
            // lblAnoAtual
            // 
            this.lblAnoAtual.AutoSize = true;
            this.lblAnoAtual.Location = new System.Drawing.Point(183, 129);
            this.lblAnoAtual.Name = "lblAnoAtual";
            this.lblAnoAtual.Size = new System.Drawing.Size(56, 13);
            this.lblAnoAtual.TabIndex = 3;
            this.lblAnoAtual.Text = "Ano Atual:";
            // 
            // resultIdade
            // 
            this.resultIdade.Location = new System.Drawing.Point(303, 225);
            this.resultIdade.Name = "resultIdade";
            this.resultIdade.Size = new System.Drawing.Size(100, 20);
            this.resultIdade.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(264, 173);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(180, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular Idade";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(720, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(68, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(303, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(183, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            // 
            // btnMensagem
            // 
            this.btnMensagem.Location = new System.Drawing.Point(440, 25);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(90, 23);
            this.btnMensagem.TabIndex = 9;
            this.btnMensagem.Text = "Mensagem";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.btnMensagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.resultIdade);
            this.Controls.Add(this.lblAnoAtual);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.txtAnoAtual);
            this.Controls.Add(this.txtNascimento);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAnoAtual;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblAnoAtual;
        private System.Windows.Forms.TextBox resultIdade;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnMensagem;
    }
}

