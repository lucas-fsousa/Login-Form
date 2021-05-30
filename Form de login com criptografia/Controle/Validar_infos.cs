using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_v2 {
    class Validar_infos {
        public bool ok = false; // Definição de variavel booleana
        public string resp_validacao = ""; // Definição de variavel string

        // Gera uma senha aleatória para o usuário
        public string Gerar_senha() {
            string senha = ""; // Define uma string vazia
            Random rnd = new Random(); // Instancia um objeto da classe random
            const string minuscula = @"abcdefghijklmnopqrstuvwxyz"; // Define uma string de constantes contendo letras minusculas
            const string maiuscula = @"ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // Define uma string de constantes contendo letras maiusculas
            const string especiais = @"@!#$"; // Define uma string de constantes contendo caracteres especiais
            const string numeros = "0123456789"; // Define uma string de constantes contendo numeros
            string caracteres = string.Concat(maiuscula, numeros, minuscula, especiais); // Concatena as constantes em uma unica string

            //O looping rodará 8 vezes para gerar os 8 digitos da senha de usuario
            for(int i = 1; i <= 8; i++) {
                //Utulizaa função substring para concatenar caracteres na variavel senha que são gerados de acordo com o valor numerico do random dentro da string de caracteres
                senha = senha + caracteres.Substring(rnd.Next(0, caracteres.Length - 1), 1);
            }
            return senha; // retorna a senha gerada
        }

        public string Codificar(string str) {
            // Define um array de bytes
            byte[] salt = new byte[128 / 8];
            // Define um array de bytes que receberá a codificação da função KeyDerivation.Pdkdf2
            byte[] codify = KeyDerivation.Pbkdf2(str, salt, KeyDerivationPrf.HMACSHA1, 10000, 256 / 8);
            //Define uma string para receber a conversão do array de byts codificado
            string hash = Convert.ToBase64String(codify);
            //Retorna o hash
            return hash;
        }

        public bool contains_esp(string str) {
            //Define um array com caracteres especiais
            string[] especiais = { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û", "¹", "²", "³", "£", "¢", "¬", "º", "¨", "\"", "'", ".", ",", "-", ":", "(", ")", "ª", "|", "\\\\", "°", "_", "%", "&", "*", ";", "/", "<", ">", "?", "[", "]", "{", "}", "=", "+", "§", "´", "`", "^", "~" };

            // Esta estrutura de repetição validará se a string contem caractere especial
            for(int i = 0; i < especiais.Length - 1; i++) {// atribui o tamanho do vetor vet ao valor de i
                if(str.Contains(especiais[i])) { // Verifica se a string possui algum caractere do Array "ESPECIAIS"
                    return true; // retorna verdadeiro caso algum caractere não permitido seja localizado na string de entrada

                }
            }
            return false; // retorna falso se não houver nenhum impedimento durante a validação

        }
        public bool Valida_Cad(string login, string senha, string re_senha) {
            this.ok = false;
            login.Trim(); // Remove os caracteres de estapço antes e depois da string login
            senha.Trim(); // Remove os caracteres de estapço antes e depois da string senha
            re_senha.Trim(); // Remove os caracteres de estapço antes e depois da string confirmação de senha

            if(senha.Equals("") || re_senha.Equals("")) { // verifica se os campos são diferentes de vazio
                this.resp_validacao = "Existem campos com espaço em branco, favor preencher.";

            } else if(senha.Length != 8 && re_senha.Length != 8) { // Verifica se o tamanho das senhas digitadas correspondem a 8 caracteres
                this.resp_validacao = "A senha precisa ter 8 Caracteres";

            } else if(!senha.Equals(re_senha)) { // Verifica se a senha e a senha de confirmação são diferentes
                this.resp_validacao = "A senha de confirmação não corresponde a senha digitada.";

            } else if(senha.Equals(login)) { // verifica se a senha é igual ao login
                this.resp_validacao = "A senha informada não pode ser igual ao login já cadastrado.";

            } else if(contains_esp(senha)) { // chama a função para verificar se a senha e o login contem caractere especial
                this.resp_validacao = "A senha contém caractere especial não permitido";
            
            } else {//Se o usuário passar pelos requisitos da validação, estará apto a ser cadastrado
                this.resp_validacao = "";
                this.ok = true; // retorna a validação booleana do cadastro

            }
            return ok; // Retorna valor booleano para saber se o usuario foi autenticado e cadastrado com sucesso (true ou false)
        }
        public bool Valida_login(string login, string senha) {
            this.ok = false;
            if(senha.Equals("") || login.Equals("")) { // Verifica se a senha ou o login estão vazios
                this.resp_validacao = "Usuario ou senha sem preenchimento"; // Atribuição de valor a variavel de resposta
            
            } else { 
                this.resp_validacao = ""; // Atribuição de valor a variavel resposta
                this.ok = true; // atribuição de valor verdadeiro para a variavel de validação 
            }
            return this.ok; // retorna a validação booleana de login
        }

        
    }
}
