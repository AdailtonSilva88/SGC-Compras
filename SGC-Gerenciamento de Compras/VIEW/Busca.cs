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
    public partial class frmBusca : Form
    {
        public frmBusca()
        {
            InitializeComponent();
        }

        public String status;
        public String campo;

        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();


        private void btnBusca_Click(object sender, EventArgs e)
        {
            busca(buscaCampo() + buscaStatus()); ;
        }

        private void busca(String Busca)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT TP.ID_PEDIDO,FAB.NOME_FABRICANTE,TP.PEDIDO_FABRICANTE, TP.PEDIDO_COMPRADOR,TP.NF ,TP.NOME_COMPRADOR,TP.NOME_VENDEDOR,TP.DATA_PEDIDO,TP.PREVISAO_FATURAMENTO,TP.PRAZO," +
                "UNI.NOME_UNIDADE,ETA.NOME_ETAPA_PEDIDO,TP.PED_STATUS,TP.OBS,PR.DESCRICAO_PROD,PD.SALDO_PEDIDO,PD.VALOR FROM TB_PEDIDO AS TP " +
                "INNER JOIN TB_PRODUTOS_PEDIDO AS PD ON TP.ID_PEDIDO = PD.ID_PEDIDO " +
                "INNER JOIN TB_PRODUTO AS PR ON PD.ID_PRODUTO = PR.ID_PRODUTO " +
                "INNER JOIN TB_FABRICANTE AS FAB ON FAB.ID_FABRICANTE = TP.ID_FABRICANTE " +
                "INNER JOIN TB_UNIDADE AS UNI ON UNI.ID_UNIDADE = TP.ID_UNIDADE " +
                "INNER JOIN TB_ETAPA_PEDIDO AS ETA ON ETA.ID_ETAPA_PEDIDO = TP.ID_ETAPA_PEDIDO  " + Busca;

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
                dgvResultadoBusca.Columns[4].HeaderText = "NF";
                dgvResultadoBusca.Columns[5].HeaderText = "Nome Comprador";
                dgvResultadoBusca.Columns[6].HeaderText = "Nome Vendedor";
                dgvResultadoBusca.Columns[7].HeaderText = "Data Pedido";
                dgvResultadoBusca.Columns[7].DefaultCellStyle.Format = "d";
                dgvResultadoBusca.Columns[8].HeaderText = "Prev Faturamento";
                dgvResultadoBusca.Columns[8].DefaultCellStyle.Format = "d";
                dgvResultadoBusca.Columns[9].HeaderText = "Prazo";
                dgvResultadoBusca.Columns[10].HeaderText = "Unidade";
                dgvResultadoBusca.Columns[11].HeaderText = "Etapa";
                dgvResultadoBusca.Columns[12].HeaderText = "Status";
                dgvResultadoBusca.Columns[13].HeaderText = "Observação";
                dgvResultadoBusca.Columns[14].HeaderText = "Nome Produto";
                dgvResultadoBusca.Columns[15].HeaderText = "Qtd";
                dgvResultadoBusca.Columns[16].HeaderText = "Valor";

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

        private void btnExportar_Click(object sender, EventArgs e)
        {

            if (dgvResultadoBusca.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvResultadoBusca.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvResultadoBusca.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dgvResultadoBusca.Rows.Count ; i++)
                    {
                        for (int j = 0; j < dgvResultadoBusca.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvResultadoBusca.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }

        }

        public String buscaStatus() 
        {
            if (rdTodos.Checked == true) //buscar todos
            {
                status = "";
            }
            else if (rdAtivo.Checked == true)
            {
                status = "AND TP.PED_STATUS  = 'ATIVO' ";
            }
            else if (rdFinalizado.Checked == true)
            {
                status = "AND TP.PED_STATUS  = 'FINALIZADO' ";
            }
            else if (rdCancelado.Checked == true)
            {
                status = "AND TP.PED_STATUS  = 'CANCELADO' ";
            }

            return status;

        }

        public String buscaCampo()
        {
            if (rdIdPedido.Checked == true) //buscar todos
            {
                campo = "WHERE TP.ID_PEDIDO = " + txtIdPedido.Text;
            }
            else if (rdNFe.Checked == true)
            {
                campo = "WHERE TP.NF = " + txtNF.Text;
            }
            else if (rdFabricante.Checked == true)
            {
                campo = "WHERE TP.ID_FABRICANTE = " + cbxFabricante.SelectedValue;
            }
            else if (rdProduto.Checked == true)
            {
                campo = "WHERE PR.COD_PRODUTO = " + txtProduto.Text;
            }

            return campo;

        }

        private void rdIdPedido_CheckedChanged(object sender, EventArgs e)
        {
            if (rdIdPedido.Checked) 
            {
                lblIdPedido.Visible = true;
                txtIdPedido.Visible = true;
            }
            else 
            {
                lblIdPedido.Visible = false;
                txtIdPedido.Visible = false;
            }
        }

        private void rdNFe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNFe.Checked)
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

        private void rdFabricante_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFabricante.Checked)
            {
                lblFabricante.Visible = true;
                cbxFabricante.Visible = true;
            }
            else
            {
                lblFabricante.Visible = false;
                cbxFabricante.Visible = false;
            }
        }

        private void rdProduto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdProduto.Checked)
            {
                lblCodProduto.Visible = true;
                lblNomeProduto.Visible = true;
                txtProduto.Visible = true;
            }
            else
            {
                lblCodProduto.Visible = false;
                lblNomeProduto.Visible = false;
                txtProduto.Visible = false;
            }
        }
    }
}
