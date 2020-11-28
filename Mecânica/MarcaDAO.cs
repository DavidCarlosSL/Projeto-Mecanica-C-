using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecânica
{
    public class MarcaDAO
    {
        static private SqlConnection con;
        static private SqlCommand cmd;

        public static List<ModeloMarca> ObterMarca()
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                var lista = new List<ModeloMarca>();

                string query = "SELECT id_marca, nome_marca from tb_marca";

                var cmd = new SqlCommand(query, con);

                var leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    ModeloMarca marca = new ModeloMarca();

                    marca._idMarca = Convert.ToInt32(leitor["id_marca"]);
                    marca._nomeMarca = leitor["nome_marca"].ToString();

                    lista.Add(marca);
                }

                return lista;

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


        public static int ObterMarcaPorNome(string nome)
        {
            try
            {
                con = new ConexaoBanco().obterConexao();

                string query = "SELECT id_marca from tb_marca WHERE nome_marca = @nome_marca";

                var cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@nome_marca", nome);

                var id = cmd.ExecuteReader();
                id.Read();

                return Convert.ToInt32(id["id_marca"]);

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
