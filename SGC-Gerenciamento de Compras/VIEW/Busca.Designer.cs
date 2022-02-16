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
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.lblNF = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.cbxFabricante = new System.Windows.Forms.ComboBox();
            this.tBFABRICANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGC_DBDataSet14 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet14();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.dgvResultadoBusca = new System.Windows.Forms.DataGridView();
            this.tB_FABRICANTETableAdapter = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet14TableAdapters.TB_FABRICANTETableAdapter();
            this.sGC_DBDataSet15 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet15();
            this.tBUNIDADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_UNIDADETableAdapter = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet15TableAdapters.TB_UNIDADETableAdapter();
            this.btnExportar = new System.Windows.Forms.Button();
            this.rdAtivo = new System.Windows.Forms.RadioButton();
            this.rdFinalizado = new System.Windows.Forms.RadioButton();
            this.rdCancelado = new System.Windows.Forms.RadioButton();
            this.gpStatusPedido = new System.Windows.Forms.GroupBox();
            this.rdTodos = new System.Windows.Forms.RadioButton();
            this.gpBusca = new System.Windows.Forms.GroupBox();
            this.rdProduto = new System.Windows.Forms.RadioButton();
            this.rdFabricante = new System.Windows.Forms.RadioButton();
            this.rdNFe = new System.Windows.Forms.RadioButton();
            this.rdIdPedido = new System.Windows.Forms.RadioButton();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBFABRICANTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUNIDADEBindingSource)).BeginInit();
            this.gpStatusPedido.SuspendLayout();
            this.gpBusca.SuspendLayout();
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
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(1305, 110);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(86, 70);
            this.btnBusca.TabIndex = 8;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txtNF
            // 
            this.txtNF.Location = new System.Drawing.Point(116, 38);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(135, 20);
            this.txtNF.TabIndex = 5;
            this.txtNF.Visible = false;
            // 
            // lblNF
            // 
            this.lblNF.AutoSize = true;
            this.lblNF.Location = new System.Drawing.Point(112, 22);
            this.lblNF.Name = "lblNF";
            this.lblNF.Size = new System.Drawing.Size(27, 13);
            this.lblNF.TabIndex = 0;
            this.lblNF.Text = "NFe";
            this.lblNF.Visible = false;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(109, 22);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 0;
            this.lblFabricante.Text = "Fabricante";
            this.lblFabricante.Visible = false;
            // 
            // cbxFabricante
            // 
            this.cbxFabricante.DataSource = this.tBFABRICANTEBindingSource;
            this.cbxFabricante.DisplayMember = "NOME_FABRICANTE";
            this.cbxFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFabricante.FormattingEnabled = true;
            this.cbxFabricante.Location = new System.Drawing.Point(115, 38);
            this.cbxFabricante.Name = "cbxFabricante";
            this.cbxFabricante.Size = new System.Drawing.Size(135, 21);
            this.cbxFabricante.TabIndex = 7;
            this.cbxFabricante.ValueMember = "ID_FABRICANTE";
            this.cbxFabricante.Visible = false;
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
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(115, 38);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(134, 20);
            this.txtProduto.TabIndex = 6;
            this.txtProduto.Visible = false;
            this.txtProduto.Leave += new System.EventHandler(this.txtProduto_Leave);
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(113, 22);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(80, 13);
            this.lblCodProduto.TabIndex = 0;
            this.lblCodProduto.Text = "Codigo Produto";
            this.lblCodProduto.Visible = false;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(118, 73);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(133, 24);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome Produto";
            this.lblNomeProduto.Visible = false;
            // 
            // dgvResultadoBusca
            // 
            this.dgvResultadoBusca.AllowUserToAddRows = false;
            this.dgvResultadoBusca.AllowUserToDeleteRows = false;
            this.dgvResultadoBusca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResultadoBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoBusca.Location = new System.Drawing.Point(16, 195);
            this.dgvResultadoBusca.Name = "dgvResultadoBusca";
            this.dgvResultadoBusca.ReadOnly = true;
            this.dgvResultadoBusca.RowHeadersVisible = false;
            this.dgvResultadoBusca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadoBusca.Size = new System.Drawing.Size(1375, 507);
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
            this.btnExportar.Location = new System.Drawing.Point(1305, 9);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(86, 39);
            this.btnExportar.TabIndex = 9;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // rdAtivo
            // 
            this.rdAtivo.AutoSize = true;
            this.rdAtivo.Location = new System.Drawing.Point(18, 42);
            this.rdAtivo.Name = "rdAtivo";
            this.rdAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdAtivo.TabIndex = 10;
            this.rdAtivo.TabStop = true;
            this.rdAtivo.Text = "Ativo";
            this.rdAtivo.UseVisualStyleBackColor = true;
            // 
            // rdFinalizado
            // 
            this.rdFinalizado.AutoSize = true;
            this.rdFinalizado.Location = new System.Drawing.Point(18, 65);
            this.rdFinalizado.Name = "rdFinalizado";
            this.rdFinalizado.Size = new System.Drawing.Size(72, 17);
            this.rdFinalizado.TabIndex = 11;
            this.rdFinalizado.TabStop = true;
            this.rdFinalizado.Text = "Finalizado";
            this.rdFinalizado.UseVisualStyleBackColor = true;
            // 
            // rdCancelado
            // 
            this.rdCancelado.AutoSize = true;
            this.rdCancelado.Location = new System.Drawing.Point(18, 88);
            this.rdCancelado.Name = "rdCancelado";
            this.rdCancelado.Size = new System.Drawing.Size(76, 17);
            this.rdCancelado.TabIndex = 12;
            this.rdCancelado.TabStop = true;
            this.rdCancelado.Text = "Cancelado";
            this.rdCancelado.UseVisualStyleBackColor = true;
            // 
            // gpStatusPedido
            // 
            this.gpStatusPedido.Controls.Add(this.rdTodos);
            this.gpStatusPedido.Controls.Add(this.rdCancelado);
            this.gpStatusPedido.Controls.Add(this.rdAtivo);
            this.gpStatusPedido.Controls.Add(this.rdFinalizado);
            this.gpStatusPedido.Location = new System.Drawing.Point(16, 58);
            this.gpStatusPedido.Name = "gpStatusPedido";
            this.gpStatusPedido.Size = new System.Drawing.Size(110, 122);
            this.gpStatusPedido.TabIndex = 13;
            this.gpStatusPedido.TabStop = false;
            this.gpStatusPedido.Text = "Status da Busca";
            // 
            // rdTodos
            // 
            this.rdTodos.AutoSize = true;
            this.rdTodos.Location = new System.Drawing.Point(18, 19);
            this.rdTodos.Name = "rdTodos";
            this.rdTodos.Size = new System.Drawing.Size(55, 17);
            this.rdTodos.TabIndex = 13;
            this.rdTodos.TabStop = true;
            this.rdTodos.Text = "Todos";
            this.rdTodos.UseVisualStyleBackColor = true;
            // 
            // gpBusca
            // 
            this.gpBusca.Controls.Add(this.rdProduto);
            this.gpBusca.Controls.Add(this.rdFabricante);
            this.gpBusca.Controls.Add(this.rdNFe);
            this.gpBusca.Controls.Add(this.rdIdPedido);
            this.gpBusca.Controls.Add(this.lblIdPedido);
            this.gpBusca.Controls.Add(this.txtIdPedido);
            this.gpBusca.Controls.Add(this.lblNF);
            this.gpBusca.Controls.Add(this.lblNomeProduto);
            this.gpBusca.Controls.Add(this.txtNF);
            this.gpBusca.Controls.Add(this.txtProduto);
            this.gpBusca.Controls.Add(this.lblCodProduto);
            this.gpBusca.Controls.Add(this.lblFabricante);
            this.gpBusca.Controls.Add(this.cbxFabricante);
            this.gpBusca.Location = new System.Drawing.Point(132, 58);
            this.gpBusca.Name = "gpBusca";
            this.gpBusca.Size = new System.Drawing.Size(1155, 122);
            this.gpBusca.TabIndex = 14;
            this.gpBusca.TabStop = false;
            this.gpBusca.Text = "Busca";
            // 
            // rdProduto
            // 
            this.rdProduto.AutoSize = true;
            this.rdProduto.Location = new System.Drawing.Point(21, 90);
            this.rdProduto.Name = "rdProduto";
            this.rdProduto.Size = new System.Drawing.Size(62, 17);
            this.rdProduto.TabIndex = 13;
            this.rdProduto.TabStop = true;
            this.rdProduto.Text = "Produto";
            this.rdProduto.UseVisualStyleBackColor = true;
            this.rdProduto.CheckedChanged += new System.EventHandler(this.rdProduto_CheckedChanged);
            // 
            // rdFabricante
            // 
            this.rdFabricante.AutoSize = true;
            this.rdFabricante.Location = new System.Drawing.Point(22, 67);
            this.rdFabricante.Name = "rdFabricante";
            this.rdFabricante.Size = new System.Drawing.Size(75, 17);
            this.rdFabricante.TabIndex = 12;
            this.rdFabricante.TabStop = true;
            this.rdFabricante.Text = "Fabricante";
            this.rdFabricante.UseVisualStyleBackColor = true;
            this.rdFabricante.CheckedChanged += new System.EventHandler(this.rdFabricante_CheckedChanged);
            // 
            // rdNFe
            // 
            this.rdNFe.AutoSize = true;
            this.rdNFe.Location = new System.Drawing.Point(22, 44);
            this.rdNFe.Name = "rdNFe";
            this.rdNFe.Size = new System.Drawing.Size(45, 17);
            this.rdNFe.TabIndex = 11;
            this.rdNFe.TabStop = true;
            this.rdNFe.Text = "NFe";
            this.rdNFe.UseVisualStyleBackColor = true;
            this.rdNFe.CheckedChanged += new System.EventHandler(this.rdNFe_CheckedChanged);
            // 
            // rdIdPedido
            // 
            this.rdIdPedido.AutoSize = true;
            this.rdIdPedido.Location = new System.Drawing.Point(22, 22);
            this.rdIdPedido.Name = "rdIdPedido";
            this.rdIdPedido.Size = new System.Drawing.Size(72, 17);
            this.rdIdPedido.TabIndex = 10;
            this.rdIdPedido.TabStop = true;
            this.rdIdPedido.Text = "ID Pedido";
            this.rdIdPedido.UseVisualStyleBackColor = true;
            this.rdIdPedido.CheckedChanged += new System.EventHandler(this.rdIdPedido_CheckedChanged);
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Location = new System.Drawing.Point(111, 23);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(54, 13);
            this.lblIdPedido.TabIndex = 8;
            this.lblIdPedido.Text = "ID Pedido";
            this.lblIdPedido.Visible = false;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(115, 39);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(136, 20);
            this.txtIdPedido.TabIndex = 9;
            this.txtIdPedido.Visible = false;
            // 
            // frmBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 714);
            this.Controls.Add(this.gpBusca);
            this.Controls.Add(this.gpStatusPedido);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvResultadoBusca);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmBusca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca";
            this.Load += new System.EventHandler(this.Busca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBFABRICANTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUNIDADEBindingSource)).EndInit();
            this.gpStatusPedido.ResumeLayout(false);
            this.gpStatusPedido.PerformLayout();
            this.gpBusca.ResumeLayout(false);
            this.gpBusca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.Label lblNF;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.ComboBox cbxFabricante;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.DataGridView dgvResultadoBusca;
        private SGC_DBDataSet14 sGC_DBDataSet14;
        private System.Windows.Forms.BindingSource tBFABRICANTEBindingSource;
        private SGC_DBDataSet14TableAdapters.TB_FABRICANTETableAdapter tB_FABRICANTETableAdapter;
        private SGC_DBDataSet15 sGC_DBDataSet15;
        private System.Windows.Forms.BindingSource tBUNIDADEBindingSource;
        private SGC_DBDataSet15TableAdapters.TB_UNIDADETableAdapter tB_UNIDADETableAdapter;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.RadioButton rdAtivo;
        private System.Windows.Forms.RadioButton rdFinalizado;
        private System.Windows.Forms.RadioButton rdCancelado;
        private System.Windows.Forms.GroupBox gpStatusPedido;
        private System.Windows.Forms.RadioButton rdTodos;
        private System.Windows.Forms.GroupBox gpBusca;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.RadioButton rdProduto;
        private System.Windows.Forms.RadioButton rdFabricante;
        private System.Windows.Forms.RadioButton rdNFe;
        private System.Windows.Forms.RadioButton rdIdPedido;
    }
}