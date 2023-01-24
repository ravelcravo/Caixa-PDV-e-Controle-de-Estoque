using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AppControleDeEstoque.Controller
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Preco { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public string CodBarras { get; set; }

        public decimal precoTotalPorItem { get; set; }

        //public string Categoria { get; set; }

        
        public Produto(string nome , string preco, string descricao, int quantidade, string codBarras)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
            Quantidade = quantidade;
            CodBarras = codBarras;
            //Categoria = categoria;
        }

        public static List <Produto> GetListaProdutos()
        {
            //instanciar um objeto lista de produtos
            var listaProdutos = new List<Produto>();

            listaProdutos.Add(new Produto("SAL","11.90","sal do himalaia",2,"99999999999999"));

            return listaProdutos;
        }
    }
}
