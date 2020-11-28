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
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        private void Relatorios_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
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

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            relatorios.Show();
            this.Hide();
        }

        private void BtnGerarRelatorio1_Click(object sender, EventArgs e)
        {
            Relatorio_Faturamento relatorio_faturamento = new Relatorio_Faturamento();

            relatorio_faturamento.relatorio.dataInicial = Convert.ToDateTime(mskDataInicialFaturamento.Text);
            relatorio_faturamento.relatorio.dataFinal = Convert.ToDateTime(mskDataFinalFaturamento.Text);

            relatorio_faturamento.Show();
            this.Hide();
        }

        private bool verificaData(string campo)
        {
            if (DateTime.TryParse(campo, out DateTime campoVerificado))
                return true;
            else
            {
                if(campo == "")
                    return true;
                else
                    return false;
            }
        }

        private bool verificaNumero(string campo)
        {
            if(Int32.TryParse(campo, out int n))
                return true;
            else
            {
                if (campo == "")
                    return true;
                else
                    return false;
            }
        }

        private void TmVerificaAvisos_Tick(object sender, EventArgs e)
        {
            if (lblAvisoDataInicialFaturamento.Visible == true || lblAvisoDataFinalFaturamento.Visible == true)
                btnGerarRelatorio1.Enabled = false;
            else
                btnGerarRelatorio1.Enabled = true;

            if (lblAvisoDataInicialOrcamento.Visible == true || lblAvisoDataFinalOrcamento.Visible == true)
                btnGerarRelatorio2.Enabled = false;
            else
                btnGerarRelatorio2.Enabled = true;

            if (lblAvisoAno.Visible == true || lblAvisoMes.Visible == true)
                btnGerarRelatorio3.Enabled = false;
            else
                btnGerarRelatorio3.Enabled = true;
        }

        private void MskDataInicialFaturamento_TextChanged(object sender, EventArgs e)
        {
            if(this.verificaData(mskDataInicialFaturamento.Text) == true)
                lblAvisoDataInicialFaturamento.Visible = false;
            else
                lblAvisoDataInicialFaturamento.Visible = true;
        }

        private void MskDataFinalFaturamento_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaData(mskDataFinalFaturamento.Text) == true)
                lblAvisoDataFinalFaturamento.Visible = false;
            else
                lblAvisoDataFinalFaturamento.Visible = true;
        }

        private void MskDataInicialOrcamento_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaData(mskDataInicialOrcamento.Text) == true)
                lblAvisoDataInicialOrcamento.Visible = false;
            else
                lblAvisoDataInicialOrcamento.Visible = true;
        }

        private void MskDataFinalOrcamento_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaData(mskDataFinalOrcamento.Text) == true)
                lblAvisoDataFinalOrcamento.Visible = false;
            else
                lblAvisoDataFinalOrcamento.Visible = true;
        }

        private void BtnGerarRelatorio2_Click(object sender, EventArgs e)
        {
            Relatorio_Orcamento relatorio_Orcamento = new Relatorio_Orcamento();

            relatorio_Orcamento.relatorio.dataInicial = Convert.ToDateTime(mskDataInicialOrcamento.Text);
            relatorio_Orcamento.relatorio.dataFinal = Convert.ToDateTime(mskDataFinalOrcamento.Text);

            relatorio_Orcamento.Show();
            this.Hide();
        }

        private void TxtMes_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaNumero(txtMes.Text) == true)
                lblAvisoMes.Visible = false;
            else
                lblAvisoMes.Visible = true;
        }

        private void TxtAno_TextChanged(object sender, EventArgs e)
        {
            if (this.verificaNumero(txtAno.Text) == true)
                lblAvisoAno.Visible = false;
            else
                lblAvisoAno.Visible = true;
        }

        private void BtnGerarRelatorio3_Click(object sender, EventArgs e)
        {
            Relatorio_Mecanico relatorio_Mecanico = new Relatorio_Mecanico();

            relatorio_Mecanico.mes = txtMes.Text;
            relatorio_Mecanico.ano = txtAno.Text;

            relatorio_Mecanico.Show();
            this.Hide();
        }
    }
}
