﻿using System;
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
    public partial class TelaVisVet : Form
    {
        public TelaVisVet(TelaCadUsu telacadusu)
        {
            InitializeComponent();
            this.tela_cadusu = telacadusu;
        }
        private TelaCadUsu tela_cadusu;

        public TelaVisVet(TelaAgendamento telaAgendamento)
        {
            InitializeComponent();
            this.tela_agendamento = telaAgendamento;
        }
        private TelaAgendamento tela_agendamento;



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

        private void TelaVisVet_Load(object sender, EventArgs e)
        {
            int i = 0;
            string todosvet = "SELECT veterinario.crmv as 'CRMV', veterinario.nome as 'NOME' FROM veterinario";

            dgv_TelaVisUsu.DataSource = BancoDados.Consulta(todosvet);
            dgv_TelaVisUsu.Columns[0].Width = 160;
            dgv_TelaVisUsu.Columns[1].Width = 260;
            dgv_TelaVisUsu.Sort(dgv_TelaVisUsu.Columns[i], ListSortDirection.Ascending);
        }
    }
}
