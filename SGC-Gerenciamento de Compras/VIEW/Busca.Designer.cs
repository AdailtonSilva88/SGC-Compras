namespace SGC_Gerenciamento_de_Compras
{
    partial class frmBusca
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtPedidoFabricante = new System.Windows.Forms.TextBox();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxFabricante = new System.Windows.Forms.ComboBox();
            this.tBFABRICANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGC_DBDataSet14 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet14();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComprador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPedidoCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.dgvResultadoBusca = new System.Windows.Forms.DataGridView();
            this.tB_FABRICANTETableAdapter = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet14TableAdapters.TB_FABRICANTETableAdapter();
            this.sGC_DBDataSet15 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet15();
            this.tBUNIDADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_UNIDADETableAdapter = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet15TableAdapters.TB_UNIDADETableAdapter();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tBFABRICANTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUNIDADEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Azonix", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pedido Fabricante";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(994, 132);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(86, 70);
            this.btnBusca.TabIndex = 8;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txtPedidoFabricante
            // 
            this.txtPedidoFabricante.Location = new System.Drawing.Point(15, 87);
            this.txtPedidoFabricante.Name = "txtPedidoFabricante";
            this.txtPedidoFabricante.Size = new System.Drawing.Size(136, 20);
            this.txtPedidoFabricante.TabIndex = 1;
            // 
            // txtNF
            // 
            this.txtNF.Location = new System.Drawing.Point(578, 87);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(135, 20);
            this.txtNF.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "NFe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fabricante";
            // 
            // cbxFabricante
            // 
            this.cbxFabricante.DataSource = this.tBFABRICANTEBindingSource;
            this.cbxFabricante.DisplayMember = "NOME_FABRICANTE";
            this.cbxFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFabricante.FormattingEnabled = true;
            this.cbxFabricante.Location = new System.Drawing.Point(578, 132);
            this.cbxFabricante.Name = "cbxFabricante";
            this.cbxFabricante.Size = new System.Drawing.Size(135, 21);
            this.cbxFabricante.TabIndex = 7;
            this.cbxFabricante.ValueMember = "ID_FABRICANTE";
            // 
            // tBFABRICANTEBindingSource
            // 
            this.tBFABRICANTEBindingSource.DataMember = "TB_FABRICANTE";
            this.tBFABRICANTEBindingSource.DataSource = this.sGC_DBDataSet14;
            // 
            // sGC_DBDataSet14
            // 
            this.sGC_DBDataSet14.DataSetName = "SGC_DBDataSet14";
            this.sGC_DBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(298, 87);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(134, 20);
            this.txtVendedor.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vendedor";
            // 
            // txtComprador
            // 
            this.txtComprador.Location = new System.Drawing.Point(438, 87);
            this.txtComprador.Name = "txtComprador";
            this.txtComprador.Size = new System.Drawing.Size(134, 20);
            this.txtComprador.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Comprador";
            // 
            // txtPedidoCliente
            // 
            this.txtPedidoCliente.Location = new System.Drawing.Point(157, 87);
            this.txtPedidoCliente.Name = "txtPedidoCliente";
            this.txtPedidoCliente.Size = new System.Drawing.Size(135, 20);
            this.txtPedidoCliente.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pedido Cliente";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(17, 132);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(134, 20);
            this.txtProduto.TabIndex = 6;
            this.txtProduto.Leave += new System.EventHandler(this.txtProduto_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Codigo Produto";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(18, 165);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(133, 24);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome Produto";
            // 
            // dgvResultadoBusca
            // 
            this.dgvResultadoBusca.AllowUserToAddRows = false;
            this.dgvResultadoBusca.AllowUserToDeleteRows = false;
            this.dgvResultadoBusca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResultadoBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoBusca.Location = new System.Drawing.Point(12, 208);
            this.dgvResultadoBusca.Name = "dgvResultadoBusca";
            this.dgvResultadoBusca.ReadOnly = true;
            this.dgvResultadoBusca.RowHeadersVisible = false;
            this.dgvResultadoBusca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadoBusca.Size = new System.Drawing.Size(1068, 494);
            this.dgvResultadoBusca.TabIndex = 0;
            // 
            // tB_FABRICANTETableAdapter
            // 
            this.tB_FABRICANTETableAdapter.ClearBeforeFill = true;
            // 
            // sGC_DBDataSet15
            // 
            this.sGC_DBDataSet15.DataSetName = "SGC_DBDataSet15";
            this.sGC_DBDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBUNIDADEBindingSource
            // 
            this.tBUNIDADEBindingSource.DataMember = "TB_UNIDADE";
            this.tBUNIDADEBindingSource.DataSource = this.sGC_DBDataSet15;
            // 
            // tB_UNIDADETableAdapter
            // 
            this.tB_UNIDADETableAdapter.ClearBeforeFill = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(994, 9);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(86, 24);
            this.btnExportar.TabIndex = 9;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 714);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvResultadoBusca);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPedidoCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtComprador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxFabricante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPedidoFabricante);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBusca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca";
            this.Load += new System.EventHandler(this.Busca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBFABRICANTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUNIDADEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtPedidoFabricante;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxFabricante;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComprador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPedidoCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.DataGridView dgvResultadoBusca;
        private SGC_DBDataSet14 sGC_DBDataSet14;
        private System.Windows.Forms.BindingSource tBFABRICANTEBindingSource;
        private SGC_DBDataSet14TableAdapters.TB_FABRICANTETableAdapter tB_FABRICANTETableAdapter;
        private SGC_DBDataSet15 sGC_DBDataSet15;
        private System.Windows.Forms.BindingSource tBUNIDADEBindingSource;
        private SGC_DBDataSet15TableAdapters.TB_UNIDADETableAdapter tB_UNIDADETableAdapter;
        private System.Windows.Forms.Button btnExportar;
    }
}