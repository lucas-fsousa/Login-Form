using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_v2.Apresentacao {
    public partial class F_cadastrar_novo : Form {
        public F_cadastrar_novo() {
            InitializeComponent();
        }

        private void btn_info_senha_Click(object sender, EventArgs e) {
            MessageBox.Show("- Caracteres especiais permitidos: @ # ! $\n- Poderá conter letras e numeros\n- Deverá ter 8 digitos\n- Senha não pode ser igual a login\n- Não poderá ser Vazia","Requisitos de senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_cadastrar_Click(object sender, EventArgs e) {
            Controle ctrl = new Controle();
            MessageBox.Show("Aguarde enquanto processamos sua solicitação!", "Mensagem", MessageBoxButtons.OK);
            if(ctrl.Cadastrar(tb_login.Text,tb_email.Text)) {
                tb_email.Clear(); // Limpa o campo de confirmação de senha
                tb_login.Clear(); // limpa o campo de login
                //Apresenta uma mensagem informativa ao usuario
                MessageBox.Show(ctrl.mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                //Apresenta uma mensagem de erro ao usuario
                MessageBox.Show(ctrl.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void tb_login_TextChanged(object sender, EventArgs e) {
            Controle ctrl = new Controle();
            if(tb_login.Text.Equals("")) {
                lbl_disponivel.ForeColor = Color.White; // Atribui a cor branco para as letras do label
                lbl_disponivel.BackColor = Color.White; // atribui fundo branco para o label
                lbl_disponivel.Text = "..."; // atribui valor ... para o label
            } else {
                if(ctrl.check_disp_login(tb_login.Text)) { // Verifica se o login digitado na textbox está disponivel para uso
                    lbl_disponivel.ForeColor = Color.Yellow; // Atribui a cor amarela para as letras do label
                    lbl_disponivel.BackColor = Color.Red; // atribui fundo vermelho para o label
                    lbl_disponivel.Text = "Indisponivel"; // atribui valor indisponivel para o label
                } else {
                    lbl_disponivel.ForeColor = Color.WhiteSmoke; // atribui cor branca para as letras do label
                    lbl_disponivel.BackColor = Color.DarkGreen; // atribui fundo verde escuro para o label
                    lbl_disponivel.Text = "Disponivel"; // atribui valor disponivel pro label
                }
            }
        }
    }
}
