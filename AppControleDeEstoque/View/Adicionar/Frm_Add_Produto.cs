using AppControleDeEstoque.Controller;
using AppControleDeEstoque.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControleDeEstoque.View
{
    public partial class Frm_Add_Produto : Form
    {
        public bool tem;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        DAL_Produtos dal = new DAL_Produtos();
        public Frm_Add_Produto()
        {
            InitializeComponent();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                dal.AddProduto(Convert.ToString(txbCodBarras.Text), Convert.ToString(txbNomeProduto.Text), Convert.ToString(txbPrecoProduto.Text.Replace(",", ".")), Convert.ToInt32(txbQtdProdutoCadastrar.Text), Convert.ToString(txbDescricaoProduto.Text),cboCategoria.Text);

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Erro não tratado no método Gravar/Novo");

            }
            txbNomeProduto.Focus();
        }

        private void btGravarSair_Click(object sender, EventArgs e)
        {
            try
            {
                dal.AddProduto(Convert.ToString(txbCodBarras.Text), Convert.ToString(txbNomeProduto.Text), Convert.ToString(txbPrecoProduto.Text.Replace(",",".")), Convert.ToInt32(txbQtdProdutoCadastrar.Text), Convert.ToString(txbDescricaoProduto.Text),cboCategoria.Text);

                LimparCampos();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Erro não tratado no método Gravar/Sair");
            }
        }

        private void LimparCampos()
        {
            txbCodBarras.Text = "";
            txbDescricaoProduto.Text = "";
            txbNomeProduto.Text = "";
            txbPrecoProduto.Text = "";
            txbQtdProdutoCadastrar.Text = "";

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparCampos();
                Close();
            }
            catch
            {

            }
        }

        private bool ValidarCampos()
        {
            if (txbNomeProduto.Text == "")
            {
                MessageBox.Show("Informe o nome do produto.");
                txbNomeProduto.Focus();
                return false;
            }
            if (txbQtdProdutoCadastrar.Text == "")
            {
                MessageBox.Show("Informe a quantidade a ser cadastrada no banco.");
                txbQtdProdutoCadastrar.Focus();
                return false;
            }
           
            if (txbCodBarras.Text == "")
            {
                MessageBox.Show("Informe o código de barras do produto.");
                txbCodBarras.Focus();
                return false;
            }
            if(txbDescricaoProduto.Text == "")
            {
                MessageBox.Show("Informe a descrição do produto.");
                txbDescricaoProduto.Focus();
                return false;
            }
           
            if (txbPrecoProduto.Text == "")
            {
                MessageBox.Show("Informe o preço do produto.");
                txbPrecoProduto.Focus();
                return false;
            }
           

            return true;
        }
        private void Frm_Add_Produto_Load(object sender, EventArgs e)
        {
            Combos.GetCategorias(cboCategoria,"S");

        }

        private void txbCodBarras_TextChanged(object sender, EventArgs e)
        {
            if (txbCodBarras.Text.Length > 13)
            {
                MessageBox.Show("O código de barras deve conter no max 13 carateres");
                txbCodBarras.Clear();
                txbCodBarras.Focus();
                return;
            }
        }
    }
}
