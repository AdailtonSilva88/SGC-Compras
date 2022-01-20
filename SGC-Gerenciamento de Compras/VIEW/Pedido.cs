using SGC_Gerenciamento_de_Compras.DAL;
using SGC_Gerenciamento_de_Compras.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_Gerenciamento_de_Compras
{
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }
        double total;
        double calculo;

        List<ProdPedido> prodPedidos = new List<ProdPedido>();


        private void frmPedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet10.TB_ETAPA_PEDIDO'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_ETAPA_PEDIDOTableAdapter.Fill(this.sGC_DBDataSet10.TB_ETAPA_PEDIDO);
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet9.TB_UNIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_UNIDADETableAdapter1.Fill(this.sGC_DBDataSet9.TB_UNIDADE);
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet4.TB_UNIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_UNIDADETableAdapter.Fill(this.sGC_DBDataSet4.TB_UNIDADE);
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet3.TB_FABRICANTE'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_FABRICANTETableAdapter1.Fill(this.sGC_DBDataSet3.TB_FABRICANTE);
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet2.TB_FABRICANTE'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_FABRICANTETableAdapter.Fill(this.sGC_DBDataSet2.TB_FABRICANTE);

        }

        private void btnAddFabricante_Click(object sender, EventArgs e)
        {
            frmCadastroFabricante cadFabricante = new frmCadastroFabricante();
            cadFabricante.ShowDialog();
        }

        private void btnAddCompraUnidade_Click(object sender, EventArgs e)
        {
            CadUnidade cadUnidade = new CadUnidade();
            cadUnidade.ShowDialog();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            CadProduto cadProduto = new CadProduto();
            cadProduto.ShowDialog();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            if (verificaCamposVazios())
            {
                String mensagem = "Preencha todos os campos para adicionar produtos...";
                MessageBox.Show(mensagem, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                double preco;

                preco = Convert.ToDouble(txtPreco.Text);

                calculo = Convert.ToDouble(txtQtd.Text) * Convert.ToDouble(txtPreco.Text);

                total = total + calculo;

                dgvProdutosPedido.Rows.Add(txtCodProduto.Text, lblNomeProduto.Text, txtQtd.Text, preco, calculo);

                lblTotalPedido.Text = total.ToString("C");

                limparProdutos();

            }
        }

        private void limparProdutos()
        {
            txtCodProduto.Text = "";
            txtQtd.Text = "";
            txtPreco.Text = "";
            lblNomeProduto.Text = "";
        }

        private void limparDadosPedido()
        {
            txtNomeComprador.Text = "";
            txtNomeVendedor.Text = "";
            txtObs.Text = "";
            txtParcela.Text = "";
            txtPedidoComprador.Text = "";
            txtPedidoFabricante.Text = "";
            txtPrazo.Text = "";
            dgvProdutosPedido.Rows.Clear();
        }

        private bool verificaCamposVazios()
        {
            if (string.IsNullOrEmpty(txtNomeComprador.Text) | string.IsNullOrEmpty(txtNomeVendedor.Text) |
                    string.IsNullOrEmpty(txtParcela.Text) || string.IsNullOrEmpty(txtPedidoComprador.Text) |
                    string.IsNullOrEmpty(txtPedidoFabricante.Text) | string.IsNullOrEmpty(txtPrazo.Text))
            {
                return true;
            }
            return false;
        }

        private bool verificaFabricanteVazios()
        {
            if (string.IsNullOrEmpty(txtNomeVendedor.Text) || string.IsNullOrEmpty(txtParcela.Text)
                || string.IsNullOrEmpty(txtPedidoFabricante.Text) || string.IsNullOrEmpty(txtPrazo.Text))
            {
                return true;
            }
            return false;
        }

        private bool verificaCompradorVazio()
        {
            if (string.IsNullOrEmpty(txtPedidoComprador.Text) || string.IsNullOrEmpty(txtNomeComprador.Text))
            {
                return true;
            }
            return false;
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            if (txtCodProduto.Text == "")
            {
            }
            else
            {
                ProdPedidoDAL prodPedidoDAL = new ProdPedidoDAL();
                lblNomeProduto.Text = prodPedidoDAL.nomeProduto(Convert.ToInt32(txtCodProduto.Text));
            }
        }

        [Obsolete]
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            PedidoDAL pedidoDAL = new PedidoDAL();

            String mensagem = pedidoDAL.cadastrarPedido(DadosPedido(), ListaProdutos());

            limparProdutos();
            limparDadosPedido();
            //"Pedido Cadastrado com Sucesso !!!";
            MessageBox.Show(mensagem, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private Pedido DadosPedido()
        {
            Pedido pedido = new Pedido();


            pedido.IdFabricante = (int)cbxFabricante.SelectedValue;
            pedido.IdEtapa = (int)cbxEtapa.SelectedValue;
            pedido.PedidoFabricante = txtPedidoFabricante.Text;
            pedido.NomeVendedor = txtNomeVendedor.Text;
            pedido.DataPedido = dtDataPedido.Value;
            pedido.PrevisaoFaturamento = dtPrevisaoFaturamento.Value;
            pedido.Prazo = Convert.ToInt32(txtPrazo.Text);
            pedido.Parcela = Convert.ToInt32(txtParcela.Text);
            pedido.PedidoComprador = txtPedidoComprador.Text;
            pedido.IdUnidade = (int)cbxCompraUnidade.SelectedValue;
            pedido.NomeComprador = txtNomeComprador.Text;
            pedido.Obs = txtObs.Text;

            return pedido;

        }
        private List<ProdPedido> ListaProdutos()
        {

            for (int i = 0; i < dgvProdutosPedido.Rows.Count; i++)
            {
                prodPedidos.Add(new ProdPedido(Convert.ToInt32(dgvProdutosPedido.Rows[i].Cells[0].Value),
                Convert.ToDouble(dgvProdutosPedido.Rows[i].Cells[2].Value),
                Convert.ToDouble(dgvProdutosPedido.Rows[i].Cells[2].Value),
                Convert.ToDouble(dgvProdutosPedido.Rows[i].Cells[3].Value)));

            }
            return prodPedidos;

        }



        private void dgvProdutosPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodProduto.Text = dgvProdutosPedido.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblNomeProduto.Text = dgvProdutosPedido.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtQtd.Text = dgvProdutosPedido.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPreco.Text = dgvProdutosPedido.Rows[e.RowIndex].Cells[3].Value.ToString();

            total = total - Convert.ToDouble(dgvProdutosPedido.Rows[e.RowIndex].Cells[4].Value);

            dgvProdutosPedido.Rows.RemoveAt(dgvProdutosPedido.CurrentRow.Index);


        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            total = total - Convert.ToDouble(dgvProdutosPedido.CurrentRow.Cells[4].Value);
            dgvProdutosPedido.Rows.RemoveAt(dgvProdutosPedido.CurrentRow.Index);
        }



        private void txtParcela_TextChanged(object sender, EventArgs e)
        {
            if (verificaFabricanteVazios())
            {
                //nada
            }
            else
            {
                gpComprador.Enabled = true;
            }
        }

        private void txtNomeComprador_TextChanged(object sender, EventArgs e)
        {
            if (verificaCompradorVazio())
            {
                //nada
            }
            else
            {
                gpProdutos.Enabled = true;
            }
        }
    }


}
