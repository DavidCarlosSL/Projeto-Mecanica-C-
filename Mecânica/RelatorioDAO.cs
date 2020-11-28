using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace Mecânica
{
    class RelatorioDAO
    {
        static private SqlConnection con;
        static private SqlCommand cmd;

        public static double obterRelatorioFaturamento(ModeloRelatorio relatorio)
        {
            con = new ConexaoBanco().obterConexao();

            string query = "SELECT Faturamento = sum(total_orcamento) from orcamento where data_orcamento between @dataInicial AND @dataFinal";

            var cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@dataInicial", relatorio.dataInicial);
            cmd.Parameters.AddWithValue("@dataFinal", relatorio.dataFinal);

            var faturamento = cmd.ExecuteReader();
            faturamento.Read();

            if (faturamento.HasRows)
                return Convert.ToDouble(faturamento["Faturamento"]);
            else
                return -1;
        }

        public static int obterRelatorioOrcamento(ModeloRelatorio relatorio)
        {
            con = new ConexaoBanco().obterConexao();

            string query = "SELECT Quantidade_de_orcamentos = count(id_orcamento) from orcamento where data_orcamento between @dataInicial AND @dataFinal";

            var cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@dataInicial", relatorio.dataInicial);
            cmd.Parameters.AddWithValue("@dataFinal", relatorio.dataFinal);

            var faturamento = cmd.ExecuteReader();
            faturamento.Read();

            if (faturamento.HasRows)
                return Convert.ToInt32(faturamento["Quantidade_de_orcamentos"]);
            else
                return -1;
        }

        static public DataTable obterRelatorioMecanico(string inicioMes, string finalMes)
        {
            DataTable dt = new DataTable();

            try
            {
                con = new ConexaoBanco().obterConexao();
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT mecanico.nome_mecanico [Nome], mecanico.cpf_mecanico [CPF], Venda = sum(maoObra_orcamento) from orcamento INNER JOIN mecanico on orcamento.id_mecanico = mecanico.id_mecanico ");
                query.AppendLine("where data_orcamento between @inicioMes AND @finalMes group by orcamento.id_mecanico, mecanico.nome_mecanico, mecanico.cpf_mecanico");

                cmd = con.CreateCommand();
                cmd.CommandText = query.ToString();

                cmd.Parameters.AddWithValue("@inicioMes", inicioMes);
                cmd.Parameters.AddWithValue("@finalMes", finalMes);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao inserir o Registro!" + erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
