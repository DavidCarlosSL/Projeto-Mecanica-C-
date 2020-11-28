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
    public partial class Orcamentos : Form
    {
        public Orcamentos()
        {
            InitializeComponent();
        }

        private int idOrcamento;

        private void exibirOrcamentos()
        {
            DataTable dt = OrcamentoDAO.obterOrcamentos();

            if (dt.Rows.Count != 0)
            {
                dgvOrcamentos.DataSource = dt;
            }
        }

        private void Orcamentos_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.exibirOrcamentos();
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

        private void BtnCadastrarOrcamento_Click(object sender, EventArgs e)
        {
            Cadastro_Orcamento cadastro_orcamento = new Cadastro_Orcamento();
            cadastro_orcamento.Show();
            this.Hide();
        }

        private void DgvOrcamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Pecas_Vinculadas pecas_vinculadas = new Pecas_Vinculadas();
            pecas_vinculadas.idOrcamento = this.idOrcamento;
            pecas_vinculadas.Show();
        }

        private void DgvOrcamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idOrcamento = Convert.ToInt32(dgvOrcamentos.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (dgvOrcamentos.Rows[e.RowIndex].Cells[6].Value.ToString() == "")
                btnVincularVeiculo.Enabled = true;
            else
                btnVincularVeiculo.Enabled = false;

            if (dgvOrcamentos.Rows[e.RowIndex].Cells[7].Value.ToString() == "")
                btnVincularMecanico.Enabled = true;
            else
                btnVincularMecanico.Enabled = false;
        }

        private void TxtPesquisaOrcamento_Enter(object sender, EventArgs e)
        {
            if (txtPesquisaOrcamento.Text == "Pesquise por Placa...")
            {
                txtPesquisaOrcamento.Text = "";
            }
        }

        private void TxtPesquisaOrcamento_Leave(object sender, EventArgs e)
        {
            if (txtPesquisaOrcamento.Text == "")
            {
                txtPesquisaOrcamento.Text = "Pesquise por Placa...";
            }
        }

        private void TxtPesquisaOrcamento_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisaOrcamento.Text != "")
            {
                DataTable dt = OrcamentoDAO.filtrarOrcamentos(txtPesquisaOrcamento.Text);
                if (dt.Rows.Count != 0)
                {
                    dgvOrcamentos.DataSource = dt;
                }
            }
            else
            {
                this.exibirOrcamentos();
            }
        }

        private void BtnVincularMecanico_Click(object sender, EventArgs e)
        {
            Vincular_OrcamentoMecanico vincular_orcamentoMecanico = new Vincular_OrcamentoMecanico();

            vincular_orcamentoMecanico.idOrcamento = this.idOrcamento;
            vincular_orcamentoMecanico.Show();
            this.Hide();
        }

        private void BtnVincularVeiculo_Click(object sender, EventArgs e)
        {
            Vincular_OrcamentoVeiculo vincular_orcamentoVeiculo = new Vincular_OrcamentoVeiculo();

            vincular_orcamentoVeiculo.idOrcamento = this.idOrcamento;
            vincular_orcamentoVeiculo.Show();
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
