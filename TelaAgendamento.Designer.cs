
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
            this.txb_Dia = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.btn_Agendado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Inicio
            // 
            this.pb_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("pb_Inicio.Image")));
            this.pb_Inicio.Location = new System.Drawing.Point(0, 0);
            this.pb_Inicio.Name = "pb_Inicio";
            this.pb_Inicio.Size = new System.Drawing.Size(41, 31);
            this.pb_Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Inicio.TabIndex = 24;
            this.pb_Inicio.TabStop = false;
            // 
            // lbl_Calendario
            // 
            this.lbl_Calendario.AutoSize = true;
            this.lbl_Calendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Calendario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Calendario.Location = new System.Drawing.Point(41, 48);
            this.lbl_Calendario.Name = "lbl_Calendario";
            this.lbl_Calendario.Size = new System.Drawing.Size(95, 20);
            this.lbl_Calendario.TabIndex = 25;
            this.lbl_Calendario.Text = "Calendário";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(37, 68);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 26;
            // 
            // lbl_Dia
            // 
            this.lbl_Dia.AutoSize = true;
            this.lbl_Dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dia.Location = new System.Drawing.Point(45, 243);
            this.lbl_Dia.Name = "lbl_Dia";
            this.lbl_Dia.Size = new System.Drawing.Size(166, 18);
            this.lbl_Dia.TabIndex = 27;
            this.lbl_Dia.Text = "Digite o dia desejado";
            // 
            // txb_Dia
            // 
            this.txb_Dia.Location = new System.Drawing.Point(48, 264);
            this.txb_Dia.Name = "txb_Dia";
            this.txb_Dia.Size = new System.Drawing.Size(163, 20);
            this.txb_Dia.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 30;
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.Location = new System.Drawing.Point(45, 298);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(176, 18);
            this.lbl_Hora.TabIndex = 29;
            this.lbl_Hora.Text = "Digite a hora desejada";
            // 
            // btn_Agendado
            // 
            this.btn_Agendado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agendado.Location = new System.Drawing.Point(324, 298);
            this.btn_Agendado.Name = "btn_Agendado";
            this.btn_Agendado.Size = new System.Drawing.Size(170, 35);
            this.btn_Agendado.TabIndex = 31;
            this.btn_Agendado.Text = "Agendar";
            this.btn_Agendado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Horário disponível";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Horário indisponível";
            // 
            // TelaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 351);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Agendado);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.txb_Dia);
            this.Controls.Add(this.lbl_Dia);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lbl_Calendario);
            this.Controls.Add(this.pb_Inicio);
            this.Name = "TelaAgendamento";
            this.Text = "Agendamento";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Inicio;
        private System.Windows.Forms.Label lbl_Calendario;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbl_Dia;
        private System.Windows.Forms.TextBox txb_Dia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Button btn_Agendado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}