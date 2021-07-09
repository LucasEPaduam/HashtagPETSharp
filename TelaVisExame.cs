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
            this.Close();
            tela_cadexame.Close();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_Voltarparacadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaVisExame_Load(object sender, EventArgs e)
        {
            int i = 0;
            string todosexames = "SELECT exame.codigo as 'COD EXAME', exame.nome as 'NOME EXAME', exame.preco as 'VALOR' FROM Exame";

            dgv_TelaVisExame.DataSource = BancoDados.Consulta(todosexames);
            dgv_TelaVisExame.Columns[0].Width = 140;
            dgv_TelaVisExame.Columns[1].Width = 140;
            dgv_TelaVisExame.Columns[2].Width = 140;
            dgv_TelaVisExame.Sort(dgv_TelaVisExame.Columns[i], ListSortDirection.Ascending);
        }
    }
}
