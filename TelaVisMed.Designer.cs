
namespace ProjInter
{
    partial class TelaVisMed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVisMed));
            this.pb_Inicio = new System.Windows.Forms.PictureBox();
            this.dgv_TelaVisMed = new System.Windows.Forms.DataGridView();
            this.btn_Voltarparacadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TelaVisMed)).BeginInit();
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
            this.pb_Inicio.Click += new System.EventHandler(this.pb_Inicio_Click);
            // 
            // dgv_TelaVisMed
            // 
            this.dgv_TelaVisMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TelaVisMed.Location = new System.Drawing.Point(12, 59);
            this.dgv_TelaVisMed.Name = "dgv_TelaVisMed";
            this.dgv_TelaVisMed.Size = new System.Drawing.Size(560, 293);
            this.dgv_TelaVisMed.TabIndex = 27;
            // 
            // btn_Voltarparacadastro
            // 
            this.btn_Voltarparacadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltarparacadastro.Location = new System.Drawing.Point(374, 364);
            this.btn_Voltarparacadastro.Name = "btn_Voltarparacadastro";
            this.btn_Voltarparacadastro.Size = new System.Drawing.Size(198, 35);
            this.btn_Voltarparacadastro.TabIndex = 28;
            this.btn_Voltarparacadastro.Text = "Voltar para cadastro";
            this.btn_Voltarparacadastro.UseVisualStyleBackColor = true;
            this.btn_Voltarparacadastro.Click += new System.EventHandler(this.btn_Voltarparacadastro_Click);
            // 
            // TelaVisMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btn_Voltarparacadastro);
            this.Controls.Add(this.dgv_TelaVisMed);
            this.Controls.Add(this.pb_Inicio);
            this.Name = "TelaVisMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Medicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TelaVisMed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Inicio;
        private System.Windows.Forms.DataGridView dgv_TelaVisMed;
        private System.Windows.Forms.Button btn_Voltarparacadastro;
    }
}