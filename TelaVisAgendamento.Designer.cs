
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVisAgendamento));
            this.lbl_Hor_consulta = new System.Windows.Forms.Label();
            this.lbl_Cod_consulta = new System.Windows.Forms.Label();
            this.lbl_Agendamentos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_RecebeDataPicker = new System.Windows.Forms.Label();
            this.btn_FecharAgendamento = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Hor_consulta
            // 
            this.lbl_Hor_consulta.AutoSize = true;
            this.lbl_Hor_consulta.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hor_consulta.Location = new System.Drawing.Point(142, 103);
            this.lbl_Hor_consulta.Name = "lbl_Hor_consulta";
            this.lbl_Hor_consulta.Size = new System.Drawing.Size(135, 23);
            this.lbl_Hor_consulta.TabIndex = 2;
            this.lbl_Hor_consulta.Text = "Horário consulta";
            // 
            // lbl_Cod_consulta
            // 
            this.lbl_Cod_consulta.AutoSize = true;
            this.lbl_Cod_consulta.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cod_consulta.Location = new System.Drawing.Point(309, 103);
            this.lbl_Cod_consulta.Name = "lbl_Cod_consulta";
            this.lbl_Cod_consulta.Size = new System.Drawing.Size(95, 23);
            this.lbl_Cod_consulta.TabIndex = 3;
            this.lbl_Cod_consulta.Text = "Código PET";
            // 
            // lbl_Agendamentos
            // 
            this.lbl_Agendamentos.AutoSize = true;
            this.lbl_Agendamentos.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Agendamentos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Agendamentos.Location = new System.Drawing.Point(229, 2);
            this.lbl_Agendamentos.Name = "lbl_Agendamentos";
            this.lbl_Agendamentos.Size = new System.Drawing.Size(156, 29);
            this.lbl_Agendamentos.TabIndex = 0;
            this.lbl_Agendamentos.Text = "Agendamentos";
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
            // lbl_RecebeDataPicker
            // 
            this.lbl_RecebeDataPicker.AutoSize = true;
            this.lbl_RecebeDataPicker.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecebeDataPicker.Location = new System.Drawing.Point(206, 67);
            this.lbl_RecebeDataPicker.Name = "lbl_RecebeDataPicker";
            this.lbl_RecebeDataPicker.Size = new System.Drawing.Size(211, 27);
            this.lbl_RecebeDataPicker.TabIndex = 28;
            this.lbl_RecebeDataPicker.Text = "lbl_RecebeDataPicker";
            // 
            // btn_FecharAgendamento
            // 
            this.btn_FecharAgendamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_FecharAgendamento.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_FecharAgendamento.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_FecharAgendamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_FecharAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FecharAgendamento.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FecharAgendamento.Location = new System.Drawing.Point(270, 356);
            this.btn_FecharAgendamento.Name = "btn_FecharAgendamento";
            this.btn_FecharAgendamento.Size = new System.Drawing.Size(74, 41);
            this.btn_FecharAgendamento.TabIndex = 29;
            this.btn_FecharAgendamento.Text = "Fechar";
            this.btn_FecharAgendamento.UseVisualStyleBackColor = false;
            this.btn_FecharAgendamento.Click += new System.EventHandler(this.btn_FecharAgendamento_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(309, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(157, 214);
            this.dataGridView1.TabIndex = 31;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(146, 129);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(157, 214);
            this.dataGridView2.TabIndex = 32;
            // 
            // TelaVisAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_FecharAgendamento);
            this.Controls.Add(this.lbl_RecebeDataPicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Cod_consulta);
            this.Controls.Add(this.lbl_Hor_consulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaVisAgendamento";
            this.Text = "Visualizar Agendamento";
            this.Load += new System.EventHandler(this.TelaVisAgendamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Hor_consulta;
        private System.Windows.Forms.Label lbl_Cod_consulta;
        private System.Windows.Forms.Label lbl_Agendamentos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_RecebeDataPicker;
        private System.Windows.Forms.Button btn_FecharAgendamento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}