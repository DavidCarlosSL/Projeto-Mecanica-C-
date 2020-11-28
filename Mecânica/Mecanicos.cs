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
    public partial class Mecanicos : Form
    {
        public Mecanicos()
        {
            InitializeComponent();
        }

        private void exibirMecanicos()
        {
            DataTable dt = MecanicoDAO.obterMecanicos();

            if (dt.Rows.Count != 0)
            {
                dgvMecanicos.DataSource = dt;
            }
        }

        private void Mecanicos_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.exibirMecanicos();
        }

        private void BtnMecanicos_Click(object sender, EventArgs e)
        {
            Mecanicos mecanicos = new Mecanicos();
            mecanicos.Show();
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

        private void BtnRegistrarMecanico_Click(object sender, EventArgs e)
        {
            Cadastro_Mecanico cadastro_mecanico = new Cadastro_Mecanico();
            cadastro_mecanico.Show();
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
                    dgvMecanicos.DataSource = dt;
                }
            }
            else
            {
                this.exibirMecanicos();
            }
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            relatorios.Show();
            this.Hide();
        }
    }
}
