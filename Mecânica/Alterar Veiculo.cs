using FluentValidation.Results;
using Mecânica.Validators;
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
    public partial class Alterar_Veiculo : Form
    {
        public Alterar_Veiculo()
        {
            InitializeComponent();
        }

        private string placa_antiga;

        private bool verificaAnoFabricacao()
        {
            if (!(Int64.TryParse(txtAnoFabricacao.Text, out long ano_fabricacao)))
            {
                if (!(txtAnoFabricacao.Text == ""))
                    return false;
                else
                    return true;
            }

            return true;
        }

        private bool verificaAnoModelo()
        {
            if (!(Int64.TryParse(txtAnoModelo.Text, out long ano_modelo)))
            {
                if (!(txtAnoModelo.Text == ""))
                    return false;
                else
                    return true;
            }

            return true;
        }

        private void Alterar_Veiculo_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            var listaMarca = new List<ModeloMarca>();
            listaMarca = MarcaDAO.ObterMarca();

            foreach (var marca in listaMarca)
            {
                cmbMarca.Items.Add(marca._nomeMarca);
                cmbMarca.DisplayMember = marca._nomeMarca;
                cmbMarca.ValueMember = marca._idMarca.ToString();
            }

            cmbMarca.Select();
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

        public void definirVeiculo(ModeloVeiculo veiculo)
        {
            this.placa_antiga = veiculo._placaVeiculo;
            txtPlaca.Text = veiculo._placaVeiculo;
            cmbMarca.Text = veiculo._marcaVeiculo;
            txtModelo.Text = veiculo._modeloVeiculo;
            txtAnoFabricacao.Text = Convert.ToString(veiculo._anoFabricacao);
            txtAnoModelo.Text = Convert.ToString(veiculo._anoModelo);
            txtMotorizacao.Text = veiculo._motorVeiculo;
            txtCor.Text = veiculo._corVeiculo;
            txtObservacao.Text = veiculo._observacaoVeiculo;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            ModeloVeiculo veiculo = new ModeloVeiculo();

            veiculo._placaVeiculo = txtPlaca.Text;
            veiculo._idMarca = Convert.ToInt32(cmbMarca.SelectedIndex + 1);
            veiculo._modeloVeiculo = txtModelo.Text;
            if (!(txtAnoFabricacao.Text == ""))
                veiculo._anoFabricacao = Convert.ToInt32(txtAnoFabricacao.Text);
            if (!(txtAnoModelo.Text == ""))
                veiculo._anoModelo = Convert.ToInt32(txtAnoModelo.Text);
            veiculo._motorVeiculo = txtMotorizacao.Text;
            veiculo._corVeiculo = txtCor.Text;
            veiculo._observacaoVeiculo = txtObservacao.Text;

            VeiculoValidator veiculo_validator = new VeiculoValidator();
            ValidationResult resultado = veiculo_validator.Validate(veiculo);

            if (resultado.IsValid == false)
            {
                foreach (ValidationFailure failure in resultado.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string placaBD = VeiculoDAO.obterVeiculoPorPlaca(veiculo._placaVeiculo);

                if(placaBD == "0")
                {
                    VeiculoDAO.alterarVeiculo(veiculo, this.placa_antiga);
                    Veiculos veiculos = new Veiculos();
                    veiculos.Show();
                    this.Hide();
                }
                else
                {
                    if(placaBD == this.placa_antiga)
                    {
                        VeiculoDAO.alterarVeiculo(veiculo, this.placa_antiga);
                        Veiculos veiculos = new Veiculos();
                        veiculos.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Placa já cadastrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                
            }
        }

        private void TmVerifcaAvisos_Tick(object sender, EventArgs e)
        {
            if (lblAvisoAno.Visible == true)
                btnAlterar.Enabled = false;
            else
                btnAlterar.Enabled = true;
        }

        private void TxtAnoFabricacao_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaAnoFabricacao() == false || this.verificaAnoModelo() == false)
                lblAvisoAno.Visible = true;
            else
                lblAvisoAno.Visible = false;
        }

        private void TxtAnoModelo_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaAnoFabricacao() == false || this.verificaAnoModelo() == false)
                lblAvisoAno.Visible = true;
            else
                lblAvisoAno.Visible = false;
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
