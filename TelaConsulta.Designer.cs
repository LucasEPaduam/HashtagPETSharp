
namespace ProjInter
{
    partial class TelaConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaConsulta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Mensagem_Consulta = new System.Windows.Forms.Label();
            this.btn_Iniciar_Consulta = new System.Windows.Forms.Button();
            this.pb_Inicio = new System.Windows.Forms.PictureBox();
            this.dgv_historico = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_IniciarConsulta = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Paciente = new System.Windows.Forms.Label();
            this.tb_paciente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Mensagem_Consulta
            // 
            this.lbl_Mensagem_Consulta.AutoSize = true;
            this.lbl_Mensagem_Consulta.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mensagem_Consulta.Location = new System.Drawing.Point(19, 57);
            this.lbl_Mensagem_Consulta.Name = "lbl_Mensagem_Consulta";
            this.lbl_Mensagem_Consulta.Size = new System.Drawing.Size(415, 24);
            this.lbl_Mensagem_Consulta.TabIndex = 0;
            this.lbl_Mensagem_Consulta.Text = "Selecione a consulta e clique em Iniciar Consulta";
            // 
            // btn_Iniciar_Consulta
            // 
            this.btn_Iniciar_Consulta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Iniciar_Consulta.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar_Consulta.Location = new System.Drawing.Point(442, 371);
            this.btn_Iniciar_Consulta.Name = "btn_Iniciar_Consulta";
            this.btn_Iniciar_Consulta.Size = new System.Drawing.Size(130, 35);
            this.btn_Iniciar_Consulta.TabIndex = 5;
            this.btn_Iniciar_Consulta.Text = "Iniciar consulta";
            this.btn_Iniciar_Consulta.UseVisualStyleBackColor = false;
            this.btn_Iniciar_Consulta.Click += new System.EventHandler(this.btn_Iniciar_Consulta_Click);
            // 
            // pb_Inicio
            // 
            this.pb_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("pb_Inicio.Image")));
            this.pb_Inicio.Location = new System.Drawing.Point(3, 12);
            this.pb_Inicio.Name = "pb_Inicio";
            this.pb_Inicio.Size = new System.Drawing.Size(30, 30);
            this.pb_Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Inicio.TabIndex = 23;
            this.pb_Inicio.TabStop = false;
            this.pb_Inicio.Click += new System.EventHandler(this.pb_Inicio_Click);
            // 
            // dgv_historico
            // 
            this.dgv_historico.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_historico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historico.EnableHeadersVisualStyles = false;
            this.dgv_historico.Location = new System.Drawing.Point(20, 136);
            this.dgv_historico.Name = "dgv_historico";
            this.dgv_historico.RowHeadersVisible = false;
            this.dgv_historico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_historico.Size = new System.Drawing.Size(552, 230);
            this.dgv_historico.TabIndex = 24;
            this.dgv_historico.SelectionChanged += new System.EventHandler(this.dgv_historico_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_IniciarConsulta);
            this.panel1.Location = new System.Drawing.Point(-4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 32);
            this.panel1.TabIndex = 25;
            // 
            // lbl_IniciarConsulta
            // 
            this.lbl_IniciarConsulta.AutoSize = true;
            this.lbl_IniciarConsulta.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IniciarConsulta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_IniciarConsulta.Location = new System.Drawing.Point(211, 2);
            this.lbl_IniciarConsulta.Name = "lbl_IniciarConsulta";
            this.lbl_IniciarConsulta.Size = new System.Drawing.Size(173, 29);
            this.lbl_IniciarConsulta.TabIndex = 0;
            this.lbl_IniciarConsulta.Text = "Iniciar Consulta";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(554, 139);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 224);
            this.vScrollBar1.TabIndex = 30;
            // 
            // tb_data
            // 
            this.tb_data.Enabled = false;
            this.tb_data.Location = new System.Drawing.Point(20, 115);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(102, 20);
            this.tb_data.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Data";
            // 
            // lbl_Paciente
            // 
            this.lbl_Paciente.AutoSize = true;
            this.lbl_Paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paciente.Location = new System.Drawing.Point(128, 99);
            this.lbl_Paciente.Name = "lbl_Paciente";
            this.lbl_Paciente.Size = new System.Drawing.Size(69, 16);
            this.lbl_Paciente.TabIndex = 37;
            this.lbl_Paciente.Text = "Paciente";
            // 
            // tb_paciente
            // 
            this.tb_paciente.Enabled = false;
            this.tb_paciente.Location = new System.Drawing.Point(129, 115);
            this.tb_paciente.Name = "tb_paciente";
            this.tb_paciente.Size = new System.Drawing.Size(102, 20);
            this.tb_paciente.TabIndex = 36;
            // 
            // TelaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.lbl_Paciente);
            this.Controls.Add(this.tb_paciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pb_Inicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_historico);
            this.Controls.Add(this.btn_Iniciar_Consulta);
            this.Controls.Add(this.lbl_Mensagem_Consulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Consulta";
            this.Load += new System.EventHandler(this.TelaConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Mensagem_Consulta;
        private System.Windows.Forms.Button btn_Iniciar_Consulta;
        private System.Windows.Forms.PictureBox pb_Inicio;
        private System.Windows.Forms.DataGridView dgv_historico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_IniciarConsulta;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Paciente;
        private System.Windows.Forms.TextBox tb_paciente;
    }
}