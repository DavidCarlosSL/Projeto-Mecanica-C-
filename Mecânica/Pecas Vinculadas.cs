using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mecânica
{
    public partial class Pecas_Vinculadas : Form
    {
        public Pecas_Vinculadas()
        {
            InitializeComponent();
        }

        public int idOrcamento;

        private void exibirPecasVinculadas()
        {
            DataTable dt = OrcamentoDAO.obterPecasVinculadas(this.idOrcamento);

            if (dt.Rows.Count != 0)
            {
                dgvVeiculosVinculados.DataSource = dt;
            }
        }

        private void Pecas_Vinculadas_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.exibirPecasVinculadas();
        }
    }
}
