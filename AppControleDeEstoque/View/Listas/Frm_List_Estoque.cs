using AppControleDeEstoque.Controller;
using AppControleDeEstoque.Model;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Math;
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
    public partial class Frm_List_Estoque : Form
    {
        
        Conexao o = new Conexao();
        DAL_Produtos dal = new DAL_Produtos();
        public Frm_List_Estoque()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            GridResultado.Columns.Clear();
            try
            {
                Grid.MontarGrid(GridResultado, "use CaixaPDV select COD AS Cód,CODBARRAS as [Código de Barras],Nome as [Nome do Produto],PRECO as Preço,QUANTIDADE AS Quantidade,DCRPRODUTO as Descrição, datcadastro as [Data de Cadastro] from Produto");

            DataGridViewImageColumn btnDel = new DataGridViewImageColumn();
            btnDel.Name = "DelCourrier";
            btnDel.HeaderText = "Editar";
            btnDel.Image = Properties.Resources.cesta_de_compras1;// delete is the name of the image added as ressource
            GridResultado.Columns.Add(btnDel);

                //for (int i = 0; i < GridResultado.RowCount - 1; i++)
                //{

                //    GridResultado.Rows[i].Cells[0].Value = btnDel;
                //}
            }
          
            catch { }
           
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Frm_Add_Produto fadd = new Frm_Add_Produto();
            fadd.ShowDialog();
        }
        

        private void Frm_List_Estoque_Load(object sender, EventArgs e)
        {
            Grid.MontarGrid(GridResultado,"use CaixaPDV select '','', COD AS Cód,CODBARRAS as [Código de Barras],Nome as [Nome do Produto],PRECO as Preço,QUANTIDADE AS Quantidade,DCRPRODUTO as Descrição, datcadastro as [Data de Cadastro] from Produto");

           

            //for (int i = 0; i < GridResultado.RowCount; i++)
            //{
            //    GridResultado.Rows[i].Cells[0].Value = Properties.Resources.cesta_de_compras1;
            //}

        }

      

        private void GridResultado_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow coluna = GridResultado.Rows[e.ColumnIndex];
                DataGridViewRow linha = GridResultado.Rows[e.RowIndex];

                if (coluna.Index == 0)
                {

                }
            }
            catch { }
            
           
        }

        public void Editar()
        {
            
            
        }
    }
}
