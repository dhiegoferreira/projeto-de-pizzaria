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



                }
                else
                { 
                    DAOCadastroFuncionario.InserirFuncionario(txtfunNome.Text, cboCargo.SelectedItem.ToString(), txtfunUsuario.Text, txtfunSenha.Text, cboPerfil.SelectedItem.ToString(), rbMasculino.Text);

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
                Console.WriteLine(txtfunNome);
                Console.WriteLine(cboCargo);
                Console.WriteLine(txtfunUsuario);
                Console.WriteLine(txtfunSenha);
                Console.WriteLine(cboPerfil);
                /*DaoFuncionario.InserirFuncionario(txtfunNome.Text, cboCargo.SelectedItem.ToString(), txtfunUsuario.Text, txtfunSenha.Text, cboPerfil.SelectedItem.ToString());
                cboCargo.SelectedItem.ToString();
                */
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

        private void txtfunPesquisar_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tblFuncionarios_MouseClick(object sender, MouseEventArgs e)
        {
            txtfunNome.Text = tblFuncionarios.CurrentRow.Cells["Nome"].Value.ToString();
            cboCargo.SelectedItem = tblFuncionarios.CurrentRow.Cells["Cargo"].Value.ToString();
            txtfunUsuario.Text = tblFuncionarios.CurrentRow.Cells["Usuário"].Value.ToString();
            txtfunSenha.Text = tblFuncionarios.CurrentRow.Cells["Senha"].Value.ToString();
            cboPerfil.SelectedItem = tblFuncionarios.CurrentRow.Cells["Perfil"].Value.ToString();


            if (tblFuncionarios.CurrentRow.Cells["Sexo"].Value.ToString().Equals("Feminino"))
            {
                rbFeminino.Select();

            }
            else
            {
                rbMasculino.Select();

            }
        }
    }

}
