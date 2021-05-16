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
    public partial class TelaCadPac : Form
    {
        public TelaCadPac(TelaInicial telaInicial)
        {
            InitializeComponent();
            this.tela_inicial = telaInicial;
        }

        private TelaInicial tela_inicial;

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            //TextBox do Paciente
            tb_Codigo_Pac.Clear();
            tb_Nome_Pac.Clear();
            tb_Raça.Clear();
            tb_Idade.Clear();
            tb_Peso.Clear();
            tb_Altura.Clear();

            //TextBox do Dono 
            tb_CPF.Clear();
            tb_NomeDono.Clear();
            tb_Rua.Clear();
            tb_Nº.Clear();
            tb_CEP.Clear();
            tb_Cidade.Clear();
            tb_email.Clear();
            tb_Tel.Clear();
        }

        public TelaCadPac(TelaVisPac telavispac)
        {
            InitializeComponent();
            this.tela_vispac = telavispac;
        }
        private TelaVisPac tela_vispac;

        private void btn_Histórico_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVisPac telavispac = new TelaVisPac(this);
            telavispac.Show();
        }
    }
}
