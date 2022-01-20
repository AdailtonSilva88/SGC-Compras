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
    public partial class CadEtapas : Form
    {
        public CadEtapas()
        {
            InitializeComponent();
        }

        private String nomeEtapa;
        private String mensagem;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            EtapaDAL ed = new EtapaDAL();
            String etapa;
            etapa = txtNomeEtapa.Text;

            if (!ed.verificaEtapa(etapa))
            {
                String msgBox = "Etapa já Existe";
                MessageBox.Show(msgBox, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (String.IsNullOrEmpty(txtNomeEtapa.Text))
                {
                    String msgBox = "Preencha o nome da Etapa";
                    MessageBox.Show(msgBox, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    nomeEtapa = txtNomeEtapa.Text;

                    EtapaDAL produtoDal = new EtapaDAL();

                    mensagem = produtoDal.cadastrar(nomeEtapa);

                    MessageBox.Show(mensagem);
                    carregarDados();
                    limparDados();
                }
            }

        }

        private void CadEtapas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet5.TB_ETAPA_PEDIDO'. Você pode movê-la ou removê-la conforme necessário.
            carregarDados();

        }

        private void carregarDados() 
        {
            this.tB_ETAPA_PEDIDOTableAdapter.Fill(this.sGC_DBDataSet5.TB_ETAPA_PEDIDO);
        }

        private void limparDados() 
        {
            txtNomeEtapa.Text = null;
        }
    }
}
