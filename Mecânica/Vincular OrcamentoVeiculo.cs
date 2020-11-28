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
    public partial class Vincular_OrcamentoVeiculo : Form
    {
        public Vincular_OrcamentoVeiculo()
        {
            InitializeComponent();
        }

        public int idOrcamento;
        private string placaVeiculo;

        private void Vincular_OrcamentoVeiculo_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.exibirVeiculos();
        }

        private void exibirVeiculos()
        {
            DataTable dt = new VeiculoDAO().obterVeiculos();

            if (dt.Rows.Count != 0)
            {
                dgvVincularVeiculo.DataSource = dt;
            }
        }

        private void TxtPesquisaVeiculo_Enter(object sender, EventArgs e)
        {
            if (txtPesquisaVeiculo.Text == "Pesquise por placa, modelo...")
            {
                txtPesquisaVeiculo.Text = "";
            }
        }

        private void TxtPesquisaVeiculo_Leave(object sender, EventArgs e)
        {
            if (txtPesquisaVeiculo.Text == "")
            {
                txtPesquisaVeiculo.Text = "Pesquise por placa, modelo...";
            }
        }

        private void TxtPesquisaVeiculo_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisaVeiculo.Text != "")
            {
                DataTable dt = VeiculoDAO.filtrarVeiculos(txtPesquisaVeiculo.Text);
                if (dt.Rows.Count != 0)
                {
                    dgvVincularVeiculo.DataSource = dt;
                }
            }
            else
            {
                this.exibirVeiculos();
            }
        }

        private void DgvVincularVeiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.placaVeiculo = dgvVincularVeiculo.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnVincular.Enabled = true;
        }

        private void BtnVincular_Click(object sender, EventArgs e)
        {
            OrcamentoDAO.vincularVeiculoOrcamento(this.idOrcamento, this.placaVeiculo);

            MessageBox.Show("Veiculo vinculado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Orcamentos orcamentos = new Orcamentos();
            orcamentos.Show();
            this.Hide();
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

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            relatorios.Show();
            this.Hide();
        }
    }
}
