using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjInter
{
    public partial class TelaCadNewLogin : Form
    {
        public TelaCadNewLogin()
        {
            InitializeComponent();
            
        }

        public TelaCadNewLogin(TelaLogin telaLogin)
        {
            InitializeComponent();
            this.telaLogin = telaLogin;
        }
        private TelaLogin telaLogin;

        private void btn_Salvar_Usu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin tela_login = new TelaLogin(this);
            tela_login.Show();
        }

        private void ckb_opcao_Administrativo_CheckedChanged(object sender, EventArgs e)
        {
           
                if (ckb_opcao_Administrativo.Checked)
                {
                    tb_Cargo_Usu.Enabled = true;
                    tb_Cidade_Usu.Enabled = true;
                    tb_CEP_Usu.Enabled = true;
                    tb_CPF_Usu.Enabled = true;
                    tb_Cod_Usu.Enabled = true;
                    tb_Idade_Usu.Enabled = true;
                    tb_Nasc_Usu.Enabled = true;
                    tb_Nome_Usu.Enabled = true;
                    tb_Num_Usu.Enabled = true;
                    tb_Rua_Av_Usu.Enabled = true;
                    tb_UF_Usu.Enabled = true;

                }
                else
                {
                    tb_Cargo_Usu.Enabled = false;
                    tb_Cidade_Usu.Enabled = false;
                    tb_CEP_Usu.Enabled = false;
                    tb_CPF_Usu.Enabled = false;
                    tb_Cod_Usu.Enabled = false;
                    tb_Idade_Usu.Enabled = false;
                    tb_Nasc_Usu.Enabled = false;
                    tb_Nome_Usu.Enabled = false;
                    tb_Num_Usu.Enabled = false;
                    tb_Rua_Av_Usu.Enabled = false;
                    tb_UF_Usu.Enabled = false;
                }


            

           
        }

        private void ckb_Veterinario_CheckedChanged(object sender, EventArgs e)
        {

            if (ckb_Veterinario.Checked)
            {

                tb_Cep_Med_Usu.Enabled = true;
                tb_CRMV_Usu.Enabled = true;
                tb_Nome_Vet_Usu.Enabled = true;
                tb_N_Usu.Enabled = true;
                tb_Rua_Usu.Enabled = true;
                tb_UF_Med_Usu.Enabled = true;
                tb_Cid_Usu.Enabled = true;

            }
            else
            {

                tb_Cep_Med_Usu.Enabled = false;
                tb_CRMV_Usu.Enabled = false;
                tb_Nome_Vet_Usu.Enabled = false;
                tb_N_Usu.Enabled = false;
                tb_Rua_Usu.Enabled = false;
                tb_UF_Med_Usu.Enabled = false;
                tb_Cid_Usu.Enabled = false;




            }
        }

       
    }
}
