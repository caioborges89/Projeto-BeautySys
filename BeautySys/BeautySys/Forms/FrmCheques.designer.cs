namespace BeautySys.Forms
{
    partial class FrmCheques
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
            this.mtxbDtVencimento = new System.Windows.Forms.MaskedTextBox();
            this.mtxbDtEmissao = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmissao = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txbBanco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cboSituação = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxbVencFin = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxbVencIni = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxbEmisFin = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxbEmisIni = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.rbtodos = new System.Windows.Forms.RadioButton();
            this.rbdevolvido = new System.Windows.Forms.RadioButton();
            this.rbbaixado = new System.Windows.Forms.RadioButton();
            this.rbaberto = new System.Windows.Forms.RadioButton();
            this.dgvCheques = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxbDtVencimento
            // 
            this.mtxbDtVencimento.Location = new System.Drawing.Point(382, 12);
            this.mtxbDtVencimento.Mask = "00/00/0000";
            this.mtxbDtVencimento.Name = "mtxbDtVencimento";
            this.mtxbDtVencimento.Size = new System.Drawing.Size(84, 20);
            this.mtxbDtVencimento.TabIndex = 102;
            this.mtxbDtVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // mtxbDtEmissao
            // 
            this.mtxbDtEmissao.Location = new System.Drawing.Point(220, 12);
            this.mtxbDtEmissao.Mask = "00/00/0000";
            this.mtxbDtEmissao.Name = "mtxbDtEmissao";
            this.mtxbDtEmissao.Size = new System.Drawing.Size(84, 20);
            this.mtxbDtEmissao.TabIndex = 101;
            this.mtxbDtEmissao.ValidatingType = typeof(System.DateTime);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(59, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Vencimento:";
            // 
            // lblEmissao
            // 
            this.lblEmissao.AutoSize = true;
            this.lblEmissao.Location = new System.Drawing.Point(165, 15);
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Size = new System.Drawing.Size(49, 13);
            this.lblEmissao.TabIndex = 97;
            this.lblEmissao.Text = "Emissão:";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(59, 38);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 104;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 41);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(47, 13);
            this.lbl.TabIndex = 103;
            this.lbl.Text = "Número:";
            // 
            // txbBanco
            // 
            this.txbBanco.Location = new System.Drawing.Point(212, 38);
            this.txbBanco.Name = "txbBanco";
            this.txbBanco.Size = new System.Drawing.Size(46, 20);
            this.txbBanco.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Banco:";
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(59, 64);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(253, 20);
            this.txbCliente.TabIndex = 110;
            this.txbCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbCliente_KeyDown);
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(358, 64);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(108, 20);
            this.txbValor.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "Valor:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(11, 67);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 107;
            this.lblCliente.Text = "Cliente:";
            // 
            // cboSituação
            // 
            this.cboSituação.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituação.FormattingEnabled = true;
            this.cboSituação.Location = new System.Drawing.Point(323, 38);
            this.cboSituação.Name = "cboSituação";
            this.cboSituação.Size = new System.Drawing.Size(143, 21);
            this.cboSituação.TabIndex = 112;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 111;
            this.label11.Text = "Situação:";
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.label7);
            this.gpbPesquisa.Controls.Add(this.mtxbVencFin);
            this.gpbPesquisa.Controls.Add(this.label8);
            this.gpbPesquisa.Controls.Add(this.mtxbVencIni);
            this.gpbPesquisa.Controls.Add(this.label9);
            this.gpbPesquisa.Controls.Add(this.label6);
            this.gpbPesquisa.Controls.Add(this.mtxbEmisFin);
            this.gpbPesquisa.Controls.Add(this.label5);
            this.gpbPesquisa.Controls.Add(this.mtxbEmisIni);
            this.gpbPesquisa.Controls.Add(this.label10);
            this.gpbPesquisa.Controls.Add(this.btnLocalizar);
            this.gpbPesquisa.Controls.Add(this.rbtodos);
            this.gpbPesquisa.Controls.Add(this.rbdevolvido);
            this.gpbPesquisa.Controls.Add(this.rbbaixado);
            this.gpbPesquisa.Controls.Add(this.rbaberto);
            this.gpbPesquisa.Location = new System.Drawing.Point(472, 12);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(151, 311);
            this.gpbPesquisa.TabIndex = 113;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 115;
            this.label7.Text = "Final:";
            // 
            // mtxbVencFin
            // 
            this.mtxbVencFin.Location = new System.Drawing.Point(51, 237);
            this.mtxbVencFin.Mask = "00/00/0000";
            this.mtxbVencFin.Name = "mtxbVencFin";
            this.mtxbVencFin.Size = new System.Drawing.Size(84, 20);
            this.mtxbVencFin.TabIndex = 114;
            this.mtxbVencFin.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 113;
            this.label8.Text = "Início:";
            // 
            // mtxbVencIni
            // 
            this.mtxbVencIni.Location = new System.Drawing.Point(51, 211);
            this.mtxbVencIni.Mask = "00/00/0000";
            this.mtxbVencIni.Name = "mtxbVencIni";
            this.mtxbVencIni.Size = new System.Drawing.Size(84, 20);
            this.mtxbVencIni.TabIndex = 112;
            this.mtxbVencIni.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 111;
            this.label9.Text = "Vencimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "Final:";
            // 
            // mtxbEmisFin
            // 
            this.mtxbEmisFin.Location = new System.Drawing.Point(51, 159);
            this.mtxbEmisFin.Mask = "00/00/0000";
            this.mtxbEmisFin.Name = "mtxbEmisFin";
            this.mtxbEmisFin.Size = new System.Drawing.Size(84, 20);
            this.mtxbEmisFin.TabIndex = 109;
            this.mtxbEmisFin.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 108;
            this.label5.Text = "Início:";
            // 
            // mtxbEmisIni
            // 
            this.mtxbEmisIni.Location = new System.Drawing.Point(51, 133);
            this.mtxbEmisIni.Mask = "00/00/0000";
            this.mtxbEmisIni.Name = "mtxbEmisIni";
            this.mtxbEmisIni.Size = new System.Drawing.Size(84, 20);
            this.mtxbEmisIni.TabIndex = 107;
            this.mtxbEmisIni.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 106;
            this.label10.Text = "Emissão:";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Image = global::BeautySys.Properties.Resources.pesquisar;
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizar.Location = new System.Drawing.Point(51, 263);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(82, 39);
            this.btnLocalizar.TabIndex = 105;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // rbtodos
            // 
            this.rbtodos.AutoSize = true;
            this.rbtodos.Location = new System.Drawing.Point(6, 88);
            this.rbtodos.Name = "rbtodos";
            this.rbtodos.Size = new System.Drawing.Size(55, 17);
            this.rbtodos.TabIndex = 7;
            this.rbtodos.TabStop = true;
            this.rbtodos.Text = "Todos";
            this.rbtodos.UseVisualStyleBackColor = true;
            // 
            // rbdevolvido
            // 
            this.rbdevolvido.AutoSize = true;
            this.rbdevolvido.Location = new System.Drawing.Point(6, 65);
            this.rbdevolvido.Name = "rbdevolvido";
            this.rbdevolvido.Size = new System.Drawing.Size(73, 17);
            this.rbdevolvido.TabIndex = 6;
            this.rbdevolvido.TabStop = true;
            this.rbdevolvido.Text = "Devolvido";
            this.rbdevolvido.UseVisualStyleBackColor = true;
            // 
            // rbbaixado
            // 
            this.rbbaixado.AutoSize = true;
            this.rbbaixado.Location = new System.Drawing.Point(6, 42);
            this.rbbaixado.Name = "rbbaixado";
            this.rbbaixado.Size = new System.Drawing.Size(63, 17);
            this.rbbaixado.TabIndex = 5;
            this.rbbaixado.TabStop = true;
            this.rbbaixado.Text = "Baixado";
            this.rbbaixado.UseVisualStyleBackColor = true;
            // 
            // rbaberto
            // 
            this.rbaberto.AutoSize = true;
            this.rbaberto.Location = new System.Drawing.Point(6, 19);
            this.rbaberto.Name = "rbaberto";
            this.rbaberto.Size = new System.Drawing.Size(73, 17);
            this.rbaberto.TabIndex = 4;
            this.rbaberto.TabStop = true;
            this.rbaberto.Text = "Em aberto";
            this.rbaberto.UseVisualStyleBackColor = true;
            // 
            // dgvCheques
            // 
            this.dgvCheques.AllowUserToAddRows = false;
            this.dgvCheques.AllowUserToDeleteRows = false;
            this.dgvCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nro,
            this.banco,
            this.valor});
            this.dgvCheques.Location = new System.Drawing.Point(14, 90);
            this.dgvCheques.Name = "dgvCheques";
            this.dgvCheques.ReadOnly = true;
            this.dgvCheques.Size = new System.Drawing.Size(452, 179);
            this.dgvCheques.TabIndex = 114;
            this.dgvCheques.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheques_CellDoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::BeautySys.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(176, 275);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 39);
            this.btnExcluir.TabIndex = 117;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::BeautySys.Properties.Resources.editar;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(95, 275);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 39);
            this.btnAlterar.TabIndex = 116;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::BeautySys.Properties.Resources.salvar;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(14, 275);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 39);
            this.btnGravar.TabIndex = 115;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::BeautySys.Properties.Resources.limpar;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(257, 275);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 39);
            this.btnLimpar.TabIndex = 119;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::BeautySys.Properties.Resources.fechar;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(338, 275);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(81, 39);
            this.btnFechar.TabIndex = 118;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nro
            // 
            this.nro.HeaderText = "Nro Cheque";
            this.nro.Name = "nro";
            this.nro.ReadOnly = true;
            // 
            // banco
            // 
            this.banco.HeaderText = "Banco";
            this.banco.Name = "banco";
            this.banco.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // FrmCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 331);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.dgvCheques);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.cboSituação);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txbBanco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.mtxbDtVencimento);
            this.Controls.Add(this.mtxbDtEmissao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmissao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCheques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheques";
            this.Load += new System.EventHandler(this.FrmCheques_Load);
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxbDtVencimento;
        private System.Windows.Forms.MaskedTextBox mtxbDtEmissao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmissao;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txbBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboSituação;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.RadioButton rbtodos;
        private System.Windows.Forms.RadioButton rbdevolvido;
        private System.Windows.Forms.RadioButton rbbaixado;
        private System.Windows.Forms.RadioButton rbaberto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxbVencFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxbVencIni;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxbEmisFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxbEmisIni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.DataGridView dgvCheques;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}