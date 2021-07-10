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
    public partial class TelaVisAdm : Form
    {
        public TelaVisAdm(TelaCadUsu telacadusu)
        {
            InitializeComponent();
            this.tela_cadusu = telacadusu;
        }
        private TelaCadUsu tela_cadusu;

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Close();
            tela_cadusu.Close();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_Voltarparacadastro_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void TelaVisUsu_Load(object sender, EventArgs e)
        {
            int i = 0;
            string todosadm = "SELECT administrativo.cpf as 'cpf administrativo', administrativo.nome as 'nome adm' FROM administrativo";

            dgv_TelaVisUsu.DataSource = BancoDados.Consulta(todosadm);
            dgv_TelaVisUsu.Columns[0].Width = 215;
            dgv_TelaVisUsu.Columns[1].Width = 215;
            dgv_TelaVisUsu.Sort(dgv_TelaVisUsu.Columns[i], ListSortDirection.Ascending);
        }
    }
}
