using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
    public class ModelPedido
    {
        private int pedCod;
        private double pedTotal;
        private string pedDescricao;
        private double pedTaxaEnt;
        private string pedTipoVenda;
        private string pedFromaPag;
        private double pedTroco;
        private string pedStatus;
        private string pedDataHora;
        private int clienteCliCod;
        private int funcionarioFunCod;
        private string entegadorEntCod;
        private string enderecoCod;
        private double valorRecebido;


        
        public int CodigoPedido
        {
            get { return pedCod; }
            set { pedCod = value; }
        }

        public double TotalPedido
        {
            get { return pedTotal; }
            set { pedTotal = value; }

        }

        public int CodigoCliente
        {
            get { return clienteCliCod; }
            set { clienteCliCod = value; }


        }

        public string TipoDeVenda
        {
            get { return pedTipoVenda; }
            set { pedTipoVenda = value; }

        }


        public string PedidoDescricao
        {
            get { return pedDescricao; }
            set { pedDescricao = value; }
        }

        public int CodigoFuncionario
        {
            get { return funcionarioFunCod; }
            set { funcionarioFunCod = value; }
        }


        public string CodigoEntregador
        {
            get { return entegadorEntCod; }
            set { entegadorEntCod = value; }

        }

        public double TaxaEntrega
        {
            get { return pedTaxaEnt; }
            set { pedTaxaEnt = value; }

        }

        public string FormaPagamento
        {
            get { return pedFromaPag; }
            set { pedFromaPag = value; }
        }

        public  double TrocoPedido
        {
            get { return pedTroco; }
            set { pedTroco = value; }

        }

        public string DataHoraPed
        {
            get { return pedDataHora; }
            set { pedDataHora = value; }
        }
       
        
       
        public string CodigoEndereco
        {
            get { return enderecoCod; }
            set { enderecoCod = value; }


        }
        
        
        public double ValorRecebido
        {
            get { return valorRecebido; }
            set { valorRecebido = value; }

        }
        
        
        
        
        
        /*
        public string GetPedCod()
        {
            return pedCod;
        }
          
        public void SetPedCod(string PedCodigo)
        {
            PedCodigo = pedCod;

        }

        */
    }
}
