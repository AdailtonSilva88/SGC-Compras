namespace SGC_Gerenciamento_de_Compras
{
    partial class BaixarNFs
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
            this.txtBuscaNF = new System.Windows.Forms.TextBox();
            this.btnBuscaNF = new System.Windows.Forms.Button();
            this.btnBaixaNF = new System.Windows.Forms.Button();
            this.dgvBuscaNF = new System.Windows.Forms.DataGridView();
            this.cbxFabricante = new System.Windows.Forms.ComboBox();
            this.tBFABRICANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGC_DBDataSet16 = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet16();
            this.tB_FABRICANTETableAdapter = new SGC_Gerenciamento_de_Compras.SGC_DBDataSet16TableAdapters.TB_FABRICANTETableAdapter();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaNF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFABRICANTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baixar NFs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o nº da NF";
            // 
            // txtBuscaNF
            // 
            this.txtBuscaNF.Location = new System.Drawing.Point(15, 127);
            this.txtBuscaNF.Name = "txtBuscaNF";
            this.txtBuscaNF.Size = new System.Drawing.Size(204, 20);
            this.txtBuscaNF.TabIndex = 2;
            // 
            // btnBuscaNF
            // 
            this.btnBuscaNF.Location = new System.Drawing.Point(268, 84);
            this.btnBuscaNF.Name = "btnBuscaNF";
            this.btnBuscaNF.Size = new System.Drawing.Size(83, 63);
            this.btnBuscaNF.TabIndex = 3;
            this.btnBuscaNF.Text = "Buscar NF";
            this.btnBuscaNF.UseVisualStyleBackColor = true;
            this.btnBuscaNF.Click += new System.EventHandler(this.btnBuscaNF_Click);
            // 
            // btnBaixaNF
            // 
            this.btnBaixaNF.Location = new System.Drawing.Point(378, 84);
            this.btnBaixaNF.Name = "btnBaixaNF";
            this.btnBaixaNF.Size = new System.Drawing.Size(83, 63);
            this.btnBaixaNF.TabIndex = 4;
            this.btnBaixaNF.Text = "Baixar NF";
            this.btnBaixaNF.UseVisualStyleBackColor = true;
            // 
            // dgvBuscaNF
            // 
            this.dgvBuscaNF.AllowUserToAddRows = false;
            this.dgvBuscaNF.AllowUserToDeleteRows = false;
            this.dgvBuscaNF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaNF.Location = new System.Drawing.Point(15, 153);
            this.dgvBuscaNF.Name = "dgvBuscaNF";
            this.dgvBuscaNF.ReadOnly = true;
            this.dgvBuscaNF.RowHeadersVisible = false;
            this.dgvBuscaNF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscaNF.Size = new System.Drawing.Size(462, 279);
            this.dgvBuscaNF.TabIndex = 5;
            // 
            // cbxFabricante
            // 
            this.cbxFabricante.DataSource = this.tBFABRICANTEBindingSource;
            this.cbxFabricante.DisplayMember = "NOME_FABRICANTE";
            this.cbxFabricante.FormattingEnabled = true;
            this.cbxFabricante.Location = new System.Drawing.Point(15, 74);
            this.cbxFabricante.Name = "cbxFabricante";
            this.cbxFabricante.Size = new System.Drawing.Size(204, 21);
            this.cbxFabricante.TabIndex = 6;
            this.cbxFabricante.ValueMember = "ID_FABRICANTE";
            // 
            // tBFABRICANTEBindingSource
            // 
            this.tBFABRICANTEBindingSource.DataMember = "TB_FABRICANTE";
            this.tBFABRICANTEBindingSource.DataSource = this.sGC_DBDataSet16;
            // 
            // sGC_DBDataSet16
            // 
            this.sGC_DBDataSet16.DataSetName = "SGC_DBDataSet16";
            this.sGC_DBDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_FABRICANTETableAdapter
            // 
            this.tB_FABRICANTETableAdapter.ClearBeforeFill = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(409, 471);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 25);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total";
            // 
            // BaixarNFs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 544);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbxFabricante);
            this.Controls.Add(this.dgvBuscaNF);
            this.Controls.Add(this.btnBaixaNF);
            this.Controls.Add(this.btnBuscaNF);
            this.Controls.Add(this.txtBuscaNF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BaixarNFs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baixar NFs";
            this.Load += new System.EventHandler(this.BaixarNFs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaNF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFABRICANTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGC_DBDataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscaNF;
        private System.Windows.Forms.Button btnBuscaNF;
        private System.Windows.Forms.Button btnBaixaNF;
        private System.Windows.Forms.DataGridView dgvBuscaNF;
        private System.Windows.Forms.ComboBox cbxFabricante;
        private SGC_DBDataSet16 sGC_DBDataSet16;
        private System.Windows.Forms.BindingSource tBFABRICANTEBindingSource;
        private SGC_DBDataSet16TableAdapters.TB_FABRICANTETableAdapter tB_FABRICANTETableAdapter;
        private System.Windows.Forms.Label lblTotal;
    }
}