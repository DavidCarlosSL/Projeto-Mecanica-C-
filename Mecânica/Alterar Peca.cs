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
    public partial class Alterar_Peca : Form
    {
        public Alterar_Peca()
        {
            InitializeComponent();
        }

        private int idPeca;

        public void definirPeca(ModeloPeca peca)
        {
            this.idPeca = peca._idPeca;
            txtNomeDaPeca.Text = peca._nomePeca;
            txtQuantidade.Text = Convert.ToString(peca._quantidadePeca);
            txtValor.Text = Convert.ToString(peca._valorPeca);
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

        private void Alterar_Peca_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private bool verificaValor()
        {
            if (!(Double.TryParse(txtValor.Text, out double valor)))
            {
                if (!(txtValor.Text == ""))
                    return false;
                else
                    return true;
            }

            return true;
        }

        private bool verificaQuantidade()
        {
            if (!(Int32.TryParse(txtQuantidade.Text, out int quantidade)))
            {
                if (!(txtValor.Text == ""))
                    return false;
                else
                    return true;
            }

            return true;
        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaValor() == false)
                lblAvisoValor.Visible = true;
            else
                lblAvisoValor.Visible = false;
        }

        private void TxtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaQuantidade() == false)
                lblAvisoQuantidade.Visible = true;
            else
                lblAvisoQuantidade.Visible = false;
        }

        private void TmVerificaAvisos_Tick(object sender, EventArgs e)
        {
            if (lblAvisoQuantidade.Visible == true || lblAvisoValor.Visible == true)
                btnAlterar.Enabled = false;
            else
                btnAlterar.Enabled = true;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            ModeloPeca novaPeca = new ModeloPeca();

            novaPeca._nomePeca = txtNomeDaPeca.Text;
            novaPeca._quantidadePeca = Convert.ToInt32(txtQuantidade.Text);
            novaPeca._valorPeca = Convert.ToDouble(txtValor.Text);
            novaPeca._idPeca = this.idPeca;

            PecaDAO.alterarPeca(novaPeca);

            Pecas pecas = new Pecas();
            pecas.Show();
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
