namespace BeautySys.Forms
{
    partial class FrmFluxoCaixa
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
            this.tabGrids = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvComandasCanceladas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvContasRecebidas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbTotais = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotalSaidas = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalEntradas = new System.Windows.Forms.Label();
            this.lblTotalCReceber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalComanda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalAbertura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tabGrids.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandasCanceladas)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasRecebidas)).BeginInit();
            this.gpbTotais.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGrids
            // 
            this.tabGrids.Controls.Add(this.tabPage1);
            this.tabGrids.Controls.Add(this.tabPage2);
            this.tabGrids.Controls.Add(this.tabPage3);
            this.tabGrids.Location = new System.Drawing.Point(12, 12);
            this.tabGrids.Name = "tabGrids";
            this.tabGrids.SelectedIndex = 0;
            this.tabGrids.Size = new System.Drawing.Size(403, 353);
            this.tabGrids.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvComandas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(395, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Comandas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvComandas
            // 
            this.dgvComandas.AllowUserToAddRows = false;
            this.dgvComandas.AllowUserToDeleteRows = false;
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.cliente,
            this.valor});
            this.dgvComandas.Location = new System.Drawing.Point(6, 6);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.ReadOnly = true;
            this.dgvComandas.Size = new System.Drawing.Size(383, 315);
            this.dgvComandas.TabIndex = 0;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 80;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 60;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvComandasCanceladas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(395, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comandas Canceladas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvComandasCanceladas
            // 
            this.dgvComandasCanceladas.AllowUserToAddRows = false;
            this.dgvComandasCanceladas.AllowUserToDeleteRows = false;
            this.dgvComandasCanceladas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandasCanceladas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvComandasCanceladas.Location = new System.Drawing.Point(6, 6);
            this.dgvComandasCanceladas.Name = "dgvComandasCanceladas";
            this.dgvComandasCanceladas.ReadOnly = true;
            this.dgvComandasCanceladas.Size = new System.Drawing.Size(383, 315);
            this.dgvComandasCanceladas.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Número";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvContasRecebidas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(395, 327);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Contas Recebidas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvContasRecebidas
            // 
            this.dgvContasRecebidas.AllowUserToAddRows = false;
            this.dgvContasRecebidas.AllowUserToDeleteRows = false;
            this.dgvContasRecebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContasRecebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvContasRecebidas.Location = new System.Drawing.Point(6, 6);
            this.dgvContasRecebidas.Name = "dgvContasRecebidas";
            this.dgvContasRecebidas.ReadOnly = true;
            this.dgvContasRecebidas.Size = new System.Drawing.Size(383, 315);
            this.dgvContasRecebidas.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Número";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // gpbTotais
            // 
            this.gpbTotais.Controls.Add(this.label13);
            this.gpbTotais.Controls.Add(this.lblTotalSaidas);
            this.gpbTotais.Controls.Add(this.label11);
            this.gpbTotais.Controls.Add(this.lblTotalEntradas);
            this.gpbTotais.Controls.Add(this.lblTotalCReceber);
            this.gpbTotais.Controls.Add(this.label9);
            this.gpbTotais.Controls.Add(this.lblSaldo);
            this.gpbTotais.Controls.Add(this.label7);
            this.gpbTotais.Controls.Add(this.lblTotalComanda);
            this.gpbTotais.Controls.Add(this.label5);
            this.gpbTotais.Controls.Add(this.lblTotalAbertura);
            this.gpbTotais.Controls.Add(this.label1);
            this.gpbTotais.Location = new System.Drawing.Point(420, 85);
            this.gpbTotais.Name = "gpbTotais";
            this.gpbTotais.Size = new System.Drawing.Size(276, 186);
            this.gpbTotais.TabIndex = 1;
            this.gpbTotais.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Saídas: R$";
            // 
            // lblTotalSaidas
            // 
            this.lblTotalSaidas.AutoSize = true;
            this.lblTotalSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaidas.Location = new System.Drawing.Point(99, 74);
            this.lblTotalSaidas.Name = "lblTotalSaidas";
            this.lblTotalSaidas.Size = new System.Drawing.Size(40, 20);
            this.lblTotalSaidas.TabIndex = 10;
            this.lblTotalSaidas.Text = "0,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Entradas: R$";
            // 
            // lblTotalEntradas
            // 
            this.lblTotalEntradas.AutoSize = true;
            this.lblTotalEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEntradas.Location = new System.Drawing.Point(115, 45);
            this.lblTotalEntradas.Name = "lblTotalEntradas";
            this.lblTotalEntradas.Size = new System.Drawing.Size(40, 20);
            this.lblTotalEntradas.TabIndex = 8;
            this.lblTotalEntradas.Text = "0,00";
            // 
            // lblTotalCReceber
            // 
            this.lblTotalCReceber.AutoSize = true;
            this.lblTotalCReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCReceber.Location = new System.Drawing.Point(181, 129);
            this.lblTotalCReceber.Name = "lblTotalCReceber";
            this.lblTotalCReceber.Size = new System.Drawing.Size(40, 20);
            this.lblTotalCReceber.TabIndex = 7;
            this.lblTotalCReceber.Text = "0,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Contas Recebidas: R$";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(91, 157);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(40, 20);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Abertura: R$";
            // 
            // lblTotalComanda
            // 
            this.lblTotalComanda.AutoSize = true;
            this.lblTotalComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComanda.Location = new System.Drawing.Point(127, 101);
            this.lblTotalComanda.Name = "lblTotalComanda";
            this.lblTotalComanda.Size = new System.Drawing.Size(40, 20);
            this.lblTotalComanda.TabIndex = 3;
            this.lblTotalComanda.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saldo: R$";
            // 
            // lblTotalAbertura
            // 
            this.lblTotalAbertura.AutoSize = true;
            this.lblTotalAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAbertura.Location = new System.Drawing.Point(112, 16);
            this.lblTotalAbertura.Name = "lblTotalAbertura";
            this.lblTotalAbertura.Size = new System.Drawing.Size(40, 20);
            this.lblTotalAbertura.TabIndex = 1;
            this.lblTotalAbertura.Text = "0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comandas: R$";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(460, 14);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(96, 20);
            this.dtpDataInicial.TabIndex = 102;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(600, 14);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(96, 20);
            this.dtpDataFinal.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Início:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Final:";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Image = global::BeautySys.Properties.Resources.pesquisar;
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizar.Location = new System.Drawing.Point(421, 40);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(82, 39);
            this.btnLocalizar.TabIndex = 101;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::BeautySys.Properties.Resources.fechar;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(616, 40);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 39);
            this.btnFechar.TabIndex = 106;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 371);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.gpbTotais);
            this.Controls.Add(this.tabGrids);
            this.Name = "FrmFluxoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluxo de Caixa";
            this.tabGrids.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandasCanceladas)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasRecebidas)).EndInit();
            this.gpbTotais.ResumeLayout(false);
            this.gpbTotais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabGrids;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gpbTotais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotalSaidas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalEntradas;
        private System.Windows.Forms.Label lblTotalCReceber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalComanda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalAbertura;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridView dgvComandasCanceladas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dgvContasRecebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}