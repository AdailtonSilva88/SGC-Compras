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
    public partial class frmCadastroFabricante : Form
    {
        public frmCadastroFabricante()
        {
            InitializeComponent();
        }

        private String nomeFabricante;
        private String mensagem;

        FabricanteDAL fabricanteDal = new FabricanteDAL();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FabricanteDAL fd = new FabricanteDAL();
            Int32 codFabricante = 0;
            codFabricante = Convert.ToInt32(txtNumFabricante.Text);

            if (!fd.verificaCodigo(codFabricante))
            {
                String msgBox = "Codigo já Existe";
                MessageBox.Show(msgBox, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (String.IsNullOrEmpty(txtNomeFabricante.Text) || String.IsNullOrEmpty(txtNumFabricante.Text))
                {
                    String msgBox = "Preencha todos os campos";
                    MessageBox.Show(msgBox, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    codFabricante = Convert.ToInt32(txtNumFabricante.Text);
                    nomeFabricante = txtNomeFabricante.Text;

                    mensagem = fabricanteDal.cadastrar(codFabricante, nomeFabricante);

                    MessageBox.Show(mensagem);
                    limparDados();
                    carregarDados();
                }
            }
        }

        private void frmCadastroFabricante_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet6.TB_FABRICANTE'. Você pode movê-la ou removê-la conforme necessário.
            carregarDados();
        }

        private void carregarDados() 
        {
            Int32 novoId = Convert.ToInt32(fabricanteDal.ultimoCadastroId()) + 1;
            txtNumFabricante.Text = novoId.ToString();
            this.tB_FABRICANTETableAdapter.Fill(this.sGC_DBDataSet6.TB_FABRICANTE);
        }

        private void limparDados() 
        {
            txtNomeFabricante.Text = null;
            txtNumFabricante.Text = null;
        }

    }
}
