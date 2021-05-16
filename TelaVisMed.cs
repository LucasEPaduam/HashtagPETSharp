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
    public partial class TelaVisMed : Form
    {
        public TelaVisMed(TelaCadMed telacadmed)
        {
            InitializeComponent();
            this.tela_cadmed = telacadmed;
        }
        private TelaCadMed tela_cadmed;

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_Voltarparacadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadMed tela_cadmed = new TelaCadMed(this);
            tela_cadmed.Show();
        }
    }
}
