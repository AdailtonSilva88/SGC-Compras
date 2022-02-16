using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_Gerenciamento_de_Compras.DAL
{
    internal class EtapaDAL
    {
        public String mensagem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        public String cadastrar(String nomeEtapa)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "INSERT INTO TB_ETAPA_PEDIDO VALUES(@nomeEtapa);";
            cmd.Parameters.AddWithValue("@nomeEtapa", nomeEtapa);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();

                this.mensagem = "Cadastrado com Sucesso";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro SQL";
            }
            return mensagem;

        }

        public bool verificaEtapa(String etapa)
        {
            SqlDataReader dr;
            bool resultado = true;
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT * FROM TB_ETAPA_PEDIDO WHERE NOME_ETAPA_PEDIDO = '" + etapa +"'";
            StringBuilder errorMessages = new StringBuilder();


            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    return false;
                }

                con.desconectar();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }

            return resultado;

        }

    }
}
