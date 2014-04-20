namespace BeautySys.Forms
{
    partial class FrmCReceber
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.lblpagto = new System.Windows.Forms.Label();
            this.txbSerie = new System.Windows.Forms.TextBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmissao = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblserie = new System.Windows.Forms.Label();
            this.txbDuplicata = new System.Windows.Forms.TextBox();
            this.lblduplicata = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.mtxbEmissa = new System.Windows.Forms.MaskedTextBox();
            this.mtxbVencimento = new System.Windows.Forms.MaskedTextBox();
            this.mtxbPagamento = new System.Windows.Forms.MaskedTextBox();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.dgvCReceber = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duplicata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label4 = new System.Windows.Forms.Label();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.rbBaixada = new System.Windows.Forms.RadioButton();
            this.rbAberto = new System.Windows.Forms.RadioButton();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboFormaPagto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCReceber)).BeginInit();
            this.gpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::BeautySys.Properties.Resources.limpar;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(475, 269);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 39);
            this.btnLimpar.TabIndex = 27;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::BeautySys.Properties.Resources.fechar;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(556, 269);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(81, 39);
            this.btnFechar.TabIndex = 26;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::BeautySys.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(174, 269);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 39);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::BeautySys.Properties.Resources.editar;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(93, 269);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 39);
            this.btnAlterar.TabIndex = 24;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::BeautySys.Properties.Resources.salvar;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(12, 269);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 39);
            this.btnGravar.TabIndex = 23;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Image = global::BeautySys.Properties.Resources.pesquisar;
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizar.Location = new System.Drawing.Point(51, 241);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(82, 39);
            this.btnLocalizar.TabIndex = 77;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // lblpagto
            // 
            this.lblpagto.AutoSize = true;
            this.lblpagto.Location = new System.Drawing.Point(486, 16);
            this.lblpagto.Name = "lblpagto";
            this.lblpagto.Size = new System.Drawing.Size(64, 13);
            this.lblpagto.TabIndex = 90;
            this.lblpagto.Text = "Pagamento:";
            // 
            // txbSerie
            // 
            this.txbSerie.Location = new System.Drawing.Point(219, 65);
            this.txbSerie.Name = "txbSerie";
            this.txbSerie.Size = new System.Drawing.Size(46, 20);
            this.txbSerie.TabIndex = 89;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(372, 39);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(114, 20);
            this.txbValor.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Vencimento:";
            // 
            // lblEmissao
            // 
            this.lblEmissao.AutoSize = true;
            this.lblEmissao.Location = new System.Drawing.Point(179, 16);
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Size = new System.Drawing.Size(49, 13);
            this.lblEmissao.TabIndex = 83;
            this.lblEmissao.Text = "Emissão:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(25, 42);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 81;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(179, 68);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(34, 13);
            this.lblserie.TabIndex = 80;
            this.lblserie.Text = "Série:";
            // 
            // txbDuplicata
            // 
            this.txbDuplicata.Location = new System.Drawing.Point(73, 65);
            this.txbDuplicata.Name = "txbDuplicata";
            this.txbDuplicata.Size = new System.Drawing.Size(100, 20);
            this.txbDuplicata.TabIndex = 79;
            // 
            // lblduplicata
            // 
            this.lblduplicata.AutoSize = true;
            this.lblduplicata.Location = new System.Drawing.Point(12, 68);
            this.lblduplicata.Name = "lblduplicata";
            this.lblduplicata.Size = new System.Drawing.Size(55, 13);
            this.lblduplicata.TabIndex = 78;
            this.lblduplicata.Text = "Duplicata:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(73, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 94;
            // 
            // mtxbEmissa
            // 
            this.mtxbEmissa.Location = new System.Drawing.Point(234, 13);
            this.mtxbEmissa.Mask = "00/00/0000";
            this.mtxbEmissa.Name = "mtxbEmissa";
            this.mtxbEmissa.Size = new System.Drawing.Size(84, 20);
            this.mtxbEmissa.TabIndex = 95;
            this.mtxbEmissa.ValidatingType = typeof(System.DateTime);
            // 
            // mtxbVencimento
            // 
            this.mtxbVencimento.Location = new System.Drawing.Point(396, 13);
            this.mtxbVencimento.Mask = "00/00/0000";
            this.mtxbVencimento.Name = "mtxbVencimento";
            this.mtxbVencimento.Size = new System.Drawing.Size(84, 20);
            this.mtxbVencimento.TabIndex = 96;
            this.mtxbVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // mtxbPagamento
            // 
            this.mtxbPagamento.Location = new System.Drawing.Point(556, 13);
            this.mtxbPagamento.Mask = "00/00/0000";
            this.mtxbPagamento.Name = "mtxbPagamento";
            this.mtxbPagamento.ReadOnly = true;
            this.mtxbPagamento.Size = new System.Drawing.Size(84, 20);
            this.mtxbPagamento.TabIndex = 97;
            this.mtxbPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(73, 39);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(253, 20);
            this.txbCliente.TabIndex = 98;
            // 
            // dgvCReceber
            // 
            this.dgvCReceber.AllowUserToAddRows = false;
            this.dgvCReceber.AllowUserToDeleteRows = false;
            this.dgvCReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.cliente,
            this.valor,
            this.vencimento,
            this.emissao,
            this.pagamento,
            this.comanda,
            this.formaPagto,
            this.duplicata,
            this.serie});
            this.dgvCReceber.Location = new System.Drawing.Point(12, 91);
            this.dgvCReceber.Name = "dgvCReceber";
            this.dgvCReceber.ReadOnly = true;
            this.dgvCReceber.Size = new System.Drawing.Size(628, 172);
            this.dgvCReceber.TabIndex = 99;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // vencimento
            // 
            this.vencimento.HeaderText = "Vencimento";
            this.vencimento.Name = "vencimento";
            this.vencimento.ReadOnly = true;
            // 
            // emissao
            // 
            this.emissao.HeaderText = "Emissão";
            this.emissao.Name = "emissao";
            this.emissao.ReadOnly = true;
            // 
            // pagamento
            // 
            this.pagamento.HeaderText = "Pagamento";
            this.pagamento.Name = "pagamento";
            this.pagamento.ReadOnly = true;
            // 
            // comanda
            // 
            this.comanda.HeaderText = "Comanda";
            this.comanda.Name = "comanda";
            this.comanda.ReadOnly = true;
            // 
            // formaPagto
            // 
            this.formaPagto.HeaderText = "Forma de Pagamento";
            this.formaPagto.Name = "formaPagto";
            this.formaPagto.ReadOnly = true;
            this.formaPagto.Width = 150;
            // 
            // duplicata
            // 
            this.duplicata.HeaderText = "Duplicata";
            this.duplicata.Name = "duplicata";
            this.duplicata.ReadOnly = true;
            // 
            // serie
            // 
            this.serie.HeaderText = "Serie";
            this.serie.Name = "serie";
            this.serie.ReadOnly = true;
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
            this.gpbPesquisa.Controls.Add(this.label4);
            this.gpbPesquisa.Controls.Add(this.rbTodas);
            this.gpbPesquisa.Controls.Add(this.rbBaixada);
            this.gpbPesquisa.Controls.Add(this.rbAberto);
            this.gpbPesquisa.Controls.Add(this.btnLocalizar);
            this.gpbPesquisa.Location = new System.Drawing.Point(646, 12);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(153, 296);
            this.gpbPesquisa.TabIndex = 100;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 104;
            this.label7.Text = "Final:";
            // 
            // mtxbVencFin
            // 
            this.mtxbVencFin.Location = new System.Drawing.Point(51, 215);
            this.mtxbVencFin.Mask = "00/00/0000";
            this.mtxbVencFin.Name = "mtxbVencFin";
            this.mtxbVencFin.Size = new System.Drawing.Size(84, 20);
            this.mtxbVencFin.TabIndex = 103;
            this.mtxbVencFin.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "Início:";
            // 
            // mtxbVencIni
            // 
            this.mtxbVencIni.Location = new System.Drawing.Point(51, 189);
            this.mtxbVencIni.Mask = "00/00/0000";
            this.mtxbVencIni.Name = "mtxbVencIni";
            this.mtxbVencIni.Size = new System.Drawing.Size(84, 20);
            this.mtxbVencIni.TabIndex = 101;
            this.mtxbVencIni.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 100;
            this.label9.Text = "Vencimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 99;
            this.label6.Text = "Final:";
            // 
            // mtxbEmisFin
            // 
            this.mtxbEmisFin.Location = new System.Drawing.Point(51, 137);
            this.mtxbEmisFin.Mask = "00/00/0000";
            this.mtxbEmisFin.Name = "mtxbEmisFin";
            this.mtxbEmisFin.Size = new System.Drawing.Size(84, 20);
            this.mtxbEmisFin.TabIndex = 98;
            this.mtxbEmisFin.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "Início:";
            // 
            // mtxbEmisIni
            // 
            this.mtxbEmisIni.Location = new System.Drawing.Point(51, 111);
            this.mtxbEmisIni.Mask = "00/00/0000";
            this.mtxbEmisIni.Name = "mtxbEmisIni";
            this.mtxbEmisIni.Size = new System.Drawing.Size(84, 20);
            this.mtxbEmisIni.TabIndex = 96;
            this.mtxbEmisIni.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Emissão:";
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Location = new System.Drawing.Point(6, 63);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(55, 17);
            this.rbTodas.TabIndex = 6;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = true;
            // 
            // rbBaixada
            // 
            this.rbBaixada.AutoSize = true;
            this.rbBaixada.Location = new System.Drawing.Point(6, 40);
            this.rbBaixada.Name = "rbBaixada";
            this.rbBaixada.Size = new System.Drawing.Size(63, 17);
            this.rbBaixada.TabIndex = 5;
            this.rbBaixada.TabStop = true;
            this.rbBaixada.Text = "Baixada";
            this.rbBaixada.UseVisualStyleBackColor = true;
            // 
            // rbAberto
            // 
            this.rbAberto.AutoSize = true;
            this.rbAberto.Location = new System.Drawing.Point(6, 19);
            this.rbAberto.Name = "rbAberto";
            this.rbAberto.Size = new System.Drawing.Size(73, 17);
            this.rbAberto.TabIndex = 4;
            this.rbAberto.TabStop = true;
            this.rbAberto.Text = "Em aberto";
            this.rbAberto.UseVisualStyleBackColor = true;
            // 
            // txbComanda
            // 
            this.txbComanda.Location = new System.Drawing.Point(553, 39);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(87, 20);
            this.txbComanda.TabIndex = 102;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(492, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 101;
            this.label10.Text = "Comanda:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 103;
            this.label11.Text = "Forma de Pagamento:";
            // 
            // cboFormaPagto
            // 
            this.cboFormaPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPagto.FormattingEnabled = true;
            this.cboFormaPagto.Location = new System.Drawing.Point(388, 65);
            this.cboFormaPagto.Name = "cboFormaPagto";
            this.cboFormaPagto.Size = new System.Drawing.Size(162, 21);
            this.cboFormaPagto.TabIndex = 104;
            // 
            // FrmCReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 321);
            this.Controls.Add(this.cboFormaPagto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbComanda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.dgvCReceber);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.mtxbPagamento);
            this.Controls.Add(this.mtxbVencimento);
            this.Controls.Add(this.mtxbEmissa);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblpagto);
            this.Controls.Add(this.txbSerie);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmissao);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblserie);
            this.Controls.Add(this.txbDuplicata);
            this.Controls.Add(this.lblduplicata);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnGravar);
            this.Name = "FrmCReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.FrmCReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCReceber)).EndInit();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label lblpagto;
        private System.Windows.Forms.TextBox txbSerie;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmissao;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.TextBox txbDuplicata;
        private System.Windows.Forms.Label lblduplicata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox mtxbEmissa;
        private System.Windows.Forms.MaskedTextBox mtxbVencimento;
        private System.Windows.Forms.MaskedTextBox mtxbPagamento;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.DataGridView dgvCReceber;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxbVencFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxbVencIni;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxbEmisFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxbEmisIni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.RadioButton rbBaixada;
        private System.Windows.Forms.RadioButton rbAberto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboFormaPagto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagto;
        private System.Windows.Forms.DataGridViewTextBoxColumn duplicata;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
    }
}