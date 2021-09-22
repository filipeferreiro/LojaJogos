using LojaJogos.Repositorio;
using MySql.Data.MySqlClient;
using LojaJogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaJogos.Repositorio /* ver se é controllers ou repositorio */
{
    public class Acoes
    {
        Conexao conexao = new Conexao();
        MySqlCommand command = new MySqlCommand();

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO tb_funcionario VALUES(@CodFuncionario,@NomeFuncionario,@CPFFuncionario,@RGFuncionario,@NascFuncionario,@EnderecoFuncionario,@CelFuncionario,@EmailFuncionario,@CargoFuncionario)", conexao.ConectarBD());
            command.Parameters.Add("@CodFuncionario", MySqlDbType.VarChar).Value = funcionario.CodFuncionario;
            command.Parameters.Add("@NomeFuncionario", MySqlDbType.VarChar).Value = funcionario.NomeFuncionario;
            command.Parameters.Add("@CPFFuncionario", MySqlDbType.VarChar).Value = funcionario.CPFFuncionario;
            command.Parameters.Add("@RGFuncionario", MySqlDbType.VarChar).Value = funcionario.RGFuncionario;
            command.Parameters.Add("@NascFuncionario", MySqlDbType.VarChar).Value = funcionario.NascFuncionario;
            command.Parameters.Add("@EnderecoFuncionario", MySqlDbType.VarChar).Value = funcionario.EnderecoFuncionario;
            command.Parameters.Add("@CelFuncionario", MySqlDbType.VarChar).Value = funcionario.CelFuncionario;
            command.Parameters.Add("@EmailFuncionario", MySqlDbType.VarChar).Value = funcionario.EmailFuncionario;
            command.Parameters.Add("@CargoFuncionario", MySqlDbType.VarChar).Value = funcionario.CargoFuncionario;
            command.ExecuteNonQuery();
            conexao.DesconectarBD();
        }

        public List<Funcionario> ListarFuncionario()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM tb_funcionario", conexao.ConectarBD());
            var DadosFuncionario = command.ExecuteReader();
            return ListarTodosFuncionarios(DadosFuncionario);
        }

        public List<Funcionario> ListarTodosFuncionarios(MySqlDataReader data)
        {
            var TodosFuncionarios = new List<Funcionario>();
            while (data.Read())
            {
                var FuncionarioTemp = new Funcionario()
                {
                    CodFuncionario = data["CodFuncionario"].ToString(),
                    NomeFuncionario = data["NomeFuncionario"].ToString(),
                    CPFFuncionario = data["CPFFuncionario"].ToString(),
                    RGFuncionario = data["RGFuncionario"].ToString(),
                    NascFuncionario = data["NascFuncionario"].ToString(),
                    EnderecoFuncionario = data["EnderecoFuncionario"].ToString(),
                    CelFuncionario = data["CelFuncionario"].ToString(),
                    EmailFuncionario = data["EmailFuncionario"].ToString(),
                    CargoFuncionario = data["CargoFuncionario"].ToString()
                };
                TodosFuncionarios.Add(FuncionarioTemp);
            }

            data.Close();
            return TodosFuncionarios;
        }

        public void CadastrarCliente(Cliente cliente)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO tb_cliente VALUES(@CPFCliente,@NomeCliente,@NascCliente,@EnderecoCliente,@CelCliente,@EmailCliente)", conexao.ConectarBD());
            command.Parameters.Add("@CPFCliente", MySqlDbType.VarChar).Value = cliente.CPFCliente;
            command.Parameters.Add("@NomeCliente", MySqlDbType.VarChar).Value = cliente.NomeCliente;
            command.Parameters.Add("@NascCliente", MySqlDbType.VarChar).Value = cliente.NascCliente;
            command.Parameters.Add("@EnderecoCliente", MySqlDbType.VarChar).Value = cliente.EnderecoCliente;
            command.Parameters.Add("@CelCliente", MySqlDbType.VarChar).Value = cliente.CelCliente;
            command.Parameters.Add("@EmailCliente", MySqlDbType.VarChar).Value = cliente.EmailCliente;
            command.ExecuteNonQuery();
            conexao.DesconectarBD();
        }

        public List<Cliente> ListarCliente()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM tb_cliente", conexao.ConectarBD());
            var DadosCliente = command.ExecuteReader();
            return ListarTodosClientes(DadosCliente);
        }

        public List<Cliente> ListarTodosClientes(MySqlDataReader data)
        {
            var TodosClientes = new List<Cliente>();
            while (data.Read())
            {
                var ClienteTemp = new Cliente()
                {
                    CPFCliente = data["CPFCliente"].ToString(),
                    NomeCliente = data["NomeCliente"].ToString(),
                    NascCliente = data["NascCliente"].ToString(),
                    EnderecoCliente = data["EnderecoCliente"].ToString(),
                    CelCliente = data["CelCliente"].ToString(),
                    EmailCliente = data["EmailCliente"].ToString()
                };
                TodosClientes.Add(ClienteTemp);
            }

            data.Close();
            return TodosClientes;
        }

        public void CadastrarJogo(Jogo jogo)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO tb_jogo VALUES(@CodJogo,@NomeJogo,@VersaoJogo,@DesJogo,@GeneroJogo,@EtariaJogo,@PlatJogo,@AnoJogo,@SinopseJogo)", conexao.ConectarBD());
            command.Parameters.Add("@CodJogo", MySqlDbType.VarChar).Value = jogo.CodJogo;
            command.Parameters.Add("@NomeJogo", MySqlDbType.VarChar).Value = jogo.NomeJogo;
            command.Parameters.Add("@VersaoJogo", MySqlDbType.VarChar).Value = jogo.VersaoJogo;
            command.Parameters.Add("@DesJogo", MySqlDbType.VarChar).Value = jogo.DesJogo;
            command.Parameters.Add("@GeneroJogo", MySqlDbType.VarChar).Value = jogo.GeneroJogo;
            command.Parameters.Add("@EtariaJogo", MySqlDbType.VarChar).Value = jogo.EtariaJogo;
            command.Parameters.Add("@PlatJogo", MySqlDbType.VarChar).Value = jogo.PlatJogo;
            command.Parameters.Add("@AnoJogo", MySqlDbType.VarChar).Value = jogo.AnoJogo;
            command.Parameters.Add("@SinopseJogo", MySqlDbType.Text).Value = jogo.SinopseJogo;
            command.ExecuteNonQuery();
            conexao.DesconectarBD();
        }

        public List<Jogo> ListarJogo()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM tb_jogo", conexao.ConectarBD());
            var DadosJogo = command.ExecuteReader();
            return ListarTodosJogos(DadosJogo);
        }

        public List<Jogo> ListarTodosJogos(MySqlDataReader data)
        {
            var TodosJogos = new List<Jogo>();
            while (data.Read())
            {
                var JogoTemp = new Jogo()
                {
                    CodJogo = data["CodJogo"].ToString(),
                    NomeJogo = data["NomeJogo"].ToString(),
                    VersaoJogo = data["VersaoJogo"].ToString(),
                    DesJogo = data["DesJogo"].ToString(),
                    GeneroJogo = data["GeneroJogo"].ToString(),
                    EtariaJogo = data["EtariaJogo"].ToString(),
                    PlatJogo = data["PlatJogo"].ToString(),
                    AnoJogo = data["AnoJogo"].ToString(),
                    SinopseJogo = data["SinopseJogo"].ToString(),
                };
                TodosJogos.Add(JogoTemp);
            }

            data.Close();
            return TodosJogos;
        }
    }
}