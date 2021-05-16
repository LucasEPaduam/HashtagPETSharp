
namespace ProjInter
{
    partial class TelaVisPac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVisPac));
            this.pb_Inicio = new System.Windows.Forms.PictureBox();
            this.dgv_TelaVisPac = new System.Windows.Forms.DataGridView();
            this.btn_Voltarparacadastro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_HistoricoPac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TelaVisPac)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Inicio
            // 
            this.pb_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("pb_Inicio.Image")));
            this.pb_Inicio.Location = new System.Drawing.Point(1, 14);
            this.pb_Inicio.Name = "pb_Inicio";
            this.pb_Inicio.Size = new System.Drawing.Size(30, 30);
            this.pb_Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Inicio.TabIndex = 25;
            this.pb_Inicio.TabStop = false;
            this.pb_Inicio.Click += new System.EventHandler(this.pb_Inicio_Click);
            // 
            // dgv_TelaVisPac
            // 
            this.dgv_TelaVisPac.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_TelaVisPac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TelaVisPac.Location = new System.Drawing.Point(12, 54);
            this.dgv_TelaVisPac.Name = "dgv_TelaVisPac";
            this.dgv_TelaVisPac.Size = new System.Drawing.Size(560, 293);
            this.dgv_TelaVisPac.TabIndex = 26;
            // 
            // btn_Voltarparacadastro
            // 
            this.btn_Voltarparacadastro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Voltarparacadastro.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Voltarparacadastro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Voltarparacadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Voltarparacadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltarparacadastro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltarparacadastro.Location = new System.Drawing.Point(374, 364);
            this.btn_Voltarparacadastro.Name = "btn_Voltarparacadastro";
            this.btn_Voltarparacadastro.Size = new System.Drawing.Size(198, 35);
            this.btn_Voltarparacadastro.TabIndex = 27;
            this.btn_Voltarparacadastro.Text = "Voltar para cadastro";
            this.btn_Voltarparacadastro.UseVisualStyleBackColor = false;
            this.btn_Voltarparacadastro.Click += new System.EventHandler(this.btn_Voltarparacadastro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_HistoricoPac);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 34);
            this.panel1.TabIndex = 28;
            // 
            // lbl_HistoricoPac
            // 
            this.lbl_HistoricoPac.AutoSize = true;
            this.lbl_HistoricoPac.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HistoricoPac.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_HistoricoPac.Location = new System.Drawing.Point(182, 2);
            this.lbl_HistoricoPac.Name = "lbl_HistoricoPac";
            this.lbl_HistoricoPac.Size = new System.Drawing.Size(230, 29);
            this.lbl_HistoricoPac.TabIndex = 0;
            this.lbl_HistoricoPac.Text = "Histórico do Paciente";
            // 
            // TelaVisPac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.pb_Inicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Voltarparacadastro);
            this.Controls.Add(this.dgv_TelaVisPac);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaVisPac";
            this.Text = "Histórico do Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TelaVisPac)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Inicio;
        private System.Windows.Forms.DataGridView dgv_TelaVisPac;
        private System.Windows.Forms.Button btn_Voltarparacadastro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_HistoricoPac;
    }
}