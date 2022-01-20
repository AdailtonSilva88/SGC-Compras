namespace SGC_Gerenciamento_de_Compras
{
    partial class frmPedidos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddFabricante = new System.Windows.Forms.Button();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.dgvProdutosPedido = new System.Windows.Forms.DataGridView();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProdutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.lblPedidoFabricante = new System.Windows.Forms.Label();
            this.lblNomeVendedor = new System.Windows.Forms.Label();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.lblPrevFaturamento = new System.Windows.Forms.Label();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.lblPedidoComprador = new System.Windows.Forms.Label();
            this.txtPedidoFabricante = new System.Windows.Forms.TextBox();
            this.txtNomeComprador = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtPedidoComprador = new System.Windows.Forms.TextBox();
            this.cbxFabricante = new System.Windows.Forms.ComboBox();
            this.tBFABRICANTEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sGC_DBDataSet3 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet3();
            this.cbxCompraUnidade = new System.Windows.Forms.ComboBox();
            this.tBUNIDADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGC_DBDataSet4 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet4();
            this.dtDataPedido = new System.Windows.Forms.DateTimePicker();
            this.dtPrevisaoFaturamento = new System.Windows.Forms.DateTimePicker();
            this.gpFabricante = new System.Windows.Forms.GroupBox();
            this.txtParcela = new System.Windows.Forms.MaskedTextBox();
            this.txtPrazo = new System.Windows.Forms.MaskedTextBox();
            this.gpComprador = new System.Windows.Forms.GroupBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.btnAddCompraUnidade = new System.Windows.Forms.Button();
            this.lblNomeComprador = new System.Windows.Forms.Label();
            this.lblCompraUnidade = new System.Windows.Forms.Label();
            this.lblProdutosPedido = new System.Windows.Forms.Label();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gpProdutos = new System.Windows.Forms.GroupBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblLançamentoPedidos = new System.Windows.Forms.Label();
            this.sGC_DBDataSet = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet();
            this.sGCDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGC_DBDataSet2 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet2();
            this.tBFABRICANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_FABRICANTETableAdapter = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet2TableAdapters.TB_FABRICANTETableAdapter();
            this.tB_FABRICANTETableAdapter1 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet3TableAdapters.TB_FABRICANTETableAdapter();
            this.tB_UNIDADETableAdapter = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet4TableAdapters.TB_UNIDADETableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEtapa = new System.Windows.Forms.ComboBox();
            this.tBETAPAPEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGC_DBDataSet10 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet10();
            this.sGC_DBDataSet9 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet9();
            this.tBUNIDADEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tB_UNIDADETableAdapter1 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet9TableAdapters.TB_UNIDADETableAdapter();
            this.tB_ETAPA_PEDIDOTableAdapter = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet10TableAdapters.TB_ETAPA_PEDIDOTableAdapter();
            this.lblIdPedido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFABRICANTEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUNIDADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet4)).BeginInit();
            this.gpFabricante.SuspendLayout();
            this.gpComprador.SuspendLayout();
            this.gpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGCDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFABRICANTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBETAPAPEDIDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUNIDADEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFabricante
            // 
            this.btnAddFabricante.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddFabricante.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFabricante.Location = new System.Drawing.Point(190, 45);
            this.btnAddFabricante.Name = "btnAddFabricante";
            this.btnAddFabricante.Size = new System.Drawing.Size(29, 21);
            this.btnAddFabricante.TabIndex = 0;
            this.btnAddFabricante.TabStop = false;
            this.btnAddFabricante.Text = "+";
            this.btnAddFabricante.UseVisualStyleBackColor = true;
            this.btnAddFabricante.Click += new System.EventHandler(this.btnAddFabricante_Click);
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(17, 29);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 0;
            this.lblFabricante.Text = "Fabricante";
            // 
            // dgvProdutosPedido
            // 
            this.dgvProdutosPedido.AllowUserToAddRows = false;
            this.dgvProdutosPedido.AllowUserToDeleteRows = false;
            this.dgvProdutosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProduto,
            this.nomeProduto,
            this.qtdProduto,
            this.precoProduto,
            this.totalProdutos});
            this.dgvProdutosPedido.Location = new System.Drawing.Point(12, 531);
            this.dgvProdutosPedido.Name = "dgvProdutosPedido";
            this.dgvProdutosPedido.ReadOnly = true;
            this.dgvProdutosPedido.RowHeadersVisible = false;
            this.dgvProdutosPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosPedido.Size = new System.Drawing.Size(624, 191);
            this.dgvProdutosPedido.TabIndex = 0;
            this.dgvProdutosPedido.TabStop = false;
            this.dgvProdutosPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutosPedido_CellDoubleClick);
            // 
            // CodProduto
            // 
            this.CodProduto.HeaderText = "Codigo";
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.ReadOnly = true;
            this.CodProduto.Width = 80;
            // 
            // nomeProduto
            // 
            this.nomeProduto.HeaderText = "Nome do Produto";
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.ReadOnly = true;
            this.nomeProduto.Width = 280;
            // 
            // qtdProduto
            // 
            this.qtdProduto.HeaderText = "Qtd";
            this.qtdProduto.Name = "qtdProduto";
            this.qtdProduto.ReadOnly = true;
            this.qtdProduto.Width = 60;
            // 
            // precoProduto
            // 
            dataGridViewCellStyle13.Format = "C2";
            dataGridViewCellStyle13.NullValue = null;
            this.precoProduto.DefaultCellStyle = dataGridViewCellStyle13;
            this.precoProduto.HeaderText = "Preço";
            this.precoProduto.Name = "precoProduto";
            this.precoProduto.ReadOnly = true;
            // 
            // totalProdutos
            // 
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.totalProdutos.DefaultCellStyle = dataGridViewCellStyle14;
            this.totalProdutos.HeaderText = "Total";
            this.totalProdutos.Name = "totalProdutos";
            this.totalProdutos.ReadOnly = true;
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(468, 45);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(114, 20);
            this.txtNomeVendedor.TabIndex = 3;
            // 
            // lblPedidoFabricante
            // 
            this.lblPedidoFabricante.AutoSize = true;
            this.lblPedidoFabricante.Location = new System.Drawing.Point(280, 29);
            this.lblPedidoFabricante.Name = "lblPedidoFabricante";
            this.lblPedidoFabricante.Size = new System.Drawing.Size(93, 13);
            this.lblPedidoFabricante.TabIndex = 0;
            this.lblPedidoFabricante.Text = "Pedido Fabricante";
            // 
            // lblNomeVendedor
            // 
            this.lblNomeVendedor.AutoSize = true;
            this.lblNomeVendedor.Location = new System.Drawing.Point(469, 29);
            this.lblNomeVendedor.Name = "lblNomeVendedor";
            this.lblNomeVendedor.Size = new System.Drawing.Size(84, 13);
            this.lblNomeVendedor.TabIndex = 0;
            this.lblNomeVendedor.Text = "Nome Vendedor";
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Location = new System.Drawing.Point(17, 86);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(81, 13);
            this.lblDataPedido.TabIndex = 0;
            this.lblDataPedido.Text = "Data do Pedido";
            // 
            // lblPrevFaturamento
            // 
            this.lblPrevFaturamento.AutoSize = true;
            this.lblPrevFaturamento.Location = new System.Drawing.Point(151, 86);
            this.lblPrevFaturamento.Name = "lblPrevFaturamento";
            this.lblPrevFaturamento.Size = new System.Drawing.Size(125, 13);
            this.lblPrevFaturamento.TabIndex = 0;
            this.lblPrevFaturamento.Text = "Previsão de Faturamento";
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Location = new System.Drawing.Point(308, 86);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(34, 13);
            this.lblPrazo.TabIndex = 0;
            this.lblPrazo.Text = "Prazo";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(465, 86);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(43, 13);
            this.lblParcela.TabIndex = 0;
            this.lblParcela.Text = "Parcela";
            // 
            // lblPedidoComprador
            // 
            this.lblPedidoComprador.AutoSize = true;
            this.lblPedidoComprador.Location = new System.Drawing.Point(17, 37);
            this.lblPedidoComprador.Name = "lblPedidoComprador";
            this.lblPedidoComprador.Size = new System.Drawing.Size(94, 13);
            this.lblPedidoComprador.TabIndex = 0;
            this.lblPedidoComprador.Text = "Pedido Comprador";
            // 
            // txtPedidoFabricante
            // 
            this.txtPedidoFabricante.Location = new System.Drawing.Point(283, 45);
            this.txtPedidoFabricante.Name = "txtPedidoFabricante";
            this.txtPedidoFabricante.Size = new System.Drawing.Size(124, 20);
            this.txtPedidoFabricante.TabIndex = 2;
            // 
            // txtNomeComprador
            // 
            this.txtNomeComprador.Location = new System.Drawing.Point(468, 53);
            this.txtNomeComprador.Name = "txtNomeComprador";
            this.txtNomeComprador.Size = new System.Drawing.Size(129, 20);
            this.txtNomeComprador.TabIndex = 10;
            this.txtNomeComprador.TextChanged += new System.EventHandler(this.txtNomeComprador_TextChanged);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(96, 97);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(501, 26);
            this.txtObs.TabIndex = 11;
            // 
            // txtPedidoComprador
            // 
            this.txtPedidoComprador.Location = new System.Drawing.Point(20, 53);
            this.txtPedidoComprador.Name = "txtPedidoComprador";
            this.txtPedidoComprador.Size = new System.Drawing.Size(153, 20);
            this.txtPedidoComprador.TabIndex = 8;
            // 
            // cbxFabricante
            // 
            this.cbxFabricante.DataSource = this.tBFABRICANTEBindingSource1;
            this.cbxFabricante.DisplayMember = "NOME_FABRICANTE";
            this.cbxFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFabricante.FormattingEnabled = true;
            this.cbxFabricante.Location = new System.Drawing.Point(20, 45);
            this.cbxFabricante.Name = "cbxFabricante";
            this.cbxFabricante.Size = new System.Drawing.Size(164, 21);
            this.cbxFabricante.TabIndex = 1;
            this.cbxFabricante.ValueMember = "ID_FABRICANTE";
            // 
            // tBFABRICANTEBindingSource1
            // 
            this.tBFABRICANTEBindingSource1.DataMember = "TB_FABRICANTE";
            this.tBFABRICANTEBindingSource1.DataSource = this.sGC_DBDataSet3;
            // 
            // sGC_DBDataSet3
            // 
            this.sGC_DBDataSet3.DataSetName = "SGC_DBDataSet3";
            this.sGC_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxCompraUnidade
            // 
            this.cbxCompraUnidade.DataSource = this.tBUNIDADEBindingSource;
            this.cbxCompraUnidade.DisplayMember = "NOME_UNIDADE";
            this.cbxCompraUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCompraUnidade.FormattingEnabled = true;
            this.cbxCompraUnidade.Location = new System.Drawing.Point(190, 52);
            this.cbxCompraUnidade.Name = "cbxCompraUnidade";
            this.cbxCompraUnidade.Size = new System.Drawing.Size(217, 21);
            this.cbxCompraUnidade.TabIndex = 9;
            this.cbxCompraUnidade.ValueMember = "ID_UNIDADE";
            // 
            // tBUNIDADEBindingSource
            // 
            this.tBUNIDADEBindingSource.DataMember = "TB_UNIDADE";
            this.tBUNIDADEBindingSource.DataSource = this.sGC_DBDataSet4;
            // 
            // sGC_DBDataSet4
            // 
            this.sGC_DBDataSet4.DataSetName = "SGC_DBDataSet4";
            this.sGC_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtDataPedido
            // 
            this.dtDataPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataPedido.Location = new System.Drawing.Point(20, 103);
            this.dtDataPedido.Name = "dtDataPedido";
            this.dtDataPedido.Size = new System.Drawing.Size(106, 20);
            this.dtDataPedido.TabIndex = 4;
            // 
            // dtPrevisaoFaturamento
            // 
            this.dtPrevisaoFaturamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPrevisaoFaturamento.Location = new System.Drawing.Point(154, 103);
            this.dtPrevisaoFaturamento.Name = "dtPrevisaoFaturamento";
            this.dtPrevisaoFaturamento.Size = new System.Drawing.Size(106, 20);
            this.dtPrevisaoFaturamento.TabIndex = 5;
            // 
            // gpFabricante
            // 
            this.gpFabricante.Controls.Add(this.txtParcela);
            this.gpFabricante.Controls.Add(this.txtPrazo);
            this.gpFabricante.Controls.Add(this.dtPrevisaoFaturamento);
            this.gpFabricante.Controls.Add(this.btnAddFabricante);
            this.gpFabricante.Controls.Add(this.dtDataPedido);
            this.gpFabricante.Controls.Add(this.lblFabricante);
            this.gpFabricante.Controls.Add(this.txtNomeVendedor);
            this.gpFabricante.Controls.Add(this.cbxFabricante);
            this.gpFabricante.Controls.Add(this.lblPedidoFabricante);
            this.gpFabricante.Controls.Add(this.lblNomeVendedor);
            this.gpFabricante.Controls.Add(this.lblDataPedido);
            this.gpFabricante.Controls.Add(this.lblPrevFaturamento);
            this.gpFabricante.Controls.Add(this.lblPrazo);
            this.gpFabricante.Controls.Add(this.lblParcela);
            this.gpFabricante.Controls.Add(this.txtPedidoFabricante);
            this.gpFabricante.Location = new System.Drawing.Point(12, 96);
            this.gpFabricante.Name = "gpFabricante";
            this.gpFabricante.Size = new System.Drawing.Size(624, 147);
            this.gpFabricante.TabIndex = 0;
            this.gpFabricante.TabStop = false;
            this.gpFabricante.Text = "Dados Fabricante";
            // 
            // txtParcela
            // 
            this.txtParcela.Location = new System.Drawing.Point(468, 102);
            this.txtParcela.Mask = "99";
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(100, 20);
            this.txtParcela.TabIndex = 7;
            this.txtParcela.TextChanged += new System.EventHandler(this.txtParcela_TextChanged);
            // 
            // txtPrazo
            // 
            this.txtPrazo.Location = new System.Drawing.Point(311, 102);
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(100, 20);
            this.txtPrazo.TabIndex = 6;
            // 
            // gpComprador
            // 
            this.gpComprador.Controls.Add(this.lblObs);
            this.gpComprador.Controls.Add(this.btnAddCompraUnidade);
            this.gpComprador.Controls.Add(this.lblNomeComprador);
            this.gpComprador.Controls.Add(this.lblCompraUnidade);
            this.gpComprador.Controls.Add(this.lblPedidoComprador);
            this.gpComprador.Controls.Add(this.txtPedidoComprador);
            this.gpComprador.Controls.Add(this.cbxCompraUnidade);
            this.gpComprador.Controls.Add(this.txtObs);
            this.gpComprador.Controls.Add(this.txtNomeComprador);
            this.gpComprador.Enabled = false;
            this.gpComprador.Location = new System.Drawing.Point(12, 249);
            this.gpComprador.Name = "gpComprador";
            this.gpComprador.Size = new System.Drawing.Size(624, 138);
            this.gpComprador.TabIndex = 0;
            this.gpComprador.TabStop = false;
            this.gpComprador.Text = "Dados Comprador";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(17, 97);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(73, 13);
            this.lblObs.TabIndex = 0;
            this.lblObs.Text = "Observações:";
            // 
            // btnAddCompraUnidade
            // 
            this.btnAddCompraUnidade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddCompraUnidade.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCompraUnidade.Location = new System.Drawing.Point(413, 52);
            this.btnAddCompraUnidade.Name = "btnAddCompraUnidade";
            this.btnAddCompraUnidade.Size = new System.Drawing.Size(31, 21);
            this.btnAddCompraUnidade.TabIndex = 0;
            this.btnAddCompraUnidade.TabStop = false;
            this.btnAddCompraUnidade.Text = "+";
            this.btnAddCompraUnidade.UseVisualStyleBackColor = true;
            this.btnAddCompraUnidade.Click += new System.EventHandler(this.btnAddCompraUnidade_Click);
            // 
            // lblNomeComprador
            // 
            this.lblNomeComprador.AutoSize = true;
            this.lblNomeComprador.Location = new System.Drawing.Point(465, 36);
            this.lblNomeComprador.Name = "lblNomeComprador";
            this.lblNomeComprador.Size = new System.Drawing.Size(89, 13);
            this.lblNomeComprador.TabIndex = 0;
            this.lblNomeComprador.Text = "Nome Comprador";
            // 
            // lblCompraUnidade
            // 
            this.lblCompraUnidade.AutoSize = true;
            this.lblCompraUnidade.Location = new System.Drawing.Point(187, 36);
            this.lblCompraUnidade.Name = "lblCompraUnidade";
            this.lblCompraUnidade.Size = new System.Drawing.Size(110, 13);
            this.lblCompraUnidade.TabIndex = 0;
            this.lblCompraUnidade.Text = "Compra para Unidade";
            // 
            // lblProdutosPedido
            // 
            this.lblProdutosPedido.AutoSize = true;
            this.lblProdutosPedido.Location = new System.Drawing.Point(13, 512);
            this.lblProdutosPedido.Name = "lblProdutosPedido";
            this.lblProdutosPedido.Size = new System.Drawing.Size(99, 13);
            this.lblProdutosPedido.TabIndex = 0;
            this.lblProdutosPedido.Text = "Produtos do pedido";
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.AutoSize = true;
            this.lblTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedido.Location = new System.Drawing.Point(546, 735);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(20, 24);
            this.lblTotalPedido.TabIndex = 0;
            this.lblTotalPedido.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(439, 735);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Total";
            // 
            // gpProdutos
            // 
            this.gpProdutos.Controls.Add(this.txtPreco);
            this.gpProdutos.Controls.Add(this.txtQtd);
            this.gpProdutos.Controls.Add(this.txtCodProduto);
            this.gpProdutos.Controls.Add(this.btnFinalizar);
            this.gpProdutos.Controls.Add(this.lblPreco);
            this.gpProdutos.Controls.Add(this.btnCadProduto);
            this.gpProdutos.Controls.Add(this.btnExcluirProduto);
            this.gpProdutos.Controls.Add(this.btnAddProduto);
            this.gpProdutos.Controls.Add(this.lblQtd);
            this.gpProdutos.Controls.Add(this.lblNomeProduto);
            this.gpProdutos.Controls.Add(this.lblCodProduto);
            this.gpProdutos.Enabled = false;
            this.gpProdutos.Location = new System.Drawing.Point(12, 393);
            this.gpProdutos.Name = "gpProdutos";
            this.gpProdutos.Size = new System.Drawing.Size(624, 116);
            this.gpProdutos.TabIndex = 0;
            this.gpProdutos.TabStop = false;
            this.gpProdutos.Text = "Adicionar Produtos";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(514, 41);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(83, 20);
            this.txtPreco.TabIndex = 18;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(431, 41);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(56, 20);
            this.txtQtd.TabIndex = 17;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(11, 41);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(100, 20);
            this.txtCodProduto.TabIndex = 16;
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave_1);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFinalizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(514, 73);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(85, 37);
            this.btnFinalizar.TabIndex = 0;
            this.btnFinalizar.TabStop = false;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(511, 21);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 0;
            this.lblPreco.Text = "Preço";
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCadProduto.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProduto.Location = new System.Drawing.Point(117, 41);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(28, 20);
            this.btnCadProduto.TabIndex = 0;
            this.btnCadProduto.TabStop = false;
            this.btnCadProduto.Text = "+";
            this.btnCadProduto.UseVisualStyleBackColor = true;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduto.Location = new System.Drawing.Point(423, 73);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(85, 37);
            this.btnExcluirProduto.TabIndex = 0;
            this.btnExcluirProduto.TabStop = false;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduto.Location = new System.Drawing.Point(332, 73);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(85, 37);
            this.btnAddProduto.TabIndex = 19;
            this.btnAddProduto.Text = "Adicionar";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(428, 21);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(24, 13);
            this.lblQtd.TabIndex = 0;
            this.lblQtd.Text = "Qtd";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(151, 44);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(0, 13);
            this.lblNomeProduto.TabIndex = 0;
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(17, 25);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(40, 13);
            this.lblCodProduto.TabIndex = 0;
            this.lblCodProduto.Text = "Codigo";
            // 
            // lblLançamentoPedidos
            // 
            this.lblLançamentoPedidos.AutoSize = true;
            this.lblLançamentoPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLançamentoPedidos.Font = new System.Drawing.Font("Azonix", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLançamentoPedidos.Location = new System.Drawing.Point(15, 27);
            this.lblLançamentoPedidos.Name = "lblLançamentoPedidos";
            this.lblLançamentoPedidos.Size = new System.Drawing.Size(284, 21);
            this.lblLançamentoPedidos.TabIndex = 0;
            this.lblLançamentoPedidos.Text = "Lançamento Pedidos";
            // 
            // sGC_DBDataSet
            // 
            this.sGC_DBDataSet.DataSetName = "SGC_DBDataSet";
            this.sGC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sGCDBDataSetBindingSource
            // 
            this.sGCDBDataSetBindingSource.DataSource = this.sGC_DBDataSet;
            this.sGCDBDataSetBindingSource.Position = 0;
            // 
            // sGC_DBDataSet2
            // 
            this.sGC_DBDataSet2.DataSetName = "SGC_DBDataSet2";
            this.sGC_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBFABRICANTEBindingSource
            // 
            this.tBFABRICANTEBindingSource.DataMember = "TB_FABRICANTE";
            this.tBFABRICANTEBindingSource.DataSource = this.sGC_DBDataSet2;
            // 
            // tB_FABRICANTETableAdapter
            // 
            this.tB_FABRICANTETableAdapter.ClearBeforeFill = true;
            // 
            // tB_FABRICANTETableAdapter1
            // 
            this.tB_FABRICANTETableAdapter1.ClearBeforeFill = true;
            // 
            // tB_UNIDADETableAdapter
            // 
            this.tB_UNIDADETableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etapa";
            // 
            // cbxEtapa
            // 
            this.cbxEtapa.DataSource = this.tBETAPAPEDIDOBindingSource;
            this.cbxEtapa.DisplayMember = "NOME_ETAPA_PEDIDO";
            this.cbxEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEtapa.FormattingEnabled = true;
            this.cbxEtapa.Location = new System.Drawing.Point(471, 69);
            this.cbxEtapa.Name = "cbxEtapa";
            this.cbxEtapa.Size = new System.Drawing.Size(168, 21);
            this.cbxEtapa.TabIndex = 0;
            this.cbxEtapa.TabStop = false;
            this.cbxEtapa.ValueMember = "ID_ETAPA_PEDIDO";
            // 
            // tBETAPAPEDIDOBindingSource
            // 
            this.tBETAPAPEDIDOBindingSource.DataMember = "TB_ETAPA_PEDIDO";
            this.tBETAPAPEDIDOBindingSource.DataSource = this.sGC_DBDataSet10;
            // 
            // sGC_DBDataSet10
            // 
            this.sGC_DBDataSet10.DataSetName = "SGC_DBDataSet10";
            this.sGC_DBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sGC_DBDataSet9
            // 
            this.sGC_DBDataSet9.DataSetName = "SGC_DBDataSet9";
            this.sGC_DBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBUNIDADEBindingSource1
            // 
            this.tBUNIDADEBindingSource1.DataMember = "TB_UNIDADE";
            this.tBUNIDADEBindingSource1.DataSource = this.sGC_DBDataSet9;
            // 
            // tB_UNIDADETableAdapter1
            // 
            this.tB_UNIDADETableAdapter1.ClearBeforeFill = true;
            // 
            // tB_ETAPA_PEDIDOTableAdapter
            // 
            this.tB_ETAPA_PEDIDOTableAdapter.ClearBeforeFill = true;
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Location = new System.Drawing.Point(604, 13);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(18, 13);
            this.lblIdPedido.TabIndex = 0;
            this.lblIdPedido.Text = "ID";
            this.lblIdPedido.Visible = false;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 774);
            this.Controls.Add(this.lblIdPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEtapa);
            this.Controls.Add(this.lblLançamentoPedidos);
            this.Controls.Add(this.gpProdutos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblTotalPedido);
            this.Controls.Add(this.lblProdutosPedido);
            this.Controls.Add(this.gpComprador);
            this.Controls.Add(this.gpFabricante);
            this.Controls.Add(this.dgvProdutosPedido);
            this.Name = "frmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFABRICANTEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUNIDADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet4)).EndInit();
            this.gpFabricante.ResumeLayout(false);
            this.gpFabricante.PerformLayout();
            this.gpComprador.ResumeLayout(false);
            this.gpComprador.PerformLayout();
            this.gpProdutos.ResumeLayout(false);
            this.gpProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGCDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFABRICANTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBETAPAPEDIDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUNIDADEBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFabricante;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.DataGridView dgvProdutosPedido;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.Label lblPedidoFabricante;
        private System.Windows.Forms.Label lblNomeVendedor;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.Label lblPrevFaturamento;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.Label lblPedidoComprador;
        private System.Windows.Forms.TextBox txtPedidoFabricante;
        private System.Windows.Forms.TextBox txtNomeComprador;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtPedidoComprador;
        private System.Windows.Forms.ComboBox cbxFabricante;
        private System.Windows.Forms.ComboBox cbxCompraUnidade;
        private System.Windows.Forms.DateTimePicker dtDataPedido;
        private System.Windows.Forms.DateTimePicker dtPrevisaoFaturamento;
        private System.Windows.Forms.GroupBox gpFabricante;
        private System.Windows.Forms.GroupBox gpComprador;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Button btnAddCompraUnidade;
        private System.Windows.Forms.Label lblNomeComprador;
        private System.Windows.Forms.Label lblCompraUnidade;
        private System.Windows.Forms.Label lblProdutosPedido;
        private System.Windows.Forms.Label lblTotalPedido;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gpProdutos;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Label lblLançamentoPedidos;
        private System.Windows.Forms.BindingSource sGCDBDataSetBindingSource;
        private SGC_DBDataSet sGC_DBDataSet;
        private SGC_DBDataSet2 sGC_DBDataSet2;
        private System.Windows.Forms.BindingSource tBFABRICANTEBindingSource;
        private SGC_DBDataSet2TableAdapters.TB_FABRICANTETableAdapter tB_FABRICANTETableAdapter;
        private SGC_DBDataSet3 sGC_DBDataSet3;
        private System.Windows.Forms.BindingSource tBFABRICANTEBindingSource1;
        private SGC_DBDataSet3TableAdapters.TB_FABRICANTETableAdapter tB_FABRICANTETableAdapter1;
        private SGC_DBDataSet4 sGC_DBDataSet4;
        private System.Windows.Forms.BindingSource tBUNIDADEBindingSource;
        private SGC_DBDataSet4TableAdapters.TB_UNIDADETableAdapter tB_UNIDADETableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEtapa;
        private SGC_DBDataSet9 sGC_DBDataSet9;
        private System.Windows.Forms.BindingSource tBUNIDADEBindingSource1;
        private SGC_DBDataSet9TableAdapters.TB_UNIDADETableAdapter tB_UNIDADETableAdapter1;
        private SGC_DBDataSet10 sGC_DBDataSet10;
        private System.Windows.Forms.BindingSource tBETAPAPEDIDOBindingSource;
        private SGC_DBDataSet10TableAdapters.TB_ETAPA_PEDIDOTableAdapter tB_ETAPA_PEDIDOTableAdapter;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.MaskedTextBox txtParcela;
        private System.Windows.Forms.MaskedTextBox txtPrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProdutos;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtCodProduto;
    }
}

