using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace DesktopApp
{
    public partial class TelaCadastroProduto : Form
    {
        public TelaCadastroProduto()
        {
            InitializeComponent();
        }

       public static double valor;

     

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

     

        private void TelaCadastroProduto_Load(object sender, EventArgs e)
        {
            DAOCadastroProduto.ObterDados(tblProdutos);
        }

        private void tblProdutos_MouseClick(object sender, MouseEventArgs e)
        {
            txtCodigo.Text = tblProdutos.CurrentRow.Cells["Código"].Value.ToString();
            txtNome.Text = tblProdutos.CurrentRow.Cells["Nome"].Value.ToString();
            cboCategoria.SelectedItem = tblProdutos.CurrentRow.Cells["Categoria"].Value.ToString();
            txtDescricao.Text = tblProdutos.CurrentRow.Cells["Descrição"].Value.ToString();
            txtValor.Text = tblProdutos.CurrentRow.Cells["Valor"].Value.ToString();
            cboUnidade.SelectedItem = tblProdutos.CurrentRow.Cells["Medida"].Value.ToString();



        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            DAOCadastroProduto.CadastrarProduto(txtNome.Text, cboCategoria.SelectedItem.ToString(), valor.ToString(), txtDescricao.Text, cboUnidade.SelectedItem.ToString());
            DAOCadastroProduto.ObterDados(tblProdutos);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DAOCadastroProduto.AlterarProduto(txtNome.Text, cboCategoria.SelectedItem.ToString(), valor.ToString(), txtDescricao.Text, cboUnidade.SelectedItem.ToString(), txtCodigo.Text);
            DAOCadastroProduto.ObterDados(tblProdutos);
        }



        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(txtPesquisarProd.Text != "" || txtPesquisarProd.Text != "Pesquisar por nome")
            {
                DAOCadastroProduto.PesquisarPorNome(tblProdutos, txtPesquisarProd.Text);


            } else
            {
                MessageBox.Show("Informe um nome válido!");

            }
        }

        private void txtPesquisarProd_Leave(object sender, EventArgs e)
        {
            txtPesquisarProd.Text = "Pesquisar por nome";
        }

        private void txtPesquisarProd_MouseClick(object sender, MouseEventArgs e)
        {
            txtPesquisarProd.Text = "";
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            int i = txtValor.Text.IndexOf(",");
            if (txtValor.Text.Contains(","))
            {
                valor = Convert.ToDouble(txtValor.Text.Replace(",", "."));
            } else
            {
                valor = Convert.ToDouble(txtValor.Text);
            }
                       
            double formatar = Convert.ToDouble(txtValor.Text.Replace("R$", ""));
            txtValor.Text = formatar.ToString("C2", CultureInfo.CreateSpecificCulture("pt-BR"));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            txtNome.Text = "";
            txtValor.Text = "";
            cboCategoria.Text = "";
            cboUnidade.Text = "";
        }
    }
}
