
namespace ProjInter
{
    partial class TelaAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAgendamento));
            this.pb_Inicio = new System.Windows.Forms.PictureBox();
            this.lbl_Calendario = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_Agendado = new System.Windows.Forms.Button();
            this.lbl_Agendamento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Pesquisar = new System.Windows.Forms.PictureBox();
            this.tb_Pesquisar = new System.Windows.Forms.TextBox();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_Dia = new System.Windows.Forms.Label();
            this.tb_Dia = new System.Windows.Forms.TextBox();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.tb_Hora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Inicio
            // 
            this.pb_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("pb_Inicio.Image")));
            this.pb_Inicio.Location = new System.Drawing.Point(4, 4);
            this.pb_Inicio.Name = "pb_Inicio";
            this.pb_Inicio.Size = new System.Drawing.Size(30, 30);
            this.pb_Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Inicio.TabIndex = 24;
            this.pb_Inicio.TabStop = false;
            this.pb_Inicio.Click += new System.EventHandler(this.pb_Inicio_Click);
            // 
            // lbl_Calendario
            // 
            this.lbl_Calendario.AutoSize = true;
            this.lbl_Calendario.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Calendario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Calendario.Location = new System.Drawing.Point(25, 54);
            this.lbl_Calendario.Name = "lbl_Calendario";
            this.lbl_Calendario.Size = new System.Drawing.Size(107, 27);
            this.lbl_Calendario.TabIndex = 25;
            this.lbl_Calendario.Text = "Calendário";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(30, 80);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 26;
            // 
            // btn_Agendado
            // 
            this.btn_Agendado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Agendado.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Agendado.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Agendado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Agendado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agendado.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agendado.Location = new System.Drawing.Point(435, 349);
            this.btn_Agendado.Name = "btn_Agendado";
            this.btn_Agendado.Size = new System.Drawing.Size(80, 35);
            this.btn_Agendado.TabIndex = 31;
            this.btn_Agendado.Text = "Agendar";
            this.btn_Agendado.UseVisualStyleBackColor = false;
            this.btn_Agendado.Click += new System.EventHandler(this.btn_Agendado_Click);
            // 
            // lbl_Agendamento
            // 
            this.lbl_Agendamento.AutoSize = true;
            this.lbl_Agendamento.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Agendamento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Agendamento.Location = new System.Drawing.Point(202, 4);
            this.lbl_Agendamento.Name = "lbl_Agendamento";
            this.lbl_Agendamento.Size = new System.Drawing.Size(146, 29);
            this.lbl_Agendamento.TabIndex = 34;
            this.lbl_Agendamento.Text = "Agendamento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_Agendamento);
            this.panel1.Controls.Add(this.pb_Inicio);
            this.panel1.Location = new System.Drawing.Point(0, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 37);
            this.panel1.TabIndex = 36;
            // 
            // pb_Pesquisar
            // 
            this.pb_Pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.pb_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("pb_Pesquisar.Image")));
            this.pb_Pesquisar.Location = new System.Drawing.Point(175, 7);
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
            this.tb_Pesquisar.Location = new System.Drawing.Point(7, 6);
            this.tb_Pesquisar.Name = "tb_Pesquisar";
            this.tb_Pesquisar.Size = new System.Drawing.Size(190, 23);
            this.tb_Pesquisar.TabIndex = 58;
            this.tb_Pesquisar.Text = "Pesquisar paciente";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Excluir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Excluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Excluir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(351, 349);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(80, 35);
            this.btn_Excluir.TabIndex = 72;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(281, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(291, 252);
            this.dataGridView1.TabIndex = 73;
            // 
            // lbl_Dia
            // 
            this.lbl_Dia.AutoSize = true;
            this.lbl_Dia.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dia.Location = new System.Drawing.Point(6, 4);
            this.lbl_Dia.Name = "lbl_Dia";
            this.lbl_Dia.Size = new System.Drawing.Size(127, 15);
            this.lbl_Dia.TabIndex = 27;
            this.lbl_Dia.Text = "Digite a data desejada";
            this.lbl_Dia.Click += new System.EventHandler(this.lbl_Dia_Click);
            // 
            // tb_Dia
            // 
            this.tb_Dia.Location = new System.Drawing.Point(8, 20);
            this.tb_Dia.Name = "tb_Dia";
            this.tb_Dia.Size = new System.Drawing.Size(190, 20);
            this.tb_Dia.TabIndex = 28;
            this.tb_Dia.TextChanged += new System.EventHandler(this.tb_Dia_TextChanged);
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.Location = new System.Drawing.Point(7, 44);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(127, 15);
            this.lbl_Hora.TabIndex = 29;
            this.lbl_Hora.Text = "Digite a hora desejada";
            this.lbl_Hora.Click += new System.EventHandler(this.lbl_Hora_Click);
            // 
            // tb_Hora
            // 
            this.tb_Hora.Location = new System.Drawing.Point(8, 59);
            this.tb_Hora.Name = "tb_Hora";
            this.tb_Hora.Size = new System.Drawing.Size(190, 20);
            this.tb_Hora.TabIndex = 30;
            this.tb_Hora.TextChanged += new System.EventHandler(this.tb_Hora_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 74;
            this.label1.Text = "Paciente selecionado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 75;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pb_Pesquisar);
            this.panel2.Controls.Add(this.tb_Pesquisar);
            this.panel2.Location = new System.Drawing.Point(42, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 70);
            this.panel2.TabIndex = 76;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tb_Hora);
            this.panel3.Controls.Add(this.lbl_Hora);
            this.panel3.Controls.Add(this.tb_Dia);
            this.panel3.Controls.Add(this.lbl_Dia);
            this.panel3.Location = new System.Drawing.Point(42, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 86);
            this.panel3.TabIndex = 77;
            // 
            // TelaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Agendado);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lbl_Calendario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaAgendamento";
            this.Text = "Agendamento";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Inicio;
        private System.Windows.Forms.Label lbl_Calendario;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_Agendado;
        private System.Windows.Forms.Label lbl_Agendamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Pesquisar;
        private System.Windows.Forms.TextBox tb_Pesquisar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Dia;
        private System.Windows.Forms.TextBox tb_Dia;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.TextBox tb_Hora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}