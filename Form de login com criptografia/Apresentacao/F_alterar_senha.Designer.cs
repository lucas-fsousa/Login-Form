
namespace Projeto_v2.Apresentacao {
    partial class F_alterar_senha {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_re_pass = new System.Windows.Forms.TextBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_question = new System.Windows.Forms.Button();
            this.lbl_rec_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(22, 48);
            this.tb_pass.MaxLength = 8;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(165, 23);
            this.tb_pass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nova Senha";
            // 
            // tb_re_pass
            // 
            this.tb_re_pass.Location = new System.Drawing.Point(22, 101);
            this.tb_re_pass.MaxLength = 8;
            this.tb_re_pass.Name = "tb_re_pass";
            this.tb_re_pass.PasswordChar = '*';
            this.tb_re_pass.Size = new System.Drawing.Size(165, 23);
            this.tb_re_pass.TabIndex = 5;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(69, 130);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 6;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_question
            // 
            this.btn_question.Location = new System.Drawing.Point(169, 75);
            this.btn_question.Name = "btn_question";
            this.btn_question.Size = new System.Drawing.Size(18, 23);
            this.btn_question.TabIndex = 7;
            this.btn_question.Text = "?";
            this.btn_question.UseVisualStyleBackColor = true;
            this.btn_question.Click += new System.EventHandler(this.btn_question_Click);
            // 
            // lbl_rec_login
            // 
            this.lbl_rec_login.AutoSize = true;
            this.lbl_rec_login.Location = new System.Drawing.Point(69, 9);
            this.lbl_rec_login.Name = "lbl_rec_login";
            this.lbl_rec_login.Size = new System.Drawing.Size(38, 15);
            this.lbl_rec_login.TabIndex = 8;
            this.lbl_rec_login.Text = "label4";
            // 
            // F_alterar_senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 165);
            this.Controls.Add(this.lbl_rec_login);
            this.Controls.Add(this.btn_question);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.tb_re_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pass);
            this.Name = "F_alterar_senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_re_pass;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_question;
        private System.Windows.Forms.Label lbl_rec_login;
    }
}