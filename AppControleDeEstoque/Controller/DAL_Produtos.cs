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

        public bool AddProduto(string codBarras, string nome, string preco,int qtd, string dcrProduto)
        {
            try
            {

                string sql = "";

                sql = "insert into CaixaPDV..Produto (CODIGODEBARRAS,NOME,PRECO,QUANTIDADE,DCRPRODUTO,DATCADASTRO) values(" + codBarras + " ,'" + nome + "'," + preco + "," + qtd + ",'" + dcrProduto + "',GETDATE())";

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
        public DataTable CarregaDados()
        {
           
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("use CaixaPDV select CODIGO AS Cód,CODIGODEBARRAS as [Código de Barras],Nome as [Nome do Produto],PRECO as Preço,QUANTIDADE AS Quantidade,DCRPRODUTO as Descrição, datcadastro as [Data de Cadastro] from Produto", o.conectar());
                da.Fill(dt);
                return dt;
        }

        
    }
}
