namespace projetodepizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Conn.Conectar())
            {
                MessageBox.Show("Conectado com sucesso!");

            } else
            {
                MessageBox.Show("N�o conseguimos conectar!");
            }
        
        }
    }
}