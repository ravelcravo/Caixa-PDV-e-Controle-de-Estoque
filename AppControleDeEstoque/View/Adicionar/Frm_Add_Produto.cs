using AppControleDeEstoque.Controller;
using AppControleDeEstoque.Model;
using System;
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
            try
            {
                dal.AddProduto(Convert.ToString(txbCodBarras.Text), Convert.ToString(txbNomeProduto.Text), Convert.ToString(txbPrecoProduto.Text), Convert.ToInt32(txbQtdProdutoCadastrar.Text), Convert.ToString(txbDescricaoProduto.Text));

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Erro não tratado no método Gravar/Novo");

            }

        }

        private void btGravarSair_Click(object sender, EventArgs e)
        {
            try
            {
                dal.AddProduto(Convert.ToString(txbCodBarras.Text), Convert.ToString(txbNomeProduto.Text), Convert.ToString(txbPrecoProduto.Text), Convert.ToInt32(txbQtdProdutoCadastrar.Text), Convert.ToString(txbDescricaoProduto.Text));

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
    }
}
