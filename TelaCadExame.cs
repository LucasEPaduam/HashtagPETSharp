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
    public partial class TelaCadExame : Form
    {
        public TelaCadExame(TelaInicial telaInicial)
        {
            InitializeComponent();
            this.tela_inicial = telaInicial;
        }
        private TelaInicial tela_inicial;

        public TelaCadExame(TelaVisExame telavisexame)
        {
            InitializeComponent();
            this.tela_visexame = telavisexame;
        }
        private TelaVisExame tela_visexame;

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tb_Cod_Exame.Text = "";
            tb_Nome_Exame.Clear();
            tb_Preco_Exame.Text = "";
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
            TelaVisExame telavisexame = new TelaVisExame(this);
            telavisexame.Show();
        }
    }
}
