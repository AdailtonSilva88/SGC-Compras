using SGC_Gerenciamento_de_Compras.DAL;
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
    public partial class Busca : Form
    {
        public Busca()
        {
            InitializeComponent();
        }

        public String buscar;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        private void btnBusca_Click(object sender, EventArgs e)
        {            
            if (txtPedidoCliente.Text != "")
            {
                buscar = "WHERE TP.PEDIDO_COMPRADOR = " + txtPedidoCliente.Text;                
            }
            else if (txtPedidoFabricante.Text != "")
            {
                buscar = "WHERE TP.PEDIDO_FABRICANTE = " + txtPedidoFabricante.Text;                
            }
            else if (txtNF.Text != "")
            {
                buscar = "WHERE TP.NF = " + txtNF.Text;                
            }
            else if (txtVendedor.Text != "")
            {
                buscar = "WHERE TP.NOME_VENDEDOR = '" + txtVendedor.Text + "'";                
            }
            else if (txtComprador.Text != "")
            {
                buscar = "WHERE TP.NOME_COMPRADOR = '" + txtComprador.Text +"'";                
            }                  
            else if (txtProduto.Text != "")
            {
                buscar = "WHERE PD.ID_PRODUTO = " + txtProduto.Text;
            }
            else 
            {
                buscar = "WHERE TP.ID_FABRICANTE = " + cbxFabricante.SelectedValue;
            }
            busca(buscar);
        }

        private void busca(String Busca)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT TP.ID_PEDIDO,FAB.NOME_FABRICANTE,TP.PEDIDO_FABRICANTE, TP.PEDIDO_COMPRADOR,TP.NOME_COMPRADOR,TP.NOME_VENDEDOR,TP.PREVISAO_FATURAMENTO,TP.PRAZO," +
                "UNI.NOME_UNIDADE,ETA.NOME_ETAPA_PEDIDO,PR.DESCRICAO_PROD,PD.QTD_PEDIDO,PD.VALOR FROM TB_PEDIDO AS TP " +
                "INNER JOIN TB_PRODUTOS_PEDIDO AS PD ON TP.ID_PEDIDO = PD.ID_PEDIDO " +
                "INNER JOIN TB_PRODUTO AS PR ON PD.ID_PRODUTO = PR.ID_PRODUTO " +
                "INNER JOIN TB_FABRICANTE AS FAB ON FAB.ID_FABRICANTE = TP.ID_FABRICANTE " +
                "INNER JOIN TB_UNIDADE AS UNI ON UNI.ID_UNIDADE = TP.ID_UNIDADE " +
                "INNER JOIN TB_ETAPA_PEDIDO AS ETA ON ETA.ID_ETAPA_PEDIDO = TP.ID_ETAPA_PEDIDO " + Busca ;


            try
            {
                cmd.Connection = con.conectar();
                adapter.SelectCommand = cmd;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                dgvResultadoBusca.DataSource = dataSet;
                dgvResultadoBusca.DataMember = dataSet.Tables[0].TableName;
                dgvResultadoBusca.Columns[0].HeaderText = "ID Pedido";
                dgvResultadoBusca.Columns[1].HeaderText = "Nome Fabricante";
                dgvResultadoBusca.Columns[2].HeaderText = "Ped Fabricante";
                dgvResultadoBusca.Columns[3].HeaderText = "Ped Comprador";
                dgvResultadoBusca.Columns[4].HeaderText = "Nome Comprador";
                dgvResultadoBusca.Columns[5].HeaderText = "Nome Vendedor";
                dgvResultadoBusca.Columns[6].HeaderText = "Prev Faturamento";
                dgvResultadoBusca.Columns[6].DefaultCellStyle.Format = "d";
                dgvResultadoBusca.Columns[7].HeaderText = "Prazo";
                dgvResultadoBusca.Columns[8].HeaderText = "Unidade";
                dgvResultadoBusca.Columns[9].HeaderText = "Etapa";
                dgvResultadoBusca.Columns[10].HeaderText = "Nome Produto";
                dgvResultadoBusca.Columns[11].HeaderText = "Qtd";
                dgvResultadoBusca.Columns[12].HeaderText = "Valor";              

                con.desconectar();
            }
            catch (SqlException ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Busca_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet15.TB_UNIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_UNIDADETableAdapter.Fill(this.sGC_DBDataSet15.TB_UNIDADE);
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet14.TB_FABRICANTE'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_FABRICANTETableAdapter.Fill(this.sGC_DBDataSet14.TB_FABRICANTE);

        }

        private void txtProduto_Leave(object sender, EventArgs e)
        {
            if (txtProduto.Text == "")
            {

            }
            else
            {
                ProdPedidoDAL prodPedidoDAL = new ProdPedidoDAL();
                lblNomeProduto.Text = prodPedidoDAL.nomeProduto(Convert.ToInt32(txtProduto.Text));
            }
        }
    }
}
