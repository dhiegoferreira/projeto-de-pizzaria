using System.Diagnostics;

namespace projetodepizzaria
{
    public partial class TelaLogin : Form
    {

        //MÉTODO CONSTRUTOR
        public TelaLogin()
        {
            InitializeComponent();
            CenterToScreen(); // TelaLogin.CenterToScreen Não faz sentido pois já está sendo construido


        }

        //Método para autenticação
        public void autenticacao()
        {

            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {

                //Trace.WriteLine ou Debug.WriteLine
                MessageBox.Show("Preencha os campos corretamente.");
                

            }
            else
            {
                //Aqui nós iremos passar os textos inseridos pelo usuário como parâmetros
                Console.WriteLine(txtUsuario);
                Console.WriteLine(txtSenha);
                DAOLogin.autenticarFuncionario(txtUsuario.Text, txtSenha.Text);
                

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Olá, mundo!");
            //Chamar o método autenticação
            autenticacao();

        }

        //Método de máscara para a senha
        private void txtSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //Ação do botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}