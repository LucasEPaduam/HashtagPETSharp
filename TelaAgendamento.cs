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
    public partial class TelaAgendamento : Form
    {
        public TelaAgendamento(TelaInicial telaInicial)
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

        private void btn_Agendado_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void lbl_Dia_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Hora_Click(object sender, EventArgs e)
        {

        }

        private void tb_Dia_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Hora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
