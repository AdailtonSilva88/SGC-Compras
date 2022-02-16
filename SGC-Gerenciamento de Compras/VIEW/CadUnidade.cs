using SGC_Gerenciamento_de_Compras.DAL;
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
    public partial class CadUnidade : Form
    {
        public CadUnidade()
        {
            InitializeComponent();
        }

        private Int32 codUnidade;
        private String nomeUnidade;
        private String mensagem;

        UnidadeDAL unidadeDAL = new UnidadeDAL();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            UnidadeDAL ud = new UnidadeDAL();
            Int32 codigo = 0;

            codigo = Convert.ToInt32(txtNumUnidade.Text);

            if (!ud.verificaCodigo(codigo))
            {
                String msgBox = "Codigo já Existe";
                MessageBox.Show(msgBox, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (String.IsNullOrEmpty(txtNomeUnidade.Text) || String.IsNullOrEmpty(txtNumUnidade.Text))
                {
                    String msgBox = "Preencha todos os campos";
                    MessageBox.Show(msgBox, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    codUnidade = Convert.ToInt32(txtNumUnidade.Text);
                    nomeUnidade = txtNomeUnidade.Text;

                    mensagem = ud.cadastrar(codUnidade, nomeUnidade);
                    
                    limparDados();
                    MessageBox.Show(mensagem);
                    carregarDados();                    
                }
            }
        }

        private void CadUnidade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet8.TB_UNIDADE'. Você pode movê-la ou removê-la conforme necessário.
            carregarDados();
        }

        private void carregarDados()
        {
            Int32 novoId = Convert.ToInt32(unidadeDAL.ultimoCadastroId()) + 1;
            txtNumUnidade.Text = novoId.ToString();
            this.tB_UNIDADETableAdapter.Fill(this.sGC_DBDataSet8.TB_UNIDADE);
        }

        private void limparDados()
        {
            txtNomeUnidade.Text = "";
            txtNumUnidade.Text = "";
        }
    }
}
