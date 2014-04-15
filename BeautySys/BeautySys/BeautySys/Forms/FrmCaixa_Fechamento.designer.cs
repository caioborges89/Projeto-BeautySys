namespace BeautySys.Forms
{
    partial class FrmCaixa_Fechamento
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
            this.dtpCaixa = new System.Windows.Forms.DateTimePicker();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCaixaFechamento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dtpCaixa
            // 
            this.dtpCaixa.Enabled = false;
            this.dtpCaixa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCaixa.Location = new System.Drawing.Point(114, 20);
            this.dtpCaixa.Name = "dtpCaixa";
            this.dtpCaixa.Size = new System.Drawing.Size(84, 20);
            this.dtpCaixa.TabIndex = 109;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(243, 71);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 23);
            this.btnSair.TabIndex = 107;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(243, 20);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(86, 23);
            this.btnFechar.TabIndex = 108;
            this.btnFechar.Text = "Fechar Caixa";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(114, 74);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(84, 20);
            this.txtValor.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Valor final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Data fechamento:";
            // 
            // dtpCaixaFechamento
            // 
            this.dtpCaixaFechamento.Enabled = false;
            this.dtpCaixaFechamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCaixaFechamento.Location = new System.Drawing.Point(114, 47);
            this.dtpCaixaFechamento.Name = "dtpCaixaFechamento";
            this.dtpCaixaFechamento.Size = new System.Drawing.Size(84, 20);
            this.dtpCaixaFechamento.TabIndex = 109;
            // 
            // FrmCaixa_Fechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 119);
            this.Controls.Add(this.dtpCaixaFechamento);
            this.Controls.Add(this.dtpCaixa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "FrmCaixa_Fechamento";
            this.Text = "Fechamento de Caixa";
            this.Load += new System.EventHandler(this.FrmCaixa_Fechamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpCaixa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCaixaFechamento;
    }
}