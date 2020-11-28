using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mecânica
{
    class OrcamentoDAO
    {
        static private SqlConnection con;
        static private SqlCommand cmd;

        static public DataTable obterOrcamentos()
        {
            DataTable dt = new DataTable();

            try
            {
                con = new ConexaoBanco().obterConexao();
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT id_orcamento [Código], descricao_orcamento [Descrição], valorPecas_orcamento [Valor das Peças], maoObra_orcamento [Mão de Obra], ");
                query.AppendLine("total_orcamento [Total], data_orcamento [Data], placa_veiculo [Placa], id_mecanico [Mecânico] from orcamento");

                cmd = con.CreateCommand();
                cmd.CommandText = query.ToString();

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

        static public DataTable filtrarOrcamentos(string termoPesquisa)
        {
            DataTable dt = new DataTable();

            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT id_orcamento [Código], descricao_orcamento [Descrição], valorPecas_orcamento [Valor das Peças], maoObra_orcamento [Mão de Obra], ");
                query.AppendLine("total_orcamento [Total], data_orcamento [Data], placa_veiculo [Placa], id_mecanico [Mecânico] from orcamento WHERE placa_veiculo like @placa_veiculo");

                cmd = con.CreateCommand();

                cmd.Parameters.AddWithValue("@placa_veiculo", "%" + termoPesquisa + "%");

                cmd.CommandText = Convert.ToString(query);
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

        static public DataTable filtrarOrcamentosPorData(DateTime dataInicial, DateTime dataFinal)
        {
            DataTable dt = new DataTable();

            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT id_orcamento [Código], descricao_orcamento [Descrição], valorPecas_orcamento [Valor das Peças], maoObra_orcamento [Mão de Obra], ");
                query.AppendLine("total_orcamento [Total], data_orcamento [Data], placa_veiculo [Placa], id_mecanico [Mecânico] from orcamento WHERE data_orcamento between @dataInicial AND @dataFinal");

                cmd = con.CreateCommand();

                cmd.Parameters.AddWithValue("@dataInicial", dataInicial);
                cmd.Parameters.AddWithValue("@dataFinal", dataFinal);

                cmd.CommandText = Convert.ToString(query);
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


        static public void vincularMecanicoOrcamento(int id_orcamento, int id_mecanico)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("UPDATE orcamento SET id_mecanico = @id_mecanico WHERE id_orcamento = @id_orcamento");

                cmd = con.CreateCommand();
                cmd.CommandText = Convert.ToString(query);

                cmd.Parameters.AddWithValue("@id_mecanico", id_mecanico);
                cmd.Parameters.AddWithValue("@id_orcamento", id_orcamento);

                cmd.ExecuteNonQuery();

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

        static public void vincularVeiculoOrcamento(int id_orcamento, string placa_veiculo)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("UPDATE orcamento SET placa_veiculo = @placa_veiculo WHERE id_orcamento = @id_orcamento");

                cmd = con.CreateCommand();
                cmd.CommandText = Convert.ToString(query);

                cmd.Parameters.AddWithValue("@placa_veiculo", placa_veiculo);
                cmd.Parameters.AddWithValue("@id_orcamento", id_orcamento);

                cmd.ExecuteNonQuery();

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

        static public DataTable obterPecasVinculadas(int id_orcamento)
        {
            DataTable dt = new DataTable();

            try
            {
                con = new ConexaoBanco().obterConexao();
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT pecas_orcamento.id_orcamento [Código Orçamento], pecas_orcamento.id_peca [Código Peça], peca.nome_peca [Nome Peça], peca.valor_peca [Valor Peça] from pecas_orcamento");
                query.AppendLine("INNER JOIN orcamento on pecas_orcamento.id_orcamento = orcamento.id_orcamento INNER JOIN peca on pecas_orcamento.id_peca = peca.id_peca");
                query.AppendLine("WHERE pecas_orcamento.id_orcamento = @id_orcamento");

                cmd = con.CreateCommand();

                cmd.Parameters.AddWithValue("@id_orcamento", id_orcamento);

                cmd.CommandText = query.ToString();

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

        static public double obterSomaPecasVinculadas(int id_orcamento)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT pec");

                cmd = con.CreateCommand();

                cmd.Parameters.AddWithValue("@id_orcamento", id_orcamento);

                cmd.CommandText = query.ToString();

                double soma = cmd.ExecuteNonQuery();
                return soma;
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

        static public int cadastraOrcamento()
        {
            try
            {
                Int32 newProdID = 0;

                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("INSERT INTO orcamento VALUES (null, null, null, null, null, null, null)" + "SELECT CAST(scope_identity() AS int)");

                cmd = con.CreateCommand();
                cmd.CommandText = Convert.ToString(query);

                newProdID = (Int32)cmd.ExecuteScalar();

                return newProdID;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao inserir o Registro: " + erro.Message);
            }
            finally
            {
                con.Close();
            }

        }

        static public void atualizaOrcamento(ModeloOrcamento orcamento)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("UPDATE orcamento SET descricao_orcamento = @descricao_orcamento, valorPecas_orcamento = @valorPecas_orcamento, maoObra_orcamento = @maoObra_orcamento, ");
                query.AppendLine("total_orcamento = @total_orcamento, data_orcamento = @data_orcamento WHERE id_orcamento = @id_orcamento");


                cmd = con.CreateCommand();
                cmd.CommandText = query.ToString();

                cmd.Parameters.AddWithValue("@id_orcamento", orcamento._idOrcamento);
                cmd.Parameters.AddWithValue("@descricao_orcamento", orcamento._descricaoOrcamento);
                cmd.Parameters.AddWithValue("@valorPecas_orcamento", orcamento._valorPecasOrcamento);
                cmd.Parameters.AddWithValue("@maoObra_orcamento", orcamento._maoObraOrcamento);
                cmd.Parameters.AddWithValue("@total_orcamento", orcamento._totalOrcamento);
                cmd.Parameters.AddWithValue("@data_orcamento", orcamento._dataOrcamento);

                cmd.ExecuteNonQuery();
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
        static public void vincularOrcamentoPeca(int id_orcamento, int id_peca)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("INSERT INTO pecas_orcamento (id_orcamento, id_peca) VALUES (@id_orcamento, @id_peca)");

                cmd = con.CreateCommand();
                cmd.CommandText = Convert.ToString(query);

                cmd.Parameters.AddWithValue("@id_orcamento", id_orcamento);
                cmd.Parameters.AddWithValue("@id_peca", id_peca);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao inserir o Registro: " + erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
