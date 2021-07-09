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
            this.Close();
            this.tela_cadmed.Close();
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
            string todosmedicamentos = "SELECT remedio.codigo as 'CODIGO', remedio.nome as 'NOME', remedio.preco as 'VALOR' FROM Remedio";

            dgv_TelaVisMed.DataSource = BancoDados.Consulta(todosmedicamentos);
            dgv_TelaVisMed.Columns[0].Width = 90;
            dgv_TelaVisMed.Columns[1].Width = 210;
            dgv_TelaVisMed.Columns[2].Width = 120;
            dgv_TelaVisMed.Sort(dgv_TelaVisMed.Columns[i], ListSortDirection.Ascending);
        }
    }
}
