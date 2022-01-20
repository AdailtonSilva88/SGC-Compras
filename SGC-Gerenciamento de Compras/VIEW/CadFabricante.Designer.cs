namespace SGC_Gerenciamento_de_Compras
{
    partial class frmCadastroFabricante
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
            this.txtNomeFabricante = new System.Windows.Forms.TextBox();
            this.txtNumFabricante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODFABRICANTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEFABRICANTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBFABRICANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGC_DBDataSet6 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet6();
            this.tB_FABRICANTETableAdapter = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet6TableAdapters.TB_FABRICANTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFABRICANTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Fabricante";
            // 
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Fabricante";
            // 
            // txtNomeFabricante
            // 
            this.txtNomeFabricante.Location = new System.Drawing.Point(15, 122);
            this.txtNomeFabricante.Name = "txtNomeFabricante";
            this.txtNomeFabricante.Size = new System.Drawing.Size(223, 20);
            this.txtNomeFabricante.TabIndex = 2;
            // 
            // txtNumFabricante
            // 
            this.txtNumFabricante.Location = new System.Drawing.Point(12, 67);
            this.txtNumFabricante.Name = "txtNumFabricante";
            this.txtNumFabricante.Size = new System.Drawing.Size(100, 20);
            this.txtNumFabricante.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nº Fabricante";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(247, 116);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 31);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODFABRICANTEDataGridViewTextBoxColumn,
            this.nOMEFABRICANTEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBFABRICANTEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(310, 255);
            this.dataGridView1.TabIndex = 7;
            // 
            // cODFABRICANTEDataGridViewTextBoxColumn
            // 
            this.cODFABRICANTEDataGridViewTextBoxColumn.DataPropertyName = "COD_FABRICANTE";
            this.cODFABRICANTEDataGridViewTextBoxColumn.HeaderText = "N° Fabricante";
            this.cODFABRICANTEDataGridViewTextBoxColumn.Name = "cODFABRICANTEDataGridViewTextBoxColumn";
            this.cODFABRICANTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODFABRICANTEDataGridViewTextBoxColumn.Width = 80;
            // 
            // nOMEFABRICANTEDataGridViewTextBoxColumn
            // 
            this.nOMEFABRICANTEDataGridViewTextBoxColumn.DataPropertyName = "NOME_FABRICANTE";
            this.nOMEFABRICANTEDataGridViewTextBoxColumn.HeaderText = "Nome Fabricante";
            this.nOMEFABRICANTEDataGridViewTextBoxColumn.Name = "nOMEFABRICANTEDataGridViewTextBoxColumn";
            this.nOMEFABRICANTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMEFABRICANTEDataGridViewTextBoxColumn.Width = 230;
            // 
            // tBFABRICANTEBindingSource
            // 
            this.tBFABRICANTEBindingSource.DataMember = "TB_FABRICANTE";
            this.tBFABRICANTEBindingSource.DataSource = this.sGC_DBDataSet6;
            // 
            // sGC_DBDataSet6
            // 
            this.sGC_DBDataSet6.DataSetName = "SGC_DBDataSet6";
            this.sGC_DBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_FABRICANTETableAdapter
            // 
            this.tB_FABRICANTETableAdapter.ClearBeforeFill = true;
            // 
            // frmCadastroFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNumFabricante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeFabricante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroFabricante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Fabricante";
            this.Load += new System.EventHandler(this.frmCadastroFabricante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFABRICANTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFabricante;
        private System.Windows.Forms.TextBox txtNumFabricante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SGC_DBDataSet6 sGC_DBDataSet6;
        private System.Windows.Forms.BindingSource tBFABRICANTEBindingSource;
        private SGC_DBDataSet6TableAdapters.TB_FABRICANTETableAdapter tB_FABRICANTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODFABRICANTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEFABRICANTEDataGridViewTextBoxColumn;
    }
}