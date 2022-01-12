using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_Gerenciamento_de_Compras.MODEL
{
    internal class ProdPedido
    {
        
        private Int32 idProduto;
        private Double qtdPedido;
        private Double saldoPedido;
        private Double valor;

        public ProdPedido( int idProduto, double qtdPedido, double saldoPedido, double valor)
        {
            
            this.idProduto = idProduto;
            this.qtdPedido = qtdPedido;
            this.saldoPedido = saldoPedido;
            this.valor = valor;
        }

        
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public double QtdPedido { get => qtdPedido; set => qtdPedido = value; }
        public double SaldoPedido { get => saldoPedido; set => saldoPedido = value; }
        public double Valor { get => valor; set => valor = value; }
        
    }
}
