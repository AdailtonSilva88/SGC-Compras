namespace SGC_Gerenciamento_de_Compras
{
    partial class Menu
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
            this.btnLancarPedido = new System.Windows.Forms.Button();
            this.btnEtapaPedido = new System.Windows.Forms.Button();
            this.btnBaixarNFs = new System.Windows.Forms.Button();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.btnConsultaPedidos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLancarPedido
            // 
            this.btnLancarPedido.AutoEllipsis = true;
            this.btnLancarPedido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancarPedido.Location = new System.Drawing.Point(14, 133);
            this.btnLancarPedido.Name = "btnLancarPedido";
            this.btnLancarPedido.Size = new System.Drawing.Size(136, 104);
            this.btnLancarPedido.TabIndex = 0;
            this.btnLancarPedido.Text = "Lançar Pedido";
            this.btnLancarPedido.UseVisualStyleBackColor = true;
            this.btnLancarPedido.Click += new System.EventHandler(this.btnLancarPedido_Click);
            // 
            // btnEtapaPedido
            // 
            this.btnEtapaPedido.AutoEllipsis = true;
            this.btnEtapaPedido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtapaPedido.Location = new System.Drawing.Point(174, 133);
            this.btnEtapaPedido.Name = "btnEtapaPedido";
            this.btnEtapaPedido.Size = new System.Drawing.Size(136, 104);
            this.btnEtapaPedido.TabIndex = 1;
            this.btnEtapaPedido.Text = "Alterar Etapa do Pedido";
            this.btnEtapaPedido.UseVisualStyleBackColor = true;
            this.btnEtapaPedido.Click += new System.EventHandler(this.btnEtapaPedido_Click);
            // 
            // btnBaixarNFs
            // 
            this.btnBaixarNFs.AutoEllipsis = true;
            this.btnBaixarNFs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixarNFs.Location = new System.Drawing.Point(339, 133);
            this.btnBaixarNFs.Name = "btnBaixarNFs";
            this.btnBaixarNFs.Size = new System.Drawing.Size(136, 104);
            this.btnBaixarNFs.TabIndex = 2;
            this.btnBaixarNFs.Text = "Baixar NFs";
            this.btnBaixarNFs.UseVisualStyleBackColor = true;
            this.btnBaixarNFs.Click += new System.EventHandler(this.btnBaixarNFs_Click);
            // 
            // btnCadastros
            // 
            this.btnCadastros.AutoEllipsis = true;
            this.btnCadastros.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.Location = new System.Drawing.Point(16, 266);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(136, 104);
            this.btnCadastros.TabIndex = 3;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.UseVisualStyleBackColor = true;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // btnConsultaPedidos
            // 
            this.btnConsultaPedidos.AutoEllipsis = true;
            this.btnConsultaPedidos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaPedidos.Location = new System.Drawing.Point(174, 266);
            this.btnConsultaPedidos.Name = "btnConsultaPedidos";
            this.btnConsultaPedidos.Size = new System.Drawing.Size(136, 104);
            this.btnConsultaPedidos.TabIndex = 4;
            this.btnConsultaPedidos.Text = "Consulta Pedidos";
            this.btnConsultaPedidos.UseVisualStyleBackColor = true;
            this.btnConsultaPedidos.Click += new System.EventHandler(this.btnConsultaPedidos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Azonix", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Menu";
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(339, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 104);
            this.button1.TabIndex = 11;
            this.button1.Text = "Relatorios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultaPedidos);
            this.Controls.Add(this.btnCadastros);
            this.Controls.Add(this.btnBaixarNFs);
            this.Controls.Add(this.btnEtapaPedido);
            this.Controls.Add(this.btnLancarPedido);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLancarPedido;
        private System.Windows.Forms.Button btnEtapaPedido;
        private System.Windows.Forms.Button btnBaixarNFs;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Button btnConsultaPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}