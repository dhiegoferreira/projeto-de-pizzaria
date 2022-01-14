using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DesktopApp
{
    public partial class TelaCadastroFuncionario : Form
    {
        
        public TelaCadastroFuncionario()
        {
            InitializeComponent();

        }



        private void InserirFuncionario()
        {

            if (txtfunNome.Equals("") || cboCargo.Equals("") || txtfunUsuario.Equals("") || txtfunSenha.Equals("") || cboPerfil.Equals("") || rbFeminino.Checked.Equals(false) && rbMasculino.Checked.Equals(false))
            {
                MessageBox.Show("Um ou mais campos não foram peenchidos corretamente.");

            }
            else
            { 
                //Condicional para passar o conteúdo do radiobutton selecionado
                if (rbFeminino.Checked.Equals(true))
                {
                    DAOCadastroFuncionario.InserirFuncionario(txtfunNome.Text, cboCargo.SelectedItem.ToString(), txtfunUsuario.Text, txtfunSenha.Text, cboPerfil.SelectedItem.ToString(), rbFeminino.Text);
                    DAOCadastroFuncionario.ObterDados(tblFuncionarios);



                }
                else
                { 
                    DAOCadastroFuncionario.InserirFuncionario(txtfunNome.Text, cboCargo.SelectedItem.ToString(), txtfunUsuario.Text, txtfunSenha.Text, cboPerfil.SelectedItem.ToString(), rbMasculino.Text);
                    DAOCadastroFuncionario.ObterDados(tblFuncionarios);

                }
            }
        }


        private void AlterarFuncionario()
        {
            if (txtfunNome.Text == "" && cboCargo.SelectedItem == null
                && txtfunUsuario.Text == "" && txtfunSenha.Text == "" && cboPerfil.SelectedItem == null)
            {
                MessageBox.Show("Prenncha os campos corretamente.");
                Console.WriteLine("Preencha os campos corretamente.");

            }
            else
            {
                //Aqui nós iremos passar os textos inseridos pelo usuário como parâmetros      
                //Condicional para passar o conteúdo do radiobutton selecionado
                if (rbFeminino.Checked.Equals(true))
                {
                    DAOCadastroFuncionario.AlterarFuncionario(txtfunNome.Text, cboCargo.SelectedItem.ToString(), txtfunUsuario.Text, txtfunSenha.Text, cboPerfil.SelectedItem.ToString(), rbFeminino.Text, tblFuncionarios.CurrentRow.Cells["Código"].Value.ToString());
                    DAOCadastroFuncionario.ObterDados(tblFuncionarios);



                }
                else
                {
                    DAOCadastroFuncionario.AlterarFuncionario(txtfunNome.Text, cboCargo.SelectedItem.ToString(), txtfunUsuario.Text, txtfunSenha.Text, cboPerfil.SelectedItem.ToString(), rbMasculino.Text, tblFuncionarios.CurrentRow.Cells["Código"].Value.ToString());
                    DAOCadastroFuncionario.ObterDados(tblFuncionarios);

                }

            }
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            InserirFuncionario();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarFuncionario();
        }

        private void Tela_CadastroFuncionario_Load(object sender, EventArgs e)
        {
            DAOCadastroFuncionario.ObterDados(tblFuncionarios);
        }


        private void tblFuncionarios_MouseClick(object sender, MouseEventArgs e)
        {
            txtfunNome.Text = tblFuncionarios.CurrentRow.Cells["Nome"].Value.ToString();
            cboCargo.SelectedItem = tblFuncionarios.CurrentRow.Cells["Cargo"].Value.ToString();
            txtfunUsuario.Text = tblFuncionarios.CurrentRow.Cells["Usuário"].Value.ToString();
            txtfunSenha.Text = tblFuncionarios.CurrentRow.Cells["Senha"].Value.ToString();
            cboPerfil.SelectedItem = tblFuncionarios.CurrentRow.Cells["Perfil"].Value.ToString();

            //Condicional para selecionar o radioButton do campos /sexo/
            if (tblFuncionarios.CurrentRow.Cells["Sexo"].Value.ToString().Equals("Feminino"))
            {
                rbFeminino.Select();

            }
            else
            {
                rbMasculino.Select();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       

        //Pesquisar por nome 
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if(txtFuncPesquisar.Text != "" || txtFuncPesquisar.Text != "Pesquisar por nome")
            {
                DAOCadastroFuncionario.PesquisarFuncNome(tblFuncionarios, txtFuncPesquisar.Text);

            }
        }

        private void txtFuncPesquisar_MouseClick(object sender, MouseEventArgs e)
        {
            txtFuncPesquisar.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtfunNome.Text = "";
            cboCargo.Text = "";
            txtfunUsuario.Text = "";
            cboPerfil.Text = "";
            txtfunSenha.Text = "";
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;

        }
    }

}
