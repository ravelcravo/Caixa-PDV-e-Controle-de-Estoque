using AppControleDeEstoque.Controller;
using AppControleDeEstoque.Model;
using Microsoft.VisualBasic.ApplicationServices;
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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace AppControleDeEstoque.View
{
    public partial class Frm_List_Estoque : Form
    {

        public Frm_List_Estoque()
        {
            InitializeComponent();
        }
        private void Frm_List_Estoque_Load(object sender, EventArgs e)
        {
            //MontarGrid();
        }
        private void btBuscar_Click(object sender, EventArgs e)
        {
            
            MontarGrid();

        }
        private void btNovo_Click(object sender, EventArgs e)
        {
            Frm_Add_Produto fadd = new Frm_Add_Produto();
            fadd.ShowDialog();
        }

        private void MontarGrid()
        {
            GridResultado.Columns.Clear();

            

            try
            {
                Gridd.MontarGrid(GridResultado, "use CaixaPDV select '' as ' ', COD AS Cód, CODBARRAS as [Código de Barras], Nome as [Nome do Produto],PRECO as Preço,QUANTIDADE AS Quantidade,DCRPRODUTO as Descrição, datcadastro as [Data de Cadastro] from Produto");
                Gridd.AlturaLinha(GridResultado, 30);

                GridResultado.Columns[0].Width = 30;
                GridResultado.Columns[1].Width = 50;
                GridResultado.Columns[2].Width = 100;
                GridResultado.Columns[3].Width = 100;
                GridResultado.Columns[4].Width = 50;
                GridResultado.Columns[5].Width = 50;
                GridResultado.Columns[6].Width = 160;
                GridResultado.Columns[7].Width = 140;


                lblTotalRows.Text = GridResultado.RowCount.ToString();
                DesenharGridEstoque();

                //DataGridViewImageColumn btnDel = new DataGridViewImageColumn();
                //btnDel.Name = "DelCourrier";
                //btnDel.HeaderText = "Editar";
                //btnDel.Image = Properties.Resources.cesta_de_compras1;// delete is the name of the image added as ressource
                //GridResultado.Columns.Add(btnDel);

                //for (int i = 0; i < GridResultado.RowCount - 1; i++)
                //{

                //    GridResultado.Rows[i].Cells[0].Value = btnDel;
                //}
            }

            catch { }
        }
        private void DesenharGridEstoque()
        {
            for (int i = 0; i < GridResultado.RowCount; i++)
            {
                var qtd = Convert.ToInt32(GridResultado.Rows[i].Cells[5].Value);
                if (qtd < 2)
                {
                    GridResultado.Rows[i].Cells[5].Style.BackColor = Color.FromArgb(255, 77, 77);
                }
                else if (qtd < 5)
                {
                    GridResultado.Rows[i].Cells[5].Style.BackColor = Color.FromArgb(255, 210, 77);
                }
                else
                {
                    GridResultado.Rows[i].Cells[5].Style.BackColor = Color.FromArgb(26, 255, 102);
                }
            }
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
