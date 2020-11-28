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
    public partial class Cadastro_Orcamento : Form
    {
        public Cadastro_Orcamento()
        {
            InitializeComponent();
        }

        ModeloOrcamento orcamento = new ModeloOrcamento();
        public string idOrcamento;

        public void definiOrcamento(ModeloOrcamento orcamento)
        {
            txtMaoDeObra.Text = Convert.ToString(orcamento._maoObraOrcamento);
            txtValorPecas.Text = Convert.ToString(orcamento._valorPecasOrcamento);
            mskDataCadastro.Text = Convert.ToString(orcamento._dataOrcamento);
            txtDescricao.Text += orcamento._descricaoOrcamento;
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

        private void Cadastro_Orcamento_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            mskDataCadastro.Text = DateTime.Now.ToString();
        }

        private bool verificaMaoDeObra()
        {
            if (!(Double.TryParse(txtMaoDeObra.Text, out double maoDeObra)))
            {
                if (!(txtMaoDeObra.Text == ""))
                    return false;
                else
                    return true;
            }

            return true;
        }

        private bool verificaData()
        {
            if (!(DateTime.TryParse(mskDataCadastro.Text, out DateTime data)))
            {
                if (!(mskDataCadastro.Text == ""))
                    return false;
                else
                    return true;
            }

            return true;
        }

        private void TxtMaoDeObra_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaMaoDeObra() == false)
                lblAvisoMaoDeObra.Visible = true;
            else
                lblAvisoMaoDeObra.Visible = false;
        }

        private void MskDataCadastro_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaData() == false)
                lblAvisoData.Visible = true;
            else
                lblAvisoData.Visible = false;
        }

        private void TmVerificaAvisos_Tick(object sender, EventArgs e)
        {
            if (lblAvisoData.Visible == true || lblAvisoMaoDeObra.Visible == true)
                btnCadastrar.Enabled = false;
            else
                btnCadastrar.Enabled = true;
        }

        private void BtnAdicionarPeca_Click(object sender, EventArgs e)
        {
            Adicionar_Peca adicionar_peca = new Adicionar_Peca();

            if (this.idOrcamento == null)
                adicionar_peca.idOrcamento = OrcamentoDAO.cadastraOrcamento();
            else
                adicionar_peca.idOrcamento = Convert.ToInt32(this.idOrcamento);

            adicionar_peca.orcamento._maoObraOrcamento = Convert.ToDouble(txtMaoDeObra.Text);
            adicionar_peca.orcamento._valorPecasOrcamento = Convert.ToDouble(txtValorPecas.Text);
            adicionar_peca.orcamento._dataOrcamento = Convert.ToDateTime(mskDataCadastro.Text);
            adicionar_peca.orcamento._descricaoOrcamento = txtDescricao.Text;

            adicionar_peca.Show();
            this.Hide();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            double maoObra = Convert.ToDouble(txtMaoDeObra.Text);
            double valorPecas = Convert.ToDouble(txtValorPecas.Text);
            this.orcamento._maoObraOrcamento = maoObra;
            this.orcamento._valorPecasOrcamento = valorPecas;
            this.orcamento._totalOrcamento = maoObra + valorPecas;
            this.orcamento._dataOrcamento = Convert.ToDateTime(mskDataCadastro.Text);
            this.orcamento._descricaoOrcamento = txtDescricao.Text;
            this.orcamento._idOrcamento = Convert.ToInt32(this.idOrcamento);

            OrcamentoDAO.atualizaOrcamento(orcamento);

            MessageBox.Show("Orçamento cadastrado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
