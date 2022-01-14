using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DesktopApp
{
    public partial class TelaCadastroCliente : Form
    {
        public TelaCadastroCliente()
        {
            InitializeComponent();

          

        }

        private bool VerificarCampos()
        {
            if (txtCliNome.Equals("") || txtCliBairro.Equals("") || txtCliRua.Equals("") || txtCliNumero.Equals("") || maskTextCliTel.Equals("") || rbFeminino.Checked.Equals(false) && rbMasculino.Checked.Equals(false))
            {
                return false;
            } else
            {
                return true;
            }


        }

        //Quando o componente for carregado
        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            DAOCadastroCliente.ObterDados(tblClientes);
            pbSexoImagem.Image = Image.FromFile(@"C:../../Debug/icone-imagemInicial.png");
        }



        //PARA PEGAR OS DADOS NA TABELA E JOGAR NOS CAMPOS CORRESPONDENTES
        private void dataGrid_Clientes_MouseClick(object sender, MouseEventArgs e)
        {
            //SETAR CAMPOS
            txtCliNome.Text = tblClientes.CurrentRow.Cells["Nome"].Value.ToString();
            txtCliBairro.Text = tblClientes.CurrentRow.Cells["Bairro"].Value.ToString();
            txtCliRua.Text = tblClientes.CurrentRow.Cells["Rua"].Value.ToString();
            txtCliNumero.Text = tblClientes.CurrentRow.Cells["Numero"].Value.ToString();
            maskTextCliTel.Text = tblClientes.CurrentRow.Cells["Telefone"].Value.ToString();

            if (tblClientes.CurrentRow.Cells["Sexo"].Value.ToString().Equals("Feminino"))
            {
                rbFeminino.Select();
                pbSexoImagem.Image = Image.FromFile(@"C:../../Debug/Icone-mulher.png");
            }
            else
            {
                rbMasculino.Select();
                pbSexoImagem.Image = Image.FromFile(@"C:../../Debug/Icone-homem.png");

            }

        }

        private void button1_Click(object sender, EventArgs e) { this.Dispose(); }


        //Botão Adicionar cliente chamando métodos do banco 
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (VerificarCampos().Equals(true))
            {
                
                //Se retornar verdadeiro, então existe um cliente já cadastrado
                if (DAOCadastroCliente.VerificaDuplicados(txtCliNome.Text, maskTextCliTel.Text) == true) 
                {
                    MessageBox.Show("Cliente já cadastrado na Base de Dados!", "Atenção");
                    DialogResult novoendereco = MessageBox.Show("Deseja adicionar um novo endereço para o(a) cliente: " + tblClientes.CurrentRow.Cells["Nome"].Value.ToString() + "?", "Atenção ", MessageBoxButtons.YesNo);

                    string bairro = tblClientes.CurrentRow.Cells["Bairro"].Value.ToString();
                    string rua = tblClientes.CurrentRow.Cells["Rua"].Value.ToString();
                    string numero = tblClientes.CurrentRow.Cells["Numero"].Value.ToString();


                    if (novoendereco == DialogResult.Yes)
                    {
                        if(txtCliBairro.Text != bairro || txtCliRua.Text != rua || txtCliNumero.Text != numero)
                        {
                            //Método de adidionar
                            DAOCadastroCliente.codigoCliente = tblClientes.CurrentRow.Cells["Código"].Value.ToString();
                            DAOCadastroCliente.CadastrarEndereco(txtCliBairro.Text, txtCliRua.Text, txtCliNumero.Text);
                            MessageBox.Show("Endereço adicionado!");
                            DAOCadastroCliente.ObterDados(tblClientes); //Refresh

                        } else
                        {
                            //Não cadastrado
                            MessageBox.Show("Endereço indêntico ao informado, novo endereço não cadastrado.", "Erro");
                        }
                        
                        

                    }
             
                } else {

                    //Condicional para passar o conteúdo do radiobutton selecionado
                    if (rbFeminino.Checked.Equals(true))
                    {
                        //Primeiro criar o cliente
                        DAOCadastroCliente.CadastrarCliente(txtCliNome.Text, maskTextCliTel.Text, rbFeminino.Text);
                        //pegar o último cod do cliente gerado
                        DAOCadastroCliente.ResgatarCodigoCliente();

                        //criar o endereco
                        DAOCadastroCliente.CadastrarEndereco(txtCliBairro.Text, txtCliRua.Text, txtCliNumero.Text);

                        DAOCadastroCliente.ObterDados(tblClientes); //Refresh

                        //rbMasculino
                    }
                    else
                    {
                        //Primeiro criar o cliente
                        DAOCadastroCliente.CadastrarCliente(txtCliNome.Text, maskTextCliTel.Text, rbMasculino.Text);
                        //pegar o último cod do cliente gerado
                        DAOCadastroCliente.ResgatarCodigoCliente();
                        //criar o endereco
                        DAOCadastroCliente.CadastrarEndereco(txtCliBairro.Text, txtCliRua.Text, txtCliNumero.Text);
                        DAOCadastroCliente.ObterDados(tblClientes); //Refresh

                    }
                }
       
            } else
            {
                MessageBox.Show("Um ou mais campos não foram peenchidos corretamente.");
            }
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            if (VerificarCampos().Equals(false))
            {
                MessageBox.Show("Um ou mais campos não foram preechidos corretamente.");


                //Todos os campos foram preechindos corretamente.
            } else
            {   //O rádio button Feminino foi selecionado 
                               
                if (rbFeminino.Checked.Equals(true))
                {
                    //Atualizar o cliente
                    DAOCadastroCliente.AtualizarCliente(txtCliNome.Text, maskTextCliTel.Text, rbFeminino.Text, tblClientes.CurrentRow.Cells["Código"].Value.ToString());

                    DAOCadastroCliente.codigoCliente = tblClientes.CurrentRow.Cells["Código"].Value.ToString();


                    //passa o código do endereco
                    DAOCadastroCliente.codigoEndereco = tblClientes.CurrentRow.Cells["endCódigo"].Value.ToString();
                    //Atualizar o endereco selecionado
                    DAOCadastroCliente.AtualizarEndereco(txtCliBairro.Text, txtCliRua.Text, txtCliNumero.Text);

                    

                    DAOCadastroCliente.ObterDados(tblClientes); //Refresh

                }

                //O rádio button Masculino foi selecionado
                else
                {
                    //Atualizar o cliente
                    DAOCadastroCliente.AtualizarCliente(txtCliNome.Text, maskTextCliTel.Text, rbMasculino.Text, tblClientes.CurrentRow.Cells["Código"].Value.ToString());

                    DAOCadastroCliente.codigoCliente = tblClientes.CurrentRow.Cells["Código"].Value.ToString();

                    //passa o código do endereco
                    DAOCadastroCliente.codigoEndereco = tblClientes.CurrentRow.Cells["endCódigo"].Value.ToString();

                    //Atualizar o endereco selecionado
                    DAOCadastroCliente.AtualizarEndereco(txtCliBairro.Text, txtCliRua.Text, txtCliNumero.Text);

                    DAOCadastroCliente.ObterDados(tblClientes); //Refresh
                }


            }
            
        }

        //Responsável por limpar os campos
        private void pictureBox1_Click(object sender, EventArgs e)
        {
       
            txtCliNome.Text = "";
            txtCliBairro.Text = "";
            txtCliRua.Text = "";
            txtCliNumero.Text = "";
            maskTextCliTel.Text = "";
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;
            pbSexoImagem.Image = Image.FromFile(@"C:../../Debug/icone-imagemInicial.png");
        }

        private void txtPesquisar_MouseClick(object sender, MouseEventArgs e)
        {
            txtPesquisar.Text = "";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "" || txtPesquisar.Text == "Pesquisar por nome")
            {
                MessageBox.Show("Insira um nome válido!");

            } else
            {

                DAOCadastroCliente.recupararCodCliente(txtCliNome.Text);
                DAOCadastroCliente.ObterClientePesquisa(tblClientes);


            }
        }

        private void txtPesquisar_Leave(object sender, EventArgs e)
        {
            txtPesquisar.Text = "Pesquisar por nome";
        }

        private void rbFeminino_MouseClick(object sender, MouseEventArgs e)
        {
            pbSexoImagem.Image = Image.FromFile(@"C:../../Debug/Icone-mulher.png");
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            pbSexoImagem.Image = Image.FromFile(@"C:../../Debug/Icone-homem.png");
        }
    }


}