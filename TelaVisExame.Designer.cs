
namespace ProjInter
{
    partial class TelaVisExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVisExame));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_PacientesCadastrados = new System.Windows.Forms.Label();
            this.pb_Inicio = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Voltarparacadastro = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.dgv_TelaVisExame = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TelaVisExame)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PacientesCadastrados
            // 
            this.lbl_PacientesCadastrados.AutoSize = true;
            this.lbl_PacientesCadastrados.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PacientesCadastrados.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_PacientesCadastrados.Location = new System.Drawing.Point(122, 2);
            this.lbl_PacientesCadastrados.Name = "lbl_PacientesCadastrados";
            this.lbl_PacientesCadastrados.Size = new System.Drawing.Size(221, 29);
            this.lbl_PacientesCadastrados.TabIndex = 0;
            this.lbl_PacientesCadastrados.Text = "Exames Cadastrados";
            // 
            // pb_Inicio
            // 
            this.pb_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("pb_Inicio.Image")));
            this.pb_Inicio.Location = new System.Drawing.Point(1, 12);
            this.pb_Inicio.Name = "pb_Inicio";
            this.pb_Inicio.Size = new System.Drawing.Size(30, 30);
            this.pb_Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Inicio.TabIndex = 29;
            this.pb_Inicio.TabStop = false;
            this.pb_Inicio.Click += new System.EventHandler(this.pb_Inicio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_PacientesCadastrados);
            this.panel1.Location = new System.Drawing.Point(-3, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 34);
            this.panel1.TabIndex = 30;
            // 
            // btn_Voltarparacadastro
            // 
            this.btn_Voltarparacadastro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Voltarparacadastro.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Voltarparacadastro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Voltarparacadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Voltarparacadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltarparacadastro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltarparacadastro.Location = new System.Drawing.Point(258, 352);
            this.btn_Voltarparacadastro.Name = "btn_Voltarparacadastro";
            this.btn_Voltarparacadastro.Size = new System.Drawing.Size(198, 35);
            this.btn_Voltarparacadastro.TabIndex = 31;
            this.btn_Voltarparacadastro.Text = "Voltar para cadastro";
            this.btn_Voltarparacadastro.UseVisualStyleBackColor = false;
            this.btn_Voltarparacadastro.Click += new System.EventHandler(this.btn_Voltarparacadastro_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(436, 54);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 291);
            this.vScrollBar1.TabIndex = 33;
            // 
            // dgv_TelaVisExame
            // 
            this.dgv_TelaVisExame.AllowUserToAddRows = false;
            this.dgv_TelaVisExame.AllowUserToDeleteRows = false;
            this.dgv_TelaVisExame.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TelaVisExame.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_TelaVisExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TelaVisExame.EnableHeadersVisualStyles = false;
            this.dgv_TelaVisExame.Location = new System.Drawing.Point(13, 53);
            this.dgv_TelaVisExame.MultiSelect = false;
            this.dgv_TelaVisExame.Name = "dgv_TelaVisExame";
            this.dgv_TelaVisExame.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TelaVisExame.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_TelaVisExame.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TelaVisExame.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_TelaVisExame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TelaVisExame.Size = new System.Drawing.Size(443, 293);
            this.dgv_TelaVisExame.TabIndex = 32;
            // 
            // TelaVisExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(467, 393);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dgv_TelaVisExame);
            this.Controls.Add(this.btn_Voltarparacadastro);
            this.Controls.Add(this.pb_Inicio);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaVisExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Visualizar Exames";
            this.Load += new System.EventHandler(this.TelaVisExame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TelaVisExame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_PacientesCadastrados;
        private System.Windows.Forms.PictureBox pb_Inicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Voltarparacadastro;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.DataGridView dgv_TelaVisExame;
    }
}