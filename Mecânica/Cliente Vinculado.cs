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
    public partial class Cliente_Vinculado : Form
    {
        public Cliente_Vinculado()
        {
            InitializeComponent();
        }

        public int id_cliente;

        private void exibirClienteVinculado()
        {
            DataTable dt = ClienteDAO.obterClienteVinculado(this.id_cliente);

            if (dt.Rows.Count != 0)
            {
                dgvClienteVinculado.DataSource = dt;
            }
        }

        private void Cliente_Vinculado_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.exibirClienteVinculado();
        }
    }
}
