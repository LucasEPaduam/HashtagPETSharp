
namespace ProjInter
{
    partial class TelaVisAgendamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVisAgendamento));
            this.lbl_Agendamentos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_consultasagendadas = new System.Windows.Forms.DataGridView();
            this.btn_Pesdata = new System.Windows.Forms.Button();
            this.btn_Pesvet = new System.Windows.Forms.Button();
            this.btn_Pespac = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.rb_data = new System.Windows.Forms.RadioButton();
            this.rb_vet = new System.Windows.Forms.RadioButton();
            this.rb_pac = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.bt_imprimir = new System.Windows.Forms.Button();
            this.btn_todascon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultasagendadas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Agendamentos
            // 
            this.lbl_Agendamentos.AutoSize = true;
            this.lbl_Agendamentos.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Agendamentos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Agendamentos.Location = new System.Drawing.Point(186, 3);
            this.lbl_Agendamentos.Name = "lbl_Agendamentos";
            this.lbl_Agendamentos.Size = new System.Drawing.Size(222, 29);
            this.lbl_Agendamentos.TabIndex = 0;
            this.lbl_Agendamentos.Text = "Consultas Realizadas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_Agendamentos);
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 34);
            this.panel1.TabIndex = 27;
            // 
            // dgv_consultasagendadas
            // 
            this.dgv_consultasagendadas.AllowUserToAddRows = false;
            this.dgv_consultasagendadas.AllowUserToDeleteRows = false;
            this.dgv_consultasagendadas.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_consultasagendadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_consultasagendadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultasagendadas.EnableHeadersVisualStyles = false;
            this.dgv_consultasagendadas.Location = new System.Drawing.Point(16, 62);
            this.dgv_consultasagendadas.Name = "dgv_consultasagendadas";
            this.dgv_consultasagendadas.ReadOnly = true;
            this.dgv_consultasagendadas.RowHeadersVisible = false;
            this.dgv_consultasagendadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_consultasagendadas.Size = new System.Drawing.Size(552, 217);
            this.dgv_consultasagendadas.TabIndex = 31;
            this.dgv_consultasagendadas.SelectionChanged += new System.EventHandler(this.dgv_consultasagendadas_SelectionChanged);
            // 
            // btn_Pesdata
            // 
            this.btn_Pesdata.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pesdata.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Pesdata.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pesdata.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Pesdata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pesdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesdata.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesdata.Location = new System.Drawing.Point(16, 354);
            this.btn_Pesdata.Name = "btn_Pesdata";
            this.btn_Pesdata.Size = new System.Drawing.Size(100, 34);
            this.btn_Pesdata.TabIndex = 32;
            this.btn_Pesdata.Text = "Pesquisar";
            this.btn_Pesdata.UseVisualStyleBackColor = false;
            this.btn_Pesdata.Click += new System.EventHandler(this.btn_Pesdata_Click);
            // 
            // btn_Pesvet
            // 
            this.btn_Pesvet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pesvet.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Pesvet.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pesvet.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Pesvet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pesvet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesvet.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesvet.Location = new System.Drawing.Point(119, 354);
            this.btn_Pesvet.Name = "btn_Pesvet";
            this.btn_Pesvet.Size = new System.Drawing.Size(100, 34);
            this.btn_Pesvet.TabIndex = 33;
            this.btn_Pesvet.Text = "Pesquisar";
            this.btn_Pesvet.UseVisualStyleBackColor = false;
            this.btn_Pesvet.Click += new System.EventHandler(this.btn_Pesvet_Click);
            // 
            // btn_Pespac
            // 
            this.btn_Pespac.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pespac.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Pespac.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pespac.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Pespac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pespac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pespac.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pespac.Location = new System.Drawing.Point(222, 354);
            this.btn_Pespac.Name = "btn_Pespac";
            this.btn_Pespac.Size = new System.Drawing.Size(100, 34);
            this.btn_Pespac.TabIndex = 34;
            this.btn_Pespac.Text = "Pesquisar";
            this.btn_Pespac.UseVisualStyleBackColor = false;
            this.btn_Pespac.Click += new System.EventHandler(this.btn_Pespac_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 333);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(119, 333);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 36;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(222, 333);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 37;
            // 
            // rb_data
            // 
            this.rb_data.AutoSize = true;
            this.rb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_data.Location = new System.Drawing.Point(19, 313);
            this.rb_data.Name = "rb_data";
            this.rb_data.Size = new System.Drawing.Size(52, 17);
            this.rb_data.TabIndex = 38;
            this.rb_data.TabStop = true;
            this.rb_data.Text = "Data";
            this.rb_data.UseVisualStyleBackColor = true;
            this.rb_data.CheckedChanged += new System.EventHandler(this.rb_data_CheckedChanged);
            // 
            // rb_vet
            // 
            this.rb_vet.AutoSize = true;
            this.rb_vet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_vet.Location = new System.Drawing.Point(122, 313);
            this.rb_vet.Name = "rb_vet";
            this.rb_vet.Size = new System.Drawing.Size(86, 17);
            this.rb_vet.TabIndex = 39;
            this.rb_vet.TabStop = true;
            this.rb_vet.Text = "Veterinário";
            this.rb_vet.UseVisualStyleBackColor = true;
            this.rb_vet.CheckedChanged += new System.EventHandler(this.rb_vet_CheckedChanged);
            // 
            // rb_pac
            // 
            this.rb_pac.AutoSize = true;
            this.rb_pac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_pac.Location = new System.Drawing.Point(224, 313);
            this.rb_pac.Name = "rb_pac";
            this.rb_pac.Size = new System.Drawing.Size(75, 17);
            this.rb_pac.TabIndex = 40;
            this.rb_pac.TabStop = true;
            this.rb_pac.Text = "Paciente";
            this.rb_pac.UseVisualStyleBackColor = true;
            this.rb_pac.CheckedChanged += new System.EventHandler(this.rb_pac_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Selecione o tipo de pesquisa desejada:";
            // 
            // bt_voltar
            // 
            this.bt_voltar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_voltar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_voltar.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_voltar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_voltar.Location = new System.Drawing.Point(452, 342);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(100, 34);
            this.bt_voltar.TabIndex = 42;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = false;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_imprimir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_imprimir.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_imprimir.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_imprimir.Location = new System.Drawing.Point(350, 342);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(100, 34);
            this.bt_imprimir.TabIndex = 43;
            this.bt_imprimir.Text = "Imprimir";
            this.bt_imprimir.UseVisualStyleBackColor = false;
            this.bt_imprimir.Click += new System.EventHandler(this.bt_imprimir_Click);
            // 
            // btn_todascon
            // 
            this.btn_todascon.AutoSize = true;
            this.btn_todascon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_todascon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_todascon.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_todascon.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_todascon.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_todascon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_todascon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_todascon.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todascon.Location = new System.Drawing.Point(382, 280);
            this.btn_todascon.Name = "btn_todascon";
            this.btn_todascon.Size = new System.Drawing.Size(187, 30);
            this.btn_todascon.TabIndex = 44;
            this.btn_todascon.Text = "Visualizar todas as consultas";
            this.btn_todascon.UseVisualStyleBackColor = false;
            this.btn_todascon.Click += new System.EventHandler(this.btn_todascon_Click);
            // 
            // TelaVisAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(584, 399);
            this.Controls.Add(this.btn_todascon);
            this.Controls.Add(this.bt_imprimir);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_pac);
            this.Controls.Add(this.rb_vet);
            this.Controls.Add(this.rb_data);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Pesdata);
            this.Controls.Add(this.btn_Pesvet);
            this.Controls.Add(this.btn_Pespac);
            this.Controls.Add(this.dgv_consultasagendadas);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaVisAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Consultas Realizadas";
            this.Load += new System.EventHandler(this.TelaVisAgendamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultasagendadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Agendamentos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_consultasagendadas;
        private System.Windows.Forms.Button btn_Pesdata;
        private System.Windows.Forms.Button btn_Pesvet;
        private System.Windows.Forms.Button btn_Pespac;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.RadioButton rb_data;
        private System.Windows.Forms.RadioButton rb_vet;
        private System.Windows.Forms.RadioButton rb_pac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.Button bt_imprimir;
        private System.Windows.Forms.Button btn_todascon;
    }
}