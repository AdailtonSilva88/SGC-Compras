namespace SGC_Gerenciamento_de_Compras
{
    partial class CadEtapas
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
            this.txtNomeEtapa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDETAPAPEDIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEETAPAPEDIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBETAPAPEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGC_DBDataSet5 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet5();
            this.tB_ETAPA_PEDIDOTableAdapter = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet5TableAdapters.TB_ETAPA_PEDIDOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBETAPAPEDIDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(247, 98);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 31);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNomeEtapa
            // 
            this.txtNomeEtapa.Location = new System.Drawing.Point(19, 104);
            this.txtNomeEtapa.Name = "txtNomeEtapa";
            this.txtNomeEtapa.Size = new System.Drawing.Size(222, 20);
            this.txtNomeEtapa.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome Etapa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cadastro de Etapas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDETAPAPEDIDODataGridViewTextBoxColumn,
            this.nOMEETAPAPEDIDODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBETAPAPEDIDOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(303, 275);
            this.dataGridView1.TabIndex = 19;
            // 
            // iDETAPAPEDIDODataGridViewTextBoxColumn
            // 
            this.iDETAPAPEDIDODataGridViewTextBoxColumn.DataPropertyName = "ID_ETAPA_PEDIDO";
            this.iDETAPAPEDIDODataGridViewTextBoxColumn.HeaderText = "ID Etapa";
            this.iDETAPAPEDIDODataGridViewTextBoxColumn.Name = "iDETAPAPEDIDODataGridViewTextBoxColumn";
            this.iDETAPAPEDIDODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDETAPAPEDIDODataGridViewTextBoxColumn.Width = 80;
            // 
            // nOMEETAPAPEDIDODataGridViewTextBoxColumn
            // 
            this.nOMEETAPAPEDIDODataGridViewTextBoxColumn.DataPropertyName = "NOME_ETAPA_PEDIDO";
            this.nOMEETAPAPEDIDODataGridViewTextBoxColumn.HeaderText = "Etapa";
            this.nOMEETAPAPEDIDODataGridViewTextBoxColumn.Name = "nOMEETAPAPEDIDODataGridViewTextBoxColumn";
            this.nOMEETAPAPEDIDODataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMEETAPAPEDIDODataGridViewTextBoxColumn.Width = 230;
            // 
            // tBETAPAPEDIDOBindingSource
            // 
            this.tBETAPAPEDIDOBindingSource.DataMember = "TB_ETAPA_PEDIDO";
            this.tBETAPAPEDIDOBindingSource.DataSource = this.sGC_DBDataSet5;
            // 
            // sGC_DBDataSet5
            // 
            this.sGC_DBDataSet5.DataSetName = "SGC_DBDataSet5";
            this.sGC_DBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_ETAPA_PEDIDOTableAdapter
            // 
            this.tB_ETAPA_PEDIDOTableAdapter.ClearBeforeFill = true;
            // 
            // CadEtapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNomeEtapa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadEtapas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Etapas";
            this.Load += new System.EventHandler(this.CadEtapas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBETAPAPEDIDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomeEtapa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SGC_DBDataSet5 sGC_DBDataSet5;
        private System.Windows.Forms.BindingSource tBETAPAPEDIDOBindingSource;
        private SGC_DBDataSet5TableAdapters.TB_ETAPA_PEDIDOTableAdapter tB_ETAPA_PEDIDOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDETAPAPEDIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEETAPAPEDIDODataGridViewTextBoxColumn;
    }
}