using Projeto_v2.Apresentacao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_v2 {
    public class Controle {

        public string mensagem = ""; // Define uma string para armazenar os valores de mensagens para o usuario
        private bool validar = false; // Atributo do tipo booleano para receber a validação de user inicializado como falso
        public bool trocar = false;

        SqlCommand cmd = new SqlCommand(); //Instancia a classe responsavel pelos comandos SQL
        Validar_infos vi = new Validar_infos(); // Instancia a classe de validação de inforamções do formulario
        SqlDataReader dr; // Instancia de atributo do tipo SqlReader que será responsável pela leitura de dados no banco
        Conexao conexao = new Conexao(); // Instancia a classe para fazer a conexão com o banco de dados

        // Método para logar ao sistema (este fará a verificação da existência do usuario no banco)
        public bool Logar(string login, string senha) {
            this.validar = false;
            if(vi.Valida_login(login, senha)) {// Verifica se o login e senha digitado é válido
                senha = string.Concat(login, senha);
                senha = vi.Codificar(senha); // Criptografa a senha

                // o comand text é a QUERY que sera executada no banco de dados;
                cmd.CommandText = "SELECT * FROM cadastro WHERE login = @login AND senha = @senha;";
                cmd.Parameters.AddWithValue("@login", login); // O valor contido na varaivel login será armazenado em @login
                cmd.Parameters.AddWithValue("@senha", senha); // O valor contido na varaivel senha será armazenado em @login

                // Este bloco será o responsável pela execução da tarefa no banco de dados
                try {// se tudo ocorrer bem, somente o TRY sera executado, em caso de erro, será direcionado ao CATCH

                    cmd.Connection = conexao.Conectar(); // Abre uma conexao com o banco de dados
                    dr = cmd.ExecuteReader(); // Armazena as informações do banco de dados dentro do atributo de leitura DR

                    if(dr.HasRows) {//Verifica se houve retorno de dados do banco
                        dr.Read(); // Realiza a leitura dos dados do objeto DataReader
                        string pass_auto = dr.GetString(5); // Coleta as informações da 4° coluna do banco de dados e armazena na string auto_pass
                        
                        if(pass_auto.Equals("true")) { // Verifica se o valor da string auto_pass é igual a true
                            this.trocar = true; // Define o valor da variavel de troca como verdadeiro para que o usuario seja direcionado para a tela de alteração de senha
                            this.validar = false; // define valor falso na variavel de validar, informa que o usuário não é válido (precisa trocar a senha)
                        } else {
                            this.validar = true; // define valor verdadeiro na variavel de validação
                            this.mensagem = "Usuário autenticado com sucesso"; // Inclusão de informação na string de mensagem
                        }
                    
                    } else {
                        this.mensagem = "Usuário não localizado na sessão de cadastros."; // Inclusão de informação na string de mensagem
                    }
                    dr.Close(); // Fecha o leitor de informações do banco de dados  

                } catch(SqlException) { // se houver erro durante a execução do TRY, este bloco será executado para tratar o erro
                    this.mensagem = "Ocorreu um erro durante a conexão com o banco de dados";

                } finally {
                    conexao.Desconectar(); // fecha a conexão com o banco de dados
                }
            } else {
                this.mensagem = vi.resp_validacao; // Define o valor da mensagem de usuário
                this.validar = vi.ok; // define o valor da variavel de validação
            
            }
            return this.validar; // retorna a validação do usuário
        }

        // Método para cadastrar um usuário
        public bool Cadastrar(string login, string email) {
            DateTime data = DateTime.Now; // Define uma variavel do tipo Datetime para armazenar informações de data e hora atuais

            this.validar = false;
            string senha = vi.Gerar_senha(); // Define uma string para receber um valor randomico retornado pelo metodo de gerar senha
            string temp = senha; // define uma string que armazenará o valor temporario da senha
            string auto_pass = "true" ; // Variavel para declaração de password gerado automaticamente pelo sistema

            senha = string.Concat(login, senha);// A senha receberá a concatenação dela mesma com o login
            senha = vi.Codificar(senha); // Criptografa a senha

            cmd.CommandText = "INSERT INTO cadastro VALUES (@login, @senha, @data, @email, @auto_pass);"; // QUERY A SER EXECUTADA NO BANCO
            cmd.Parameters.AddWithValue("@login", login); // Transfere as informações da variavel de login para @login
            cmd.Parameters.AddWithValue("@senha", senha); // Transfere as informações da variavel de senha para @senha
            cmd.Parameters.AddWithValue("@data", data); // Transfere as informações da variavel data local para @data
            cmd.Parameters.AddWithValue("@email", email); // Transfere as informações da variavel email para @email
            cmd.Parameters.AddWithValue("@auto_pass", auto_pass); // Transfere as informações da variavel auto_pass para @auto_pass
            
            try {//Este bloco tentará conectar e executar a instrução no banco de dados

                cmd.Connection = conexao.Conectar(); // Realiza a conexão segura com o banco de dados
                cmd.ExecuteNonQuery(); // Executa o comando SQL contido no CommandText
                send_mail(email, "Senha de login na plataforma", login, temp); // Envia um e-mail para o usuario com a senha gerada automaticamente
                this.validar = true; // a validação do usuario recebera verdadeiro
                this.mensagem = "Usuário cadastrado com sucesso! Sua senha foi enviada para o e-mail: "+email+"! Verifique sua caixa de spam/Lixo eletrônico."; // atribuição de mensagem para o usuario
                temp = ""; // define a string temporaria como Vazia
            } catch(SqlException) {
                this.mensagem = "Ops. Algo deu errado."; // atribuição de mensagem para o usuario

            } finally {
                conexao.Desconectar(); // fecha a conexão com o banco de dados
            }
            return this.validar; // retorna a validação do usuário
        }

        //Método para enviar um e-mail com a senha do usuário
        public string send_mail(string cli_mail, string assunto, string login, string senha) {
            string msg = ""; // define a string de mensagem
            SmtpClient client = new SmtpClient(); // instancia a classe Smtp para fazer a tratativa das transmissões
            
            client.Host = "smtp.office365.com"; // Define o host que fará a transmissão do e-mail
            client.EnableSsl = true;
            // Define o login e a senha do e-mail que fará o envio das informações (dever ser @hotmail)
            client.Credentials = new NetworkCredential("autoreplynewpassword@hotmail.com", "9iamcEu8cGiBCfAbRpQ6");
            
            MailMessage mail = new MailMessage(); // Instancia a classe de Mail responsavel pela composição do e-mail
            
            // Define o e-mail que ficará visivel e o nome do e-mail
            mail.Sender = new MailAddress("autoreplynewpassword@hotmail.com", "E-mail de testes");
            mail.From = new MailAddress("autoreplynewpassword@hotmail.com", "E-mail de testes");
            // Define o e-mail do cliente que receberá as informações
            mail.To.Add(new MailAddress(cli_mail, login));
            mail.Subject = assunto; // Define o assunto do e-mail
            // Informação que ficará no corpo do e-mail
            mail.Body = "Olá " + login + "! Sua nova senha é: " + senha;
            mail.IsBodyHtml = true; // Informa que o corpo do e-mail é do tipo HTML
            mail.Priority = MailPriority.High; // Define a prioridade do e-mail como alta

            try { // Tenta executar o envio do e-mail, caso de erro, executa o bloco Catch
                client.Send(mail); // Envia o email
                msg = "Email enviado com sucesso!"; // Atribuição de mensagem informativa na variavel msg
            } catch(Exception) {
                msg = "Ocorreu o erro durante o envio da nova senha"; // Atribuição de mensagem informativa na variavel msg
            }
            return msg; // retorna a mensagem informativa
        }

        // Método para trocar a senha do usuário
        public bool troca_senha(string login, string senha, string re_senha) {
            this.validar = false; // define valor booleano falso a variavel de validação
            if(vi.Valida_Cad(login, senha, re_senha)) {
                senha = string.Concat(login, senha); // concatena a o login e a senha dentro da variavel senha
                senha = vi.Codificar(senha); // codifica a senha do usuario
                string auto_pass = "false"; // Definição de variavel string
                DateTime data = DateTime.Now;  // Define uma variavel do tipo DateTime para receber informações de data e hora atuais
                // Bloco onde é definidade a Query do banco de dados e atribuição dos valores a serem utilizados na query
                cmd.CommandText = "update cadastro set senha = @senha, data_creat_senha = @data, auto_pass = @auto_pass where login = @login;";
                cmd.Parameters.AddWithValue("@login", login); // Atribui o valor da variavel login em @login
                cmd.Parameters.AddWithValue("@senha", senha); // atribui o valor da variavel senha em @senha
                cmd.Parameters.AddWithValue("@data", data); // Atribui o valor da variavel data em @data
                cmd.Parameters.AddWithValue("@auto_pass", auto_pass); // atribui o valor da variavel auto_pass em @auto_pass

                // Tenta executar as instruções no banco de dados, se houver falha, executa o bloco Catch
                try {
                    cmd.Connection = conexao.Conectar(); // Abre uma conexão segura com o banco de dados
                    cmd.ExecuteNonQuery(); // executa a Query no banco de dados
                    this.mensagem = "Senha alterada com sucesso"; // Atribuição de valor na variavel de mensagem
                    this.validar = true; // define a validação de usuario como verdadeira
                
                } catch(SqlException) {
                    this.mensagem = "Ocorreu um erro durante a conexão com o banco de dados";
                
                } finally { // idependente se houver falha ou não, este bloco é executado
                    conexao.Desconectar(); // fecha a conexão com o banco de dados
                }
            } else {
                this.mensagem = vi.resp_validacao; // atribui a mensagem de validação do usuario na variavel mensagem
            }
            return validar; // retorna a validação do usuário
        }
        public bool check_disp_login(string str) {
            this.validar = false; // define falso para validar login em uso
            this.mensagem = "";

            cmd.CommandText = "select login from cadastro where login = @login;";
            cmd.Parameters.AddWithValue("@login", str); // atribui o valor da variavel str em @login

            try {
                cmd.Connection = conexao.Conectar(); // Realiza uma conexão segura com o banco de dados
                dr = cmd.ExecuteReader();
                if(dr.HasRows) {
                    this.validar = true; // Atribui valor verdadeiro a variavel de validação
                }
            } catch(SqlException) {
                this.mensagem = "Falha ao registrar o login";
            } finally {
                conexao.Desconectar(); // encerra a conexão com o banco de dados
            }
            return this.validar; // retorna o valor da validação de login
        }
    }
}
