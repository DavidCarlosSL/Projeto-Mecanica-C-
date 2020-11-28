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
    public partial class Vincular_OrcamentoMecanico : Form
    {
        public Vincular_OrcamentoMecanico()
        {
            InitializeComponent();
        }

        public int idOrcamento;
        private int idMecanico;

        private void exibirMecanicos()
        {
            DataTable dt = MecanicoDAO.obterMecanicos();

            if (dt.Rows.Count != 0)
            {
                dgvVincularMecanico.DataSource = dt;
            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void BtnVeiculos_Click(object sender, EventArgs e)
        {
            Veiculos veiculos = new Veiculos();
            veiculos.Show();
            this.Hide();
        }

        private void BtnMecanicos_Click(object sender, EventArgs e)
        {
            Mecanicos mecanicos = new Mecanicos();
            mecanicos.Show();
            this.Hide();
        }

        private void BtnPecas_Click(object sender, EventArgs e)
        {
            Pecas pecas = new Pecas();
            pecas.Show();
            this.Hide();
        }

        private void BtnOrcamento_Click(object sender, EventArgs e)
        {
            Orcamentos orcamentos = new Orcamentos();
            orcamentos.Show();
            this.Hide();
        }

        private void Vincular_OrcamentoMecanico_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.exibirMecanicos();
        }

        private void TxtPesquisaMecanico_Enter(object sender, EventArgs e)
        {
            if (txtPesquisaMecanico.Text == "Pesquise por CPF, Nome...")
            {
                txtPesquisaMecanico.Text = "";
            }
        }

        private void TxtPesquisaMecanico_Leave(object sender, EventArgs e)
        {
            if (txtPesquisaMecanico.Text == "")
            {
                txtPesquisaMecanico.Text = "Pesquise por CPF, Nome...";
            }
        }

        private void TxtPesquisaMecanico_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisaMecanico.Text != "")
            {
                DataTable dt = MecanicoDAO.filtrarMecanicos(txtPesquisaMecanico.Text);
                if (dt.Rows.Count != 0)
                {
                    dgvVincularMecanico.DataSource = dt;
                }
            }
            else
            {
                this.exibirMecanicos();
            }
        }

        private void DgvVincularMecanico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idMecanico = Convert.ToInt32(dgvVincularMecanico.Rows[e.RowIndex].Cells[0].Value.ToString());
            btnVincular.Enabled = true;
        }

        private void BtnVincular_Click(object sender, EventArgs e)
        {
            OrcamentoDAO.vincularMecanicoOrcamento(this.idOrcamento, this.idMecanico);

            MessageBox.Show("Mecânico vinculado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Orcamentos orcamentos = new Orcamentos();
            orcamentos.Show();
            this.Hide();
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            relatorios.Show();
            this.Hide();
        }
    }
}
