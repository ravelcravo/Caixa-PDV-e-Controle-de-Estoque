using AppControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControleDeEstoque.Controller
{
    public class DAL_Produtos
    {
        Conexao o = new Conexao();

        public bool AddProduto(string codBarras, string nome, string preco,int qtd, string dcrProduto,string categoria)
        {
            try
            {

                string sql = "";

                sql = "insert into CaixaPDV..Produto (CODBARRAS,NOME,PRECO,QUANTIDADE,DCRPRODUTO,DATCADASTRO,STAPRODUTO,CATEGORIA) values(" + codBarras + " ,'" + nome + "'," + preco + "," + qtd + ",'" + dcrProduto + "',GETDATE(),1,'" + categoria  + "')";

                o.ExecSql(sql);

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex + "Exceção não tratada no método: 'Adicionar Produto'");
                return false;
            }

            MessageBox.Show("Produto Adicionado com Sucesso.");
            return true;
        }

        
    }
}
