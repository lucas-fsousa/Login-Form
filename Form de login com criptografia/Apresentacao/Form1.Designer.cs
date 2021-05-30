
namespace Projeto_v2 {
    partial class F_login {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.btn_acessar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SENHA";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(91, 29);
            this.tb_login.MaxLength = 15;
            this.tb_login.Name = "tb_login";
            this.tb_login.PlaceholderText = "Entre com login";
            this.tb_login.Size = new System.Drawing.Size(144, 23);
            this.tb_login.TabIndex = 2;
            this.tb_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(91, 57);
            this.tb_senha.MaxLength = 8;
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.PlaceholderText = "Entre com a senha";
            this.tb_senha.Size = new System.Drawing.Size(144, 23);
            this.tb_senha.TabIndex = 3;
            this.tb_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_acessar
            // 
            this.btn_acessar.Location = new System.Drawing.Point(173, 93);
            this.btn_acessar.Name = "btn_acessar";
            this.btn_acessar.Size = new System.Drawing.Size(62, 23);
            this.btn_acessar.TabIndex = 4;
            this.btn_acessar.Text = "Acessar";
            this.btn_acessar.UseVisualStyleBackColor = true;
            this.btn_acessar.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(104, 129);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Não tenho cadastro";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(91, 93);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(35, 23);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // F_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 164);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_acessar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "F_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button btn_acessar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_sair;
    }
}

