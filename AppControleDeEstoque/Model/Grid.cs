﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Drawing;

namespace AppControleDeEstoque.Model
{
    public static class Grid
    {
        
        public static void MontarGrid(DataGridView grid,string sql)
        {
            Conexao o = new Conexao();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, o.conectar());
            da.Fill(ds);
            grid.DataSource = ds;
            grid.DataMember = ds.Tables[0].TableName;

            //for (int row = 0; row < grid.Rows.Count - 1; row++)
            //{
            //    Bitmap bmp = new Bitmap(Application.StartupPath + "\\Data\\AirPlaneData\\" + dt.Rows[row][4]);
            //    ((DataGridViewImageCell)grid.Rows[row].Cells[5]).Value = bmp;
            //}

        }

        public static void AlterarTituloColuna(ADGV.AdvancedDataGridView grid,string titulo,int numeroNoluna)
        {
            grid.Columns[numeroNoluna].HeaderText = titulo;
        }
    }
}