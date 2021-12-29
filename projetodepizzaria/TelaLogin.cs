namespace projetodepizzaria
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
           

            //Buscando imagem do status banco utilizando o a classe Image.System.Drawing.Image
            Image bdAtivo = Image.FromFile("C:\\Users\\TESTE\\source\\repos\\projetodepizzaria\\projetodepizzaria\\Image\\icone-BDAtivo.png");

            Image bdInativo = Image.FromFile("C:\\Users\\TESTE\\source\\repos\\projetodepizzaria\\projetodepizzaria\\Image\\icone-BDInativo.png");

            if (Conn.Conectar()) {
                //A linha abaixo define o tamanho da labek de acordo com o tamannho da imagem.
                txtBancoStatus.Size = new Size(bdAtivo.Width, bdAtivo.Height);
                //A linha abaixo define a imagem bdAtivo para a label
                txtBancoStatus.Image = bdAtivo;

            } else
            {
                txtBancoStatus.Size = new Size(bdInativo.Width, bdInativo.Height);
                txtBancoStatus.Image = bdInativo;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Conn.Conectar())
            {
                MessageBox.Show("Conectado com sucesso!");

            } else
            {
                MessageBox.Show("Não conseguimos conectar!");
            }
        
        }

       
    }
}