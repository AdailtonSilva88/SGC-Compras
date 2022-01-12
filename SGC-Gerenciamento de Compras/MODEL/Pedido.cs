using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_Gerenciamento_de_Compras.MODEL
{
    internal class Pedido
    {
        private Int32 idPedido;
        private Int32 idFabricante;
        private Int32 idEtapa;
        private String pedidoFabricante;
        private String nomeVendedor;
        private DateTime dataPedido;
        private DateTime previsaoFaturamento;
        private Int32 prazo;
        private Int32 parcela;
        private String pedidoComprador;
        private Int32 idUnidade;
        private Int32 nf;
        private String nomeComprador;
        private String obs;
        private List<ProdPedido> prodPedidos;

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public int IdFabricante { get => idFabricante; set => idFabricante = value; }
        public int IdEtapa { get => idEtapa; set => idEtapa = value; }
        public string PedidoFabricante { get => pedidoFabricante; set => pedidoFabricante = value; }
        public string NomeVendedor { get => nomeVendedor; set => nomeVendedor = value; }
        public DateTime DataPedido { get => dataPedido; set => dataPedido = value; }
        public DateTime PrevisaoFaturamento { get => previsaoFaturamento; set => previsaoFaturamento = value; }
        public int Prazo { get => prazo; set => prazo = value; }
        public int Parcela { get => parcela; set => parcela = value; }
        public string PedidoComprador { get => pedidoComprador; set => pedidoComprador = value; }
        public int IdUnidade { get => idUnidade; set => idUnidade = value; }
        public int Nf { get => nf; set => nf = value; }
        public string NomeComprador { get => nomeComprador; set => nomeComprador = value; }
        public string Obs { get => obs; set => obs = value; }
        public List<ProdPedido> ProdPedidos { get => prodPedidos; set => prodPedidos = value; }
    }
}
