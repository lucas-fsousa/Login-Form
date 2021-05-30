using Projeto_v2.Apresentacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_v2 {
    public partial class F_login : Form {
        public F_login() {
            InitializeComponent();
        }

        private void btn_acessar_Click(object sender, EventArgs e) {
            Controle ctrl = new Controle(); // Instancia a classe de controle
            string msg = ""; // Definição de variavel string
            if(ctrl.Logar(tb_login.Text, tb_senha.Text)) {
                msg = ctrl.mensagem; // Mensagem informativa de Control
                MessageBox.Show(msg, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information); // Apresenta MessageBox informativo
                tb_login.Clear(); // Limpa a textbox de login
                tb_senha.Clear(); // limpa a textbox de senha
                this.Visible = false; // Deixa o formulario invisivel

                F_boas_vindas fbv = new F_boas_vindas(); // Instancia a classe de boas vindas
                fbv.ShowDialog(); // Chama o formulário de boas vindas
            } else {
                if(ctrl.trocar) {
                    MessageBox.Show("Identificamos que sua senha foi gerada automaticamente. " +
                        "Por favor, realize a alteração para acessar o sistema.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    F_alterar_senha fas = new F_alterar_senha(tb_login.Text); // Instancia a classe de alteração de senha
                    fas.ShowDialog(); // chama o formulario para alteração de senha
                    tb_login.Clear(); // Limpa a textbox de login
                    tb_senha.Clear(); // limpa a textbox de senha
                    this.Visible = false; // Define a visibilidade do formulario como falsa (fica invisivel para o usuario)
                } else {
                    msg = ctrl.mensagem; // mensagem informativa de Controle
                    MessageBox.Show(msg, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information); // Apresenta TextBox Informativa
                    tb_login.Clear(); // Limpa a textbox de login
                    tb_senha.Clear(); // limpa a textbox de senha
                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            F_cadastrar_novo cad = new F_cadastrar_novo(); // instancia a classe de cadastrar usuario
            cad.ShowDialog(); // Abre o formulario de cadastro de usuario
        }

        private void btn_sair_Click(object sender, EventArgs e) {
            F_login.ActiveForm.Close(); // encerra o programa.
        }
    }
}
