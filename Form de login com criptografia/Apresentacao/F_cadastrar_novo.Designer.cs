
namespace Projeto_v2.Apresentacao {
    partial class F_cadastrar_novo {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.lbl_disponivel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(12, 27);
            this.tb_login.MaxLength = 15;
            this.tb_login.Name = "tb_login";
            this.tb_login.PlaceholderText = "Informe o login de preferência";
            this.tb_login.Size = new System.Drawing.Size(213, 23);
            this.tb_login.TabIndex = 2;
            this.tb_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_login.TextChanged += new System.EventHandler(this.tb_login_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-mail";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(12, 77);
            this.tb_email.MaxLength = 100;
            this.tb_email.Name = "tb_email";
            this.tb_email.PlaceholderText = "Informe seu principal e-mail";
            this.tb_email.Size = new System.Drawing.Size(213, 23);
            this.tb_email.TabIndex = 5;
            this.tb_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(76, 115);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 8;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // lbl_disponivel
            // 
            this.lbl_disponivel.AutoSize = true;
            this.lbl_disponivel.BackColor = System.Drawing.Color.White;
            this.lbl_disponivel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_disponivel.Location = new System.Drawing.Point(55, 9);
            this.lbl_disponivel.Name = "lbl_disponivel";
            this.lbl_disponivel.Size = new System.Drawing.Size(16, 15);
            this.lbl_disponivel.TabIndex = 9;
            this.lbl_disponivel.Text = "...";
            // 
            // F_cadastrar_novo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 154);
            this.Controls.Add(this.lbl_disponivel);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "F_cadastrar_novo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar novo usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label lbl_disponivel;
    }
}