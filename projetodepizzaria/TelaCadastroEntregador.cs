using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class TelaCadastroEntregador : Form
    {
        public TelaCadastroEntregador()
        {
            InitializeComponent();
        }


        private void SetarCampos()
        {
            txtEntNome.Text = tblEntregador.CurrentRow.Cells["Nome"].Value.ToString();
            txtEntStatus.Text = tblEntregador.CurrentRow.Cells["Status"].Value.ToString();
            txtEntTelefone.Text = tblEntregador.CurrentRow.Cells["Telefone"].Value.ToString();


        }
       






        private void txtEntPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Enquanto o componente receber inserções de texto, iremos fazer a busca no Banco de Dados
        }

        private void Tela_CadastroEntregador_Load(object sender, EventArgs e)
        {
            DAOCadastroEntregador.ObterDados(tblEntregador);


        }

        private void tblEntregador_MouseClick(object sender, MouseEventArgs e)
        {
            //Quando for clicado, iremos setar os campos da tabela nos TextBox
            //Chamar método setar campos
            SetarCampos();


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Chamar método de Inserir novo entregador
            DAOCadastroEntregador.CadastrarEntregador(txtEntNome.Text, txtEntStatus.Text, txtEntTelefone.Text);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Chamar método de Update do entegador selecionado na tabela
            DAOCadastroEntregador.AtualizarEntregador(tblEntregador.CurrentRow.Cells["Código"].Value.ToString(), txtEntNome.Text, txtEntStatus.Text, txtEntTelefone.Text);


        }
    }
}
