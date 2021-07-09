
namespace ProjInter
{
    partial class TelaVisUsu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVisUsu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.pb_Inicio = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_UsuariosCadastrados = new System.Windows.Forms.Label();
            this.btn_Voltarparacadastro = new System.Windows.Forms.Button();
            this.dgv_TelaVisUsu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TelaVisUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(492, 61);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 291);
            this.vScrollBar1.TabIndex = 39;
            // 
            // pb_Inicio
            // 
            this.pb_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("pb_Inicio.Image")));
            this.pb_Inicio.Location = new System.Drawing.Point(58, 20);
            this.pb_Inicio.Name = "pb_Inicio";
            this.pb_Inicio.Size = new System.Drawing.Size(30, 30);
            this.pb_Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Inicio.TabIndex = 35;
            this.pb_Inicio.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_UsuariosCadastrados);
            this.panel1.Location = new System.Drawing.Point(57, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 34);
            this.panel1.TabIndex = 38;
            // 
            // lbl_UsuariosCadastrados
            // 
            this.lbl_UsuariosCadastrados.AutoSize = true;
            this.lbl_UsuariosCadastrados.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsuariosCadastrados.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_UsuariosCadastrados.Location = new System.Drawing.Point(121, 3);
            this.lbl_UsuariosCadastrados.Name = "lbl_UsuariosCadastrados";
            this.lbl_UsuariosCadastrados.Size = new System.Drawing.Size(231, 29);
            this.lbl_UsuariosCadastrados.TabIndex = 0;
            this.lbl_UsuariosCadastrados.Text = "Usuarios Cadastrados";
            // 
            // btn_Voltarparacadastro
            // 
            this.btn_Voltarparacadastro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Voltarparacadastro.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Voltarparacadastro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Voltarparacadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Voltarparacadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltarparacadastro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltarparacadastro.Location = new System.Drawing.Point(314, 358);
            this.btn_Voltarparacadastro.Name = "btn_Voltarparacadastro";
            this.btn_Voltarparacadastro.Size = new System.Drawing.Size(198, 35);
            this.btn_Voltarparacadastro.TabIndex = 37;
            this.btn_Voltarparacadastro.Text = "Voltar para cadastro";
            this.btn_Voltarparacadastro.UseVisualStyleBackColor = false;
            this.btn_Voltarparacadastro.Click += new System.EventHandler(this.btn_Voltarparacadastro_Click);
            // 
            // dgv_TelaVisUsu
            // 
            this.dgv_TelaVisUsu.AllowUserToAddRows = false;
            this.dgv_TelaVisUsu.AllowUserToDeleteRows = false;
            this.dgv_TelaVisUsu.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TelaVisUsu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_TelaVisUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TelaVisUsu.EnableHeadersVisualStyles = false;
            this.dgv_TelaVisUsu.Location = new System.Drawing.Point(69, 60);
            this.dgv_TelaVisUsu.MultiSelect = false;
            this.dgv_TelaVisUsu.Name = "dgv_TelaVisUsu";
            this.dgv_TelaVisUsu.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TelaVisUsu.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_TelaVisUsu.RowHeadersVisible = false;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_TelaVisUsu.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_TelaVisUsu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TelaVisUsu.Size = new System.Drawing.Size(443, 293);
            this.dgv_TelaVisUsu.TabIndex = 36;
            // 
            // TelaVisUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pb_Inicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Voltarparacadastro);
            this.Controls.Add(this.dgv_TelaVisUsu);
            this.Name = "TelaVisUsu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Usuários";
            this.Load += new System.EventHandler(this.TelaVisUsu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TelaVisUsu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox pb_Inicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_UsuariosCadastrados;
        private System.Windows.Forms.Button btn_Voltarparacadastro;
        private System.Windows.Forms.DataGridView dgv_TelaVisUsu;
    }
}