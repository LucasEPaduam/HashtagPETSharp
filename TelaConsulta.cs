using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjInter
{
    public partial class TelaConsulta : Form
    {

        DataTable data_table = new DataTable();
        public TelaConsulta(TelaInicial telaInicial)
        {
            InitializeComponent();
            this.tela_inicial = telaInicial;
        }

        private TelaInicial tela_inicial;


        public string horacon;
        public string codpet;
        public string codvet;
        public string nomepet;
        public string nomevet;


        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        public string datadodia;
        private void TelaConsulta_Load(object sender, EventArgs e)
        {



            tb_paciente.Enabled = false;
            tb_data.Text = DateTime.Now.ToShortDateString();
            datadodia = tb_data.Text;

            string selectagendamento = @"SELECT agendamento.data_consulta as 'DATA',
                                                agendamento.hora_consulta as 'HORA',
                                                agendamento.agendamento_codigopet as 'PET',
                                                agendamento.agendamento_nomepet as 'NOME PET',
                                                agendamento.agendamento_vetcrmv as 'CRMV',
                                                agendamento.agendamento_nomevet as 'NOME VET'
                                                FROM agendamento WHERE agendamento.data_consulta='"+datadodia+"'ORDER BY hora_consulta ASC;";

                    dgv_historico.DataSource = BancoDados.Consulta(selectagendamento);
                    dgv_historico.Columns[0].Width = 80;
                    dgv_historico.Columns[1].Width = 50;
                    dgv_historico.Columns[2].Width = 80;
                    dgv_historico.Columns[3].Width = 120;
                    dgv_historico.Columns[4].Width = 80;
                    dgv_historico.Columns[5].Width = 120;

            


        }

        private void dgv_historico_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            try
            {
                if (contlinhas > 0)
                {
                    DataTable dt = new DataTable();
                    string data = dgv.SelectedRows[0].Cells[0].Value.ToString();
                    string hora = dgv.SelectedRows[0].Cells[1].Value.ToString();

                    string consulta = @"SELECT * FROM agendamento WHERE data_consulta='" + data + "' AND hora_consulta= '" + hora + "'";
                    dt = BancoDados.Consulta(consulta);

                    horacon = dt.Rows[0].Field<string>("hora_consulta");
                    codpet = dt.Rows[0].Field<string>("agendamento_codigopet");
                    codvet = dt.Rows[0].Field<string>("agendamento_vetcrmv");
                    nomepet = dt.Rows[0].Field<string>("agendamento_nomepet");
                    nomevet = dt.Rows[0].Field<string>("agendamento_nomevet");

                    tb_paciente.Text = nomepet;

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Esta seleção não é válida!");
            }
        }

        private void btn_Iniciar_Consulta_Click(object sender, EventArgs e)
        {
            
            string consulta = @"SELECT * FROM agendamento WHERE data_consulta='" + datadodia + "' AND hora_consulta= '" + horacon + "'";
            data_table = BancoDados.Consulta(consulta);

            if (data_table.Rows.Count == 0)
            {
                MessageBox.Show("Nenhuma consulta selecionada ou não há consultas agendadas para hoje!");
            }
            else
            {
                this.Hide();
                TelaIniciarConsulta dadosconsulta = new TelaIniciarConsulta(horacon, codpet, codvet, nomepet, nomevet);
                dadosconsulta.Show();
            }


           


        }

    }
}
