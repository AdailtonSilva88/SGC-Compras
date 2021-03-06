using SGC_Gerenciamento_de_Compras.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_Gerenciamento_de_Compras.DAL
{
    internal class PedidoDAL
    {
        public String mensagem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        public String cadastrarPedido(Pedido pedido,List<ProdPedido> prodPedidos )
        {
            
            cmd.Parameters.Clear();

            cmd.CommandText = "INSERT INTO TB_PEDIDO VALUES(@idFabricante,@idEtapaPedido,@pedidoFabricante," +
            "@nomeVendedor,@dataPedido,@previsaoFaturamento,@prazo,@parcela,@pedidoComprador,@idUnidade," +
            "@nf,@status,@nomeComprador,@obs) SELECT SCOPE_IDENTITY()";
                

            cmd.Parameters.AddWithValue("@idFabricante",pedido.IdFabricante );
            cmd.Parameters.AddWithValue("@idEtapaPedido", pedido.IdEtapa );
            cmd.Parameters.AddWithValue("@pedidoFabricante",pedido.PedidoFabricante );
            cmd.Parameters.AddWithValue("@nomeVendedor", pedido.NomeVendedor);
            cmd.Parameters.AddWithValue("@dataPedido",pedido.DataPedido );
            cmd.Parameters.AddWithValue("@previsaoFaturamento",pedido.PrevisaoFaturamento );
            cmd.Parameters.AddWithValue("@prazo",pedido.Prazo );
            cmd.Parameters.AddWithValue("@parcela",pedido.Parcela );
            cmd.Parameters.AddWithValue("@pedidoComprador",pedido.PedidoComprador );
            cmd.Parameters.AddWithValue("@idUnidade", pedido.IdUnidade);
            cmd.Parameters.AddWithValue("@nf", 0);
            cmd.Parameters.AddWithValue("@status", "ATIVO");
            cmd.Parameters.AddWithValue("@nomeComprador", pedido.NomeComprador );
            cmd.Parameters.AddWithValue("@obs", pedido.Obs );
           
            try
            {
                cmd.Connection = con.conectar();

                int idPedido = Convert.ToInt32(cmd.ExecuteScalar());

                for (int i = 0; i < prodPedidos.Count; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO TB_PRODUTOS_PEDIDO VALUES (@idPedido,@idProduto,@qtdPedido,@saldoPedido,@valor)";
                    cmd.Parameters.AddWithValue("@idPedido", idPedido);
                    cmd.Parameters.AddWithValue("@idProduto", prodPedidos[i].IdProduto);
                    cmd.Parameters.AddWithValue("@qtdPedido", prodPedidos[i].QtdPedido);
                    cmd.Parameters.AddWithValue("@saldoPedido",prodPedidos[i].SaldoPedido);
                    cmd.Parameters.AddWithValue("@valor",prodPedidos[i].Valor);
                    cmd.ExecuteNonQuery();
                }

                con.desconectar();
                this.mensagem = "Cadastrado com Sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }

            return mensagem;

        }

        public String cadEtapaPedido(Pedido pedido, List<ProdPedido> prodPedidos)
        {
            cmd.Parameters.Clear();

            cmd.CommandText = "INSERT INTO TB_PEDIDO VALUES(@idFabricante,@idEtapaPedido,@pedidoFabricante," +
            "@nomeVendedor,@dataPedido,@previsaoFaturamento,@prazo,@parcela,@pedidoComprador,@idUnidade," +
            "@nf,@status,@nomeComprador,@obs) SELECT SCOPE_IDENTITY()";


            cmd.Parameters.AddWithValue("@idFabricante", pedido.IdFabricante);
            cmd.Parameters.AddWithValue("@idEtapaPedido", pedido.IdEtapa);
            cmd.Parameters.AddWithValue("@pedidoFabricante", pedido.PedidoFabricante);
            cmd.Parameters.AddWithValue("@nomeVendedor", pedido.NomeVendedor);
            cmd.Parameters.AddWithValue("@dataPedido", pedido.DataPedido);
            cmd.Parameters.AddWithValue("@previsaoFaturamento", pedido.PrevisaoFaturamento);
            cmd.Parameters.AddWithValue("@prazo", pedido.Prazo);
            cmd.Parameters.AddWithValue("@parcela", pedido.Parcela);
            cmd.Parameters.AddWithValue("@pedidoComprador", pedido.PedidoComprador);
            cmd.Parameters.AddWithValue("@idUnidade", pedido.IdUnidade);
            cmd.Parameters.AddWithValue("@nf", pedido.Nf);
            cmd.Parameters.AddWithValue("@status", "ATIVO");
            cmd.Parameters.AddWithValue("@nomeComprador", pedido.NomeComprador);
            cmd.Parameters.AddWithValue("@obs", pedido.Obs);

            try
            {
                cmd.Connection = con.conectar();

                int idPedido = Convert.ToInt32(cmd.ExecuteScalar());

                for (int i = 0; i < prodPedidos.Count; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO TB_PRODUTOS_PEDIDO VALUES (@idPedido,@idProduto,@qtdPedido,@saldoPedido,@valor)";
                    cmd.Parameters.AddWithValue("@idPedido", idPedido);
                    cmd.Parameters.AddWithValue("@idProduto", prodPedidos[i].IdProduto);
                    cmd.Parameters.AddWithValue("@qtdPedido", prodPedidos[i].QtdPedido);
                    cmd.Parameters.AddWithValue("@saldoPedido", prodPedidos[i].SaldoPedido);
                    cmd.Parameters.AddWithValue("@valor", prodPedidos[i].Valor);
                    cmd.ExecuteNonQuery();
                }

                //excluir itens do pedido antigo
                for (int i = 0; i < prodPedidos.Count; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "UPDATE TB_PRODUTOS_PEDIDO SET SALDO_PEDIDO = SALDO_PEDIDO - @saldoPedido WHERE ID_PEDIDO = @idPedido AND ID_PRODUTO = @idProduto ";
                    cmd.Parameters.AddWithValue("@saldoPedido", prodPedidos[i].SaldoPedido);
                    cmd.Parameters.AddWithValue("@idPedido", pedido.IdPedido);
                    cmd.Parameters.AddWithValue("@idProduto", prodPedidos[i].IdProduto);
                    cmd.ExecuteNonQuery();
                }

                con.desconectar();
                this.mensagem = "Cadastrado com Sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }

            return mensagem;
        }

        public Int32 BuscaIDPedido() 
        {
            int id = 0;

            SqlDataReader dr;
            cmd.CommandText = "SELECT MAX(ID_PEDIDO) FROM TB_PEDIDO";


            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                dr.Read();

                if (!dr.IsDBNull(0))
                {
                    id = Convert.ToInt32(dr[0]);
                }
                else
                {
                    id = 0;
                }
                con.desconectar();

                return id;

            }
            catch (SqlException)
            {
                this.mensagem = "Erro SQL";
            }

            return id;
        
        }

        public bool VerificaNfExiste(Int32 nf, Int32 fabricante) 
        {
            bool verifica = false;

            SqlDataReader dr;
            cmd.CommandText = "SELECT * FROM TB_PEDIDO WHERE NF = @nf AND ID_FABRICANTE = @fabricante";
            cmd.Parameters.AddWithValue("@nf", nf);
            cmd.Parameters.AddWithValue("@fabricante",fabricante);

            cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    verifica = true;
                    return verifica;
                }
               
                con.desconectar();

                return verifica;      

        }     

    }
}
