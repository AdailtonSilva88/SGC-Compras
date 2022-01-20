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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscaNF = new System.Windows.Forms.TextBox();
            this.btnBuscaNF = new System.Windows.Forms.Button();
            this.btnBaixaNF = new System.Windows.Forms.Button();
            this.dgvBuscaNF = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaNF)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o nº da NF";
            // 
            // txtBuscaNF
            // 
            this.txtBuscaNF.Location = new System.Drawing.Point(15, 108);
            this.txtBuscaNF.Name = "txtBuscaNF";
            this.txtBuscaNF.Size = new System.Drawing.Size(180, 20);
            this.txtBuscaNF.TabIndex = 2;
            // 
            // btnBuscaNF
            // 
            this.btnBuscaNF.Location = new System.Drawing.Point(215, 92);
            this.btnBuscaNF.Name = "btnBuscaNF";
            this.btnBuscaNF.Size = new System.Drawing.Size(75, 39);
            this.btnBuscaNF.TabIndex = 3;
            this.btnBuscaNF.Text = "Buscar NF";
            this.btnBuscaNF.UseVisualStyleBackColor = true;
            // 
            // btnBaixaNF
            // 
            this.btnBaixaNF.Location = new System.Drawing.Point(316, 92);
            this.btnBaixaNF.Name = "btnBaixaNF";
            this.btnBaixaNF.Size = new System.Drawing.Size(75, 39);
            this.btnBaixaNF.TabIndex = 4;
            this.btnBaixaNF.Text = "Baixar NF";
            this.btnBaixaNF.UseVisualStyleBackColor = true;
            // 
            // dgvBuscaNF
            // 
            this.dgvBuscaNF.AllowUserToAddRows = false;
            this.dgvBuscaNF.AllowUserToDeleteRows = false;
            this.dgvBuscaNF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaNF.Location = new System.Drawing.Point(15, 137);
            this.dgvBuscaNF.Name = "dgvBuscaNF";
            this.dgvBuscaNF.ReadOnly = true;
            this.dgvBuscaNF.Size = new System.Drawing.Size(376, 295);
            this.dgvBuscaNF.TabIndex = 5;
            // 
            // BaixarNFs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 444);
            this.Controls.Add(this.dgvBuscaNF);
            this.Controls.Add(this.btnBaixaNF);
            this.Controls.Add(this.btnBuscaNF);
            this.Controls.Add(this.txtBuscaNF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BaixarNFs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baixar NFs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaNF)).EndInit();
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
    }
}