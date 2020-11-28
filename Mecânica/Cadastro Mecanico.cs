using Correios;
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
    public partial class Cadastro_Mecanico : Form
    {
        public Cadastro_Mecanico()
        {
            InitializeComponent();
        }

        ModeloMecanico mecanico = new ModeloMecanico();

        private void limparCampos()
        {
            txtCPF.Clear();
            txtNome.Clear();
            txtFone.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtSalario.Text = "0";
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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if(Double.TryParse(txtSalario.Text, out double sal))
                this.cadastraMecanico();
            else
                MessageBox.Show("Salário inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Cadastro_Mecanico_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private int cadastraMecanico()
        {
            this.mecanico._cpfMecanico = txtCPF.Text;
            this.mecanico._nomeMecanico = txtNome.Text;
            this.mecanico._foneMecanico = txtFone.Text;
            this.mecanico._cepMecanico = txtCEP.Text;
            this.mecanico._enderecoMecanico = txtEndereco.Text;
            this.mecanico._bairroMecanico = txtBairro.Text;
            this.mecanico._cidadeMecanico = txtCidade.Text;
            this.mecanico._salarioMecanico = Convert.ToDouble(txtSalario.Text);
            this.mecanico._cepMecanico = txtCEP.Text;

            MecanicoValidator mecanico_validator = new MecanicoValidator();
            ValidationResult resultado = mecanico_validator.Validate(this.mecanico);

            if (resultado.IsValid == false)
            {
                foreach (ValidationFailure failure in resultado.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return 1;
            }
            else
            {
                if (MecanicoDAO.obterMecanicoPorCPF(this.mecanico._cpfMecanico) == -1)
                {
                    MecanicoDAO.cadastraMecanico(this.mecanico);
                    MessageBox.Show("Mecânico cadastrado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.limparCampos();

                    return 0;
                }
                else
                {
                    MessageBox.Show("CPF já cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }
            }
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

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            this.limparCampos();
        }

        private void TxtCEP_Leave(object sender, EventArgs e)
        {
            if (!(txtCEP.Text == "") && lblAvisoCEP.Visible == false)
            {
                CorreiosApi correiosAPi = new CorreiosApi();
                try
                {
                    var retorno = correiosAPi.consultaCEP(txtCEP.Text);

                    if (retorno != null)
                    {
                        txtEndereco.Text = retorno.end;
                        txtBairro.Text = retorno.bairro;
                        txtCidade.Text = retorno.cidade;
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao consultar CEP. Erro: " + erro.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEndereco.Clear();
                    txtBairro.Clear();
                    txtCidade.Clear();
                }
            }
        }

        private bool verificaCep()
        {
            if (!(Int64.TryParse(txtCEP.Text, out long cep)))
            {
                if (!(txtCEP.Text == ""))
                    return false;
                else
                    return true;
            }

            return true;
        }

        private bool verificaCpf()
        {
            if (!(Int64.TryParse(txtCPF.Text, out long cpf)))
            {
                if (!(txtCPF.Text == ""))
                    return false;
                else
                    return true;
            }

            return true;
        }

        private bool verificaFone()
        {
            if (!(Int64.TryParse(txtFone.Text, out long fone)))
            {
                if (!(txtFone.Text == ""))
                    return false;
                else
                    return true;
            }

            return true;
        }

        private bool verificaSalario()
        {
            if (!(Double.TryParse(txtSalario.Text, out double sal)))
            {
                if (!(txtSalario.Text == ""))
                    return false;
                else
                    return true;
            }

            return true;
        }

        private void TmVerificaAvisos_Tick(object sender, EventArgs e)
        {
            if (lblAvisoCEP.Visible == true || lblAvisoCPF.Visible == true || lblAvisoFone.Visible == true || lblAvisoSalario.Visible == true)
                btnCadastrar.Enabled = false;
            else
                btnCadastrar.Enabled = true;
        }

        private void TxtCPF_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaCpf() == false)
                lblAvisoCPF.Visible = true;
            else
                lblAvisoCPF.Visible = false;
        }

        private void TxtCEP_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaCep() == false)
                lblAvisoCEP.Visible = true;
            else
                lblAvisoCEP.Visible = false;
        }

        private void TxtFone_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaFone() == false)
                lblAvisoFone.Visible = true;
            else
                lblAvisoFone.Visible = false;
        }

        private void TxtSalario_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaSalario() == false)
                lblAvisoSalario.Visible = true;
            else
                lblAvisoSalario.Visible = false;
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            relatorios.Show();
            this.Hide();
        }
    }
}
