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
    public partial class TelaVisPac : Form
    {
        public TelaVisPac(TelaCadPac telacadpac)
        {
            InitializeComponent();
            this.tela_cadpac = telacadpac;
        }
        private TelaCadPac tela_cadpac;


        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_Voltarparacadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadPac tela_cadpac = new TelaCadPac(this);
            tela_cadpac.Show();
        }
    }
}
