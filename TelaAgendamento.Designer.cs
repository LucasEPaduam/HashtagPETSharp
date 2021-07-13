
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pb_Inicio = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_Agendado = new System.Windows.Forms.Button();
            this.lbl_Agendamento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.dgv_consultasagendadas = new System.Windows.Forms.DataGridView();
            this.lbl_Dia = new System.Windows.Forms.Label();
            this.tb_Datahora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_codpet = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_VIS_PAC = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_Selecthorario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Visualizarvet = new System.Windows.Forms.Button();
            this.tb_codvet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.bt_limparagendamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultasagendadas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Inicio
            // 
            this.pb_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("pb_Inicio.Image")));
            this.pb_Inicio.Location = new System.Drawing.Point(3, 4);
            this.pb_Inicio.Name = "pb_Inicio";
            this.pb_Inicio.Size = new System.Drawing.Size(30, 30);
            this.pb_Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Inicio.TabIndex = 24;
            this.pb_Inicio.TabStop = false;
            this.pb_Inicio.Click += new System.EventHandler(this.pb_Inicio_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 64);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 26;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btn_Agendado
            // 
            this.btn_Agendado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Agendado.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Agendado.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Agendado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Agendado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agendado.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agendado.Location = new System.Drawing.Point(505, 358);
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
            this.lbl_Agendamento.Location = new System.Drawing.Point(268, 4);
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
            this.panel1.Size = new System.Drawing.Size(631, 37);
            this.panel1.TabIndex = 36;
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
            this.btn_Excluir.Location = new System.Drawing.Point(424, 358);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(80, 35);
            this.btn_Excluir.TabIndex = 72;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // dgv_consultasagendadas
            // 
            this.dgv_consultasagendadas.AllowUserToAddRows = false;
            this.dgv_consultasagendadas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_consultasagendadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_consultasagendadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultasagendadas.Location = new System.Drawing.Point(251, 70);
            this.dgv_consultasagendadas.Name = "dgv_consultasagendadas";
            this.dgv_consultasagendadas.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_consultasagendadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_consultasagendadas.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_consultasagendadas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_consultasagendadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_consultasagendadas.Size = new System.Drawing.Size(363, 255);
            this.dgv_consultasagendadas.TabIndex = 73;
            this.dgv_consultasagendadas.SelectionChanged += new System.EventHandler(this.dgv_consultasagendadas_SelectionChanged);
            // 
            // lbl_Dia
            // 
            this.lbl_Dia.AutoSize = true;
            this.lbl_Dia.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dia.Location = new System.Drawing.Point(1, 4);
            this.lbl_Dia.Name = "lbl_Dia";
            this.lbl_Dia.Size = new System.Drawing.Size(221, 15);
            this.lbl_Dia.TabIndex = 27;
            this.lbl_Dia.Text = "Selecione a data desejada no calendário";
            // 
            // tb_Datahora
            // 
            this.tb_Datahora.Location = new System.Drawing.Point(29, 21);
            this.tb_Datahora.Name = "tb_Datahora";
            this.tb_Datahora.Size = new System.Drawing.Size(164, 20);
            this.tb_Datahora.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 74;
            this.label1.Text = "Informe o COD paciente";
            // 
            // tb_codpet
            // 
            this.tb_codpet.Location = new System.Drawing.Point(9, 21);
            this.tb_codpet.Name = "tb_codpet";
            this.tb_codpet.Size = new System.Drawing.Size(136, 20);
            this.tb_codpet.TabIndex = 75;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_VIS_PAC);
            this.panel2.Controls.Add(this.tb_codpet);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 77);
            this.panel2.TabIndex = 76;
            // 
            // btn_VIS_PAC
            // 
            this.btn_VIS_PAC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_VIS_PAC.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_VIS_PAC.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_VIS_PAC.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_VIS_PAC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_VIS_PAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VIS_PAC.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VIS_PAC.Location = new System.Drawing.Point(9, 43);
            this.btn_VIS_PAC.Name = "btn_VIS_PAC";
            this.btn_VIS_PAC.Size = new System.Drawing.Size(136, 24);
            this.btn_VIS_PAC.TabIndex = 78;
            this.btn_VIS_PAC.Text = "Visualizar Pacientes";
            this.btn_VIS_PAC.UseVisualStyleBackColor = false;
            this.btn_VIS_PAC.Click += new System.EventHandler(this.btn_VIS_PAC_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_Selecthorario);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tb_Datahora);
            this.panel3.Controls.Add(this.lbl_Dia);
            this.panel3.Location = new System.Drawing.Point(12, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 91);
            this.panel3.TabIndex = 77;
            // 
            // cb_Selecthorario
            // 
            this.cb_Selecthorario.FormattingEnabled = true;
            this.cb_Selecthorario.Location = new System.Drawing.Point(29, 62);
            this.cb_Selecthorario.Name = "cb_Selecthorario";
            this.cb_Selecthorario.Size = new System.Drawing.Size(164, 21);
            this.cb_Selecthorario.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Selecione o horário desejado";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Visualizarvet);
            this.panel4.Controls.Add(this.tb_codvet);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(167, 336);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(157, 77);
            this.panel4.TabIndex = 79;
            // 
            // Visualizarvet
            // 
            this.Visualizarvet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Visualizarvet.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Visualizarvet.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.Visualizarvet.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Visualizarvet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Visualizarvet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visualizarvet.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualizarvet.Location = new System.Drawing.Point(9, 43);
            this.Visualizarvet.Name = "Visualizarvet";
            this.Visualizarvet.Size = new System.Drawing.Size(136, 24);
            this.Visualizarvet.TabIndex = 78;
            this.Visualizarvet.Text = "Visualizar Veterinários";
            this.Visualizarvet.UseVisualStyleBackColor = false;
            this.Visualizarvet.Click += new System.EventHandler(this.Visualizarvet_Click);
            // 
            // tb_codvet
            // 
            this.tb_codvet.Location = new System.Drawing.Point(9, 21);
            this.tb_codvet.Name = "tb_codvet";
            this.tb_codvet.Size = new System.Drawing.Size(136, 20);
            this.tb_codvet.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 15);
            this.label3.TabIndex = 74;
            this.label3.Text = "Informe o COD veterinário";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(389, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 80;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 399);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 20);
            this.textBox2.TabIndex = 81;
            this.textBox2.Visible = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(598, 72);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(15, 251);
            this.vScrollBar1.TabIndex = 82;
            // 
            // bt_limparagendamento
            // 
            this.bt_limparagendamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_limparagendamento.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_limparagendamento.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_limparagendamento.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_limparagendamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_limparagendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limparagendamento.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limparagendamento.Location = new System.Drawing.Point(343, 358);
            this.bt_limparagendamento.Name = "bt_limparagendamento";
            this.bt_limparagendamento.Size = new System.Drawing.Size(80, 35);
            this.bt_limparagendamento.TabIndex = 83;
            this.bt_limparagendamento.Text = "Limpar";
            this.bt_limparagendamento.UseVisualStyleBackColor = false;
            this.bt_limparagendamento.Click += new System.EventHandler(this.bt_limparagendamento_Click);
            // 
            // TelaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(626, 423);
            this.Controls.Add(this.bt_limparagendamento);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_consultasagendadas);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Agendado);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.TelaAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultasagendadas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Inicio;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_Agendado;
        private System.Windows.Forms.Label lbl_Agendamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.DataGridView dgv_consultasagendadas;
        private System.Windows.Forms.Label lbl_Dia;
        private System.Windows.Forms.TextBox tb_Datahora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_codpet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_Selecthorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_VIS_PAC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Visualizarvet;
        private System.Windows.Forms.TextBox tb_codvet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button bt_limparagendamento;
    }
}