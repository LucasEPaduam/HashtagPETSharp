
namespace ProjInter
{
    partial class TelaCadExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadExame));
            this.lbl_Exame = new System.Windows.Forms.Label();
            this.pb_Inicio = new System.Windows.Forms.PictureBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.pb_Pesquisar = new System.Windows.Forms.PictureBox();
            this.tb_Pesquisar = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Cod_Exame = new System.Windows.Forms.Label();
            this.tb_Cod_Exame = new System.Windows.Forms.TextBox();
            this.lbl_Nome_Exame = new System.Windows.Forms.Label();
            this.tb_Nome_Exame = new System.Windows.Forms.TextBox();
            this.lbl_Preco_Exame = new System.Windows.Forms.Label();
            this.tb_Preco_Exame = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pesquisar)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Exame
            // 
            this.lbl_Exame.AutoSize = true;
            this.lbl_Exame.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Exame.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Exame.Location = new System.Drawing.Point(244, 1);
            this.lbl_Exame.Name = "lbl_Exame";
            this.lbl_Exame.Size = new System.Drawing.Size(88, 29);
            this.lbl_Exame.TabIndex = 0;
            this.lbl_Exame.Text = "Exames";
            // 
            // pb_Inicio
            // 
            this.pb_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("pb_Inicio.Image")));
            this.pb_Inicio.Location = new System.Drawing.Point(2, 11);
            this.pb_Inicio.Name = "pb_Inicio";
            this.pb_Inicio.Size = new System.Drawing.Size(30, 30);
            this.pb_Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Inicio.TabIndex = 24;
            this.pb_Inicio.TabStop = false;
            this.pb_Inicio.Click += new System.EventHandler(this.pb_Inicio_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Salvar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Salvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Salvar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(374, 295);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(69, 34);
            this.btn_Salvar.TabIndex = 50;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Editar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Editar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(301, 295);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(68, 34);
            this.btn_Editar.TabIndex = 49;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            // 
            // pb_Pesquisar
            // 
            this.pb_Pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.pb_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("pb_Pesquisar.Image")));
            this.pb_Pesquisar.Location = new System.Drawing.Point(400, 267);
            this.pb_Pesquisar.Name = "pb_Pesquisar";
            this.pb_Pesquisar.Size = new System.Drawing.Size(21, 21);
            this.pb_Pesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Pesquisar.TabIndex = 59;
            this.pb_Pesquisar.TabStop = false;
            // 
            // tb_Pesquisar
            // 
            this.tb_Pesquisar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pesquisar.ForeColor = System.Drawing.Color.DarkGray;
            this.tb_Pesquisar.Location = new System.Drawing.Point(173, 266);
            this.tb_Pesquisar.Name = "tb_Pesquisar";
            this.tb_Pesquisar.Size = new System.Drawing.Size(249, 23);
            this.tb_Pesquisar.TabIndex = 58;
            this.tb_Pesquisar.Text = "Pesquisar Exame";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Limpar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Limpar.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Limpar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Location = new System.Drawing.Point(228, 295);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(67, 34);
            this.btn_Limpar.TabIndex = 60;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbl_Exame);
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 33);
            this.panel3.TabIndex = 61;
            // 
            // lbl_Cod_Exame
            // 
            this.lbl_Cod_Exame.AutoSize = true;
            this.lbl_Cod_Exame.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cod_Exame.Location = new System.Drawing.Point(4, 17);
            this.lbl_Cod_Exame.Name = "lbl_Cod_Exame";
            this.lbl_Cod_Exame.Size = new System.Drawing.Size(58, 23);
            this.lbl_Cod_Exame.TabIndex = 1;
            this.lbl_Cod_Exame.Text = "Código";
            // 
            // tb_Cod_Exame
            // 
            this.tb_Cod_Exame.Location = new System.Drawing.Point(66, 19);
            this.tb_Cod_Exame.Name = "tb_Cod_Exame";
            this.tb_Cod_Exame.Size = new System.Drawing.Size(180, 20);
            this.tb_Cod_Exame.TabIndex = 2;
            // 
            // lbl_Nome_Exame
            // 
            this.lbl_Nome_Exame.AutoSize = true;
            this.lbl_Nome_Exame.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome_Exame.Location = new System.Drawing.Point(9, 52);
            this.lbl_Nome_Exame.Name = "lbl_Nome_Exame";
            this.lbl_Nome_Exame.Size = new System.Drawing.Size(52, 23);
            this.lbl_Nome_Exame.TabIndex = 3;
            this.lbl_Nome_Exame.Text = "Nome";
            // 
            // tb_Nome_Exame
            // 
            this.tb_Nome_Exame.Location = new System.Drawing.Point(66, 55);
            this.tb_Nome_Exame.Name = "tb_Nome_Exame";
            this.tb_Nome_Exame.Size = new System.Drawing.Size(180, 20);
            this.tb_Nome_Exame.TabIndex = 4;
            // 
            // lbl_Preco_Exame
            // 
            this.lbl_Preco_Exame.AutoSize = true;
            this.lbl_Preco_Exame.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Preco_Exame.Location = new System.Drawing.Point(9, 91);
            this.lbl_Preco_Exame.Name = "lbl_Preco_Exame";
            this.lbl_Preco_Exame.Size = new System.Drawing.Size(52, 23);
            this.lbl_Preco_Exame.TabIndex = 5;
            this.lbl_Preco_Exame.Text = "Preço";
            // 
            // tb_Preco_Exame
            // 
            this.tb_Preco_Exame.Location = new System.Drawing.Point(66, 94);
            this.tb_Preco_Exame.Name = "tb_Preco_Exame";
            this.tb_Preco_Exame.Size = new System.Drawing.Size(180, 20);
            this.tb_Preco_Exame.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_Preco_Exame);
            this.panel1.Controls.Add(this.lbl_Preco_Exame);
            this.panel1.Controls.Add(this.tb_Nome_Exame);
            this.panel1.Controls.Add(this.lbl_Nome_Exame);
            this.panel1.Controls.Add(this.tb_Cod_Exame);
            this.panel1.Controls.Add(this.lbl_Cod_Exame);
            this.panel1.Location = new System.Drawing.Point(160, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 136);
            this.panel1.TabIndex = 62;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Excluir.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(155, 295);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(67, 34);
            this.btn_Excluir.TabIndex = 63;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            // 
            // TelaCadExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_Inicio);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.pb_Pesquisar);
            this.Controls.Add(this.tb_Pesquisar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Editar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadExame";
            this.Text = "Cadastro Exames";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pesquisar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Exame;
        private System.Windows.Forms.PictureBox pb_Inicio;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.PictureBox pb_Pesquisar;
        private System.Windows.Forms.TextBox tb_Pesquisar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Cod_Exame;
        private System.Windows.Forms.TextBox tb_Cod_Exame;
        private System.Windows.Forms.Label lbl_Nome_Exame;
        private System.Windows.Forms.TextBox tb_Nome_Exame;
        private System.Windows.Forms.Label lbl_Preco_Exame;
        private System.Windows.Forms.TextBox tb_Preco_Exame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Excluir;
    }
}