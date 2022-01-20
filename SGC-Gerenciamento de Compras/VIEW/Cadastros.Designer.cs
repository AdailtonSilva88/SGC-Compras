namespace SGC_Gerenciamento_de_Compras
{
    partial class Cadastros
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
            this.btnCadEtapas = new System.Windows.Forms.Button();
            this.btnCadUnidades = new System.Windows.Forms.Button();
            this.btnCadFabricantes = new System.Windows.Forms.Button();
            this.btnCadProdutos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadEtapas
            // 
            this.btnCadEtapas.Location = new System.Drawing.Point(251, 266);
            this.btnCadEtapas.Name = "btnCadEtapas";
            this.btnCadEtapas.Size = new System.Drawing.Size(136, 104);
            this.btnCadEtapas.TabIndex = 8;
            this.btnCadEtapas.Text = "Cadastro de Etapas";
            this.btnCadEtapas.UseVisualStyleBackColor = true;
            this.btnCadEtapas.Click += new System.EventHandler(this.btnCadEtapas_Click);
            // 
            // btnCadUnidades
            // 
            this.btnCadUnidades.Location = new System.Drawing.Point(48, 266);
            this.btnCadUnidades.Name = "btnCadUnidades";
            this.btnCadUnidades.Size = new System.Drawing.Size(136, 104);
            this.btnCadUnidades.TabIndex = 7;
            this.btnCadUnidades.Text = "Cadastro de Unidades";
            this.btnCadUnidades.UseVisualStyleBackColor = true;
            this.btnCadUnidades.Click += new System.EventHandler(this.btnCadUnidades_Click);
            // 
            // btnCadFabricantes
            // 
            this.btnCadFabricantes.Location = new System.Drawing.Point(251, 123);
            this.btnCadFabricantes.Name = "btnCadFabricantes";
            this.btnCadFabricantes.Size = new System.Drawing.Size(136, 104);
            this.btnCadFabricantes.TabIndex = 6;
            this.btnCadFabricantes.Text = "Cadastro de Fabricantes";
            this.btnCadFabricantes.UseVisualStyleBackColor = true;
            this.btnCadFabricantes.Click += new System.EventHandler(this.btnCadFabricantes_Click);
            // 
            // btnCadProdutos
            // 
            this.btnCadProdutos.Location = new System.Drawing.Point(48, 123);
            this.btnCadProdutos.Name = "btnCadProdutos";
            this.btnCadProdutos.Size = new System.Drawing.Size(136, 104);
            this.btnCadProdutos.TabIndex = 5;
            this.btnCadProdutos.Text = "Cadastro de Produtos";
            this.btnCadProdutos.UseVisualStyleBackColor = true;
            this.btnCadProdutos.Click += new System.EventHandler(this.btnCadProdutos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Azonix", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menu Cadastros";
            // 
            // Cadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadEtapas);
            this.Controls.Add(this.btnCadUnidades);
            this.Controls.Add(this.btnCadFabricantes);
            this.Controls.Add(this.btnCadProdutos);
            this.Name = "Cadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Cadastros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadEtapas;
        private System.Windows.Forms.Button btnCadUnidades;
        private System.Windows.Forms.Button btnCadFabricantes;
        private System.Windows.Forms.Button btnCadProdutos;
        private System.Windows.Forms.Label label1;
    }
}