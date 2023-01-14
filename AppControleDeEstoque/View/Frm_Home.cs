using AppControleDeEstoque.View.Adicionar;
using AppControleDeEstoque.View.Listas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControleDeEstoque.View
{
    public partial class Frm_Home : Form
    {
        private Form frmAtivo;

        bool sidebarExpand;
        public Frm_Home()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if(frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control control in sidebarContainer.Controls)
            {
                control.ForeColor = Color.White;
            }

            frmAtivo.ForeColor = Color.Red;
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {

            //set the minium and maxium size
            if (sidebarExpand)
            {
                //if sidebar is expand,minimize
                sidebarContainer.Width -= 10;

                if(sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;

                if(sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            ActiveButton(btnCaixa);
            FormShow(new Frm_Caixa());
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            ActiveButton(btnSobre);
            ActiveFormClose();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            ActiveButton(btnEstoque);
            FormShow(new Frm_List_Estoque());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActiveButton(btnClientes);
            FormShow(new Frm_List_Clientes());
        }

        private void btnMetricas_Click(object sender, EventArgs e)
        {
            ActiveButton(btnMetricas);
            FormShow(new Frm_Metricas());
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            ActiveButton(btnVendas);
            FormShow(new Frm_List_Vendas());
        }

       
    }
}
