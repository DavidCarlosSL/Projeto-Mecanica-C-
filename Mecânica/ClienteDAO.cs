using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Mecânica
{
    class ClienteDAO
    {
        static private SqlConnection con;
        static private SqlCommand cmd;

        static public void cadastraCliente (ModeloCliente cliente)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("INSERT INTO tb_cliente (cpf_cliente, nome_cliente, fone1_cliente, fone2_cliente, email_cliente, cep_cliente, endereco_cliente, ");
                query.AppendLine("bairro_cliente, cidade_cliente, estado_cliente, data_cadastro, observacao_cliente) VALUES (@cpf_cliente, @nome_cliente, @fone1_cliente, ");
                query.AppendLine("@fone2_cliente, @email_cliente, @cep_cliente, @endereco_cliente, @bairro_cliente, @cidade_cleinte, @estado_cliente, @data_cadastro, @observacao_cliente)");

                cmd = con.CreateCommand();
                cmd.CommandText = Convert.ToString(query);

                cmd.Parameters.AddWithValue("@cpf_cliente", cliente._cpfCliente);
                cmd.Parameters.AddWithValue("@nome_cliente", cliente._nomeCliente);
                cmd.Parameters.AddWithValue("@fone1_cliente", cliente._fone1Cliente);
                cmd.Parameters.AddWithValue("@fone2_cliente", cliente._fone2Cliente);
                cmd.Parameters.AddWithValue("@email_cliente", cliente._emailCliente);
                cmd.Parameters.AddWithValue("@cep_cliente", cliente._cepCliente);
                cmd.Parameters.AddWithValue("@endereco_cliente", cliente._enderecoCliente);
                cmd.Parameters.AddWithValue("@bairro_cliente", cliente._bairroCliente);
                cmd.Parameters.AddWithValue("@cidade_cleinte", cliente._cidadeCliente);
                cmd.Parameters.AddWithValue("@estado_cliente", cliente._estadoCliente);
                cmd.Parameters.AddWithValue("@data_cadastro", cliente._dataCadastro);
                cmd.Parameters.AddWithValue("@observacao_cliente", cliente._observacaoCliente);

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

        static public DataTable obterClientes()
        {
            DataTable dt = new DataTable();

            try
            {
                con = new ConexaoBanco().obterConexao();
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT id_cliente [Código], cpf_cliente [CPF], nome_cliente [Nome], fone1_cliente [Fone 1],fone2_cliente [Fone 2],");
                query.AppendLine("email_cliente [Email], cep_cliente [CEP],endereco_cliente [Endereço], bairro_cliente [Bairro], cidade_cliente [Cidade],");
                query.AppendLine("estado_cliente [Estado], data_cadastro [Data Cadastro], observacao_cliente [Observação] from tb_cliente");

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

        static public DataTable filtrarClientes(string termoPesquisa)
        {
            DataTable dt = new DataTable();

            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT id_cliente [Código], cpf_cliente [CPF], nome_cliente [Nome], fone1_cliente [Fone 1],fone2_cliente [Fone 2],");
                query.AppendLine("email_cliente [Email], cep_cliente [CEP],endereco_cliente [Endereço], bairro_cliente [Bairro], cidade_cliente [Cidade],");
                query.AppendLine("estado_cliente [Estado], data_cadastro [Data Cadastro], observacao_cliente [Observação] from tb_cliente WHERE ");
                query.AppendLine("cpf_cliente like @cpf_cliente OR nome_cliente like @nome_cliente");

                cmd = con.CreateCommand();
                
                cmd.Parameters.AddWithValue("@cpf_cliente", "%" + termoPesquisa + "%");
                cmd.Parameters.AddWithValue("@nome_cliente", "%" + termoPesquisa + "%");

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

        static public int obterClientePorCPF(string cpf)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                string query = "SELECT id_cliente from tb_cliente WHERE cpf_cliente = @cpf_cliente";

                var cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@cpf_cliente", cpf);

                var id = cmd.ExecuteReader();
                id.Read();

                if (id.HasRows)
                    return Convert.ToInt32(id["id_cliente"]);
                else
                    return -1;
            }
            catch(Exception erro)
            {
                throw new InvalidOperationException("Erro ao inserir o Registro!" + erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

        static public DataTable obterClienteVinculado(int id_cliente)
        {
            DataTable dt = new DataTable();

            try
            {
                con = new ConexaoBanco().obterConexao();
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT id_cliente [Código], cpf_cliente [CPF], nome_cliente [Nome], fone1_cliente [Fone 1],fone2_cliente [Fone 2],");
                query.AppendLine("email_cliente [Email], cep_cliente [CEP],endereco_cliente [Endereço], bairro_cliente [Bairro], cidade_cliente [Cidade],");
                query.AppendLine("estado_cliente [Estado], data_cadastro [Data Cadastro], observacao_cliente [Observação] from tb_cliente WHERE id_cliente = @id_cliente");

                cmd = con.CreateCommand();
                cmd.CommandText = query.ToString();

                cmd.Parameters.AddWithValue("id_cliente", id_cliente);

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

        static public void removerCliente(int id_cliente)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("DELETE FROM tb_cliente WHERE id_cliente = @id_cliente");

                cmd = con.CreateCommand();
                cmd.CommandText = Convert.ToString(query);

                cmd.Parameters.AddWithValue("@id_cliente", id_cliente);

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

        static public void alterarCliente(ModeloCliente cliente)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("UPDATE tb_cliente SET cpf_cliente = @cpf_cliente, nome_cliente = @nome_cliente, fone1_cliente = @fone1_cliente, ");
                query.AppendLine("fone2_cliente = @fone2_cliente, email_cliente = @email_cliente, cep_cliente = @cep_cliente, endereco_cliente = @endereco_cliente, ");
                query.AppendLine("bairro_cliente = @bairro_cliente, cidade_cliente = @cidade_cliente, estado_cliente = @estado_cliente, data_cadastro = @data_cadastro,");
                query.AppendLine("observacao_cliente = @observacao_cliente WHERE id_cliente = @id_cliente");

                cmd = con.CreateCommand();
                cmd.CommandText = query.ToString();

                cmd.Parameters.AddWithValue("@id_cliente", cliente._idCliente);
                cmd.Parameters.AddWithValue("@cpf_cliente", cliente._cpfCliente);
                cmd.Parameters.AddWithValue("@nome_cliente", cliente._nomeCliente);
                cmd.Parameters.AddWithValue("@fone1_cliente", cliente._fone1Cliente);
                cmd.Parameters.AddWithValue("@fone2_cliente", cliente._fone2Cliente);
                cmd.Parameters.AddWithValue("@email_cliente", cliente._emailCliente);
                cmd.Parameters.AddWithValue("@cep_cliente", cliente._cepCliente);
                cmd.Parameters.AddWithValue("@endereco_cliente", cliente._enderecoCliente);
                cmd.Parameters.AddWithValue("@bairro_cliente", cliente._bairroCliente);
                cmd.Parameters.AddWithValue("@cidade_cliente", cliente._cidadeCliente);
                cmd.Parameters.AddWithValue("@estado_cliente", cliente._estadoCliente);
                cmd.Parameters.AddWithValue("@data_cadastro", cliente._dataCadastro);
                cmd.Parameters.AddWithValue("@observacao_cliente", cliente._observacaoCliente);

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

        static public void vincularCarroCliente(int id_cliente, string placa_veiculo)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("UPDATE tb_veiculo SET id_cliente = @id_cliente WHERE placa_veiculo = @placa_veiculo");

                cmd = con.CreateCommand();
                cmd.CommandText = Convert.ToString(query);

                cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                cmd.Parameters.AddWithValue("@placa_veiculo", placa_veiculo);

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
