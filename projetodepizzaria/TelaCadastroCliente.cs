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
            CenterToScreen();
        }

        //Quando o componente for carregado
        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            //Passar a string sql como parÂmetro
            // DAOCadastroCliente.ObterDados
            DAOCadastroCliente.ObterDados(dataGrid_Clientes);

        }

        private void dataGrid_Clientes_MouseClick(object sender, MouseEventArgs e)
        {
            txtCliNome.Text = dataGrid_Clientes.CurrentRow.Cells["Nome"].Value.ToString();
            txtCliBairro.Text = dataGrid_Clientes.CurrentRow.Cells["Bairro"].Value.ToString();
            txtCliRua.Text = dataGrid_Clientes.CurrentRow.Cells["Rua"].Value.ToString();
            txtCliNumero.Text = dataGrid_Clientes.CurrentRow.Cells["Numero"].Value.ToString();
            txtCliTelefone.Text = dataGrid_Clientes.CurrentRow.Cells["Telefone"].Value.ToString();

            if (dataGrid_Clientes.CurrentRow.Cells["Sexo"].Value.ToString().Equals("Feminino"))
            {
                rbFeminino.Select();
                
            }
            else
            {
                rbMasculino.Select();
 
            }

        }


        //Evento do botão adicionar - chamar a controller
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            //Fazendo a verificação dos campos 
            if (txtCliNome.Equals("") || txtCliBairro.Equals("") || txtCliRua.Equals("") || txtCliNumero.Equals("") || txtCliTelefone.Equals("") || rbFeminino.Checked.Equals(false) && rbMasculino.Checked.Equals(false) )
            {
                MessageBox.Show("Um ou mais campos não foram peenchidos.");

            }
            else
            {
                //Executar a query de INSERT no banco de dados 
                DAOCadastroCliente.CadastrarEndereco(txtCliBairro.Text, txtCliRua.Text, txtCliNumero.Text);
                DAOCadastroCliente.ResgatarCodigo(); //SEM PARÂMETROS
                //Condicional para passar o atributo sexo
                if (rbFeminino.Checked.Equals(true))
                {
                    DAOCadastroCliente.CadastrarCliente(txtCliNome.Text, txtCliTelefone.Text, rbFeminino.Text);

                //Se o radioButton rbFeminino não estiver marcado, o rbMasculino estará.
                } else
                {
                    DAOCadastroCliente.CadastrarCliente(txtCliNome.Text, txtCliTelefone.Text, rbMasculino.Text);
                }

            }


        }

      
    }
}
