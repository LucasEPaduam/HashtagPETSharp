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

        public TelaIniciarConsulta (string cod)
        {
            InitializeComponent();

            codigopet = cod;
        }

        string codigopet;

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

           //double peso = double.Parse(tb_Peso.Text);
           string idade = tb_Idade.Text;
          // double temperatura = double.Parse(tb_Temp.Text);
           string observacoes = richTextBox1.Text;



            

           

            

        }
        
        private void rb_sim_vac_CheckedChanged(object sender, EventArgs e)
        {
            string cb_vacina = @"SELECT codigo, nome FROM Vacina ORDER BY nome ASC";
            cb_Qual_Vac.DataSource = BancoDados.Consulta(cb_vacina);
            cb_Qual_Vac.DisplayMember = "nome";
            cb_Qual_Vac.ValueMember = "codigo";
        }

        private void rb_nao_vac_CheckedChanged(object sender, EventArgs e)
        {
            cb_Qual_Vac.Text = "";
        }

        private void rb_sim_rem_CheckedChanged(object sender, EventArgs e)
        {
            string cb_remedio = @"SELECT codigo, nome FROM Remedio ORDER BY nome ASC";           
            cb_Qual_Rem.DataSource = BancoDados.Consulta(cb_remedio);
            cb_Qual_Rem.DisplayMember = "nome";
            cb_Qual_Rem.ValueMember = "codigo";
        }

        private void rb_nao_rem_CheckedChanged(object sender, EventArgs e)
        {
            cb_Qual_Rem.Text = "";
        }

        private void rb_sim_exa_CheckedChanged(object sender, EventArgs e)
        {
            string cb_exame = @"SELECT codigo, nome FROM Exame ORDER BY nome ASC";                        
            cb_Qual_Exame.DataSource = BancoDados.Consulta(cb_exame);
            cb_Qual_Exame.DisplayMember = "nome";
            cb_Qual_Exame.ValueMember = "codigo";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cb_Qual_Exame.Text = "";
        }
    }
}
