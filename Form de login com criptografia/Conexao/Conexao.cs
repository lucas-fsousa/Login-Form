using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_v2 {
    public class Conexao {
        SqlConnection con = new SqlConnection(); // Instancia o objeto con do tipo SqlConnection

        // Definição do método construtor
        public Conexao() {
            // Essa string é o endereço do banco de dados
            con.ConnectionString = @"Data Source=LUCAS;Initial Catalog=Banco_Teste;Integrated Security=True";
        }

        // Método para conectar-se ao banco de dados.
        public SqlConnection Conectar() {
            //Verifica se o banco de dados está fechado
            if(con.State == System.Data.ConnectionState.Closed) {
                con.Open(); // Abre uma conexão segura com o banco de dados
            }
            return con; // Retorna um valor do tipo SqlConnection
        }

        public void Desconectar() {
            //Verifica se o banco de dados está aberto
            if(con.State == System.Data.ConnectionState.Open) {
                con.Close(); // Fecha a conexão com o banco de dados.
            }
        }

    }
}
