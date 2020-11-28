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
    public partial class Vincular_ClienteCarro : Form
    {
        public Vincular_ClienteCarro()
        {
            InitializeComponent();
        }

        public string placa_veiculo;
        public int id_cliente;
        public string cpf_cliente;

        private void exibirVeiculos()
        {
            DataTable dt = new VeiculoDAO().obterVeiculos();

            if (dt.Rows.Count != 0)
            {
                dgvVincularVeiculo.DataSource = dt;
            }
        }

        private void Vincular_ClienteCarro_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.exibirVeiculos();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void DgvVincularVeiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVincularVeiculo.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
            {
                btnVincular.Enabled = true;
                this.placa_veiculo = dgvVincularVeiculo.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else
            {
                btnVincular.Enabled = false;
            }

        }

        private void BtnVincular_Click(object sender, EventArgs e)
        {
            if (this.cpf_cliente != null)
                VeiculoDAO.vincularClienteCarro(ClienteDAO.obterClientePorCPF(this.cpf_cliente), this.placa_veiculo);
            else
                VeiculoDAO.vincularClienteCarro(this.id_cliente, this.placa_veiculo);

            MessageBox.Show("Cliente vinculado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Veiculos veiculos = new Veiculos();
            veiculos.Show();
            this.Hide();

        }

        private void TxtPesquisaVeiculo_Leave(object sender, EventArgs e)
        {
            if (txtPesquisaVeiculo.Text == "")
            {
                txtPesquisaVeiculo.Text = "Pesquise por placa, modelo...";
            }
        }

        private void TxtPesquisaVeiculo_Click(object sender, EventArgs e)
        {
            if (txtPesquisaVeiculo.Text == "Pesquise por placa, modelo...")
            {
                txtPesquisaVeiculo.Text = "";
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

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
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
