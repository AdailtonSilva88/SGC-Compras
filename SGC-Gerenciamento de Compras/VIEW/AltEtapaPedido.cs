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
    public partial class AltEtapaPedido : Form
    {
        public AltEtapaPedido()
        {
            InitializeComponent();
        }

        String idPedido;

        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        int qtd;
        double valor;
        double total = 0;
        private List<ProdPedido> prodPedidos;

        private Pedido DadosPedido()
        {
            Pedido pedido = new Pedido();

            pedido.IdPedido = Convert.ToInt32(idPedido);

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

            if (cbxEtapa.Text == "NF")
            {
                pedido.Nf = Convert.ToInt32(txtNF.Text);
            }
            else
            {
                pedido.Nf = 0;
            }

            return pedido;

        }

        private List<ProdPedido> ListaProdutos()
        {

            for (int i = 0; i < dgvProdutosPedido.Rows.Count; i++)
            {
                prodPedidos.Add(new ProdPedido(Convert.ToInt32(dgvProdEtapas.Rows[i].Cells[0].Value),
                Convert.ToDouble(dgvProdEtapas.Rows[i].Cells[2].Value),
                Convert.ToDouble(dgvProdEtapas.Rows[i].Cells[2].Value),
                Convert.ToDouble(dgvProdEtapas.Rows[i].Cells[3].Value)));

            }
            return prodPedidos;

        }

        private void AltEtapaPedido_Load(object sender, EventArgs e)
        {
            
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet13.TB_UNIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_UNIDADETableAdapter.Fill(this.sGC_DBDataSet13.TB_UNIDADE);
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet12.TB_FABRICANTE'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_FABRICANTETableAdapter.Fill(this.sGC_DBDataSet12.TB_FABRICANTE);
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet11.TB_ETAPA_PEDIDO'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_ETAPA_PEDIDOTableAdapter.Fill(this.sGC_DBDataSet11.TB_ETAPA_PEDIDO);

        }

        public bool BuscaPedido(String pedido) 
        {
            //carrega os dados dos pedidos
            bool valida = false;

            SqlDataReader dr;
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT ID_PEDIDO,ID_FABRICANTE,PEDIDO_FABRICANTE,NOME_VENDEDOR,DATA_PEDIDO,PREVISAO_FATURAMENTO,PRAZO,PARCELA,PEDIDO_COMPRADOR,ID_UNIDADE,NOME_COMPRADOR,OBS " +
                "FROM TB_PEDIDO WHERE PEDIDO_FABRICANTE = " + pedido ;

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    idPedido = dr[0].ToString();
                    cbxFabricante.SelectedValue = dr[1];
                    txtPedidoFabricante.Text = dr[2].ToString();
                    txtNomeVendedor.Text = dr[3].ToString();
                    dtDataPedido.Value = (DateTime)dr[4];
                    dtPrevisaoFaturamento.Value = (DateTime)dr[5];
                    txtPrazo.Text = dr[6].ToString();
                    txtParcela.Text = dr[7].ToString();
                    txtPedidoComprador.Text = dr[8].ToString();
                    cbxCompraUnidade.SelectedValue = dr[9];
                    txtNomeComprador.Text = dr[10].ToString();
                    txtObs.Text = dr[11].ToString();

                    con.desconectar();


                    if (idPedido == "")
                    {
                    }
                    else
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        cmd.Parameters.Clear();
                        cmd.CommandText = "SELECT PROD.COD_PRODUTO,PROD.DESCRICAO_PROD,PPED.SALDO_PEDIDO,PPED.VALOR " +
                            "FROM TB_PRODUTOS_PEDIDO AS PPED INNER JOIN TB_PRODUTO AS PROD ON PPED.ID_PRODUTO = PROD.ID_PRODUTO " +
                            "WHERE PPED.ID_PEDIDO = " + idPedido;

                        try
                        {
                            cmd.Connection = con.conectar();
                            adapter.SelectCommand = cmd;

                            DataSet dataSet = new DataSet();
                            adapter.Fill(dataSet);

                            dgvProdutosPedido.DataSource = dataSet;
                            dgvProdutosPedido.DataMember = dataSet.Tables[0].TableName;
                            dgvProdutosPedido.Columns[0].HeaderText = "Cod Produto";
                            dgvProdutosPedido.Columns[1].HeaderText = "Nome Produto";
                            dgvProdutosPedido.Columns[2].HeaderText = "Saldo";
                            dgvProdutosPedido.Columns[3].HeaderText = "Valor";



                            //dgvProdutosPedido.Columns[4].HeaderText = "Total";

                            con.desconectar();
                            valida = true;
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        atualizaTotais();
                    }
                }
                              
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return valida;

        }

        private void dgvProdutosPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodProduto.Text = dgvProdutosPedido.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblNomeProduto.Text = dgvProdutosPedido.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtQtd.Text = dgvProdutosPedido.Rows[e.RowIndex].Cells[2].Value.ToString();
            qtd = Convert.ToInt32(txtQtd.Text);
            txtValor.Text = dgvProdutosPedido.Rows[e.RowIndex].Cells[3].Value.ToString();

            //total = total - Convert.ToDouble(dgvProdutosPedido.Rows[e.RowIndex].Cells[4].Value);

            //dgvProdutosPedido.Rows.RemoveAt(dgvProdutosPedido.CurrentRow.Index);
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            int saldo;
            dgvProdEtapas.Rows.Add(txtCodProduto.Text, lblNomeProduto.Text, txtQtd.Text, txtValor.Text);
            saldo = qtd - Convert.ToInt32(txtQtd.Text);

            int index = dgvProdutosPedido.CurrentRow.Index;

            if (saldo == 0) {
                dgvProdutosPedido.Rows.RemoveAt(index);
            }
            else 
            {
                dgvProdutosPedido.Rows[index].Cells[2].Value = saldo;
            }
            atualizaTotais();
            
        }

        private void atualizaTotais() 
        {
             
            foreach (DataGridViewRow linha in dgvProdEtapas.Rows)
            {
               valor = Convert.ToDouble(linha.Cells[2].Value) * Convert.ToDouble(linha.Cells[3].Value);
                total = total + valor;

                lblTotalNovoPedido.Text = total.ToString();
            }

            total = 0;

            foreach (DataGridViewRow linha in dgvProdutosPedido.Rows)
            {
                valor = Convert.ToDouble(linha.Cells[2].Value) * Convert.ToDouble(linha.Cells[3].Value);
                total = total + valor;

                lblTotalPedido.Text = total.ToString();
            }

            total = 0;

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            PedidoDAL pedidoDAL = new PedidoDAL();

            String mensagem = pedidoDAL.cadEtapaPedido(DadosPedido(), ListaProdutos());

           
            //"Pedido Cadastrado com Sucesso !!!";
            MessageBox.Show(mensagem, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cbxEtapa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEtapa.Text == "NF")
            {
                lblNF.Visible = true;
                txtNF.Visible = true;
            }
            else
            {
                lblNF.Visible = false;
                txtNF.Visible = false;
            }
        }
    }
}
