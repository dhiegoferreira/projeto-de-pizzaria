using System.Diagnostics;

namespace DesktopApp
{
    public partial class TelaLogin : Form
    {

        //M�TODO CONSTRUTOR
        public TelaLogin()
        {
            InitializeComponent();
            CenterToScreen(); // TelaLogin.CenterToScreen n�o � corrreto pois j� est� sendo construido
        }

        //INICIALIZA O SISTEMA
        static void Main()
        {

            Application.Run(new TelaLogin());

        }


        //Inicializar a tela principal
        public static TelaPrincipal telaprincipal; 

        //M�todo de m�scara para a senha (n�o apagar) 
        private void txtSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //A��o do bot�o Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        //A��o do bot�o Entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {

                //Trace.WriteLine ou Debug.WriteLine
                MessageBox.Show("Preencha os campos corretamente.");


            }
            else
            {

                //Chamando o m�todo de conusulta ao banco de dados e passando o texto inserido
                //pelo usu�rio como par�metro do m�todo.
                telaprincipal = new TelaPrincipal();
                if (DAOLogin.AutenticarFuncionario(txtUsuario.Text, txtSenha.Text) == true) 
                {
                    telaprincipal.Show();
                    DAOLogin.AtualizarStatusAtivado();

                } else
                {
                    MessageBox.Show("Usu�rio ou senha inv�lidos.");
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