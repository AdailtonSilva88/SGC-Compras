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

    }
}
