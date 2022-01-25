using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
    class ModelPedidoProduto
    {
        private static string _prodQuantidade;
        private static string _pedido_cod_pedidos;
        private static string _pedido_cod_produtos;



        public static string ProdutoQtd
        {
            get { return _prodQuantidade; }
            set { _prodQuantidade = value; }
        }


    }
}
