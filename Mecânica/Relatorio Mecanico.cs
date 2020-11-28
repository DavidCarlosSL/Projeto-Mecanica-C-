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
    public partial class Relatorio_Mecanico : Form
    {
        public Relatorio_Mecanico()
        {
            InitializeComponent();
        }

        public string mes;
        public string ano;

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

        private void exibirRelatorio()
        {
            string inicioMes = "01/" + mes + "/" + ano;
            string finalMes = "30/" + mes + "/" + ano;

            DataTable dt = RelatorioDAO.obterRelatorioMecanico(inicioMes, finalMes);

            if (dt.Rows.Count != 0)
            {
                dgvRelatorioMecanico.DataSource = dt;
            }
        }

        private void Relatorio_Mecanico_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.exibirRelatorio();
            lblMes.Text = "Relatório do mês " + mes + "/" + ano;
        }
    }
}
