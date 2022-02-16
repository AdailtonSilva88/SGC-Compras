using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_Gerenciamento_de_Compras
{
    public partial class frmBuscaAlteraPedido : Form
    {
        public frmBuscaAlteraPedido()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool valida;
            AltEtapaPedido frm = new AltEtapaPedido();
            valida = frm.BuscarPedido(txtBusca.Text);
            if (valida)
            {
                frm.ShowDialog();
            }
            else 
            {
                String mensagem = "Insira um numero de pedido existente...";
                MessageBox.Show(mensagem, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        private void frmBuscaAlteraPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
