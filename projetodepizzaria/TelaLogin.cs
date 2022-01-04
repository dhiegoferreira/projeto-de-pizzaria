using System.Diagnostics;

namespace DesktopApp
{
    public partial class TelaLogin : Form
    {

        //MÉTODO CONSTRUTOR
        public TelaLogin()
        {
            InitializeComponent();
            CenterToScreen(); // TelaLogin.CenterToScreen não é corrreto pois já está sendo construido
           


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
                
                //Chamando o método de conusulta ao banco de dados e passando o texto inserido
                //pelo usuário como parâmetro do método.
                
                DAOLogin.AutenticarFuncionario(txtUsuario.Text, txtSenha.Text);   
                DAOLogin.AtualizarStatus();
                

            }


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


        //Ação do botão Entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Chamar o método autenticação
            autenticacao();

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblNomeSistema_Click(object sender, EventArgs e)
        {

        }
    }
}