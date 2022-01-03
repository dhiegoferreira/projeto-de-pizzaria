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


        private void LimparCampos()
        {
            txtCliNome.Text = "";
            txtCliBairro.Text = "";
            txtCliRua.Text = "";
            txtCliNumero.Text = "";
            maskTextCliTel.Text = "";
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;
        }


        private void SetarCampos()
        {
            txtCliNome.Text = dataGrid_Clientes.CurrentRow.Cells["Nome"].Value.ToString();
            txtCliBairro.Text = dataGrid_Clientes.CurrentRow.Cells["Bairro"].Value.ToString();
            txtCliRua.Text = dataGrid_Clientes.CurrentRow.Cells["Rua"].Value.ToString();
            txtCliNumero.Text = dataGrid_Clientes.CurrentRow.Cells["Numero"].Value.ToString();
            maskTextCliTel.Text = dataGrid_Clientes.CurrentRow.Cells["Telefone"].Value.ToString();

            if (dataGrid_Clientes.CurrentRow.Cells["Sexo"].Value.ToString().Equals("Feminino"))
            {
                rbFeminino.Select();

            }
            else
            {
                rbMasculino.Select();

            }


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
            SetarCampos();
        }


        //Evento do botão adicionar - chamar a controller
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Fazendo a verificação dos campos 
            if (txtCliNome.Equals("") || txtCliBairro.Equals("") || txtCliRua.Equals("") || txtCliNumero.Equals("") || maskTextCliTel.Equals("") || rbFeminino.Checked.Equals(false) && rbMasculino.Checked.Equals(false))
            {
                MessageBox.Show("Um ou mais campos não foram peenchidos corretamente.");

            }
            else
            {
                //Executar a query de INSERT no banco de dados 
                DAOCadastroCliente.CadastrarEndereco(txtCliBairro.Text, txtCliRua.Text, txtCliNumero.Text);
                DAOCadastroCliente.ResgatarCodigo(); //SEM PARÂMETROS


                //Condicional para passar o conteúdo do radiobutton selecionado
                if (rbFeminino.Checked.Equals(true))
                {
                    DAOCadastroCliente.CadastrarCliente(txtCliNome.Text, maskTextCliTel.Text, rbFeminino.Text, "INSERT INTO clientes(cli_nome, cli_telefone, cli_sexo, cli_end_fk) VALUES(@clinome, @cli_telefone, @cli_sexo, @cli_end_fk)");
                    //Passar a string sql como parÂmetro
                    // DAOCadastroCliente.ObterDados
                    DAOCadastroCliente.ObterDados(dataGrid_Clientes);



                }
                else
                {
                    DAOCadastroCliente.CadastrarCliente(txtCliNome.Text, maskTextCliTel.Text, rbMasculino.Text, "INSERT INTO clientes(cli_nome, cli_telefone, cli_sexo, cli_end_fk) VALUES(@clinome, @cli_telefone, @cli_sexo, @cli_end_fk)");
                    //Passar a string sql como parÂmetro
                    // DAOCadastroCliente.ObterDados
                    DAOCadastroCliente.ObterDados(dataGrid_Clientes);
                }

            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Verificação dos campos 
            if (txtCliNome.Equals("") || txtCliBairro.Equals("") || txtCliRua.Equals("") || txtCliNumero.Equals("") || maskTextCliTel.Equals("") || rbFeminino.Checked.Equals(false) && rbMasculino.Checked.Equals(false))
            {
                MessageBox.Show("Um ou mais campos não foram preenchidos corretamente.");

            }
            else
            {
                //Chamar o métedo UPDATE da classe DAOCadastroCliente
                DAOCadastroCliente.CodigoEndereco(txtCliNome.Text);
                DAOCadastroCliente.AtualizarEndereco(txtCliBairro.Text, txtCliRua.Text, txtCliNumero.Text);

                //Condicional para passar o conteúdo do radiobutton selecionado
                if (rbFeminino.Checked.Equals(true))
                {
                    MessageBox.Show(dataGrid_Clientes.CurrentRow.Cells["Código"].Value.ToString());
                    DAOCadastroCliente.AtualizarCliente(txtCliNome.Text, maskTextCliTel.Text, rbFeminino.Text, dataGrid_Clientes.CurrentRow.Cells["Código"].Value.ToString());
                    //Passar a string sql como parÂmetro
                    // DAOCadastroCliente.ObterDados
                    DAOCadastroCliente.ObterDados(dataGrid_Clientes);


                    //Se o radioButton rbFeminino não estiver marcado, o rbMasculino estará.
                }
                else
                {
                    MessageBox.Show(dataGrid_Clientes.CurrentRow.Cells["Código"].Value.ToString());
                    DAOCadastroCliente.AtualizarCliente(txtCliNome.Text, maskTextCliTel.Text, rbMasculino.Text, dataGrid_Clientes.CurrentRow.Cells["Código"].Value.ToString());
                    //Passar a string sql como parÂmetro
                    // DAOCadastroCliente.ObterDados
                    DAOCadastroCliente.ObterDados(dataGrid_Clientes);


                }


               

            }



        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Dispose();
            
        }

        private void TelaCadastroCliente_Activated(object sender, EventArgs e)
        {
           
        }
    }


}