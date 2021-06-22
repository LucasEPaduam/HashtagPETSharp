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
    public partial class TelaVisPac : Form
    {
        public TelaVisPac(TelaCadPac telacadpac)
        {
            InitializeComponent();
            this.tela_cadpac = telacadpac;
            
        }
        private TelaCadPac tela_cadpac;
        

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Close();
            tela_cadpac.Close();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_Voltarparacadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaVisPac_Load(object sender, EventArgs e)
        {
            int i = 0;
            string todospacientes = "SELECT paciente.codigopet as 'COD PET', paciente.nomepet as 'NOME PET', dono.nomedono as 'DONO PET', dono.cpf as 'CPF' FROM paciente, dono WHERE paciente.codigopet = dono.paciente_codigopet";

            dgv_TelaVisPac.DataSource = BancoDados.Consulta(todospacientes);
            dgv_TelaVisPac.Columns[0].Width = 90;
            dgv_TelaVisPac.Columns[1].Width = 100;
            dgv_TelaVisPac.Columns[2].Width = 130;
            dgv_TelaVisPac.Columns[3].Width = 100;
            dgv_TelaVisPac.Sort(dgv_TelaVisPac.Columns[i], ListSortDirection.Ascending);
        }
    }
}
