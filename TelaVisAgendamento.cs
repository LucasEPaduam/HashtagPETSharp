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
    public partial class TelaVisAgendamento : Form
    {
        public TelaVisAgendamento(string dataescolhida)
        {
            InitializeComponent();

            data_escolha = dataescolhida;
        }

        public string data_escolha;

        public TelaVisAgendamento(TelaInicial telainicial)
        {
            InitializeComponent();
            this.tela_inicial = telainicial;

        }
        private TelaInicial tela_inicial;



        private void TelaVisAgendamento_Load(object sender, EventArgs e)
        {

            string selectconsulta = @"SELECT consulta.consulta_data as 'DATA',
                                                consulta.consulta_hora as 'HORA',
                                                consulta.consulta_vetcrmv as 'CRMV',
                                                consulta.consulta_nomevet as 'NOME VET',
                                                consulta.consulta_codigopet as 'PET',
                                                consulta.consulta_nomepet as 'NOME PET',                                                
                                                consulta.consulta_peso as 'PESO',
                                                consulta.consulta_idade as 'IDADE',
                                                consulta.consulta_obs as 'OBS:',
                                                consulta.consulta_vacina as 'VACINA',
                                                consulta.consulta_remedio as 'REMEDIO',
                                                consulta.consulta_exame as 'EXAME'
                                                FROM consulta WHERE consulta_data ='" + data_escolha+"'ORDER BY consulta_data ASC;";

            dgv_consultasagendadas.DataSource = BancoDados.Consulta(selectconsulta);
            dgv_consultasagendadas.Columns[0].Width = 80;
            dgv_consultasagendadas.Columns[1].Width = 50;
            dgv_consultasagendadas.Columns[2].Width = 80;
            dgv_consultasagendadas.Columns[3].Width = 120;
            dgv_consultasagendadas.Columns[4].Width = 80;
            dgv_consultasagendadas.Columns[5].Width = 120;
            dgv_consultasagendadas.Columns[6].Width = 50;
            dgv_consultasagendadas.Columns[7].Width = 50;
            dgv_consultasagendadas.Columns[8].Width = 120;
            dgv_consultasagendadas.Columns[9].Width = 120;
            dgv_consultasagendadas.Columns[10].Width = 120;
            dgv_consultasagendadas.Columns[11].Width = 120;


            comboBox1.Enabled = false;           
            btn_Pesdata.Enabled = false;            
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            btn_Pesvet.Enabled = false;
            btn_Pespac.Enabled = false;


        }

        private void rb_data_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            btn_Pesdata.Enabled = true;

            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            btn_Pesvet.Enabled = false;
            btn_Pespac.Enabled = false;
            string selectdata  = @"SELECT consulta.consulta_data FROM consulta GROUP BY consulta_data;";
            comboBox1.DataSource = BancoDados.Consulta(selectdata);
            comboBox1.DisplayMember = "consulta_data";
            comboBox1.ValueMember = "consulta_data";


            
        }

        private void rb_vet_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            btn_Pesvet.Enabled = true;;
            comboBox1.Text = "";
            comboBox3.Text = "";

            comboBox1.Enabled = false;
            comboBox3.Enabled = false;
            btn_Pesdata.Enabled = false;
            btn_Pespac.Enabled = false;
            string selectVET = @"SELECT Veterinario.nome FROM Veterinario ORDER BY nome ASC;";
            comboBox2.DataSource = BancoDados.Consulta(selectVET);
            comboBox2.DisplayMember = "nome";
            comboBox2.ValueMember = "nome";
        }

        private void rb_pac_CheckedChanged(object sender, EventArgs e)
        {
           
            comboBox3.Enabled = true;           
            btn_Pespac.Enabled = true;

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;

            comboBox1.Text = "";
            comboBox2.Text = "";

            btn_Pesdata.Enabled = false;
            btn_Pesvet.Enabled = false;
            string selectPAC = @"SELECT paciente.nomepet FROM paciente ORDER BY nomepet ASC;";
            comboBox3.DataSource = BancoDados.Consulta(selectPAC);
            comboBox3.DisplayMember = "nomepet";
            comboBox3.ValueMember = "nomepet";
        }

        private void btn_Pesdata_Click(object sender, EventArgs e)
        {
            string data = comboBox1.Text;

            string selectconsulta = @"SELECT consulta.consulta_data as 'DATA',
                                                consulta.consulta_hora as 'HORA',
                                                consulta.consulta_vetcrmv as 'CRMV',
                                                consulta.consulta_nomevet as 'NOME VET',
                                                consulta.consulta_codigopet as 'PET',
                                                consulta.consulta_nomepet as 'NOME PET',                                                
                                                consulta.consulta_peso as 'PESO',
                                                consulta.consulta_idade as 'IDADE',
                                                consulta.consulta_obs as 'OBS:',
                                                consulta.consulta_vacina as 'VACINA',
                                                consulta.consulta_remedio as 'REMEDIO',
                                                consulta.consulta_exame as 'EXAME'
                                                FROM consulta WHERE consulta_data ='" + data + "'ORDER BY consulta_data ASC;";

            dgv_consultasagendadas.DataSource = BancoDados.Consulta(selectconsulta);
            dgv_consultasagendadas.Columns[0].Width = 80;
            dgv_consultasagendadas.Columns[1].Width = 50;
            dgv_consultasagendadas.Columns[2].Width = 80;
            dgv_consultasagendadas.Columns[3].Width = 120;
            dgv_consultasagendadas.Columns[4].Width = 80;
            dgv_consultasagendadas.Columns[5].Width = 120;
            dgv_consultasagendadas.Columns[6].Width = 50;
            dgv_consultasagendadas.Columns[7].Width = 50;
            dgv_consultasagendadas.Columns[8].Width = 120;
            dgv_consultasagendadas.Columns[9].Width = 120;
            dgv_consultasagendadas.Columns[10].Width = 120;
            dgv_consultasagendadas.Columns[11].Width = 120;






        }

        private void btn_Pesvet_Click(object sender, EventArgs e)
        {
            string vet = comboBox2.Text;

            string selectconsulta = @"SELECT consulta.consulta_data as 'DATA',
                                                consulta.consulta_hora as 'HORA',
                                                consulta.consulta_vetcrmv as 'CRMV',
                                                consulta.consulta_nomevet as 'NOME VET',
                                                consulta.consulta_codigopet as 'PET',
                                                consulta.consulta_nomepet as 'NOME PET',                                                
                                                consulta.consulta_peso as 'PESO',
                                                consulta.consulta_idade as 'IDADE',
                                                consulta.consulta_obs as 'OBS:',
                                                consulta.consulta_vacina as 'VACINA',
                                                consulta.consulta_remedio as 'REMEDIO',
                                                consulta.consulta_exame as 'EXAME'
                                                FROM consulta WHERE consulta_nomevet ='" + vet + "'ORDER BY consulta_nomevet ASC;";

            dgv_consultasagendadas.DataSource = BancoDados.Consulta(selectconsulta);
            dgv_consultasagendadas.Columns[0].Width = 80;
            dgv_consultasagendadas.Columns[1].Width = 50;
            dgv_consultasagendadas.Columns[2].Width = 80;
            dgv_consultasagendadas.Columns[3].Width = 120;
            dgv_consultasagendadas.Columns[4].Width = 80;
            dgv_consultasagendadas.Columns[5].Width = 120;
            dgv_consultasagendadas.Columns[6].Width = 50;
            dgv_consultasagendadas.Columns[7].Width = 50;
            dgv_consultasagendadas.Columns[8].Width = 120;
            dgv_consultasagendadas.Columns[9].Width = 120;
            dgv_consultasagendadas.Columns[10].Width = 120;
            dgv_consultasagendadas.Columns[11].Width = 120;
        }

        private void btn_Pespac_Click(object sender, EventArgs e)
        {
            string pet = comboBox3.Text;

            string selectconsulta = @"SELECT consulta.consulta_data as 'DATA',
                                                consulta.consulta_hora as 'HORA',
                                                consulta.consulta_vetcrmv as 'CRMV',
                                                consulta.consulta_nomevet as 'NOME VET',
                                                consulta.consulta_codigopet as 'PET',
                                                consulta.consulta_nomepet as 'NOME PET',                                                
                                                consulta.consulta_peso as 'PESO',
                                                consulta.consulta_idade as 'IDADE',
                                                consulta.consulta_obs as 'OBS:',
                                                consulta.consulta_vacina as 'VACINA',
                                                consulta.consulta_remedio as 'REMEDIO',
                                                consulta.consulta_exame as 'EXAME'
                                                FROM consulta WHERE consulta_nomepet ='" + pet + "'ORDER BY consulta_nomepet ASC;";

            dgv_consultasagendadas.DataSource = BancoDados.Consulta(selectconsulta);
            dgv_consultasagendadas.Columns[0].Width = 80;
            dgv_consultasagendadas.Columns[1].Width = 50;
            dgv_consultasagendadas.Columns[2].Width = 80;
            dgv_consultasagendadas.Columns[3].Width = 120;
            dgv_consultasagendadas.Columns[4].Width = 80;
            dgv_consultasagendadas.Columns[5].Width = 120;
            dgv_consultasagendadas.Columns[6].Width = 50;
            dgv_consultasagendadas.Columns[7].Width = 50;
            dgv_consultasagendadas.Columns[8].Width = 120;
            dgv_consultasagendadas.Columns[9].Width = 120;
            dgv_consultasagendadas.Columns[10].Width = 120;
            dgv_consultasagendadas.Columns[11].Width = 120;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectconsulta = @"SELECT consulta.consulta_data as 'DATA',
                                                consulta.consulta_hora as 'HORA',
                                                consulta.consulta_vetcrmv as 'CRMV',
                                                consulta.consulta_nomevet as 'NOME VET',
                                                consulta.consulta_codigopet as 'PET',
                                                consulta.consulta_nomepet as 'NOME PET',                                                
                                                consulta.consulta_peso as 'PESO',
                                                consulta.consulta_idade as 'IDADE',
                                                consulta.consulta_obs as 'OBS:',
                                                consulta.consulta_vacina as 'VACINA',
                                                consulta.consulta_remedio as 'REMEDIO',
                                                consulta.consulta_exame as 'EXAME'
                                                FROM consulta ORDER BY consulta_data ASC;";

            dgv_consultasagendadas.DataSource = BancoDados.Consulta(selectconsulta);
            dgv_consultasagendadas.Columns[0].Width = 80;
            dgv_consultasagendadas.Columns[1].Width = 50;
            dgv_consultasagendadas.Columns[2].Width = 80;
            dgv_consultasagendadas.Columns[3].Width = 120;
            dgv_consultasagendadas.Columns[4].Width = 80;
            dgv_consultasagendadas.Columns[5].Width = 120;
            dgv_consultasagendadas.Columns[6].Width = 50;
            dgv_consultasagendadas.Columns[7].Width = 50;
            dgv_consultasagendadas.Columns[8].Width = 120;
            dgv_consultasagendadas.Columns[9].Width = 120;
            dgv_consultasagendadas.Columns[10].Width = 120;
            dgv_consultasagendadas.Columns[11].Width = 120;
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
