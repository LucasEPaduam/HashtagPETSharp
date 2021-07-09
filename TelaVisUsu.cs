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
    public partial class TelaVisUsu : Form
    {
        public TelaVisUsu(TelaCadUsu telacadusu)
        {
            InitializeComponent();
            this.tela_cadusu = telacadusu;
        }
        private TelaCadUsu tela_cadusu;

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_Voltarparacadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadUsu tela_cadusu = new TelaCadUsu(this);
            tela_cadusu.Show();
        }

        private void TelaVisUsu_Load(object sender, EventArgs e)
        {
            int i = 0;
            string todospacientes = "SELECT administrativo.cpf as 'cpf administrativo', administrativo.nome as 'nome adm', veterinario.crmv as 'crmv veterinario', veterinario.nome as 'nome vet' FROM administrativo, veterinario";

            dgv_TelaVisUsu.DataSource = BancoDados.Consulta(todospacientes);
            dgv_TelaVisUsu.Columns[0].Width = 90;
            dgv_TelaVisUsu.Columns[1].Width = 100;
            dgv_TelaVisUsu.Columns[2].Width = 130;
            dgv_TelaVisUsu.Columns[3].Width = 100;
            dgv_TelaVisUsu.Sort(dgv_TelaVisUsu.Columns[i], ListSortDirection.Ascending);
        }
    }
}
