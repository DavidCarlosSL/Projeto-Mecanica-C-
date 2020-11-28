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
    public partial class Alterar_Cliente : Form
    {

        public Alterar_Cliente()
        {
            InitializeComponent();
        }

        private void Alterar_Cliente_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
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

        public void definirCliente(ModeloCliente cliente)
        {
            txtID.Text = Convert.ToString(cliente._idCliente);
            txtNome.Text = cliente._nomeCliente;
            txtCPF.Text = cliente._cpfCliente;
            txtFone1.Text = cliente._fone1Cliente;
            txtFone2.Text = cliente._fone2Cliente;
            txtEmail.Text = cliente._emailCliente;
            txtCEP.Text = cliente._cepCliente;
            txtEndereco.Text = cliente._enderecoCliente;
            txtBairro.Text = cliente._bairroCliente;
            txtCidade.Text = cliente._cidadeCliente;
            txtEstado.Text = cliente._estadoCliente;
            mskDataCadastro.Text = Convert.ToString(cliente._dataCadastro);
            txtObservacao.Text = cliente._observacaoCliente;
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

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            ModeloCliente cliente = new ModeloCliente();

            cliente._idCliente = Convert.ToInt32(txtID.Text);
            cliente._cpfCliente = txtCPF.Text;
            cliente._nomeCliente = txtNome.Text;
            cliente._fone1Cliente = txtFone1.Text;
            cliente._fone2Cliente = txtFone2.Text;
            cliente._emailCliente = txtEmail.Text;
            cliente._cepCliente = txtCEP.Text;
            cliente._enderecoCliente = txtEndereco.Text;
            cliente._bairroCliente = txtBairro.Text;
            cliente._cidadeCliente = txtCidade.Text;
            cliente._estadoCliente = txtEstado.Text;
            cliente._observacaoCliente = txtObservacao.Text;

            ClienteValidator cliente_validator = new ClienteValidator();
            ValidationResult resultado = cliente_validator.Validate(cliente);

            if (resultado.IsValid == false)
            {
                foreach (ValidationFailure failure in resultado.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (DateTime.TryParse(mskDataCadastro.Text, out DateTime data_cadastro))
                {
                    cliente._dataCadastro = Convert.ToDateTime(mskDataCadastro.Text);
                    int clienteBD = ClienteDAO.obterClientePorCPF(cliente._cpfCliente);

                    if (clienteBD == -1)
                    {
                        ClienteDAO.alterarCliente(cliente);
                        Clientes clientes = new Clientes();
                        clientes.Show();
                        this.Hide();
                    }
                    else
                    {
                        if(clienteBD != cliente._idCliente)
                            MessageBox.Show("CPF já cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            ClienteDAO.alterarCliente(cliente);
                            Clientes clientes = new Clientes();
                            clientes.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Data inválida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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

        private void TxtCPF_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaCpf() == false)
                lblAvisoCPF.Visible = true;
            else
                lblAvisoCPF.Visible = false;
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

        private void TxtCEP_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaCep() == false)
                lblAvisoCEP.Visible = true;
            else
                lblAvisoCEP.Visible = false;
        }

        private void TmVerificaAvisos_Tick(object sender, EventArgs e)
        {
            if (lblAvisoCEP.Visible == true || lblAvisoCPF.Visible == true || lblAvisoFone1Fone2.Visible == true)
            {
                btnAlterar.Enabled = false;
            }
            else
            {
                btnAlterar.Enabled = true;
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
