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
    public partial class Frm_List_Estoque : Form
    {
        
        //Conexao o = new Conexao("Data Source=DESKTOP-7LHKOP8;Integrated Security=True\"\"Data Source=DESKTOP-7LHKOP8;Integrated Security=True");
        DAL_Produtos dal = new DAL_Produtos();
        public Frm_List_Estoque()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            GridResultado.DataSource = dal.CarregaDados();
            lblTotalRows.Text = Convert.ToString(GridResultado.RowCount);
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Frm_Add_Produto fadd = new Frm_Add_Produto();
            fadd.ShowDialog();
        }

        
    }
}
