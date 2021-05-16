
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
            this.lbl_Dia = new System.Windows.Forms.Label();
            this.tb_Dia = new System.Windows.Forms.TextBox();
            this.tb_Hora = new System.Windows.Forms.TextBox();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.btn_Agendado = new System.Windows.Forms.Button();
            this.lbl_Agendamento = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Pesquisar = new System.Windows.Forms.PictureBox();
            this.tb_Pesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pesquisar)).BeginInit();
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
            this.lbl_Calendario.Location = new System.Drawing.Point(25, 74);
            this.lbl_Calendario.Name = "lbl_Calendario";
            this.lbl_Calendario.Size = new System.Drawing.Size(107, 27);
            this.lbl_Calendario.TabIndex = 25;
            this.lbl_Calendario.Text = "Calendário";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(30, 100);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 26;
            // 
            // lbl_Dia
            // 
            this.lbl_Dia.AutoSize = true;
            this.lbl_Dia.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dia.Location = new System.Drawing.Point(370, 100);
            this.lbl_Dia.Name = "lbl_Dia";
            this.lbl_Dia.Size = new System.Drawing.Size(154, 19);
            this.lbl_Dia.TabIndex = 27;
            this.lbl_Dia.Text = "Digite a data desejada";
            this.lbl_Dia.Click += new System.EventHandler(this.lbl_Dia_Click);
            // 
            // tb_Dia
            // 
            this.tb_Dia.Location = new System.Drawing.Point(366, 122);
            this.tb_Dia.Name = "tb_Dia";
            this.tb_Dia.Size = new System.Drawing.Size(163, 20);
            this.tb_Dia.TabIndex = 28;
            this.tb_Dia.TextChanged += new System.EventHandler(this.tb_Dia_TextChanged);
            // 
            // tb_Hora
            // 
            this.tb_Hora.Location = new System.Drawing.Point(366, 177);
            this.tb_Hora.Name = "tb_Hora";
            this.tb_Hora.Size = new System.Drawing.Size(163, 20);
            this.tb_Hora.TabIndex = 30;
            this.tb_Hora.TextChanged += new System.EventHandler(this.tb_Hora_TextChanged);
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.Location = new System.Drawing.Point(371, 155);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(154, 19);
            this.lbl_Hora.TabIndex = 29;
            this.lbl_Hora.Text = "Digite a hora desejada";
            this.lbl_Hora.Click += new System.EventHandler(this.lbl_Hora_Click);
            // 
            // btn_Agendado
            // 
            this.btn_Agendado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Agendado.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agendado.Location = new System.Drawing.Point(400, 344);
            this.btn_Agendado.Name = "btn_Agendado";
            this.btn_Agendado.Size = new System.Drawing.Size(102, 35);
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(336, 216);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(227, 122);
            this.richTextBox1.TabIndex = 35;
            this.richTextBox1.Text = "";
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
            this.pb_Pesquisar.Location = new System.Drawing.Point(204, 275);
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
            this.tb_Pesquisar.Location = new System.Drawing.Point(30, 274);
            this.tb_Pesquisar.Name = "tb_Pesquisar";
            this.tb_Pesquisar.Size = new System.Drawing.Size(196, 23);
            this.tb_Pesquisar.TabIndex = 58;
            this.tb_Pesquisar.Text = "Pesquisar paciente";
            // 
            // TelaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.pb_Pesquisar);
            this.Controls.Add(this.tb_Pesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_Agendado);
            this.Controls.Add(this.tb_Hora);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.tb_Dia);
            this.Controls.Add(this.lbl_Dia);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lbl_Calendario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaAgendamento";
            this.Text = "Agendamento";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Inicio;
        private System.Windows.Forms.Label lbl_Calendario;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbl_Dia;
        private System.Windows.Forms.TextBox tb_Dia;
        private System.Windows.Forms.TextBox tb_Hora;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Button btn_Agendado;
        private System.Windows.Forms.Label lbl_Agendamento;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Pesquisar;
        private System.Windows.Forms.TextBox tb_Pesquisar;
    }
}