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
    public partial class Relatorio_Orcamento : Form
    {
        public Relatorio_Orcamento()
        {
            InitializeComponent();
        }

        public ModeloRelatorio relatorio = new ModeloRelatorio();

        private void exibirOrcamentos()
        {
            DataTable dt = OrcamentoDAO.filtrarOrcamentosPorData(relatorio.dataInicial, relatorio.dataFinal);

            if (dt.Rows.Count != 0)
            {
                dgvRelatorioFaturamento.DataSource = dt;
            }
        }

        private void Relatorio_Orcamento_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.exibirOrcamentos();
            txtOrcamento.Text = Convert.ToString(RelatorioDAO.obterRelatorioOrcamento(relatorio));
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
                    dgvRelatorioFaturamento.DataSource = dt;
                }
            }
            else
            {
                this.exibirOrcamentos();
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

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            relatorios.Show();
            this.Hide();
        }
    }
}
