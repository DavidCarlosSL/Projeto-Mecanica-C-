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
    public partial class Veiculos : Form
    {
        ModeloVeiculo veiculo = new ModeloVeiculo();

        public Veiculos()
        {
            InitializeComponent();
        }

        private void atualizaForm()
        {
            Veiculos veiculos = new Veiculos();
            veiculos.Show();
            this.Hide();
        }

        private void exibirVeiculos()
        {
            DataTable dt = new VeiculoDAO().obterVeiculos();

            if (dt.Rows.Count != 0)
            {
                dgvVeiculos.DataSource = dt;
            }
        }

        private void Veiculos_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.exibirVeiculos();
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

        private void BtnRegistrarVeiculo_Click(object sender, EventArgs e)
        {
            Cadastro_Veiculo cadastro_veiculo = new Cadastro_Veiculo();
            cadastro_veiculo.Show();
            this.Hide();
        }

        private void DgvVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterarRegistro.Enabled = true;
            btnRemoverVeiculo.Enabled = true;

            if (!(dgvVeiculos.Rows[e.RowIndex].Cells[0].Value.ToString() == ""))
            {
                this.veiculo._idCliente = Convert.ToInt32(dgvVeiculos.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnVincularCliente.Enabled = false;
            }
            else
                btnVincularCliente.Enabled = true;
            this.veiculo._placaVeiculo = dgvVeiculos.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.veiculo._marcaVeiculo = dgvVeiculos.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.veiculo._modeloVeiculo = dgvVeiculos.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.veiculo._anoFabricacao = Convert.ToInt32(dgvVeiculos.Rows[e.RowIndex].Cells[4].Value.ToString());
            this.veiculo._anoModelo = Convert.ToInt32(dgvVeiculos.Rows[e.RowIndex].Cells[5].Value.ToString());
            this.veiculo._motorVeiculo = dgvVeiculos.Rows[e.RowIndex].Cells[6].Value.ToString();
            this.veiculo._corVeiculo = dgvVeiculos.Rows[e.RowIndex].Cells[7].Value.ToString();
            this.veiculo._observacaoVeiculo = dgvVeiculos.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void DgvVeiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(dgvVeiculos.Rows[e.RowIndex].Cells[0].Value.ToString() == ""))
            {
                Cliente_Vinculado cliente_vinculado = new Cliente_Vinculado();
                cliente_vinculado.id_cliente = this.veiculo._idCliente;
                cliente_vinculado.Show();
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
                    dgvVeiculos.DataSource = dt;
                }
            }
            else
            {
                this.exibirVeiculos();
            }
        }

        private void BtnRemoverVeiculo_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja mesmo apagar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (resp == DialogResult.Yes)
            {
                VeiculoDAO.removerVeiculo(this.veiculo._placaVeiculo);
                this.atualizaForm();
            }
        }

        private void BtnAlterarRegistro_Click(object sender, EventArgs e)
        {
            Alterar_Veiculo alterar_veiculo = new Alterar_Veiculo();
            alterar_veiculo.definirVeiculo(this.veiculo);
            alterar_veiculo.Show();
            this.Hide();
        }

        private void BtnVincularCliente_Click(object sender, EventArgs e)
        {
            Vincular_CarroCliente vincular_carroCliente = new Vincular_CarroCliente();
            vincular_carroCliente.placa_veiculo = veiculo._placaVeiculo;
            vincular_carroCliente.Show();
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
