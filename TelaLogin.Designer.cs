
namespace ProjInter
{
    partial class TelaLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Acessar = new System.Windows.Forms.Button();
            this.tb_Senha_login = new System.Windows.Forms.TextBox();
            this.tb_Usu_login = new System.Windows.Forms.TextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lbl_Log_Senha = new System.Windows.Forms.Label();
            this.lbl_Log_Usuario = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_Titulo_Pet_Sharp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_cadastrar = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cadastrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.Location = new System.Drawing.Point(264, 330);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(90, 49);
            this.btn_Cadastrar.TabIndex = 19;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Acessar
            // 
            this.btn_Acessar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Acessar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Acessar.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Acessar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Acessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Acessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Acessar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Acessar.Location = new System.Drawing.Point(51, 125);
            this.btn_Acessar.Name = "btn_Acessar";
            this.btn_Acessar.Size = new System.Drawing.Size(85, 49);
            this.btn_Acessar.TabIndex = 18;
            this.btn_Acessar.Text = "Acessar";
            this.btn_Acessar.UseVisualStyleBackColor = false;
            this.btn_Acessar.Click += new System.EventHandler(this.btn_Acessar_Click);
            // 
            // tb_Senha_login
            // 
            this.tb_Senha_login.Location = new System.Drawing.Point(10, 95);
            this.tb_Senha_login.Name = "tb_Senha_login";
            this.tb_Senha_login.Size = new System.Drawing.Size(166, 20);
            this.tb_Senha_login.TabIndex = 4;
            // 
            // tb_Usu_login
            // 
            this.tb_Usu_login.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Usu_login.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_Usu_login.Location = new System.Drawing.Point(10, 43);
            this.tb_Usu_login.Name = "tb_Usu_login";
            this.tb_Usu_login.Size = new System.Drawing.Size(166, 23);
            this.tb_Usu_login.TabIndex = 3;
            this.tb_Usu_login.Text = "CRMV ou Código";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.tb_Senha_login);
            this.pnlLogin.Controls.Add(this.tb_Usu_login);
            this.pnlLogin.Controls.Add(this.btn_Acessar);
            this.pnlLogin.Controls.Add(this.lbl_Log_Senha);
            this.pnlLogin.Controls.Add(this.lbl_Log_Usuario);
            this.pnlLogin.Location = new System.Drawing.Point(212, 111);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(184, 190);
            this.pnlLogin.TabIndex = 16;
            // 
            // lbl_Log_Senha
            // 
            this.lbl_Log_Senha.AutoSize = true;
            this.lbl_Log_Senha.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Log_Senha.Location = new System.Drawing.Point(9, 71);
            this.lbl_Log_Senha.Name = "lbl_Log_Senha";
            this.lbl_Log_Senha.Size = new System.Drawing.Size(53, 22);
            this.lbl_Log_Senha.TabIndex = 2;
            this.lbl_Log_Senha.Text = "Senha";
            // 
            // lbl_Log_Usuario
            // 
            this.lbl_Log_Usuario.AutoSize = true;
            this.lbl_Log_Usuario.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Log_Usuario.Location = new System.Drawing.Point(9, 20);
            this.lbl_Log_Usuario.Name = "lbl_Log_Usuario";
            this.lbl_Log_Usuario.Size = new System.Drawing.Size(63, 22);
            this.lbl_Log_Usuario.TabIndex = 1;
            this.lbl_Log_Usuario.Text = "Usuário";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_login.Location = new System.Drawing.Point(208, 102);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(38, 15);
            this.lbl_login.TabIndex = 20;
            this.lbl_login.Text = "Login";
            // 
            // lbl_Titulo_Pet_Sharp
            // 
            this.lbl_Titulo_Pet_Sharp.AutoSize = true;
            this.lbl_Titulo_Pet_Sharp.BackColor = System.Drawing.Color.White;
            this.lbl_Titulo_Pet_Sharp.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo_Pet_Sharp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Titulo_Pet_Sharp.Location = new System.Drawing.Point(139, 19);
            this.lbl_Titulo_Pet_Sharp.Name = "lbl_Titulo_Pet_Sharp";
            this.lbl_Titulo_Pet_Sharp.Size = new System.Drawing.Size(324, 45);
            this.lbl_Titulo_Pet_Sharp.TabIndex = 15;
            this.lbl_Titulo_Pet_Sharp.Text = "Hashtag PET Sharp";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_Titulo_Pet_Sharp);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 78);
            this.panel1.TabIndex = 22;
            // 
            // lbl_cadastrar
            // 
            this.lbl_cadastrar.AutoSize = true;
            this.lbl_cadastrar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_cadastrar.Location = new System.Drawing.Point(231, 310);
            this.lbl_cadastrar.Name = "lbl_cadastrar";
            this.lbl_cadastrar.Size = new System.Drawing.Size(150, 13);
            this.lbl_cadastrar.TabIndex = 23;
            this.lbl_cadastrar.Text = "Acesse aqui para cadastrar-se";
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.lbl_cadastrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.pnlLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Acessar;
        private System.Windows.Forms.TextBox tb_Senha_login;
        private System.Windows.Forms.TextBox tb_Usu_login;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lbl_Log_Senha;
        private System.Windows.Forms.Label lbl_Log_Usuario;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_Titulo_Pet_Sharp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_cadastrar;
    }
}