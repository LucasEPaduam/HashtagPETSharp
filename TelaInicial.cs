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
    public partial class TelaInicial : Form
    {
        public TelaInicial(TelaLogin telaLogin)
        {
            InitializeComponent();
            this.telaLogin = telaLogin;
        }
        private TelaLogin telaLogin;


        public TelaInicial(TelaCadUsu telacadusu)
        {
            InitializeComponent();
            this.tela_cadusu = telacadusu;
        }
        private TelaCadUsu tela_cadusu;


        public TelaInicial(TelaAgendamento telaAgendamento)
        {
            InitializeComponent();
            this.tela_agendamento = telaAgendamento;
        }
        private TelaAgendamento tela_agendamento;


        public TelaInicial(TelaCadPac telacadpac)
        {
            InitializeComponent();
            this.tela_cadpac = telacadpac;
        }
        private TelaCadPac tela_cadpac;

        public TelaInicial(TelaCadMed telacadmed)
        {
            InitializeComponent();
            this.tela_cadmed = telacadmed;
        }
        private TelaCadMed tela_cadmed;

        public TelaInicial(TelaVisVacina telaVisVacina)
        {
            InitializeComponent();
            this.tela_visvacina = telaVisVacina;
        }
        private TelaVisVacina tela_visvacina;

        public TelaInicial(TelaCadExame telacadexame)
        {
            InitializeComponent();
            this.tela_cadexame = telacadexame;
        }
        private TelaCadExame tela_cadexame;

        public TelaInicial(TelaConsulta telaconsulta)
        {
            InitializeComponent();
            this.tela_consulta = telaconsulta;
        }
        private TelaConsulta tela_consulta;


        public TelaInicial(TelaIniciarConsulta telainiciarconsulta)
        {
            InitializeComponent();
            this.tela_iniciarconsulta = telainiciarconsulta;
        }
        private TelaIniciarConsulta tela_iniciarconsulta;

        public TelaInicial(TelaVisExame telavisexame)
        {
            InitializeComponent();
            this.tela_visexame = telavisexame;
        }
        private TelaVisExame tela_visexame;

        public TelaInicial(TelaVisMed telavismed)
        {
            InitializeComponent();
            this.tela_vismed = telavismed;
        }
        private TelaVisMed tela_vismed;

        public TelaInicial(TelaVisPac telavispac)
        {
            InitializeComponent();
            this.tela_vispac = telavispac;
        }
        private TelaVisPac tela_vispac;

        public TelaInicial(TelaVisAdm telavisadm)
        {
            InitializeComponent();
            this.tela_visadm = telavisadm;
        }
        private TelaVisAdm tela_visadm;

        public TelaInicial(TelaVisVet telavisvet)
        {
            InitializeComponent();
            this.tela_visvet = telavisvet;
        }
        private TelaVisVet tela_visvet;

        public TelaInicial(TelaVisAgendamento telavisagendamento)
        {
            InitializeComponent();
            this.tela_visagendamento = telavisagendamento;
        }
        private TelaVisAgendamento tela_visagendamento;


        public string dataescolha;
        private void btn_Visualizar_Click(object sender, EventArgs e)
        {

            dataescolha = dateTimePicker1.Value.ToShortDateString();
            TelaVisAgendamento janela = new TelaVisAgendamento(dataescolha);
            janela.ShowDialog();
        }

        



        private void btn_Usuários_Click(object sender, EventArgs e)
        {

            this.Hide();
            TelaCadUsu tela_cadusu = new TelaCadUsu(this);
            tela_cadusu.Show();

        }

        private void btn_Pacientes_Click(object sender, EventArgs e)
        {

            this.Hide();
            TelaCadPac tela_cadpac = new TelaCadPac(this);
            tela_cadpac.Show();

        }

        private void btn_Medicamentos_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadMed tela_cadmed = new TelaCadMed(this);
            tela_cadmed.Show();
        }

        private void btn_Exames_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadExame tela_cadexame = new TelaCadExame(this);
            tela_cadexame.Show();
        }

        private void btn_Nova_Consulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaConsulta tela_consulta = new TelaConsulta(this);
            tela_consulta.Show();
        }

        private void btn_Agendar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaAgendamento tela_agendamento = new TelaAgendamento(this);
            tela_agendamento.Show();
        }

        private void pb_retornoLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin telalogin = new TelaLogin(this);
            telalogin.Show();
        }

       
    }
}




