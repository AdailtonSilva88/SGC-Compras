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
    public partial class CadProduto : Form
    {
        public CadProduto()
        {
            InitializeComponent();
        }
        
        private String descricao;
        private String mensagem;

        ProdutoDAL produtoDal = new ProdutoDAL();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ProdutoDAL pd = new ProdutoDAL();
            Int32 codProduto = 0;
            codProduto = Convert.ToInt32(txtCodProduto.Text);

            if (!pd.verificaCodigo(codProduto))
            {
                String msgBox = "Codigo já Existe";
                MessageBox.Show(msgBox, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (String.IsNullOrEmpty(txtDescricaoProduto.Text) || String.IsNullOrEmpty(txtCodProduto.Text))
                {
                    String msgBox = "Preencha todos os campos";
                    MessageBox.Show(msgBox, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    codProduto = Convert.ToInt32(txtCodProduto.Text);
                    descricao = txtDescricaoProduto.Text;
                    mensagem = produtoDal.cadastrarProd(codProduto, descricao);

                    limparDados();
                    MessageBox.Show(mensagem);
                    carregarDados();
                }
            }
        }

        private void CadProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet7.TB_PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            carregarDados();
        }

        private void carregarDados() 
        {
            Int32 novoId = Convert.ToInt32(produtoDal.ultimoCadastroId()) + 1;
            txtCodProduto.Text = novoId.ToString();
            this.tB_PRODUTOTableAdapter.Fill(this.sGC_DBDataSet7.TB_PRODUTO);
        }

        private void limparDados() 
        {
            txtCodProduto.Text = null;
            txtDescricaoProduto.Text = null;
        }
    }
}
