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
    public partial class Clientes : Form
    {
        ModeloCliente cliente = new ModeloCliente();

        public Clientes()
        {
            InitializeComponent();
        }

        private void atualizaForm()
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void exibirClientes()
        {
            DataTable dt = ClienteDAO.obterClientes();

            if (dt.Rows.Count != 0)
            {
                dgvClientes.DataSource = dt;
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.exibirClientes();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            this.atualizaForm();
        }

        private void BtnVeiculos_Click(object sender, EventArgs e)
        {
            Veiculos veiculos = new Veiculos();
            veiculos.Show();
            this.Hide();
        }

        private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            Cadastro_Cliente cadastro_cliente = new Cadastro_Cliente();
            cadastro_cliente.Show();
            this.Hide();
        }

        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterarRegistro.Enabled = true;
            btnRemoverCliente.Enabled = true;
            btnVincularVeiculo.Enabled = true;

            this.cliente._idCliente = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.cliente._cpfCliente = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.cliente._nomeCliente = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.cliente._fone1Cliente = dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.cliente._fone2Cliente = dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.cliente._emailCliente = dgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.cliente._cepCliente = dgvClientes.Rows[e.RowIndex].Cells[6].Value.ToString();
            this.cliente._enderecoCliente = dgvClientes.Rows[e.RowIndex].Cells[7].Value.ToString();
            this.cliente._bairroCliente = dgvClientes.Rows[e.RowIndex].Cells[8].Value.ToString();
            this.cliente._cidadeCliente = dgvClientes.Rows[e.RowIndex].Cells[9].Value.ToString();
            this.cliente._estadoCliente = dgvClientes.Rows[e.RowIndex].Cells[10].Value.ToString();
            this.cliente._dataCadastro = Convert.ToDateTime(dgvClientes.Rows[e.RowIndex].Cells[11].Value.ToString());
            this.cliente._observacaoCliente = dgvClientes.Rows[e.RowIndex].Cells[12].Value.ToString();

        }

        private void DgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Veiculos_Vinculados veiculos_vinculados = new Veiculos_Vinculados();
            veiculos_vinculados.id_cliente = this.cliente._idCliente;
            veiculos_vinculados.Show();
        }

        private void BtnRemoverCliente_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Todos os veiculos vinculados a este cliente também serão apagados. Deseja mesmo prosseguir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (resp == DialogResult.Yes)
            {
                VeiculoDAO.removerVeiculosVinculados(this.cliente._idCliente);
                ClienteDAO.removerCliente(this.cliente._idCliente);

                this.atualizaForm();
            }
        }

        private void BtnAlterarRegistro_Click(object sender, EventArgs e)
        {
            Alterar_Cliente alterar_cliente = new Alterar_Cliente();
            alterar_cliente.definirCliente(this.cliente);
            alterar_cliente.Show();
            this.Hide();
        }

        private void TxtPesquisaCliente_Enter(object sender, EventArgs e)
        {
            if(txtPesquisaCliente.Text == "Pesquise por CPF, Nome...")
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

        private void TxtPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            if(txtPesquisaCliente.Text != "")
            {
                DataTable dt = ClienteDAO.filtrarClientes(txtPesquisaCliente.Text);
                if (dt.Rows.Count != 0)
                {
                    dgvClientes.DataSource = dt;
                }
            }
            else
            {
                this.exibirClientes();
            }
        }

        private void BtnVincularVeiculo_Click(object sender, EventArgs e)
        {
            Vincular_ClienteCarro vincularClienteCarro = new Vincular_ClienteCarro();
            vincularClienteCarro.id_cliente = this.cliente._idCliente;
            vincularClienteCarro.Show();
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
