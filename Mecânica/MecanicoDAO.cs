using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Mecânica
{
    class MecanicoDAO
    {
        static private SqlConnection con;
        static private SqlCommand cmd;

        static public void cadastraMecanico(ModeloMecanico mecanico)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("INSERT INTO mecanico (cpf_mecanico, fone_mecanico, endereco_mecanico, bairro_mecanico, cidade_mecanico, salario_mecanico, nome_mecanico, cep_mecanico) ");
                query.AppendLine("VALUES (@cpf_mecanico, @fone_mecanico, @endereco_mecanico, @bairro_mecanico, @cidade_mecanico, @salario_mecanico, @nome_mecanico, @cep_mecanico)");

                cmd = con.CreateCommand();
                cmd.CommandText = Convert.ToString(query);

                cmd.Parameters.AddWithValue("@cpf_mecanico", mecanico._cpfMecanico);
                cmd.Parameters.AddWithValue("@fone_mecanico", mecanico._foneMecanico);
                cmd.Parameters.AddWithValue("@endereco_mecanico", mecanico._enderecoMecanico);
                cmd.Parameters.AddWithValue("@bairro_mecanico", mecanico._bairroMecanico);
                cmd.Parameters.AddWithValue("@cidade_mecanico", mecanico._cidadeMecanico);
                cmd.Parameters.AddWithValue("@salario_mecanico", mecanico._salarioMecanico);
                cmd.Parameters.AddWithValue("@nome_mecanico", mecanico._nomeMecanico);
                cmd.Parameters.AddWithValue("@cep_mecanico", mecanico._cepMecanico);

                object o = cmd.ExecuteScalar();

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
        static public int obterMecanicoPorCPF(string cpf)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                string query = "SELECT id_mecanico from mecanico WHERE cpf_mecanico = @cpf_mecanico";

                var cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@cpf_mecanico", cpf);

                var id = cmd.ExecuteReader();
                id.Read();

                if (id.HasRows)
                    return Convert.ToInt32(id["id_mecanico"]);
                else
                    return -1;
            }
            catch (Exception erro)
            {
                throw new InvalidOperationException("Erro ao inserir o Registro!" + erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

        static public DataTable obterMecanicos()
        {
            DataTable dt = new DataTable();

            try
            {
                con = new ConexaoBanco().obterConexao();
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT id_mecanico [Código], cpf_mecanico [CPF], nome_mecanico [Nome], fone_mecanico [Telefone], ");
                query.AppendLine("cep_mecanico [CEP], endereco_mecanico [Endereço], bairro_mecanico [Bairro], cidade_mecanico [Cidade], salario_mecanico [Salário] from mecanico");

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

        static public DataTable filtrarMecanicos(string termoPesquisa)
        {
            DataTable dt = new DataTable();

            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT id_mecanico [Código], cpf_mecanico [CPF], nome_mecanico [Nome], fone_mecanico [Telefone], ");
                query.AppendLine("cep_mecanico [CEP], endereco_mecanico [Endereço], bairro_mecanico [Bairro], cidade_mecanico [Cidade], salario_mecanico [Salário] ");
                query.AppendLine("from mecanico WHERE cpf_mecanico like @cpf_mecanico OR nome_mecanico like @nome_mecanico");

                cmd = con.CreateCommand();

                cmd.Parameters.AddWithValue("@cpf_mecanico", "%" + termoPesquisa + "%");
                cmd.Parameters.AddWithValue("@nome_mecanico", "%" + termoPesquisa + "%");

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
    }
}
