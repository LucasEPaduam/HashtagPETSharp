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
    public partial class TelaVisExame : Form
    {
        public TelaVisExame(TelaCadExame telacadexame)
        {
            InitializeComponent();
            this.tela_cadexame = telacadexame;
        }
        private TelaCadExame tela_cadexame;

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_Voltarparacadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadExame tela_cadexame = new TelaCadExame(this);
            tela_cadexame.Show();
        }
    }
}
