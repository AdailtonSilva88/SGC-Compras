namespace SGC_Gerenciamento_de_Compras
{
    partial class CadUnidade
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
            this.txtNumUnidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeUnidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODUNIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEUNIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBUNIDADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGC_DBDataSet8 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet8();
            this.tB_UNIDADETableAdapter = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet8TableAdapters.TB_UNIDADETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUNIDADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(247, 119);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 31);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNumUnidade
            // 
            this.txtNumUnidade.Location = new System.Drawing.Point(20, 73);
            this.txtNumUnidade.Name = "txtNumUnidade";
            this.txtNumUnidade.Size = new System.Drawing.Size(100, 20);
            this.txtNumUnidade.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nº Unidade";
            // 
            // txtNomeUnidade
            // 
            this.txtNomeUnidade.Location = new System.Drawing.Point(20, 125);
            this.txtNomeUnidade.Name = "txtNomeUnidade";
            this.txtNomeUnidade.Size = new System.Drawing.Size(221, 20);
            this.txtNomeUnidade.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome Unidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cadastro de unidade";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODUNIDADEDataGridViewTextBoxColumn,
            this.nOMEUNIDADEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBUNIDADEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(310, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // cODUNIDADEDataGridViewTextBoxColumn
            // 
            this.cODUNIDADEDataGridViewTextBoxColumn.DataPropertyName = "COD_UNIDADE";
            this.cODUNIDADEDataGridViewTextBoxColumn.HeaderText = "N° Unidade";
            this.cODUNIDADEDataGridViewTextBoxColumn.Name = "cODUNIDADEDataGridViewTextBoxColumn";
            this.cODUNIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODUNIDADEDataGridViewTextBoxColumn.Width = 80;
            // 
            // nOMEUNIDADEDataGridViewTextBoxColumn
            // 
            this.nOMEUNIDADEDataGridViewTextBoxColumn.DataPropertyName = "NOME_UNIDADE";
            this.nOMEUNIDADEDataGridViewTextBoxColumn.HeaderText = "Nome Unidade";
            this.nOMEUNIDADEDataGridViewTextBoxColumn.Name = "nOMEUNIDADEDataGridViewTextBoxColumn";
            this.nOMEUNIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMEUNIDADEDataGridViewTextBoxColumn.Width = 230;
            // 
            // tBUNIDADEBindingSource
            // 
            this.tBUNIDADEBindingSource.DataMember = "TB_UNIDADE";
            this.tBUNIDADEBindingSource.DataSource = this.sGC_DBDataSet8;
            // 
            // sGC_DBDataSet8
            // 
            this.sGC_DBDataSet8.DataSetName = "SGC_DBDataSet8";
            this.sGC_DBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_UNIDADETableAdapter
            // 
            this.tB_UNIDADETableAdapter.ClearBeforeFill = true;
            // 
            // CadUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNumUnidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeUnidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadUnidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Unidade";
            this.Load += new System.EventHandler(this.CadUnidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUNIDADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNumUnidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeUnidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SGC_DBDataSet8 sGC_DBDataSet8;
        private System.Windows.Forms.BindingSource tBUNIDADEBindingSource;
        private SGC_DBDataSet8TableAdapters.TB_UNIDADETableAdapter tB_UNIDADETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODUNIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEUNIDADEDataGridViewTextBoxColumn;
    }
}