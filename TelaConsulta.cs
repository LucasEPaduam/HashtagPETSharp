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
    public partial class TelaConsulta : Form
    {
        public TelaConsulta(TelaInicial telaInicial)
        {
            InitializeComponent();
            this.tela_inicial = telaInicial;
        }

        private TelaInicial tela_inicial;

        private void btn_Iniciar_Consulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaIniciarConsulta telainiciarconsulta = new TelaIniciarConsulta(this);
            telainiciarconsulta.Show();
        }

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            btn_Iniciar_Consulta.Enabled = true;
            dgv_Histórico.Visible = true;
        }
    }
}
