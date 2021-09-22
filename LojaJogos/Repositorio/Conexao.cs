using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaJogos.Repositorio
{
    public class Conexao
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;database=bd_lojaasp;user=root;password='Pererinha12_'");
        
        public static string msg;

        public MySqlConnection ConectarBD()
        {
            try
            {
                conexao.Open();
            }
            catch(Exception erro)
            {
                msg = "Ocorreu um erro ao conectar" + erro.Message;
            }
            return conexao;
        }

        public MySqlConnection DesconectarBD()
        {
            try
            {
                conexao.Close();
            }
            catch(Exception erro)
            {
                msg = "Ocorreu um erro ao desconectar" + erro.Message;
            }
            return conexao;
        }
    }
}