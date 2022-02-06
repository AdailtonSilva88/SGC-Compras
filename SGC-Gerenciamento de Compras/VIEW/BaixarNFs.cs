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
    public partial class BaixarNFs : Form
    {
        public BaixarNFs()
        {
            InitializeComponent();
        }

        private void BaixarNFs_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGC_DBDataSet16.TB_FABRICANTE'. Você pode movê-la ou removê-la conforme necessário.
            this.tB_FABRICANTETableAdapter.Fill(this.sGC_DBDataSet16.TB_FABRICANTE);

        }
    }
}
