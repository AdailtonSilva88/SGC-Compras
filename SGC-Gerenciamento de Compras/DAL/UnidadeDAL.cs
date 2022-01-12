using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_Gerenciamento_de_Compras.DAL
{
    internal class UnidadeDAL
    {
        public String mensagem;
        public String novoId = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        public String cadastrar(Int32 codUnidade, String nomeUnidade)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "INSERT INTO TB_UNIDADE VALUES(@codUnidade,@nomeUnidade);";
            cmd.Parameters.AddWithValue("@codUnidade", codUnidade);
            cmd.Parameters.AddWithValue("@nomeUnidade", nomeUnidade);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();//sem retorno
                con.desconectar();

                this.mensagem = "Cadastrado com Sucesso";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro SQL";
            }

            return mensagem;

        }

        public String ultimoCadastroId() 
        {

            SqlDataReader dr ;
            cmd.CommandText = "SELECT MAX(COD_UNIDADE) FROM TB_UNIDADE";
          
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();                
                dr.Read();// dr para retorno
                novoId = dr[0].ToString();
                con.desconectar();

                return novoId;

            }
            catch (SqlException)
            {
                this.mensagem = "Erro SQL";
            }

            return novoId;
        }

    }
}
