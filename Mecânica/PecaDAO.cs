using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Mecânica
{
    class PecaDAO
    {
        static private SqlConnection con;
        static private SqlCommand cmd;

        static public DataTable obterPecas()
        {
            DataTable dt = new DataTable();

            try
            {
                con = new ConexaoBanco().obterConexao();
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT id_peca [Código], nome_peca [Nome], quantidade_peca [Quantidade], valor_peca [Valor] from peca");

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

        static public void alterarPeca(ModeloPeca peca)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("UPDATE peca SET nome_peca = @nome_peca, quantidade_peca = @quantidade_peca, valor_peca = @valor_peca WHERE id_peca = @id_peca");

                cmd = con.CreateCommand();
                cmd.CommandText = query.ToString();

                cmd.Parameters.AddWithValue("@id_peca", peca._idPeca);
                cmd.Parameters.AddWithValue("@nome_peca", peca._nomePeca);
                cmd.Parameters.AddWithValue("@quantidade_peca", peca._quantidadePeca);
                cmd.Parameters.AddWithValue("@valor_peca", peca._valorPeca);

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

        static public DataTable filtrarPecas(string termoPesquisa)
        {
            DataTable dt = new DataTable();

            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT id_peca [Código], nome_peca [Nome], quantidade_peca [Quantidade], valor_peca [Valor] from peca WHERE nome_peca like @nome_peca");

                cmd = con.CreateCommand();

                cmd.Parameters.AddWithValue("@nome_peca", "%" + termoPesquisa + "%");

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

        static public void debitaPeca(int id_peca, int quantidade_peca)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("UPDATE peca SET quantidade_peca = @quantidade_peca WHERE id_peca = @id_peca");

                cmd = con.CreateCommand();
                cmd.CommandText = query.ToString();

                cmd.Parameters.AddWithValue("@id_peca", id_peca);
                cmd.Parameters.AddWithValue("@quantidade_peca", quantidade_peca);

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
    }
}
