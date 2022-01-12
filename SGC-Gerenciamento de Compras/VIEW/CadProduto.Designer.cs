namespace SGC_Gerenciamento_de_Compras
{
    partial class CadProduto
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOPRODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGC_DBDataSet7 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet7();
            this.tB_PRODUTOTableAdapter = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet7TableAdapters.TB_PRODUTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(247, 118);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 31);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(22, 69);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(77, 20);
            this.txtCodProduto.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo Produto";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(22, 124);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(219, 20);
            this.txtDescricaoProduto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODPRODUTODataGridViewTextBoxColumn,
            this.dESCRICAOPRODDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBPRODUTOBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(22, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(300, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // cODPRODUTODataGridViewTextBoxColumn
            // 
            this.cODPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_PRODUTO";
            this.cODPRODUTODataGridViewTextBoxColumn.HeaderText = "Codigo Produto";
            this.cODPRODUTODataGridViewTextBoxColumn.Name = "cODPRODUTODataGridViewTextBoxColumn";
            this.cODPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cODPRODUTODataGridViewTextBoxColumn.Width = 80;
            // 
            // dESCRICAOPRODDataGridViewTextBoxColumn
            // 
            this.dESCRICAOPRODDataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_PROD";
            this.dESCRICAOPRODDataGridViewTextBoxColumn.HeaderText = "Descrição Produtos";
            this.dESCRICAOPRODDataGridViewTextBoxColumn.Name = "dESCRICAOPRODDataGridViewTextBoxColumn";
            this.dESCRICAOPRODDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRICAOPRODDataGridViewTextBoxColumn.Width = 230;
            // 
            // tBPRODUTOBindingSource
            // 
            this.tBPRODUTOBindingSource.DataMember = "TB_PRODUTO";
            this.tBPRODUTOBindingSource.DataSource = this.sGC_DBDataSet7;
            // 
            // sGC_DBDataSet7
            // 
            this.sGC_DBDataSet7.DataSetName = "SGC_DBDataSet7";
            this.sGC_DBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_PRODUTOTableAdapter
            // 
            this.tB_PRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // CadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadProduto";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.CadProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SGC_DBDataSet7 sGC_DBDataSet7;
        private System.Windows.Forms.BindingSource tBPRODUTOBindingSource;
        private SGC_DBDataSet7TableAdapters.TB_PRODUTOTableAdapter tB_PRODUTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAOPRODDataGridViewTextBoxColumn;
    }
}