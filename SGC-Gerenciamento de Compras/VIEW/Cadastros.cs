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
    public partial class Cadastros : Form
    {
        public Cadastros()
        {
            InitializeComponent();
        }

        private void btnCadProdutos_Click(object sender, EventArgs e)
        {
            CadProduto cadProduto = new CadProduto();
            cadProduto.ShowDialog();
        }

        private void btnCadFabricantes_Click(object sender, EventArgs e)
        {
            frmCadastroFabricante cadFabricante = new frmCadastroFabricante();
            cadFabricante.ShowDialog();
        }

        private void btnCadUnidades_Click(object sender, EventArgs e)
        {
            CadUnidade cadUnidade = new CadUnidade();
            cadUnidade.ShowDialog();
        }

        private void btnCadEtapas_Click(object sender, EventArgs e)
        {
            CadEtapas cadEtapas = new CadEtapas();
            cadEtapas.ShowDialog();
        }             

        private void Cadastros_Load(object sender, EventArgs e)
        {

        }
    }
}
