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
    public partial class TelaCadMed : Form
    {
        public TelaCadMed(TelaInicial telaInicial)
        {
            InitializeComponent();
            this.tela_inicial = telaInicial;
        }
        private TelaInicial tela_inicial;

        public TelaCadMed(TelaVisMed telavismed)
        {
            InitializeComponent();
            this.tela_vismed = telavismed;
        }
        private TelaVisMed tela_vismed;

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tb_Cod_Med.Text = "";
            tb_Nome_Med.Text = "";
            tb_Preco_Med.Text = "";
        }

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

        private void btn_Histórico_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVisMed telavismed = new TelaVisMed(this);
            telavismed.Show();
        }
    }
}
