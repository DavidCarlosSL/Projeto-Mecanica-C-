using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;
using Mecânica.Validators;
using FluentValidation;
using FluentValidation.Results;

namespace Mecânica
{
    public partial class Cadastro_Cliente : Form
    {

        public Cadastro_Cliente()
        {
            InitializeComponent();
        }

        ModeloCliente cliente = new ModeloCliente();

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
            if(!(Int64.TryParse(txtCPF.Text, out long cpf)))
            {
                if (!(txtCPF.Text == ""))
                    return false;
                else
                    return true;
            }

            return true;
        }

        private bool verificaFone1()
        {
            if (!(Int64.TryParse(txtFone1.Text, out long fone1)))
            {
                if (!(txtFone1.Text == ""))
                    return false;
                else
                    return true;
            }

            return true;
        }

        private bool verificaFone2()
        {
            if (!(Int64.TryParse(txtFone2.Text, out long fone2)))
            {
                if (!(txtFone2.Text == ""))
                    return false;
                else
                    return true;
            }

            return true;
        }

        private int cadastraCliente()
        {
            this.cliente._cpfCliente = txtCPF.Text;
            this.cliente._nomeCliente = txtNome.Text;
            this.cliente._fone1Cliente = txtFone1.Text;
            this.cliente._fone2Cliente = txtFone2.Text;
            this.cliente._emailCliente = txtEmail.Text;
            this.cliente._cepCliente = txtCEP.Text;
            this.cliente._enderecoCliente = txtEndereco.Text;
            this.cliente._bairroCliente = txtBairro.Text;
            this.cliente._cidadeCliente = txtCidade.Text;
            this.cliente._estadoCliente = txtEstado.Text;
            this.cliente._observacaoCliente = txtObservacao.Text;

            ClienteValidator cliente_validator = new ClienteValidator();
            ValidationResult resultado = cliente_validator.Validate(this.cliente);

            if(resultado.IsValid == false)
            {
                foreach(ValidationFailure failure in resultado.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return 1;
            }
            else
            {
                if(DateTime.TryParse(mskDataCadastro.Text, out DateTime data_cadastro))
                {
                    this.cliente._dataCadastro = Convert.ToDateTime(mskDataCadastro.Text);

                    if(ClienteDAO.obterClientePorCPF(this.cliente._cpfCliente) == -1)
                    {
                        ClienteDAO.cadastraCliente(this.cliente);
                        MessageBox.Show("Cliente cadastrado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.limparCampos();
                        return 0;
                    }
                    else
                    {
                        MessageBox.Show("CPF já cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return 1;
                    }
                }
                else
                {
                    MessageBox.Show("Data inválida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }     
            }
        }

        private void limparCampos()
        {
            txtCPF.Clear();
            txtNome.Clear();
            txtFone1.Clear();
            txtFone2.Clear();
            txtEmail.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtObservacao.Clear();
        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            mskDataCadastro.Text = DateTime.Now.ToString();
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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            this.cadastraCliente();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            this.limparCampos();
        }

        private void TxtCEP_Leave(object sender, EventArgs e)
        {
            if(!(txtCEP.Text == "") && lblAvisoCEP.Visible == false)
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
                        txtEstado.Text = retorno.uf;
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao consultar CEP. Erro: " + erro.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEndereco.Clear();
                    txtBairro.Clear();
                    txtCidade.Clear();
                    txtEstado.Clear();
                }
            }
        }

        private void BtnCadastrarVincular_Click(object sender, EventArgs e)
        {
            if(this.cadastraCliente() == 0)
            {
                Vincular_ClienteCarro vincularClienteCarro = new Vincular_ClienteCarro();
                vincularClienteCarro.cpf_cliente = this.cliente._cpfCliente;
                vincularClienteCarro.Show();
                this.Hide();
            }
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

        private void TxtFone1_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaFone1() == false || this.verificaFone2() == false)
                lblAvisoFone1Fone2.Visible = true;
            else
                lblAvisoFone1Fone2.Visible = false;
        }

        private void TxtFone2_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaFone1() == false || this.verificaFone2() == false)
                lblAvisoFone1Fone2.Visible = true;
            else
                lblAvisoFone1Fone2.Visible = false;
        }

        private void TmVerificaAvisos_Tick(object sender, EventArgs e)
        {
            if(lblAvisoCEP.Visible == true || lblAvisoCPF.Visible == true || lblAvisoFone1Fone2.Visible == true)
            {
                btnCadastrar.Enabled = false;
                btnCadastrarVincular.Enabled = false;
            }
            else
            {
                btnCadastrar.Enabled = true;
                btnCadastrarVincular.Enabled = true;
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
