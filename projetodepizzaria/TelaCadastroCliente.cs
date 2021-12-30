using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetodepizzaria
{
    public partial class TelaCadastroCliente : Form
    {
        public TelaCadastroCliente()
        {
            InitializeComponent();
        }


        

        //Quando o componente for carregado
        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            //Passar a string sql como parÂmetro
            // DAOCadastroCliente.ObterDados
            DAOCadastroCliente.ObterDados("SELECT c.cli_cod AS Código, c.cli_nome AS Nome, e.end_bairro AS Bairro, e.end_rua AS Rua, e.end_numero AS Numero, c.cli_telefone AS Telefone, c.cli_sexo AS Sexo FROM clientes AS c JOIN endereco AS e ON c.cli_end_fk = e.end_cod", dataGrid_Clientes);

        }

        private void dataGrid_Clientes_MouseClick(object sender, MouseEventArgs e)
        {
            txtCliNome.Text = dataGrid_Clientes.CurrentRow.Cells["Nome"].Value.ToString();
            txtCliBairro.Text = dataGrid_Clientes.CurrentRow.Cells["Bairro"].Value.ToString();
            txtCliRua.Text = dataGrid_Clientes.CurrentRow.Cells["Rua"].Value.ToString();
            txtCliNumero.Text = dataGrid_Clientes.CurrentRow.Cells["Numero"].Value.ToString();
            txtCliTelefone.Text = dataGrid_Clientes.CurrentRow.Cells["Telefone"].Value.ToString();
            txtCliSexo.Text = dataGrid_Clientes.CurrentRow.Cells["Sexo"].Value.ToString();
        }


        //Evento do botão adicionar - chamar a controller
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            //Fazendo a verificação dos campos 
            if(txtCliNome.Equals("") || txtCliBairro.Equals("") || txtCliRua.Equals("") || txtCliNumero.Equals("") || txtCliTelefone.Equals("") || txtCliSexo.Equals(""))
            {
                MessageBox.Show("Um ou mais campos não foram peenchidos.");

            } else
            {
                //Executar a query de INSERT no banco de dados 

            }


        }
    }
}
