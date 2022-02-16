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
    public partial class BaixarNFs : Form
    {
        public BaixarNFs()
        {
            InitializeComponent();
        }
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();


        private void BaixarNFs_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet16.TB_FABRICANTE'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_FABRICANTETableAdapter.Fill(this.sGC_DBDataSet16.TB_FABRICANTE);

        }

        private void btnBuscaNF_Click(object sender, EventArgs e)
        {
            if (!BuscaNfExiste())
            {
                MessageBox.Show("NF não encontrada !!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void atualizaTotais()
        {
            double valor = 0;
            double total = 0;

            foreach (DataGridViewRow linha in dgvBuscaNF.Rows)
            {
                valor = Convert.ToDouble(linha.Cells[2].Value) * Convert.ToDouble(linha.Cells[3].Value);
                total = total + valor;

                lblTotal.Text = total.ToString("C");
            }
        }
        public bool baixarNF()
        {
            bool sucesso = false;

            cmd.Parameters.Clear();
            cmd.CommandText = "UPDATE TB_PEDIDO SET PED_STATUS = @status WHERE NF = @nf AND ID_FABRICANTE = @idFabricante  ";
            cmd.Parameters.AddWithValue("@status", "FINALIZADO");
            cmd.Parameters.AddWithValue("@nf", txtBuscaNF.Text);
            cmd.Parameters.AddWithValue("@idFabricante", cbxFabricante.SelectedValue);
            StringBuilder errorMessages = new StringBuilder();

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();

                sucesso = true;
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
            return sucesso;
        }

        public bool BuscaNfExiste()
        {
            bool verifica = false;

            SqlDataAdapter adapter = new SqlDataAdapter();
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT COD_PRODUTO,DESCRICAO_PROD,SALDO_PEDIDO,VALOR FROM TB_PRODUTOS_PEDIDO AS PD " +
                "INNER JOIN TB_PEDIDO AS TP ON TP.ID_PEDIDO = PD.ID_PEDIDO INNER JOIN TB_PRODUTO AS PR ON PD.ID_PRODUTO = PR.ID_PRODUTO " +
                "WHERE NF = @nf AND ID_FABRICANTE = @idFabricante AND TP.PED_STATUS  = 'ATIVO'";

            cmd.Parameters.AddWithValue("@nf", txtBuscaNF.Text);
            cmd.Parameters.AddWithValue("@idFabricante", cbxFabricante.SelectedValue);

            try
            {
                cmd.Connection = con.conectar();
                adapter.SelectCommand = cmd;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                dgvBuscaNF.DataSource = dataSet;
                dgvBuscaNF.DataMember = dataSet.Tables[0].TableName;
                dgvBuscaNF.Columns[0].HeaderText = "Cod Produto";
                dgvBuscaNF.Columns[1].HeaderText = "Nome Produto";
                dgvBuscaNF.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvBuscaNF.Columns[2].HeaderText = "Qtd";
                dgvBuscaNF.Columns[3].HeaderText = "Valor";

                atualizaTotais();

                con.desconectar();
                verifica = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return verifica;
        }

        private void btnBaixaNF_Click(object sender, EventArgs e)
        {
            if (baixarNF())
            {
                MessageBox.Show("NF Baixada !!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
