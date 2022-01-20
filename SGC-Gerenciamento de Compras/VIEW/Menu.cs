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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnLancarPedido_Click(object sender, EventArgs e)
        {
            frmPedidos pedido = new frmPedidos();
            pedido.ShowDialog();
        }

        private void btnEtapaPedido_Click(object sender, EventArgs e)
        {
            frmBuscaAlteraPedido etapaPed = new frmBuscaAlteraPedido();
            etapaPed.ShowDialog();
        }

        private void btnBaixarNFs_Click(object sender, EventArgs e)
        {
            BaixarNFs baixarNFs = new BaixarNFs();
            baixarNFs.ShowDialog();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            Cadastros cadastros = new Cadastros();
            cadastros.ShowDialog();
        }

        private void btnConsultaPedidos_Click(object sender, EventArgs e)
        {
            Busca busca = new Busca();
            busca.ShowDialog();
        }       
    }
}
