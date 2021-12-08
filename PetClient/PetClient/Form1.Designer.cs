namespace PetClient
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PctBxAvatar = new System.Windows.Forms.PictureBox();
            this.MnStrpMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlCadastro = new System.Windows.Forms.Panel();
            this.LblOnlyView7 = new System.Windows.Forms.Label();
            this.TxtBxQtd = new System.Windows.Forms.TextBox();
            this.LblOnlyView5 = new System.Windows.Forms.Label();
            this.TxtBxPreco = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtBxProduto = new System.Windows.Forms.TextBox();
            this.LblOnlyView3 = new System.Windows.Forms.Label();
            this.LblOnlyView2 = new System.Windows.Forms.Label();
            this.LblOnlyView1 = new System.Windows.Forms.Label();
            this.TmrAnimacaoAvatar = new System.Windows.Forms.Timer(this.components);
            this.DataSetTabelaDeProdutos = new System.Data.DataSet();
            this.DtbProdutos = new System.Data.DataTable();
            this.DtcNomeDoProduto = new System.Data.DataColumn();
            this.DtcPreco = new System.Data.DataColumn();
            this.DtcQuantidade = new System.Data.DataColumn();
            this.DtcPagamento = new System.Data.DataColumn();
            this.BndSourceTabelaDeProdutos = new System.Windows.Forms.BindingSource(this.components);
            this.DtGrdViewTabelaDeProdutos = new System.Windows.Forms.DataGridView();
            this.nomeDoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtBxFiltro = new System.Windows.Forms.TextBox();
            this.Lbl9 = new System.Windows.Forms.Label();
            this.CmbBoxProdutos = new System.Windows.Forms.ComboBox();
            this.Lbl8 = new System.Windows.Forms.Label();
            this.PnlTotais = new System.Windows.Forms.Panel();
            this.TxtBxContadorDeProdutos = new System.Windows.Forms.TextBox();
            this.Lbl11 = new System.Windows.Forms.Label();
            this.TxtBxTotal = new System.Windows.Forms.TextBox();
            this.Lbl10 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ckBxDinheiro = new System.Windows.Forms.CheckBox();
            this.ckBxCartao = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxAvatar)).BeginInit();
            this.MnStrpMenu.SuspendLayout();
            this.PnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTabelaDeProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtbProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BndSourceTabelaDeProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdViewTabelaDeProdutos)).BeginInit();
            this.panel1.SuspendLayout();
            this.PnlTotais.SuspendLayout();
            this.SuspendLayout();
            // 
            // PctBxAvatar
            // 
            this.PctBxAvatar.Location = new System.Drawing.Point(12, 366);
            this.PctBxAvatar.Name = "PctBxAvatar";
            this.PctBxAvatar.Size = new System.Drawing.Size(36, 35);
            this.PctBxAvatar.TabIndex = 0;
            this.PctBxAvatar.TabStop = false;
            // 
            // MnStrpMenu
            // 
            this.MnStrpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.MnStrpMenu.Location = new System.Drawing.Point(0, 0);
            this.MnStrpMenu.Name = "MnStrpMenu";
            this.MnStrpMenu.Size = new System.Drawing.Size(755, 24);
            this.MnStrpMenu.TabIndex = 1;
            this.MnStrpMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // PnlCadastro
            // 
            this.PnlCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnlCadastro.Controls.Add(this.ckBxCartao);
            this.PnlCadastro.Controls.Add(this.ckBxDinheiro);
            this.PnlCadastro.Controls.Add(this.LblOnlyView7);
            this.PnlCadastro.Controls.Add(this.TxtBxQtd);
            this.PnlCadastro.Controls.Add(this.LblOnlyView5);
            this.PnlCadastro.Controls.Add(this.TxtBxPreco);
            this.PnlCadastro.Controls.Add(this.BtnSalvar);
            this.PnlCadastro.Controls.Add(this.TxtBxProduto);
            this.PnlCadastro.Controls.Add(this.LblOnlyView3);
            this.PnlCadastro.Controls.Add(this.LblOnlyView2);
            this.PnlCadastro.Controls.Add(this.LblOnlyView1);
            this.PnlCadastro.Location = new System.Drawing.Point(12, 27);
            this.PnlCadastro.Name = "PnlCadastro";
            this.PnlCadastro.Size = new System.Drawing.Size(273, 271);
            this.PnlCadastro.TabIndex = 2;
            // 
            // LblOnlyView7
            // 
            this.LblOnlyView7.AutoSize = true;
            this.LblOnlyView7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOnlyView7.Location = new System.Drawing.Point(12, 187);
            this.LblOnlyView7.Name = "LblOnlyView7";
            this.LblOnlyView7.Size = new System.Drawing.Size(244, 18);
            this.LblOnlyView7.TabIndex = 9;
            this.LblOnlyView7.Text = "Selecione a forma de pagamento:";
            // 
            // TxtBxQtd
            // 
            this.TxtBxQtd.Location = new System.Drawing.Point(167, 143);
            this.TxtBxQtd.Name = "TxtBxQtd";
            this.TxtBxQtd.Size = new System.Drawing.Size(76, 20);
            this.TxtBxQtd.TabIndex = 8;
            this.TxtBxQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerificaNumeros);
            // 
            // LblOnlyView5
            // 
            this.LblOnlyView5.AutoSize = true;
            this.LblOnlyView5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOnlyView5.Location = new System.Drawing.Point(164, 122);
            this.LblOnlyView5.Name = "LblOnlyView5";
            this.LblOnlyView5.Size = new System.Drawing.Size(45, 18);
            this.LblOnlyView5.TabIndex = 7;
            this.LblOnlyView5.Text = "QTD:";
            // 
            // TxtBxPreco
            // 
            this.TxtBxPreco.Location = new System.Drawing.Point(32, 143);
            this.TxtBxPreco.Name = "TxtBxPreco";
            this.TxtBxPreco.Size = new System.Drawing.Size(100, 20);
            this.TxtBxPreco.TabIndex = 6;
            this.TxtBxPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerificaNumeros);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalvar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.Gold;
            this.BtnSalvar.Location = new System.Drawing.Point(195, 245);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 5;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtBxProduto
            // 
            this.TxtBxProduto.Location = new System.Drawing.Point(32, 78);
            this.TxtBxProduto.Name = "TxtBxProduto";
            this.TxtBxProduto.Size = new System.Drawing.Size(211, 20);
            this.TxtBxProduto.TabIndex = 3;
            this.TxtBxProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerificaCaracteres);
            // 
            // LblOnlyView3
            // 
            this.LblOnlyView3.AutoSize = true;
            this.LblOnlyView3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOnlyView3.Location = new System.Drawing.Point(29, 122);
            this.LblOnlyView3.Name = "LblOnlyView3";
            this.LblOnlyView3.Size = new System.Drawing.Size(54, 18);
            this.LblOnlyView3.TabIndex = 2;
            this.LblOnlyView3.Text = "Preço:";
            // 
            // LblOnlyView2
            // 
            this.LblOnlyView2.AutoSize = true;
            this.LblOnlyView2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOnlyView2.Location = new System.Drawing.Point(29, 57);
            this.LblOnlyView2.Name = "LblOnlyView2";
            this.LblOnlyView2.Size = new System.Drawing.Size(133, 18);
            this.LblOnlyView2.TabIndex = 1;
            this.LblOnlyView2.Text = "Nome do produto:";
            // 
            // LblOnlyView1
            // 
            this.LblOnlyView1.AutoSize = true;
            this.LblOnlyView1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOnlyView1.Location = new System.Drawing.Point(90, 12);
            this.LblOnlyView1.Name = "LblOnlyView1";
            this.LblOnlyView1.Size = new System.Drawing.Size(87, 30);
            this.LblOnlyView1.TabIndex = 0;
            this.LblOnlyView1.Text = "Caixa";
            // 
            // TmrAnimacaoAvatar
            // 
            this.TmrAnimacaoAvatar.Enabled = true;
            this.TmrAnimacaoAvatar.Interval = 500;
            this.TmrAnimacaoAvatar.Tick += new System.EventHandler(this.TmrAnimacaoAvatar_Tick);
            // 
            // DataSetTabelaDeProdutos
            // 
            this.DataSetTabelaDeProdutos.DataSetName = "NewDataSet";
            this.DataSetTabelaDeProdutos.Tables.AddRange(new System.Data.DataTable[] {
            this.DtbProdutos});
            // 
            // DtbProdutos
            // 
            this.DtbProdutos.Columns.AddRange(new System.Data.DataColumn[] {
            this.DtcNomeDoProduto,
            this.DtcPreco,
            this.DtcQuantidade,
            this.DtcPagamento});
            this.DtbProdutos.TableName = "TabelaDeProdutos";
            // 
            // DtcNomeDoProduto
            // 
            this.DtcNomeDoProduto.ColumnName = "NomeDoProduto";
            // 
            // DtcPreco
            // 
            this.DtcPreco.ColumnName = "Preco";
            // 
            // DtcQuantidade
            // 
            this.DtcQuantidade.ColumnName = "Quantidade";
            // 
            // DtcPagamento
            // 
            this.DtcPagamento.ColumnName = "Pagamento";
            // 
            // BndSourceTabelaDeProdutos
            // 
            this.BndSourceTabelaDeProdutos.DataMember = "TabelaDeProdutos";
            this.BndSourceTabelaDeProdutos.DataSource = this.DataSetTabelaDeProdutos;
            // 
            // DtGrdViewTabelaDeProdutos
            // 
            this.DtGrdViewTabelaDeProdutos.AutoGenerateColumns = false;
            this.DtGrdViewTabelaDeProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdViewTabelaDeProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDoProdutoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.pagamentoDataGridViewTextBoxColumn});
            this.DtGrdViewTabelaDeProdutos.DataSource = this.BndSourceTabelaDeProdutos;
            this.DtGrdViewTabelaDeProdutos.Location = new System.Drawing.Point(291, 82);
            this.DtGrdViewTabelaDeProdutos.Name = "DtGrdViewTabelaDeProdutos";
            this.DtGrdViewTabelaDeProdutos.Size = new System.Drawing.Size(452, 150);
            this.DtGrdViewTabelaDeProdutos.TabIndex = 3;
            // 
            // nomeDoProdutoDataGridViewTextBoxColumn
            // 
            this.nomeDoProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeDoProduto";
            this.nomeDoProdutoDataGridViewTextBoxColumn.HeaderText = "NomeDoProduto";
            this.nomeDoProdutoDataGridViewTextBoxColumn.Name = "nomeDoProdutoDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // pagamentoDataGridViewTextBoxColumn
            // 
            this.pagamentoDataGridViewTextBoxColumn.DataPropertyName = "Pagamento";
            this.pagamentoDataGridViewTextBoxColumn.HeaderText = "Pagamento";
            this.pagamentoDataGridViewTextBoxColumn.Name = "pagamentoDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.TxtBxFiltro);
            this.panel1.Controls.Add(this.Lbl9);
            this.panel1.Controls.Add(this.CmbBoxProdutos);
            this.panel1.Controls.Add(this.Lbl8);
            this.panel1.Location = new System.Drawing.Point(291, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 51);
            this.panel1.TabIndex = 4;
            // 
            // TxtBxFiltro
            // 
            this.TxtBxFiltro.Location = new System.Drawing.Point(352, 24);
            this.TxtBxFiltro.Name = "TxtBxFiltro";
            this.TxtBxFiltro.Size = new System.Drawing.Size(87, 20);
            this.TxtBxFiltro.TabIndex = 3;
            this.TxtBxFiltro.TextChanged += new System.EventHandler(this.TxtBxFiltro_TextChanged);
            // 
            // Lbl9
            // 
            this.Lbl9.AutoSize = true;
            this.Lbl9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl9.Location = new System.Drawing.Point(309, 28);
            this.Lbl9.Name = "Lbl9";
            this.Lbl9.Size = new System.Drawing.Size(37, 16);
            this.Lbl9.TabIndex = 2;
            this.Lbl9.Text = "Filtro";
            // 
            // CmbBoxProdutos
            // 
            this.CmbBoxProdutos.FormattingEnabled = true;
            this.CmbBoxProdutos.Items.AddRange(new object[] {
            "NomeDoProduto",
            "Preco",
            "Pagamento",
            "Quantidade"});
            this.CmbBoxProdutos.Location = new System.Drawing.Point(182, 23);
            this.CmbBoxProdutos.Name = "CmbBoxProdutos";
            this.CmbBoxProdutos.Size = new System.Drawing.Size(121, 21);
            this.CmbBoxProdutos.TabIndex = 1;
            // 
            // Lbl8
            // 
            this.Lbl8.AutoSize = true;
            this.Lbl8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl8.Location = new System.Drawing.Point(13, 23);
            this.Lbl8.Name = "Lbl8";
            this.Lbl8.Size = new System.Drawing.Size(163, 18);
            this.Lbl8.TabIndex = 0;
            this.Lbl8.Text = "Procurar pelo produto:";
            // 
            // PnlTotais
            // 
            this.PnlTotais.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnlTotais.Controls.Add(this.TxtBxContadorDeProdutos);
            this.PnlTotais.Controls.Add(this.Lbl11);
            this.PnlTotais.Controls.Add(this.TxtBxTotal);
            this.PnlTotais.Controls.Add(this.Lbl10);
            this.PnlTotais.Location = new System.Drawing.Point(14, 309);
            this.PnlTotais.Name = "PnlTotais";
            this.PnlTotais.Size = new System.Drawing.Size(271, 51);
            this.PnlTotais.TabIndex = 5;
            // 
            // TxtBxContadorDeProdutos
            // 
            this.TxtBxContadorDeProdutos.Location = new System.Drawing.Point(238, 17);
            this.TxtBxContadorDeProdutos.Name = "TxtBxContadorDeProdutos";
            this.TxtBxContadorDeProdutos.Size = new System.Drawing.Size(30, 20);
            this.TxtBxContadorDeProdutos.TabIndex = 3;
            // 
            // Lbl11
            // 
            this.Lbl11.AutoSize = true;
            this.Lbl11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl11.Location = new System.Drawing.Point(136, 20);
            this.Lbl11.Name = "Lbl11";
            this.Lbl11.Size = new System.Drawing.Size(100, 14);
            this.Lbl11.TabIndex = 2;
            this.Lbl11.Text = "Produtos vendidos:";
            // 
            // TxtBxTotal
            // 
            this.TxtBxTotal.Location = new System.Drawing.Point(73, 17);
            this.TxtBxTotal.Name = "TxtBxTotal";
            this.TxtBxTotal.Size = new System.Drawing.Size(57, 20);
            this.TxtBxTotal.TabIndex = 1;
            // 
            // Lbl10
            // 
            this.Lbl10.AutoSize = true;
            this.Lbl10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl10.Location = new System.Drawing.Point(13, 18);
            this.Lbl10.Name = "Lbl10";
            this.Lbl10.Size = new System.Drawing.Size(54, 16);
            this.Lbl10.TabIndex = 0;
            this.Lbl10.Text = "Total $ :";
            // 
            // ckBxDinheiro
            // 
            this.ckBxDinheiro.AutoSize = true;
            this.ckBxDinheiro.Location = new System.Drawing.Point(18, 222);
            this.ckBxDinheiro.Name = "ckBxDinheiro";
            this.ckBxDinheiro.Size = new System.Drawing.Size(65, 17);
            this.ckBxDinheiro.TabIndex = 10;
            this.ckBxDinheiro.Text = "Dinheiro";
            this.ckBxDinheiro.UseVisualStyleBackColor = true;
            // 
            // ckBxCartao
            // 
            this.ckBxCartao.AutoSize = true;
            this.ckBxCartao.Location = new System.Drawing.Point(141, 222);
            this.ckBxCartao.Name = "ckBxCartao";
            this.ckBxCartao.Size = new System.Drawing.Size(79, 17);
            this.ckBxCartao.TabIndex = 11;
            this.ckBxCartao.Text = "Cartão/PIX";
            this.ckBxCartao.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 413);
            this.Controls.Add(this.PnlTotais);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DtGrdViewTabelaDeProdutos);
            this.Controls.Add(this.PnlCadastro);
            this.Controls.Add(this.PctBxAvatar);
            this.Controls.Add(this.MnStrpMenu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnStrpMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Caixa - Nutri Pets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PctBxAvatar)).EndInit();
            this.MnStrpMenu.ResumeLayout(false);
            this.MnStrpMenu.PerformLayout();
            this.PnlCadastro.ResumeLayout(false);
            this.PnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTabelaDeProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtbProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BndSourceTabelaDeProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdViewTabelaDeProdutos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlTotais.ResumeLayout(false);
            this.PnlTotais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctBxAvatar;
        private System.Windows.Forms.MenuStrip MnStrpMenu;
        private System.Windows.Forms.Panel PnlCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.Timer TmrAnimacaoAvatar;
        private System.Windows.Forms.TextBox TxtBxProduto;
        private System.Windows.Forms.Label LblOnlyView3;
        private System.Windows.Forms.Label LblOnlyView2;
        private System.Windows.Forms.Label LblOnlyView1;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox TxtBxPreco;
        private System.Windows.Forms.TextBox TxtBxQtd;
        private System.Windows.Forms.Label LblOnlyView5;
        private System.Data.DataSet DataSetTabelaDeProdutos;
        private System.Data.DataTable DtbProdutos;
        private System.Data.DataColumn DtcNomeDoProduto;
        private System.Data.DataColumn DtcPreco;
        private System.Data.DataColumn DtcQuantidade;
        private System.Data.DataColumn DtcPagamento;
        private System.Windows.Forms.BindingSource BndSourceTabelaDeProdutos;
        private System.Windows.Forms.DataGridView DtGrdViewTabelaDeProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LblOnlyView7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtBxFiltro;
        private System.Windows.Forms.Label Lbl9;
        private System.Windows.Forms.ComboBox CmbBoxProdutos;
        private System.Windows.Forms.Label Lbl8;
        private System.Windows.Forms.Panel PnlTotais;
        private System.Windows.Forms.TextBox TxtBxContadorDeProdutos;
        private System.Windows.Forms.Label Lbl11;
        private System.Windows.Forms.TextBox TxtBxTotal;
        private System.Windows.Forms.Label Lbl10;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox ckBxCartao;
        private System.Windows.Forms.CheckBox ckBxDinheiro;
    }
}

