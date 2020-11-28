using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Mecânica
{
    class VeiculoDAO
    {
        static private SqlConnection con;
        static private SqlCommand cmd;

        static public void cadastraVeiculo(ModeloVeiculo veiculo)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("INSERT INTO tb_veiculo (placa_veiculo, id_marca, modelo_veiculo, ano_fabricacao, ano_modelo, ");
                query.AppendLine("motor_veiculo, cor_veiculo, observacao_veiculo) VALUES (@placa_veiculo, @id_marca, @modelo_veiculo, @ano_fabricacao, ");
                query.AppendLine("@ano_modelo, @motor_veiculo, @cor_veiculo, @observacao_veiculo)");

                cmd = con.CreateCommand();
                cmd.CommandText = Convert.ToString(query);

                cmd.Parameters.AddWithValue("@placa_veiculo", veiculo._placaVeiculo);
                cmd.Parameters.AddWithValue("@id_cliente", veiculo._idCliente);
                cmd.Parameters.AddWithValue("@id_marca", veiculo._idMarca);
                cmd.Parameters.AddWithValue("@modelo_veiculo", veiculo._modeloVeiculo);
                cmd.Parameters.AddWithValue("@ano_fabricacao", veiculo._anoFabricacao);
                cmd.Parameters.AddWithValue("@ano_modelo", veiculo._anoModelo);
                cmd.Parameters.AddWithValue("@motor_veiculo", veiculo._motorVeiculo);
                cmd.Parameters.AddWithValue("@cor_veiculo", veiculo._corVeiculo);
                cmd.Parameters.AddWithValue("@observacao_veiculo", veiculo._observacaoVeiculo);

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

        public DataTable obterVeiculos()
        {
            DataTable dt = new DataTable();
            con = new ConexaoBanco().obterConexao();

            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT id_cliente [Cliente], placa_veiculo [PLACA], nome_marca [Marca], modelo_veiculo [Modelo],");
                query.AppendLine("ano_fabricacao [Ano de Fabricação], ano_modelo [Ano de Modelo], motor_veiculo [Motorização],");
                query.AppendLine("cor_veiculo [Cor], observacao_veiculo [Observação] from tb_veiculo as tb_veiculo INNER JOIN tb_marca on tb_veiculo.id_marca = tb_marca.id_marca");

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

        static public DataTable filtrarVeiculos(string termoPesquisa)
        {
            DataTable dt = new DataTable();

            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT id_cliente [Cliente], placa_veiculo [PLACA], tb_marca.nome_marca [MARCA], modelo_veiculo [Modelo],");
                query.AppendLine("ano_fabricacao [Ano de Fabricação], ano_modelo [Ano de Modelo], motor_veiculo [Motorização],");
                query.AppendLine("cor_veiculo [Cor], observacao_veiculo [Observação] from tb_veiculo as tb_veiculo INNER JOIN ");
                query.AppendLine("tb_marca as tb_marca on tb_veiculo.id_marca = tb_marca.id_marca WHERE placa_veiculo LIKE @placa_veiculo OR modelo_veiculo LIKE @modelo_veiculo");

                cmd = con.CreateCommand();

                cmd.Parameters.AddWithValue("@placa_veiculo", "%" + termoPesquisa + "%");
                cmd.Parameters.AddWithValue("@modelo_veiculo", "%" + termoPesquisa + "%");
                cmd.CommandText = Convert.ToString(query);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (SqlException erro)
            {
                throw new InvalidOperationException("Erro ao inserir registro!" + erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

        static public string obterVeiculoPorPlaca(string placa_veiculo)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                string query = "SELECT placa_veiculo from tb_veiculo WHERE placa_veiculo = @placa_veiculo";

                var cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@placa_veiculo", placa_veiculo);

                var placa = cmd.ExecuteReader();
                placa.Read();

                if (placa.HasRows)
                    return Convert.ToString(placa["placa_veiculo"]);
                else
                    return "0";

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

        static public DataTable obterVeiculosVinculados(int id_cliente)
        {
            DataTable dt = new DataTable();

            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("SELECT id_cliente [Cliente], placa_veiculo [PLACA], nome_marca [Marca], modelo_veiculo [Modelo],");
                query.AppendLine("ano_fabricacao [Ano de Fabricação], ano_modelo [Ano de Modelo], motor_veiculo [Motorização],");
                query.AppendLine("cor_veiculo [Cor], observacao_veiculo [Observação] from tb_veiculo as tb_veiculo INNER JOIN ");
                query.AppendLine("tb_marca on tb_veiculo.id_marca = tb_marca.id_marca WHERE id_cliente = @id_cliente");

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

        static public void removerVeiculo(string placaVeiculo)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("DELETE FROM tb_veiculo WHERE placa_veiculo = @placa_veiculo");

                cmd = con.CreateCommand();
                cmd.CommandText = Convert.ToString(query);

                cmd.Parameters.AddWithValue("@placa_veiculo", placaVeiculo);

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

        static public void removerVeiculosVinculados(int id_cliente)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("DELETE FROM tb_veiculo WHERE id_cliente = @id_cliente");

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

        static public void alterarVeiculo(ModeloVeiculo veiculo, string placa_antiga)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                StringBuilder query = new StringBuilder();

                query.AppendLine("UPDATE tb_veiculo SET placa_veiculo = @placa_veiculo, id_marca = @id_marca, modelo_veiculo = @modelo_veiculo, ");
                query.AppendLine("ano_fabricacao = @ano_fabricacao, ano_modelo = @ano_modelo, motor_veiculo = @motor_veiculo, cor_veiculo = @cor_veiculo, ");
                query.AppendLine("observacao_veiculo = @observacao_veiculo WHERE placa_veiculo = @placa_antiga");

                cmd = con.CreateCommand();
                cmd.CommandText = query.ToString();

                cmd.Parameters.AddWithValue("@placa_veiculo", veiculo._placaVeiculo);
                cmd.Parameters.AddWithValue("@placa_antiga", placa_antiga);
                cmd.Parameters.AddWithValue("@id_marca", veiculo._idMarca);
                cmd.Parameters.AddWithValue("@modelo_veiculo", veiculo._modeloVeiculo);
                cmd.Parameters.AddWithValue("@ano_fabricacao", veiculo._anoFabricacao);
                cmd.Parameters.AddWithValue("@ano_modelo", veiculo._anoModelo);
                cmd.Parameters.AddWithValue("@motor_veiculo", veiculo._motorVeiculo);
                cmd.Parameters.AddWithValue("@cor_veiculo", veiculo._corVeiculo);
                cmd.Parameters.AddWithValue("@observacao_veiculo", veiculo._observacaoVeiculo);

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

        static public void vincularClienteCarro(int id_cliente, string placa_veiculo)
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
