using AppControleDeEstoque.Controller;
using AppControleDeEstoque.Model;
using AppControleDeEstoque.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControleDeEstoque
{
    public partial class Frm_Caixa : Form
    {

        public Frm_Caixa()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Add_Produto f = new Frm_Add_Produto();
            f.ShowDialog();
        }

        private void btEstoque_Click(object sender, EventArgs e)
        {
            Frm_List_Estoque f = new Frm_List_Estoque();
            f.Show();
        }
        private void BuscarProduto()
        {
            Conexao o = new Conexao();


            string sqlVerifica = "";


            sqlVerifica += "use CaixaPDV Select count(*) from Produto Where CODBARRAS = " + txbCodBarras.Text;

            var produto = o.GetValorInt(sqlVerifica, 0);

            if (produto < 1)
            {
                MessageBox.Show("Produto não cadastrado.");

            }
            else
            {

                string sql = "";
                sql += " use CaixaPDV Select COD,CODBARRAS,NOME,PRECO,QUANTIDADE,DCRPRODUTO from Produto Where CODBARRAS =" + txbCodBarras.Text;
                lblPrecoUnitario.Text = Convert.ToString(o.GetValorDecimal(sql, 3));
                lblQuantidade.Text = Convert.ToString(o.GetValorInt(sql,4));
                lblDescProduto.Text = o.GetValorString(sql,5);

            }
        }

        private void txbCodBarras_TextChanged(object sender, EventArgs e)
        {

        inicio:
            if (txbCodBarras.Text.Length > 12)
            {
                if (Sistema.FinalizarVenda == false)

                    BuscarProduto();
                    txbCodBarras.Text = "";
                    

                goto inicio;


            }

        }

        private void Frm_Caixa_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            lblDesconto.Text = "";
            lblDescProduto.Text = "";
            lblPrecoUnitario.Text = "";
            lblQtdTotalItens.Text = "";
            lblQuantidade.Text = "";
            lblTotalPorProduto.Text = "";
            lblTroco.Text = "";
            lblValorRecebido.Text = "";
            lblTotal.Text = "";
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
