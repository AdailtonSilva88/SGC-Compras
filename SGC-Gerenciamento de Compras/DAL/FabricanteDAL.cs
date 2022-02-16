using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_Gerenciamento_de_Compras.DAL
{
    internal class FabricanteDAL
    {
        Int32 novoId = 0;
        public String mensagem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        public String cadastrar(Int32 codFabricante, String nomeFabricante)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "INSERT INTO TB_FABRICANTE VALUES(@codFabricante,@nomeFabricante);";
            cmd.Parameters.AddWithValue("@codFabricante", codFabricante);
            cmd.Parameters.AddWithValue("@nomeFabricante", nomeFabricante);

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

        public Int32 ultimoCadastroId()
        {
            
            SqlDataReader dr;
            cmd.CommandText = "SELECT MAX(COD_FABRICANTE) FROM TB_FABRICANTE";

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
                                              
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

        public bool verificaCodigo(Int32 codFabricante)
        {
            SqlDataReader dr;
            bool resultado = true;
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT * FROM TB_FABRICANTE WHERE COD_FABRICANTE = " + codFabricante;
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
