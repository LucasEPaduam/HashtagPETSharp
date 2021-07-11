
namespace ProjInter
{
    partial class TelaIniciarConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaIniciarConsulta));
            this.gb_Vac = new System.Windows.Forms.GroupBox();
            this.cb_Qual_Vac = new System.Windows.Forms.ComboBox();
            this.lbl_Qual_Vac = new System.Windows.Forms.Label();
            this.gb_Rem = new System.Windows.Forms.GroupBox();
            this.cb_Qual_Rem = new System.Windows.Forms.ComboBox();
            this.lbl_Qual_Rem = new System.Windows.Forms.Label();
            this.gb_Exame = new System.Windows.Forms.GroupBox();
            this.cb_Qual_Exame = new System.Windows.Forms.ComboBox();
            this.lbl_Qual_Exame = new System.Windows.Forms.Label();
            this.lbl_Peso = new System.Windows.Forms.Label();
            this.tb_Peso = new System.Windows.Forms.TextBox();
            this.tb_Idade = new System.Windows.Forms.TextBox();
            this.lbl_Idade = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_Observacao = new System.Windows.Forms.Label();
            this.btn_Finalizar_Consulta = new System.Windows.Forms.Button();
            this.pb_Inicio = new System.Windows.Forms.PictureBox();
            this.tb_Temp = new System.Windows.Forms.TextBox();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Consulta = new System.Windows.Forms.Label();
            this.rb_sim_vac = new System.Windows.Forms.RadioButton();
            this.rb_nao_vac = new System.Windows.Forms.RadioButton();
            this.rb_nao_rem = new System.Windows.Forms.RadioButton();
            this.rb_sim_rem = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rb_sim_exa = new System.Windows.Forms.RadioButton();
            this.gb_Vac.SuspendLayout();
            this.gb_Rem.SuspendLayout();
            this.gb_Exame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Vac
            // 
            this.gb_Vac.Controls.Add(this.rb_nao_vac);
            this.gb_Vac.Controls.Add(this.rb_sim_vac);
            this.gb_Vac.Controls.Add(this.cb_Qual_Vac);
            this.gb_Vac.Controls.Add(this.lbl_Qual_Vac);
            this.gb_Vac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Vac.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Vac.Location = new System.Drawing.Point(270, 69);
            this.gb_Vac.Name = "gb_Vac";
            this.gb_Vac.Size = new System.Drawing.Size(298, 82);
            this.gb_Vac.TabIndex = 6;
            this.gb_Vac.TabStop = false;
            this.gb_Vac.Text = "O PET será vacinado?";
            // 
            // cb_Qual_Vac
            // 
            this.cb_Qual_Vac.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Qual_Vac.FormattingEnabled = true;
            this.cb_Qual_Vac.Location = new System.Drawing.Point(131, 44);
            this.cb_Qual_Vac.Name = "cb_Qual_Vac";
            this.cb_Qual_Vac.Size = new System.Drawing.Size(156, 23);
            this.cb_Qual_Vac.TabIndex = 25;
            // 
            // lbl_Qual_Vac
            // 
            this.lbl_Qual_Vac.AutoSize = true;
            this.lbl_Qual_Vac.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qual_Vac.Location = new System.Drawing.Point(133, 26);
            this.lbl_Qual_Vac.Name = "lbl_Qual_Vac";
            this.lbl_Qual_Vac.Size = new System.Drawing.Size(153, 17);
            this.lbl_Qual_Vac.TabIndex = 9;
            this.lbl_Qual_Vac.Text = "Qual vacina será aplicada?";
            // 
            // gb_Rem
            // 
            this.gb_Rem.Controls.Add(this.rb_nao_rem);
            this.gb_Rem.Controls.Add(this.rb_sim_rem);
            this.gb_Rem.Controls.Add(this.cb_Qual_Rem);
            this.gb_Rem.Controls.Add(this.lbl_Qual_Rem);
            this.gb_Rem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Rem.Location = new System.Drawing.Point(270, 159);
            this.gb_Rem.Name = "gb_Rem";
            this.gb_Rem.Size = new System.Drawing.Size(298, 85);
            this.gb_Rem.TabIndex = 11;
            this.gb_Rem.TabStop = false;
            this.gb_Rem.Text = "O PET precisará tomar remédios?";
            // 
            // cb_Qual_Rem
            // 
            this.cb_Qual_Rem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Qual_Rem.FormattingEnabled = true;
            this.cb_Qual_Rem.Location = new System.Drawing.Point(131, 48);
            this.cb_Qual_Rem.Name = "cb_Qual_Rem";
            this.cb_Qual_Rem.Size = new System.Drawing.Size(156, 23);
            this.cb_Qual_Rem.TabIndex = 26;
            // 
            // lbl_Qual_Rem
            // 
            this.lbl_Qual_Rem.AutoSize = true;
            this.lbl_Qual_Rem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qual_Rem.Location = new System.Drawing.Point(123, 27);
            this.lbl_Qual_Rem.Name = "lbl_Qual_Rem";
            this.lbl_Qual_Rem.Size = new System.Drawing.Size(174, 17);
            this.lbl_Qual_Rem.TabIndex = 14;
            this.lbl_Qual_Rem.Text = "Qual remédio será prescrito?";
            // 
            // gb_Exame
            // 
            this.gb_Exame.Controls.Add(this.radioButton3);
            this.gb_Exame.Controls.Add(this.rb_sim_exa);
            this.gb_Exame.Controls.Add(this.cb_Qual_Exame);
            this.gb_Exame.Controls.Add(this.lbl_Qual_Exame);
            this.gb_Exame.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Exame.Location = new System.Drawing.Point(270, 251);
            this.gb_Exame.Name = "gb_Exame";
            this.gb_Exame.Size = new System.Drawing.Size(298, 83);
            this.gb_Exame.TabIndex = 16;
            this.gb_Exame.TabStop = false;
            this.gb_Exame.Text = "O PET precisará fazer exames?";
            // 
            // cb_Qual_Exame
            // 
            this.cb_Qual_Exame.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Qual_Exame.FormattingEnabled = true;
            this.cb_Qual_Exame.Location = new System.Drawing.Point(131, 46);
            this.cb_Qual_Exame.Name = "cb_Qual_Exame";
            this.cb_Qual_Exame.Size = new System.Drawing.Size(156, 23);
            this.cb_Qual_Exame.TabIndex = 26;
            // 
            // lbl_Qual_Exame
            // 
            this.lbl_Qual_Exame.AutoSize = true;
            this.lbl_Qual_Exame.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qual_Exame.Location = new System.Drawing.Point(129, 28);
            this.lbl_Qual_Exame.Name = "lbl_Qual_Exame";
            this.lbl_Qual_Exame.Size = new System.Drawing.Size(163, 17);
            this.lbl_Qual_Exame.TabIndex = 19;
            this.lbl_Qual_Exame.Text = "Qual exame será realizado?";
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Peso.Location = new System.Drawing.Point(12, 69);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(47, 18);
            this.lbl_Peso.TabIndex = 0;
            this.lbl_Peso.Text = "Peso";
            // 
            // tb_Peso
            // 
            this.tb_Peso.Location = new System.Drawing.Point(66, 69);
            this.tb_Peso.Name = "tb_Peso";
            this.tb_Peso.Size = new System.Drawing.Size(131, 20);
            this.tb_Peso.TabIndex = 1;
            // 
            // tb_Idade
            // 
            this.tb_Idade.Location = new System.Drawing.Point(66, 95);
            this.tb_Idade.Name = "tb_Idade";
            this.tb_Idade.Size = new System.Drawing.Size(131, 20);
            this.tb_Idade.TabIndex = 3;
            // 
            // lbl_Idade
            // 
            this.lbl_Idade.AutoSize = true;
            this.lbl_Idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idade.Location = new System.Drawing.Point(12, 95);
            this.lbl_Idade.Name = "lbl_Idade";
            this.lbl_Idade.Size = new System.Drawing.Size(48, 18);
            this.lbl_Idade.TabIndex = 2;
            this.lbl_Idade.Text = "Idade";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 178);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(245, 208);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // lbl_Observacao
            // 
            this.lbl_Observacao.AutoSize = true;
            this.lbl_Observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Observacao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Observacao.Location = new System.Drawing.Point(6, 157);
            this.lbl_Observacao.Name = "lbl_Observacao";
            this.lbl_Observacao.Size = new System.Drawing.Size(113, 18);
            this.lbl_Observacao.TabIndex = 4;
            this.lbl_Observacao.Text = "Observações:";
            // 
            // btn_Finalizar_Consulta
            // 
            this.btn_Finalizar_Consulta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Finalizar_Consulta.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Finalizar_Consulta.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Finalizar_Consulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Finalizar_Consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Finalizar_Consulta.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finalizar_Consulta.Location = new System.Drawing.Point(403, 351);
            this.btn_Finalizar_Consulta.Name = "btn_Finalizar_Consulta";
            this.btn_Finalizar_Consulta.Size = new System.Drawing.Size(150, 35);
            this.btn_Finalizar_Consulta.TabIndex = 21;
            this.btn_Finalizar_Consulta.Text = "Finalizar consulta";
            this.btn_Finalizar_Consulta.UseVisualStyleBackColor = false;
            this.btn_Finalizar_Consulta.Click += new System.EventHandler(this.btn_Finalizar_Consulta_Click);
            // 
            // pb_Inicio
            // 
            this.pb_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("pb_Inicio.Image")));
            this.pb_Inicio.Location = new System.Drawing.Point(3, 11);
            this.pb_Inicio.Name = "pb_Inicio";
            this.pb_Inicio.Size = new System.Drawing.Size(30, 30);
            this.pb_Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Inicio.TabIndex = 22;
            this.pb_Inicio.TabStop = false;
            this.pb_Inicio.Click += new System.EventHandler(this.pb_Inicio_Click);
            // 
            // tb_Temp
            // 
            this.tb_Temp.Location = new System.Drawing.Point(66, 121);
            this.tb_Temp.Name = "tb_Temp";
            this.tb_Temp.Size = new System.Drawing.Size(131, 20);
            this.tb_Temp.TabIndex = 24;
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Temp.Location = new System.Drawing.Point(9, 121);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(55, 18);
            this.lbl_Temp.TabIndex = 23;
            this.lbl_Temp.Text = "Temp.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_Consulta);
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 34);
            this.panel1.TabIndex = 25;
            // 
            // lbl_Consulta
            // 
            this.lbl_Consulta.AutoSize = true;
            this.lbl_Consulta.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Consulta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Consulta.Location = new System.Drawing.Point(229, 2);
            this.lbl_Consulta.Name = "lbl_Consulta";
            this.lbl_Consulta.Size = new System.Drawing.Size(97, 29);
            this.lbl_Consulta.TabIndex = 0;
            this.lbl_Consulta.Text = "Consulta";
            // 
            // rb_sim_vac
            // 
            this.rb_sim_vac.AutoSize = true;
            this.rb_sim_vac.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sim_vac.Location = new System.Drawing.Point(26, 24);
            this.rb_sim_vac.Name = "rb_sim_vac";
            this.rb_sim_vac.Size = new System.Drawing.Size(45, 19);
            this.rb_sim_vac.TabIndex = 26;
            this.rb_sim_vac.TabStop = true;
            this.rb_sim_vac.Text = "Sim";
            this.rb_sim_vac.UseVisualStyleBackColor = true;
            this.rb_sim_vac.CheckedChanged += new System.EventHandler(this.rb_sim_vac_CheckedChanged);
            // 
            // rb_nao_vac
            // 
            this.rb_nao_vac.AutoSize = true;
            this.rb_nao_vac.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_nao_vac.Location = new System.Drawing.Point(75, 24);
            this.rb_nao_vac.Name = "rb_nao_vac";
            this.rb_nao_vac.Size = new System.Drawing.Size(46, 19);
            this.rb_nao_vac.TabIndex = 27;
            this.rb_nao_vac.TabStop = true;
            this.rb_nao_vac.Text = "Não";
            this.rb_nao_vac.UseVisualStyleBackColor = true;
            this.rb_nao_vac.CheckedChanged += new System.EventHandler(this.rb_nao_vac_CheckedChanged);
            // 
            // rb_nao_rem
            // 
            this.rb_nao_rem.AutoSize = true;
            this.rb_nao_rem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_nao_rem.Location = new System.Drawing.Point(74, 19);
            this.rb_nao_rem.Name = "rb_nao_rem";
            this.rb_nao_rem.Size = new System.Drawing.Size(46, 19);
            this.rb_nao_rem.TabIndex = 29;
            this.rb_nao_rem.TabStop = true;
            this.rb_nao_rem.Text = "Não";
            this.rb_nao_rem.UseVisualStyleBackColor = true;
            this.rb_nao_rem.CheckedChanged += new System.EventHandler(this.rb_nao_rem_CheckedChanged);
            // 
            // rb_sim_rem
            // 
            this.rb_sim_rem.AutoSize = true;
            this.rb_sim_rem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sim_rem.Location = new System.Drawing.Point(25, 19);
            this.rb_sim_rem.Name = "rb_sim_rem";
            this.rb_sim_rem.Size = new System.Drawing.Size(45, 19);
            this.rb_sim_rem.TabIndex = 28;
            this.rb_sim_rem.TabStop = true;
            this.rb_sim_rem.Text = "Sim";
            this.rb_sim_rem.UseVisualStyleBackColor = true;
            this.rb_sim_rem.CheckedChanged += new System.EventHandler(this.rb_sim_rem_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(74, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 19);
            this.radioButton3.TabIndex = 31;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Não";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rb_sim_exa
            // 
            this.rb_sim_exa.AutoSize = true;
            this.rb_sim_exa.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sim_exa.Location = new System.Drawing.Point(25, 25);
            this.rb_sim_exa.Name = "rb_sim_exa";
            this.rb_sim_exa.Size = new System.Drawing.Size(45, 19);
            this.rb_sim_exa.TabIndex = 30;
            this.rb_sim_exa.TabStop = true;
            this.rb_sim_exa.Text = "Sim";
            this.rb_sim_exa.UseVisualStyleBackColor = true;
            this.rb_sim_exa.CheckedChanged += new System.EventHandler(this.rb_sim_exa_CheckedChanged);
            // 
            // TelaIniciarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.pb_Inicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_Temp);
            this.Controls.Add(this.lbl_Temp);
            this.Controls.Add(this.btn_Finalizar_Consulta);
            this.Controls.Add(this.lbl_Observacao);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tb_Idade);
            this.Controls.Add(this.lbl_Idade);
            this.Controls.Add(this.tb_Peso);
            this.Controls.Add(this.lbl_Peso);
            this.Controls.Add(this.gb_Exame);
            this.Controls.Add(this.gb_Rem);
            this.Controls.Add(this.gb_Vac);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaIniciarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Consulta";
            this.Load += new System.EventHandler(this.TelaIniciarConsulta_Load);
            this.gb_Vac.ResumeLayout(false);
            this.gb_Vac.PerformLayout();
            this.gb_Rem.ResumeLayout(false);
            this.gb_Rem.PerformLayout();
            this.gb_Exame.ResumeLayout(false);
            this.gb_Exame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Vac;
        private System.Windows.Forms.Label lbl_Qual_Vac;
        private System.Windows.Forms.GroupBox gb_Rem;
        private System.Windows.Forms.Label lbl_Qual_Rem;
        private System.Windows.Forms.GroupBox gb_Exame;
        private System.Windows.Forms.Label lbl_Qual_Exame;
        private System.Windows.Forms.Label lbl_Peso;
        private System.Windows.Forms.TextBox tb_Peso;
        private System.Windows.Forms.TextBox tb_Idade;
        private System.Windows.Forms.Label lbl_Idade;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_Observacao;
        private System.Windows.Forms.Button btn_Finalizar_Consulta;
        private System.Windows.Forms.PictureBox pb_Inicio;
        private System.Windows.Forms.TextBox tb_Temp;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.ComboBox cb_Qual_Vac;
        private System.Windows.Forms.ComboBox cb_Qual_Rem;
        private System.Windows.Forms.ComboBox cb_Qual_Exame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Consulta;
        private System.Windows.Forms.RadioButton rb_nao_vac;
        private System.Windows.Forms.RadioButton rb_sim_vac;
        private System.Windows.Forms.RadioButton rb_nao_rem;
        private System.Windows.Forms.RadioButton rb_sim_rem;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rb_sim_exa;
    }
}