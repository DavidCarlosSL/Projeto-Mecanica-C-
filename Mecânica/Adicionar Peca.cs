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
    public partial class Adicionar_Peca : Form
    {
        public Adicionar_Peca()
        {
            InitializeComponent();
        }

        private int idPeca;
        public int idOrcamento;
        private int quantidadePeca;

        public ModeloOrcamento orcamento = new ModeloOrcamento();

        private void Adicionar_Peca_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.exibirPecas();
        }

        private void exibirPecas()
        {
            DataTable dt = PecaDAO.obterPecas();

            if (dt.Rows.Count != 0)
            {
                dgvPecas.DataSource = dt;
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

        private void TxtPesquisaPeca_Enter(object sender, EventArgs e)
        {
            if (txtPesquisaPeca.Text == "Pesquise por Nome...")
            {
                txtPesquisaPeca.Text = "";
            }
        }

        private void TxtPesquisaPeca_Leave(object sender, EventArgs e)
        {
            if (txtPesquisaPeca.Text == "")
            {
                txtPesquisaPeca.Text = "Pesquise por Nome...";
            }
        }

        private void TxtPesquisaPeca_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisaPeca.Text != "")
            {
                DataTable dt = PecaDAO.filtrarPecas(txtPesquisaPeca.Text);
                if (dt.Rows.Count != 0)
                {
                    dgvPecas.DataSource = dt;
                }
            }
            else
            {
                this.exibirPecas();
            }
        }

        private void DgvPecas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idPeca = Convert.ToInt32(dgvPecas.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.quantidadePeca = Convert.ToInt32(dgvPecas.Rows[e.RowIndex].Cells[2].Value.ToString());
            this.orcamento._valorPecasOrcamento += Convert.ToDouble(dgvPecas.Rows[e.RowIndex].Cells[3].Value.ToString());

            if (Convert.ToInt32(dgvPecas.Rows[e.RowIndex].Cells[2].Value.ToString()) > 0)
                btnAdicionar.Enabled = true;
            else
                btnAdicionar.Enabled = false;
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            OrcamentoDAO.vincularOrcamentoPeca(this.idOrcamento, this.idPeca);
            PecaDAO.debitaPeca(this.idPeca, (this.quantidadePeca - 1));

            Cadastro_Orcamento cadastro_orcamento = new Cadastro_Orcamento();
            cadastro_orcamento.idOrcamento = Convert.ToString(this.idOrcamento);
            cadastro_orcamento.definiOrcamento(this.orcamento);

            cadastro_orcamento.Show();
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
