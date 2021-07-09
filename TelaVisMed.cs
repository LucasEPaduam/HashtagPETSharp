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
            this.Close();
        }

        private void TelaVisMed_Load(object sender, EventArgs e)
        {
            
            int i = 0;
            string todosmedicamentos = "SELECT Vacina.codigo as 'COD VAC', vacina.nome as 'NOME VAC', vacina.preco as 'PRECO VAC', remedio.codigo as 'COD REM', remedio.nome as 'NOME REM', remedio.preco as 'PRECO REM' FROM vacina, remedio ";

            dgv_TelaVisMed.DataSource = BancoDados.Consulta(todosmedicamentos);
            dgv_TelaVisMed.Columns[0].Width = 90;
            dgv_TelaVisMed.Columns[1].Width = 100;
            dgv_TelaVisMed.Columns[2].Width = 130;
            dgv_TelaVisMed.Columns[3].Width = 100;
            dgv_TelaVisMed.Sort(dgv_TelaVisMed.Columns[i], ListSortDirection.Ascending);
        }
    }
}
