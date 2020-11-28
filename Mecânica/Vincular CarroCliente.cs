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
    public partial class Vincular_CarroCliente : Form
    {
        public Vincular_CarroCliente()
        {
            InitializeComponent();
        }

        public string placa_veiculo;
        private int id_cliente;

        private void exibirClientes()
        {
            DataTable dt = ClienteDAO.obterClientes();

            if (dt.Rows.Count != 0)
            {
                dgvVincularCliente.DataSource = dt;
            }
        }

        private void Vincular_CarroCliente_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.exibirClientes();
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

        private void DgvVincularCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnVincular.Enabled = true;

            this.id_cliente = Convert.ToInt32(dgvVincularCliente.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void BtnVincular_Click(object sender, EventArgs e)
        {
            ClienteDAO.vincularCarroCliente(this.id_cliente, this.placa_veiculo);

            MessageBox.Show("Veiculo vinculado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Veiculos veiculos = new Veiculos();
            veiculos.Show();
            this.Hide();
        }

        private void TxtPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisaCliente.Text != "")
            {
                DataTable dt = ClienteDAO.filtrarClientes(txtPesquisaCliente.Text);
                if (dt.Rows.Count != 0)
                {
                    dgvVincularCliente.DataSource = dt;
                }
            }
            else
            {
                this.exibirClientes();
            }
        }

        private void TxtPesquisaCliente_Enter(object sender, EventArgs e)
        {
            if (txtPesquisaCliente.Text == "Pesquise por CPF, Nome...")
            {
                txtPesquisaCliente.Text = "";
            }
        }

        private void TxtPesquisaCliente_Leave(object sender, EventArgs e)
        {
            if (txtPesquisaCliente.Text == "")
            {
                txtPesquisaCliente.Text = "Pesquise por CPF, Nome...";
            }
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
