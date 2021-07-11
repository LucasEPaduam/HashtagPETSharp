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
    public partial class TelaIniciarConsulta : Form
    {
        public TelaIniciarConsulta(TelaConsulta telaconsulta)
        {
            InitializeComponent();
            this.tela_consulta = telaconsulta;
        }
        private TelaConsulta tela_consulta;

        private void btn_Finalizar_Consulta_Click(object sender, EventArgs e)
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

        private void TelaIniciarConsulta_Load(object sender, EventArgs e)
        {
            
            double peso = double.Parse(tb_Peso.Text);
            string idade = tb_Idade.Text;
            double temperatura = double.Parse(tb_Temp.Text);
            string observacoes = richTextBox1.Text;
        }
    }
}
