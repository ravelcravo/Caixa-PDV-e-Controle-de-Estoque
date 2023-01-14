using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;

namespace AppControleDeEstoque.Model
{

    /*
     O método ExecuteNonQuery é utilizado para executar instruções SQL que não retornam dados, como Insert, Update, Delete, e Set.
     O método ExecuteReader é utilizado para executar uma instrução SQL que retorna um DataReader.   
     O método ExecuteScalar é utilizado para executar instruções SQL utilizando funções agregadas, como COUNT, SUM, MIN, MAX e AVG. Este método retorna apenas um valor como resultado.
     contato.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
     */
    public class Conexao
    {
       
        private bool disposedValue;
        public string Erro;
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
       SqlDataReader dr;
        //public Conexao()
        //{
        //    ds = new DataSet();
        //    Erro = "";
        //    disposedValue = false;
        //}
        public void ExecSql(string sql)
        {
            //conectar();
            cmd.Connection = conectar();
            cmd.CommandText = (sql);

            cmd.ExecuteNonQuery();
            desconectar();
        }

        public int GetValorInt(string sql,int posicao)
        {
            int valor;

            cmd.Connection = conectar();
            cmd.CommandText = (sql);

            dr = cmd.ExecuteReader();
            //Os dados estarão disponíveis nesse objeto de reader aqui.
            dr.Read();

            valor = Convert.ToInt32(dr.GetInt32(posicao));

            dr.Close();

            return valor;

        }
        public string GetValorString(string sql, int posicao)
        {
            string valor = "";

            cmd.Connection = conectar();
            cmd.CommandText = (sql);

            dr = cmd.ExecuteReader();
            //Os dados estarão disponíveis nesse objeto de reader aqui.
            dr.Read();

            valor = dr.GetString(posicao);

            dr.Close();

            return valor;

        }

        //public string GetValor(string Coluna, int Linha = 0, int Tabela = 0)
        //{
        //    Erro = "";
        //    string text = "";
        //    try
        //    {
        //        text = ds.Tables[Tabela].Rows[Linha][Coluna].ToString().Trim();
        //        switch (Dados.DB_LETRAS)
        //        {
        //            case Dados.TipoLetra.Maiuscula:
        //                text = text.ToUpper();
        //                break;
        //            case Dados.TipoLetra.Minuscula:
        //                text = text.ToLower();
        //                break;
        //        }

        //        return text;
        //    }
        //    catch (Exception ex)
        //    {
        //        ProjectData.SetProjectError(ex);
        //        Exception ex2 = ex;
        //        string result;
        //        try
        //        {
        //            Erro = ds.Tables[0].Rows[0][0].ToString().Trim() + " => " + ds.Tables[0].Rows[0][1].ToString().Trim();
        //            result = "{" + Coluna + "}";
        //        }
        //        catch (Exception ex3)
        //        {
        //            ProjectData.SetProjectError(ex3);
        //            Exception ex4 = ex3;
        //            Erro = ex2.Message;
        //            result = "{" + Coluna + "}";
        //            ProjectData.ClearProjectError();
        //        }

        //        ProjectData.ClearProjectError();
        //        return result;
        //    }
        //}
        //public string GetValor(string Texto,string valor1,string valor2 = "\n",bool comquebralinha = false)
        //{
        //    try
        //    {
        //        if(valor1 != ""){
        //            Texto = Texto.Substring(Texto.IndexOf(valor1) + valor1.Length);
        //        }
        //        if (valor2 != "")
        //        {
        //            Texto = Texto.Substring(0,Texto.IndexOf(valor2));
        //        }
        //        if (!comquebralinha)
        //        {
        //            Texto = Texto.Replace("\n", "").Replace("\r", "").Trim();
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        Texto = "";
        //    }
        //    return Texto;
        //}
        public DateTime GetDate (string sql, int posicao)
        {
            DateTime valor;

            cmd.Connection = conectar();
            cmd.CommandText = (sql);

            dr = cmd.ExecuteReader();
            //Os dados estarão disponíveis nesse objeto de reader aqui.
            dr.Read();

            valor = Convert.ToDateTime(dr.GetDateTime(posicao));

            dr.Close();

            return valor;

        }
        public double GetValorDouble(string sql, int posicao)
        {
            double valor = 0.0;

            cmd.Connection = conectar();
            cmd.CommandText = (sql);

            dr = cmd.ExecuteReader();
            //Os dados estarão disponíveis nesse objeto de reader aqui.
            dr.Read();

            valor = Convert.ToDouble(dr. GetDouble(posicao));

            dr.Close();

            return valor;

        }
        public decimal GetValorDecimal(string sql, int posicao)
        {
            decimal valor = 0;

            cmd.Connection = conectar();
            cmd.CommandText = (sql);

            dr = cmd.ExecuteReader();
            //Os dados estarão disponíveis nesse objeto de reader aqui.
            dr.Read();

            valor = dr.GetDecimal(posicao);

            dr.Close();

            return valor;

        }
        public SqlConnection conectar()
        {

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.ConnectionString = @"Data Source=DESKTOP-7LHKOP8;Integrated Security=True";
                con.Open();
            }
            return con;

        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        #region Conexaoantiga


        //private String _stringConexao;
        //private SqlConnection _conexao;

        //public Conexao(String dadosConexao)
        //{
        //    this._conexao = new SqlConnection();
        //    this.StringConexao = dadosConexao;
        //    this._conexao.ConnectionString = dadosConexao;
        //}

        //public String StringConexao
        //{
        //    get { return this._stringConexao; }
        //    set { this._stringConexao = value; }

        //}
        //public SqlConnection ObjetoConexao
        //{
        //    get { return this._conexao; }
        //    set { this._conexao = value; }

        //}

        //public void Conectar()
        //{
        //    this._conexao.Open();
        //}

        //public void Desconectar()
        //{
        //    this._conexao.Close();
        //}
        #endregion
    }
}
