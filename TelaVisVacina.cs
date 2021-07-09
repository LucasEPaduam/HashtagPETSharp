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
    public partial class TelaVisVacina : Form
    {
        public TelaVisVacina()
        {
            InitializeComponent();
        }

        public TelaVisVacina(TelaCadMed telacadmed)
        {
            InitializeComponent();
            this.tela_cadmed = telacadmed;
        }
        private TelaCadMed tela_cadmed;


        private void TelaVisVacina_Load(object sender, EventArgs e)
        {
            int i = 0;
            string todosvacina = "SELECT Vacina.codigo as 'CODIGO', vacina.nome as 'NOME', vacina.preco as 'VALOR' FROM Vacina";

            dgv_TelaVisVacina.DataSource = BancoDados.Consulta(todosvacina);
            dgv_TelaVisVacina.Columns[0].Width = 90;
            dgv_TelaVisVacina.Columns[1].Width = 210;
            dgv_TelaVisVacina.Columns[2].Width = 120;            
            dgv_TelaVisVacina.Sort(dgv_TelaVisVacina.Columns[i], ListSortDirection.Ascending);
        }

        private void btn_Voltarparacadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Close();
            this.tela_cadmed.Close();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }
    }
}
