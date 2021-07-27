using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Dapper.Contrib.Extensions;

namespace augusto
{
    public class ClienteDAO
    {   private string Mysql_Conexao = "Server=localhost;Database=Cliente;Uid=root;Pwd=;";
        private Cliente cliente;

        // public object JS { get; private set; } 

        public ClienteDAO()
        {

        }
        // CRUD     
        public void InserirCliente(Cliente cliente)
        {   
            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(Mysql_Conexao))
            {
                conn.Open();
                conn.Insert<Cliente>(cliente);
            }

        }
         public void AtualizarCliente(Cliente cliente)
        {   
            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(Mysql_Conexao))
            {
                conn.Open();
                conn.Update<Cliente>(cliente);
            }

        }
         public void ExcluirCliente(Cliente cliente)
        {   
            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(Mysql_Conexao))
            {
                conn.Open();
                conn.Delete<Cliente>(cliente);
            }

        }
         public IList <Cliente> PegarClientes()
        {   
            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(Mysql_Conexao))
            {
                conn.Open();
                return conn.GetAll<Cliente>().ToList();
            }

        }
        public Cliente PegarClienteByID(int id_Cliente)
        {   
            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(Mysql_Conexao))
            {
                conn.Open();
                return conn.Get<Cliente>(id_Cliente);
            }

        }


    }
    
}