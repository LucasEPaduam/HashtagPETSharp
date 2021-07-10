
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Mensagem_Consulta = new System.Windows.Forms.Label();
            this.lbl_Cod_PET = new System.Windows.Forms.Label();
            this.tb_Cod_PET = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Iniciar_Consulta = new System.Windows.Forms.Button();
            this.pb_Inicio = new System.Windows.Forms.PictureBox();
            this.dgv_Histórico = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_IniciarConsulta = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Histórico)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Mensagem_Consulta
            // 
            this.lbl_Mensagem_Consulta.AutoSize = true;
            this.lbl_Mensagem_Consulta.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mensagem_Consulta.Location = new System.Drawing.Point(19, 61);
            this.lbl_Mensagem_Consulta.Name = "lbl_Mensagem_Consulta";
            this.lbl_Mensagem_Consulta.Size = new System.Drawing.Size(384, 24);
            this.lbl_Mensagem_Consulta.TabIndex = 0;
            this.lbl_Mensagem_Consulta.Text = "Para iniciar a consulta digite o código do PET\r\n";
            // 
            // lbl_Cod_PET
            // 
            this.lbl_Cod_PET.AutoSize = true;
            this.lbl_Cod_PET.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cod_PET.Location = new System.Drawing.Point(18, 89);
            this.lbl_Cod_PET.Name = "lbl_Cod_PET";
            this.lbl_Cod_PET.Size = new System.Drawing.Size(56, 22);
            this.lbl_Cod_PET.TabIndex = 1;
            this.lbl_Cod_PET.Text = "Código";
            // 
            // tb_Cod_PET
            // 
            this.tb_Cod_PET.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Cod_PET.Location = new System.Drawing.Point(73, 92);
            this.tb_Cod_PET.Name = "tb_Cod_PET";
            this.tb_Cod_PET.Size = new System.Drawing.Size(151, 20);
            this.tb_Cod_PET.TabIndex = 2;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_OK.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(230, 90);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(44, 25);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Iniciar_Consulta
            // 
            this.btn_Iniciar_Consulta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Iniciar_Consulta.Enabled = false;
            this.btn_Iniciar_Consulta.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar_Consulta.Location = new System.Drawing.Point(442, 364);
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
            // dgv_Histórico
            // 
            this.dgv_Histórico.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Histórico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Histórico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Histórico.EnableHeadersVisualStyles = false;
            this.dgv_Histórico.Location = new System.Drawing.Point(20, 121);
            this.dgv_Histórico.Name = "dgv_Histórico";
            this.dgv_Histórico.RowHeadersVisible = false;
            this.dgv_Histórico.Size = new System.Drawing.Size(552, 238);
            this.dgv_Histórico.TabIndex = 24;
            this.dgv_Histórico.Visible = false;
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
            this.vScrollBar1.Location = new System.Drawing.Point(554, 123);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 233);
            this.vScrollBar1.TabIndex = 30;
            // 
            // TelaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pb_Inicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Histórico);
            this.Controls.Add(this.btn_Iniciar_Consulta);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tb_Cod_PET);
            this.Controls.Add(this.lbl_Cod_PET);
            this.Controls.Add(this.lbl_Mensagem_Consulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Histórico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Mensagem_Consulta;
        private System.Windows.Forms.Label lbl_Cod_PET;
        private System.Windows.Forms.TextBox tb_Cod_PET;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Iniciar_Consulta;
        private System.Windows.Forms.PictureBox pb_Inicio;
        private System.Windows.Forms.DataGridView dgv_Histórico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_IniciarConsulta;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}