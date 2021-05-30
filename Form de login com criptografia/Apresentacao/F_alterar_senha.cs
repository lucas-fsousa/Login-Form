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
    public partial class F_alterar_senha : Form {

        public F_alterar_senha(string str) {
            InitializeComponent();
            lbl_rec_login.Text = str; // Define o valor do label lbl_rec_login.Text com o valor da string do construtor
            tb_pass.Focus(); // Direciona o foco do cursor para o textbox da senha
        }

        private void btn_alterar_Click(object sender, EventArgs e) {
            Controle ctrl = new Controle(); // Instancia a classe de controle

            // Realiza a troca da senha e verifica se houve sucesso
            if(ctrl.troca_senha(lbl_rec_login.Text, tb_pass.Text, tb_re_pass.Text)) {
                MessageBox.Show(ctrl.mensagem, "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information); // Apresenta uma messagebox informativa
                this.Visible = false; // Define a visibilidade do formulario como falsa (fica invisivel para o usuario)
                
                F_boas_vindas fbv = new F_boas_vindas(); // Instancia a classe de boas vindas
                fbv.ShowDialog(); // Chama o formulario de boas vindas.
            } else { // se houver falha na troca da senha, este bloco é executado
                MessageBox.Show(ctrl.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); // Apresenta uma MessageBox com o erro
            }
            
        }

        private void btn_question_Click(object sender, EventArgs e) {
            //Apresenta uma messagebox ao usuario informando os requisitos de validação da senha
            MessageBox.Show("- Somente são permitidos os caracteres especiais @ # $ !\n" +
                "- A senha precisa ter 8 digitos\n- A senha pode conter numeros, letras e caracteres especiais\n" +
                "- A senha não pode ser igual ao login","Definições de senha", MessageBoxButtons.OK);
        }
    }
}
