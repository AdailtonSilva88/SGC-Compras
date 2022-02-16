using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_Gerenciamento_de_Compras.DAL
{
    internal class ProdPedidoDAL
    {
        public String mensagem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        public String cadastrarProdPed(Int32 idPedido, Int32 idProduto, float qtdPedido, float saldoPedido,
            float valor)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "INSERT INTO TB_PRODUTOS_PEDIDO VALUES(" + idPedido + "," + idProduto + "," + qtdPedido + "," +
                saldoPedido + "," + valor + ");";

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

        public String nomeProduto(Int32 codProduto)
        {
            String nomeProduto = "";
            SqlDataReader dr;

            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT DESCRICAO_PROD FROM TB_PRODUTO WHERE COD_PRODUTO = " + codProduto;

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
                nomeProduto = dr[0].ToString();
                con.desconectar();

            }
            catch (SqlException)
            {
                this.mensagem = "Erro SQL";
            }

            return nomeProduto;
        }

    }
}
