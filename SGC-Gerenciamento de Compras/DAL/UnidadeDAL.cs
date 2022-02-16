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
        public Int32 novoId;
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

        public Int32 ultimoCadastroId() 
        {

            SqlDataReader dr ;
            cmd.CommandText = "SELECT MAX(COD_UNIDADE) FROM TB_UNIDADE";
          
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();                
                dr.Read();// dr para retorno

                if (!dr.IsDBNull(0))
                {
                    novoId = Convert.ToInt32(dr[0]);
                }
                else
                {
                    novoId = 0;
                }
                con.desconectar();

                return novoId;

            }
            catch (SqlException)
            {
                this.mensagem = "Erro SQL";
            }

            return novoId;
        }

        public bool verificaCodigo(Int32 codigo)
        {
            SqlDataReader dr;
            bool resultado = true;
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT * FROM TB_UNIDADE WHERE COD_UNIDADE = " + codigo;
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
