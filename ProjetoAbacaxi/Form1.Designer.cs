namespace ProjetoAbacaxi
{
    partial class FrmAbacaxi
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmbFrutas = new System.Windows.Forms.ComboBox();
            this.CmbPreco = new System.Windows.Forms.ComboBox();
            this.LstSelecionados = new System.Windows.Forms.ListBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbFrutas
            // 
            this.CmbFrutas.FormattingEnabled = true;
            this.CmbFrutas.Location = new System.Drawing.Point(210, 90);
            this.CmbFrutas.Name = "CmbFrutas";
            this.CmbFrutas.Size = new System.Drawing.Size(227, 45);
            this.CmbFrutas.TabIndex = 0;
            this.CmbFrutas.SelectedIndexChanged += new System.EventHandler(this.CmbFrutas_SelectedIndexChanged);
            // 
            // CmbPreco
            // 
            this.CmbPreco.FormattingEnabled = true;
            this.CmbPreco.Location = new System.Drawing.Point(210, 171);
            this.CmbPreco.Name = "CmbPreco";
            this.CmbPreco.Size = new System.Drawing.Size(228, 45);
            this.CmbPreco.TabIndex = 1;
            // 
            // LstSelecionados
            // 
            this.LstSelecionados.FormattingEnabled = true;
            this.LstSelecionados.ItemHeight = 37;
            this.LstSelecionados.Location = new System.Drawing.Point(500, 16);
            this.LstSelecionados.Name = "LstSelecionados";
            this.LstSelecionados.Size = new System.Drawing.Size(265, 411);
            this.LstSelecionados.TabIndex = 2;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(281, 318);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(35, 37);
            this.lblMensagem.TabIndex = 3;
            this.lblMensagem.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produtos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade:";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Location = new System.Drawing.Point(210, 16);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(227, 44);
            this.TxtQuantidade.TabIndex = 7;
            this.TxtQuantidade.Leave += new System.EventHandler(this.TxtQuantidade_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total R$";
            // 
            // FrmAbacaxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.LstSelecionados);
            this.Controls.Add(this.CmbPreco);
            this.Controls.Add(this.CmbFrutas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "FrmAbacaxi";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.FrmAbacaxi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbFrutas;
        private System.Windows.Forms.ComboBox CmbPreco;
        private System.Windows.Forms.ListBox LstSelecionados;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.Label label4;
    }
}

