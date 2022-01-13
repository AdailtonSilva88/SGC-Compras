using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_Gerenciamento_de_Compras.DAL
{
    class ProdutoDAL
    {
        Int32 novoId = 0;
        public String mensagem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        
        public String cadastrarProd(Int32 codProduto,String descricao) 
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "INSERT INTO TB_PRODUTO VALUES(@codProduto,@descricao);";
            cmd.Parameters.AddWithValue("@codProduto",codProduto);
            cmd.Parameters.AddWithValue("@descricao",descricao);
            StringBuilder errorMessages = new StringBuilder();


            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();

                this.mensagem = "Cadastrado com Sucesso";
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

            return mensagem;

        }

        public Int32 ultimoCadastroId()
        {

            SqlDataReader dr;
            cmd.CommandText = "SELECT MAX(COD_PRODUTO) FROM TB_PRODUTO";
            

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (Convert.ToInt32(dr[0].ToString()) > 0)
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

        public bool verificaCodigo(Int32 codProduto)
        {
            SqlDataReader dr;
            bool resultado = true;
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT * FROM TB_PRODUTO WHERE COD_PRODUTO = " + codProduto;           
            StringBuilder errorMessages = new StringBuilder();


            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                dr.Read();

                if (Convert.ToInt32(dr[0]) > 0)
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
