using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
    class ModelPedidoProduto
    {
        private static string prodQuantidade;
        private static string pedido_cod_pedidos;
        private static string pedido_cod_produtos;



        public static string ProdutoQtd
        {
            get { return prodQuantidade; }
            set { prodQuantidade = value; }
        }


    }
}
