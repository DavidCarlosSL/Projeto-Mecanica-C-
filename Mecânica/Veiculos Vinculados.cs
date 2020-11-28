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
    public partial class Veiculos_Vinculados : Form
    {
        public Veiculos_Vinculados()
        {
            InitializeComponent();
        }

        public int id_cliente;

        private void exibirVeiculosVinculados()
        {
            DataTable dt = VeiculoDAO.obterVeiculosVinculados(this.id_cliente);

            if (dt.Rows.Count != 0)
            {
                dgvVeiculosVinculados.DataSource = dt;
            }
        }

        private void Veiculos_Vinculados_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.exibirVeiculosVinculados();
        }
    }
}
