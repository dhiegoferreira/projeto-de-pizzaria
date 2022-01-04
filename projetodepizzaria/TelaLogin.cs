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

        //M�todo para autentica��o
        public void autenticacao()
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
                
                DAOLogin.AutenticarFuncionario(txtUsuario.Text, txtSenha.Text);   
                DAOLogin.AtualizarStatus();
                

            }


        }

      

        //M�todo de m�scara para a senha
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
            //Chamar o m�todo autentica��o
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