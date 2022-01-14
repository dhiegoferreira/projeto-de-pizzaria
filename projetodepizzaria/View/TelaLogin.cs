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

        //INICIALIZA O SISTEMA
        static void Main()
        {

            Application.Run(new TelaLogin());

        }


        //Inicializar a tela principal
        public static TelaPrincipal telaprincipal; 

        //Método de máscara para a senha (não apagar) 
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
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {

                //Trace.WriteLine ou Debug.WriteLine
                MessageBox.Show("Preencha os campos corretamente.");


            }
            else
            {

                //Chamando o método de conusulta ao banco de dados e passando o texto inserido
                //pelo usuário como parâmetro do método.
                telaprincipal = new TelaPrincipal();
                if (DAOLogin.AutenticarFuncionario(txtUsuario.Text, txtSenha.Text) == true) 
                {
                    telaprincipal.Show();
                    DAOLogin.AtualizarStatusAtivado();

                } else
                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }
                
            }


        }

        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsuario.Text = "";
        }

        private void txtSenha_MouseClick(object sender, MouseEventArgs e)
        {
            txtSenha.Text = "";
        }
    }
}