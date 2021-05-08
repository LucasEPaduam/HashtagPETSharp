
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
            this.lbl_Mensagem_Consulta = new System.Windows.Forms.Label();
            this.lbl_Cod_PET = new System.Windows.Forms.Label();
            this.txb_Cod_PET = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Iniciar_Consulta = new System.Windows.Forms.Button();
            this.pb_Inicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Mensagem_Consulta
            // 
            this.lbl_Mensagem_Consulta.AutoSize = true;
            this.lbl_Mensagem_Consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mensagem_Consulta.Location = new System.Drawing.Point(15, 35);
            this.lbl_Mensagem_Consulta.Name = "lbl_Mensagem_Consulta";
            this.lbl_Mensagem_Consulta.Size = new System.Drawing.Size(437, 20);
            this.lbl_Mensagem_Consulta.TabIndex = 0;
            this.lbl_Mensagem_Consulta.Text = "Para iniciar a consulta, entrar com o código do animal";
            // 
            // lbl_Cod_PET
            // 
            this.lbl_Cod_PET.AutoSize = true;
            this.lbl_Cod_PET.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cod_PET.Location = new System.Drawing.Point(16, 61);
            this.lbl_Cod_PET.Name = "lbl_Cod_PET";
            this.lbl_Cod_PET.Size = new System.Drawing.Size(62, 18);
            this.lbl_Cod_PET.TabIndex = 1;
            this.lbl_Cod_PET.Text = "Código";
            // 
            // txb_Cod_PET
            // 
            this.txb_Cod_PET.Location = new System.Drawing.Point(84, 59);
            this.txb_Cod_PET.Name = "txb_Cod_PET";
            this.txb_Cod_PET.Size = new System.Drawing.Size(142, 20);
            this.txb_Cod_PET.TabIndex = 2;
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(280, 58);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(142, 21);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 196);
            this.panel1.TabIndex = 4;
            // 
            // btn_Iniciar_Consulta
            // 
            this.btn_Iniciar_Consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar_Consulta.Location = new System.Drawing.Point(342, 304);
            this.btn_Iniciar_Consulta.Name = "btn_Iniciar_Consulta";
            this.btn_Iniciar_Consulta.Size = new System.Drawing.Size(170, 35);
            this.btn_Iniciar_Consulta.TabIndex = 5;
            this.btn_Iniciar_Consulta.Text = "Iniciar consulta";
            this.btn_Iniciar_Consulta.UseVisualStyleBackColor = true;
            // 
            // pb_Inicio
            // 
            this.pb_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("pb_Inicio.Image")));
            this.pb_Inicio.Location = new System.Drawing.Point(0, 0);
            this.pb_Inicio.Name = "pb_Inicio";
            this.pb_Inicio.Size = new System.Drawing.Size(41, 31);
            this.pb_Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Inicio.TabIndex = 23;
            this.pb_Inicio.TabStop = false;
            // 
            // TelaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 351);
            this.Controls.Add(this.pb_Inicio);
            this.Controls.Add(this.btn_Iniciar_Consulta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txb_Cod_PET);
            this.Controls.Add(this.lbl_Cod_PET);
            this.Controls.Add(this.lbl_Mensagem_Consulta);
            this.Name = "TelaConsulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Mensagem_Consulta;
        private System.Windows.Forms.Label lbl_Cod_PET;
        private System.Windows.Forms.TextBox txb_Cod_PET;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Iniciar_Consulta;
        private System.Windows.Forms.PictureBox pb_Inicio;
    }
}