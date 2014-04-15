namespace BeautySys.Forms
{
    partial class FrmComanda
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxbData = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvComanda = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_serv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumeroComanda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbProdServ = new System.Windows.Forms.GroupBox();
            this.rbServiço = new System.Windows.Forms.RadioButton();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoProdServ = new System.Windows.Forms.TextBox();
            this.txtDescricaoProdServ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProfissional = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorProdServ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescReal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescPerc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnLimparCliente = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimparProdServ = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescTotalPerc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDescTotalReal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboFormaPagto = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).BeginInit();
            this.gpbProdServ.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Cliente:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(87, 12);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(303, 20);
            this.txtNomeCliente.TabIndex = 1;
            this.txtNomeCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeCliente_KeyDown);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(480, 12);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(72, 20);
            this.txtCodigoCliente.TabIndex = 3;
            this.txtCodigoCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoCliente_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código Cliente:";
            // 
            // mtxbData
            // 
            this.mtxbData.Location = new System.Drawing.Point(607, 12);
            this.mtxbData.Mask = "00/00/0000";
            this.mtxbData.Name = "mtxbData";
            this.mtxbData.ReadOnly = true;
            this.mtxbData.Size = new System.Drawing.Size(68, 20);
            this.mtxbData.TabIndex = 4;
            this.mtxbData.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data:";
            // 
            // dgvComanda
            // 
            this.dgvComanda.AllowUserToAddRows = false;
            this.dgvComanda.AllowUserToDeleteRows = false;
            this.dgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.desc,
            this.prod_serv,
            this.valor,
            this.qtde,
            this.desconto,
            this.total});
            this.dgvComanda.Location = new System.Drawing.Point(13, 110);
            this.dgvComanda.Name = "dgvComanda";
            this.dgvComanda.ReadOnly = true;
            this.dgvComanda.Size = new System.Drawing.Size(793, 190);
            this.dgvComanda.TabIndex = 6;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.HeaderText = "Descrição";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Width = 150;
            // 
            // prod_serv
            // 
            this.prod_serv.HeaderText = "Produto/Serviço";
            this.prod_serv.Name = "prod_serv";
            this.prod_serv.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor Unitário";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // qtde
            // 
            this.qtde.HeaderText = "Quantidade";
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            // 
            // desconto
            // 
            this.desconto.HeaderText = "Desconto";
            this.desconto.Name = "desconto";
            this.desconto.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // txtNumeroComanda
            // 
            this.txtNumeroComanda.Location = new System.Drawing.Point(734, 12);
            this.txtNumeroComanda.Name = "txtNumeroComanda";
            this.txtNumeroComanda.ReadOnly = true;
            this.txtNumeroComanda.Size = new System.Drawing.Size(72, 20);
            this.txtNumeroComanda.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número:";
            // 
            // gpbProdServ
            // 
            this.gpbProdServ.Controls.Add(this.rbServiço);
            this.gpbProdServ.Controls.Add(this.rbProduto);
            this.gpbProdServ.Location = new System.Drawing.Point(13, 31);
            this.gpbProdServ.Name = "gpbProdServ";
            this.gpbProdServ.Size = new System.Drawing.Size(75, 72);
            this.gpbProdServ.TabIndex = 9;
            this.gpbProdServ.TabStop = false;
            this.gpbProdServ.Text = "Pesquisar";
            // 
            // rbServiço
            // 
            this.rbServiço.AutoSize = true;
            this.rbServiço.Location = new System.Drawing.Point(7, 44);
            this.rbServiço.Name = "rbServiço";
            this.rbServiço.Size = new System.Drawing.Size(61, 17);
            this.rbServiço.TabIndex = 1;
            this.rbServiço.Text = "Serviço";
            this.rbServiço.UseVisualStyleBackColor = true;
            // 
            // rbProduto
            // 
            this.rbProduto.AutoSize = true;
            this.rbProduto.Checked = true;
            this.rbProduto.Location = new System.Drawing.Point(7, 20);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(62, 17);
            this.rbProduto.TabIndex = 0;
            this.rbProduto.TabStop = true;
            this.rbProduto.Text = "Produto";
            this.rbProduto.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Código:";
            // 
            // txtCodigoProdServ
            // 
            this.txtCodigoProdServ.Location = new System.Drawing.Point(146, 38);
            this.txtCodigoProdServ.Name = "txtCodigoProdServ";
            this.txtCodigoProdServ.Size = new System.Drawing.Size(72, 20);
            this.txtCodigoProdServ.TabIndex = 11;
            this.txtCodigoProdServ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProdServ_KeyDown);
            // 
            // txtDescricaoProdServ
            // 
            this.txtDescricaoProdServ.Location = new System.Drawing.Point(288, 38);
            this.txtDescricaoProdServ.Name = "txtDescricaoProdServ";
            this.txtDescricaoProdServ.Size = new System.Drawing.Size(234, 20);
            this.txtDescricaoProdServ.TabIndex = 13;
            this.txtDescricaoProdServ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricaoProdServ_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descrição:";
            // 
            // cboProfissional
            // 
            this.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfissional.FormattingEnabled = true;
            this.cboProfissional.Location = new System.Drawing.Point(597, 38);
            this.cboProfissional.Name = "cboProfissional";
            this.cboProfissional.Size = new System.Drawing.Size(209, 21);
            this.cboProfissional.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Profissional:";
            // 
            // txtValorProdServ
            // 
            this.txtValorProdServ.Location = new System.Drawing.Point(137, 64);
            this.txtValorProdServ.Name = "txtValorProdServ";
            this.txtValorProdServ.Size = new System.Drawing.Size(81, 20);
            this.txtValorProdServ.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Valor:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(295, 64);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(81, 20);
            this.txtQuantidade.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Quantidade:";
            // 
            // txtDescReal
            // 
            this.txtDescReal.Location = new System.Drawing.Point(461, 64);
            this.txtDescReal.Name = "txtDescReal";
            this.txtDescReal.Size = new System.Drawing.Size(81, 20);
            this.txtDescReal.TabIndex = 21;
            this.txtDescReal.Text = "0,00";
            this.txtDescReal.Leave += new System.EventHandler(this.txtDescReal_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Desconto R$:";
            // 
            // txtDescPerc
            // 
            this.txtDescPerc.Location = new System.Drawing.Point(621, 64);
            this.txtDescPerc.Name = "txtDescPerc";
            this.txtDescPerc.Size = new System.Drawing.Size(81, 20);
            this.txtDescPerc.TabIndex = 23;
            this.txtDescPerc.Text = "0,00";
            this.txtDescPerc.Leave += new System.EventHandler(this.txtDescPerc_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(548, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Desconto %:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(87, 306);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(719, 39);
            this.txtObservacao.TabIndex = 107;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(13, 309);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(68, 13);
            this.lblObservacao.TabIndex = 106;
            this.lblObservacao.Text = "Observação:";
            // 
            // btnLimparCliente
            // 
            this.btnLimparCliente.Image = global::BeautySys.Properties.Resources.limpar;
            this.btnLimparCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCliente.Location = new System.Drawing.Point(531, 377);
            this.btnLimparCliente.Name = "btnLimparCliente";
            this.btnLimparCliente.Size = new System.Drawing.Size(108, 39);
            this.btnLimparCliente.TabIndex = 108;
            this.btnLimparCliente.Text = "Limpar Cliente";
            this.btnLimparCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparCliente.UseVisualStyleBackColor = true;
            this.btnLimparCliente.Click += new System.EventHandler(this.btnLimparCliente_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::BeautySys.Properties.Resources.fechar;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(726, 377);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 39);
            this.btnFechar.TabIndex = 105;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::BeautySys.Properties.Resources.limpar;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(645, 377);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 39);
            this.btnLimpar.TabIndex = 104;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Image = global::BeautySys.Properties.Resources.ok_32x32;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(307, 377);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(86, 39);
            this.btnFinalizar.TabIndex = 103;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = global::BeautySys.Properties.Resources.novo;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(708, 65);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(98, 39);
            this.btnRegistrar.TabIndex = 102;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimparProdServ
            // 
            this.btnLimparProdServ.Image = global::BeautySys.Properties.Resources.limpar;
            this.btnLimparProdServ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparProdServ.Location = new System.Drawing.Point(399, 377);
            this.btnLimparProdServ.Name = "btnLimparProdServ";
            this.btnLimparProdServ.Size = new System.Drawing.Size(126, 39);
            this.btnLimparProdServ.TabIndex = 109;
            this.btnLimparProdServ.Text = "Limpar Produto/Serviço";
            this.btnLimparProdServ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparProdServ.UseVisualStyleBackColor = true;
            this.btnLimparProdServ.Click += new System.EventHandler(this.btnLimparProdServ_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(461, 351);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(81, 20);
            this.txtValorTotal.TabIndex = 111;
            this.txtValorTotal.Text = "0,00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(394, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 110;
            this.label12.Text = "Valor Total:";
            // 
            // txtDescTotalPerc
            // 
            this.txtDescTotalPerc.Location = new System.Drawing.Point(307, 351);
            this.txtDescTotalPerc.Name = "txtDescTotalPerc";
            this.txtDescTotalPerc.Size = new System.Drawing.Size(81, 20);
            this.txtDescTotalPerc.TabIndex = 115;
            this.txtDescTotalPerc.Text = "0,00";
            this.txtDescTotalPerc.Leave += new System.EventHandler(this.txtDescTotalPerc_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(207, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 114;
            this.label13.Text = "Desconto Total %:";
            // 
            // txtDescTotalReal
            // 
            this.txtDescTotalReal.Location = new System.Drawing.Point(120, 351);
            this.txtDescTotalReal.Name = "txtDescTotalReal";
            this.txtDescTotalReal.Size = new System.Drawing.Size(81, 20);
            this.txtDescTotalReal.TabIndex = 113;
            this.txtDescTotalReal.Text = "0,00";
            this.txtDescTotalReal.Leave += new System.EventHandler(this.txtDescTotalReal_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 354);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 112;
            this.label14.Text = "Desconto Total R$:";
            // 
            // cboFormaPagto
            // 
            this.cboFormaPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPagto.FormattingEnabled = true;
            this.cboFormaPagto.Location = new System.Drawing.Point(131, 377);
            this.cboFormaPagto.Name = "cboFormaPagto";
            this.cboFormaPagto.Size = new System.Drawing.Size(170, 21);
            this.cboFormaPagto.TabIndex = 116;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 117;
            this.label15.Text = "Forma de Pagamento:";
            // 
            // FrmComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 422);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cboFormaPagto);
            this.Controls.Add(this.txtDescTotalPerc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDescTotalReal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnLimparProdServ);
            this.Controls.Add(this.btnLimparCliente);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtDescPerc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDescReal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtValorProdServ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboProfissional);
            this.Controls.Add(this.txtDescricaoProdServ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodigoProdServ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gpbProdServ);
            this.Controls.Add(this.txtNumeroComanda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvComanda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxbData);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label1);
            this.Name = "FrmComanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comanda";
            this.Load += new System.EventHandler(this.FrmComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).EndInit();
            this.gpbProdServ.ResumeLayout(false);
            this.gpbProdServ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxbData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvComanda;
        private System.Windows.Forms.TextBox txtNumeroComanda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbProdServ;
        private System.Windows.Forms.RadioButton rbServiço;
        private System.Windows.Forms.RadioButton rbProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoProdServ;
        private System.Windows.Forms.TextBox txtDescricaoProdServ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboProfissional;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorProdServ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescReal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescPerc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Button btnLimparCliente;
        private System.Windows.Forms.Button btnLimparProdServ;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDescTotalPerc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDescTotalReal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_serv;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.ComboBox cboFormaPagto;
        private System.Windows.Forms.Label label15;
    }
}