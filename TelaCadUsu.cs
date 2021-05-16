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
    public partial class TelaCadUsu : Form
    {
        public TelaCadUsu(TelaLogin telaLogin)
        {
            InitializeComponent();
            this.tela_login = telaLogin;
        }

        public TelaCadUsu(TelaInicial telaInicial)
        {
            InitializeComponent();
            this.tela_inicial = telaInicial;
        }

        private TelaLogin tela_login;
        private TelaInicial tela_inicial;

        public TelaCadUsu(TelaVisUsu telavisusu)
        {
            InitializeComponent();
            this.tela_visusu = telavisusu;
        }
        private TelaVisUsu tela_visusu;

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            //TextBox do Administrativo
            tb_Cod_Usu.Clear();
            tb_Cargo_Usu.Clear();
            tb_Nasc_Usu.Clear();
            tb_CPF_Usu.Clear();
            tb_Nasc_Usu.Clear();
            tb_Idade_Usu.Clear();
            tb_Rua_Av_Usu.Clear();
            tb_Num_Usu.Clear();
            tb_CEP_Usu.Clear();
            tb_Cidade_Usu.Clear();
            tb_UF_Usu.Clear();

            //TextBox do Veterinário
            tb_CRMV_Usu.Clear();
            tb_Nome_Vet_Usu.Clear();
            tb_Rua_Usu.Clear();
            tb_N_Usu.Clear();
            tb_Cep_Med_Usu.Clear();
            tb_Cid_Usu.Clear();
            tb_UF_Med_Usu.Clear();
        }

        private void btn_Salvar_Usu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_Histórico_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVisUsu telavisusu = new TelaVisUsu(this);
            telavisusu.Show();
        }

        private void pb_InicioTCad_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void lbl_Veterinario_Click(object sender, EventArgs e)
        {

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
