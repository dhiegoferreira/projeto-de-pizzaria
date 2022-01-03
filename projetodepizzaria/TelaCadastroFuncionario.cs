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

namespace projetodepizzaria
{
    public partial class Tela_CadastroFuncionario : Form
    {
        
        public Tela_CadastroFuncionario()
        {
            InitializeComponent();

        }

        public void inserir()
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

        public void alterar()
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
        public void obterdados()
        {
            //DaoFuncionario.obterDados(tblFuncionario);
        }

        public void pesquisa()
        {
           // DaoFuncionario.pesquisarFuncionario(txtfunNome.Text);
        }

        private void btnAdicionar_Click(object sender, EventArgs e) 
            {
            inserir();   
            }

        private void btnAlterar_Click(object sender, EventArgs e)
            {
            alterar();
            }

        private void Tela_CadastroFuncionario_Load(object sender, EventArgs e)
        {
            obterdados();
        }

        private void txtfunPesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisa();
        }
    }

    }
