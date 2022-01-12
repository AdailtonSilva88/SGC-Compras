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
        public String mensagem,novoId;
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

        public String ultimoCadastroId()
        {

            SqlDataReader dr;
            cmd.CommandText = "SELECT MAX(COD_FABRICANTE) FROM TB_FABRICANTE";

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
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
