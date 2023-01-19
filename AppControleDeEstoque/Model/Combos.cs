using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppControleDeEstoque.Model
{
    public static class Combos
    {

        public static void MontarCombos(System.Windows.Forms.ComboBox combo, string tipo, string sql)
        {
            Conexao o = new Conexao();
            String scom = sql;
            SqlDataAdapter da = new SqlDataAdapter(scom, o.conectar());
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();
            //o ponto mais importante (limpa a table antes de preenche-la)
            
            if (tipo == "T"){combo.Items.Add("Todos");}

            combo.DataSource = null;
            da.Fill(dtResultado);
            combo.DataSource = dtResultado;
            combo.ValueMember = "CATEGORIA";
            combo.DisplayMember = "CATEGORIA";
            combo.SelectedItem = "";
            if (tipo == "S") { combo.Text = "Selecione"; }
            combo.Refresh();

        }

        public static void GetCategorias(System.Windows.Forms.ComboBox combo, string Tipo,string sql ="")
        {
            MontarCombos(combo, Tipo, "use CaixaPDV select * from Nicho");
        }


    }
}
