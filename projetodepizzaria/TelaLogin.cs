namespace projetodepizzaria
{
    public partial class TelaLogin : Form
    {

        //MÉTODO CONSTRUTOR
        public TelaLogin()
        {
            InitializeComponent();
            CenterToScreen(); //Não faz sentido TelaLogin.CenterToScreen pois já está sendo construido


        }

        //Método para autenticação
        public void autenticacao()
        {

            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Prenncha os campos corretamente.");
                Console.WriteLine("Preencha os campos corretamente.");
                 
            } else
            {
                //Aqui nós iremos passar os textos inseridos pelo usuário como parâmetros
                Console.WriteLine(txtUsuario);
                Console.WriteLine(txtSenha);
                DAOLogin.autenticarFuncionario(txtUsuario.Text, txtSenha.Text);

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Chamar o método autenticação
            autenticacao();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}