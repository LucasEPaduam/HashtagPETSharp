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
    public partial class TelaAgendamento : Form
    {
        public TelaAgendamento(TelaInicial telaInicial)
        {
            InitializeComponent();
            this.tela_inicial = telaInicial;
        }

        private TelaInicial tela_inicial;

        public TelaAgendamento(TelaVisPac telaVisPac)
        {
            InitializeComponent();
            this.tela_vispac = telaVisPac;
        }

        private TelaVisPac tela_vispac;

        public TelaAgendamento(TelaVisVet telavisvet)
        {
            InitializeComponent();
            this.tela_visvet = telavisvet;
        }
        private TelaVisVet tela_visvet;

       

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tb_Datahora.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void TelaAgendamento_Load(object sender, EventArgs e)
        {
            


            string selecthorario = @"SELECT horario_consulta FROM horarioconsultas ORDER BY horario_consulta ASC";
            cb_Selecthorario.DataSource = BancoDados.Consulta(selecthorario);
            cb_Selecthorario.DisplayMember = "horario_consulta";
            cb_Selecthorario.ValueMember = "horario_consulta";

            string selectagendamento = @"SELECT agendamento.data_consulta as 'DATA',
                                                agendamento.hora_consulta as 'HORA',
                                                agendamento.agendamento_codigopet as 'PET',
                                                agendamento.agendamento_nomepet as 'NOME PET',
                                                agendamento.agendamento_vetcrmv as 'CRMV',
                                                agendamento.agendamento_nomevet as 'NOME VET'
                                                FROM agendamento ORDER BY data_consulta, hora_consulta ASC;";

            dgv_consultasagendadas.DataSource = BancoDados.Consulta(selectagendamento);
            dgv_consultasagendadas.Columns[0].Width = 80;
            dgv_consultasagendadas.Columns[1].Width = 45;
            dgv_consultasagendadas.Columns[2].Width = 40;
            dgv_consultasagendadas.Columns[3].Width = 70;
            dgv_consultasagendadas.Columns[4].Width = 40;
            dgv_consultasagendadas.Columns[5].Width = 70;

            tb_Datahora.Clear();
            tb_codpet.Clear();
            
            tb_codvet.Clear();
           
            cb_Selecthorario.Text = "";
        }

        private void btn_VIS_PAC_Click(object sender, EventArgs e)
        {
            TelaVisPac telavispac = new TelaVisPac(this);
            telavispac.ShowDialog();
        }

        private void Visualizarvet_Click(object sender, EventArgs e)
        {
            TelaVisVet telavisvet = new TelaVisVet(this);
            telavisvet.ShowDialog();
        }

        public string nomepet;
        public string nomevet;
        private void btn_Agendado_Click(object sender, EventArgs e)
        {


            if (tb_Datahora.Text == "" || tb_codpet.Text == "" || tb_codvet.Text == "")
            {
                 MessageBox.Show("Todos os campos devem ser preenchidos!");
            }
            else
            {
               
               
                DataTable data_table = new DataTable();
                string verificaragendamento = tb_Datahora.Text;
                string verificarhorario = cb_Selecthorario.Text;
                string codvet = tb_codvet.Text;
                string consultaagenda = "SELECT * FROM agendamento WHERE data_consulta='" + verificaragendamento + "'AND hora_consulta= '" + verificarhorario + "' AND agendamento_vetcrmv='"+codvet+ "'";
                data_table = BancoDados.Consulta(consultaagenda);

                
                if (data_table.Rows.Count == 0)
                {
                    try
                    {
                        string codpet = tb_codpet.Text;
                        string connString = @"server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2";
                        using (MySqlConnection conn = new MySqlConnection(connString))
                        {
                            conn.Open();
                            using (MySqlCommand cmd = new MySqlCommand("SELECT nomepet FROM paciente WHERE codigopet = '" + codpet + "'", conn))

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    nomepet = reader.GetString(0);
                                }
                                if (reader.HasRows == false)
                                {
                                    MessageBox.Show("Código PET não localizado!");
                                }
                               
                            }

                        }

                        string codveterinario = tb_codvet.Text;
                        string connString2 = @"server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2";
                        using (MySqlConnection conn = new MySqlConnection(connString2))
                        {
                            conn.Open();
                            using (MySqlCommand cmd = new MySqlCommand("SELECT nome FROM Veterinario WHERE crmv = '" + codveterinario + "'", conn))

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    nomevet = reader.GetString(0);
                                }
                                if (reader.HasRows == false)
                                {
                                    MessageBox.Show("Código VET não localizado!");
                                }
                                
                            }

                        }

                                               

                        Agendamento agendamento = new Agendamento();
                        agendamento.dataagendamento = tb_Datahora.Text;
                        agendamento.horaagendamento = cb_Selecthorario.Text;
                        agendamento.codpet = tb_codpet.Text;
                        agendamento.nomepet = nomepet;
                        agendamento.codvet = tb_codvet.Text;
                        agendamento.nomevet = nomevet;

                        BancoDados.insertagendamento(agendamento);

                        Consulta consulta = new Consulta();
                        consulta.consulta_data = tb_Datahora.Text;
                        consulta.consulta_hora = cb_Selecthorario.Text;
                        consulta.consulta_vetcrmv = tb_codvet.Text;
                        consulta.consulta_nomevet = nomevet;
                        consulta.consulta_codigopet = tb_codpet.Text;
                        consulta.consulta_nomepet = nomepet;
                        consulta.consulta_peso = "0";
                        consulta.consulta_idade = "";
                        consulta.consulta_obs = "";
                        consulta.consulta_vacina = "";
                        consulta.consulta_remedio = "";
                        consulta.consulta_exame = "";

                        BancoDados.insertconsulta(consulta);



                        string selectagendamento = @"SELECT agendamento.data_consulta as 'DATA',
                                                agendamento.hora_consulta as 'HORA',
                                                agendamento.agendamento_codigopet as 'PET',
                                                agendamento.agendamento_nomepet as 'NOME PET',
                                                agendamento.agendamento_vetcrmv as 'CRMV',
                                                agendamento.agendamento_nomevet as 'NOME VET'
                                                FROM agendamento ORDER BY data_consulta, hora_consulta ASC;";

                        dgv_consultasagendadas.DataSource = BancoDados.Consulta(selectagendamento);

                        tb_Datahora.Clear();                        
                        tb_codpet.Clear();                       
                        tb_codvet.Clear();                        
                        cb_Selecthorario.Text = "";

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao cadastrar!" + erro);
                    }
                }

                else
                {

                    MessageBox.Show("Já existe uma consulta com este veterinário nesta data-hora!\nVerifique na agenda um horário que esteja disponivel.");
                }
            }

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            string data = tb_Datahora.Text;
            string hora = cb_Selecthorario.Text;
            string codvet = tb_codvet.Text;

            const string mensagem = "Você tem certeza que deseja excluir o agendamento?";
            const string caption = "Exclusão de Agendamento";
            var result = MessageBox.Show(mensagem, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {

                MessageBox.Show("Exclusão cancelada!");
            }
            else
            {

               
                try
                {
                    MySqlConnection conexaoexcluir = new MySqlConnection("server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2");
                    conexaoexcluir.Open();
                    MySqlCommand agendamentoexcluir = new MySqlCommand("DELETE FROM agendamento WHERE data_consulta = @data_consulta AND hora_consulta = @hora_consulta AND agendamento_vetcrmv = @agendamento_vetcrmv", conexaoexcluir);

                    agendamentoexcluir.Parameters.Add("@data_consulta", MySqlDbType.VarChar, 10).Value = data;
                    agendamentoexcluir.Parameters.Add("@hora_consulta", MySqlDbType.VarChar, 5).Value = hora;
                    agendamentoexcluir.Parameters.Add("@agendamento_vetcrmv", MySqlDbType.VarChar, 5).Value = codvet;
                    agendamentoexcluir.CommandType = CommandType.Text;
                    agendamentoexcluir.ExecuteNonQuery();

                    MySqlCommand consultaexcluir = new MySqlCommand("DELETE FROM consulta WHERE consulta_data = @consulta_data AND consulta_hora = @consulta_hora AND consulta_vetcrmv = @consulta_vetcrmv", conexaoexcluir);

                    consultaexcluir.Parameters.Add("@consulta_data", MySqlDbType.VarChar, 10).Value = data;
                    consultaexcluir.Parameters.Add("@consulta_hora", MySqlDbType.VarChar, 5).Value = hora;
                    consultaexcluir.Parameters.Add("@consulta_vetcrmv", MySqlDbType.VarChar, 5).Value = codvet;
                    consultaexcluir.CommandType = CommandType.Text;
                    consultaexcluir.ExecuteNonQuery();
                    conexaoexcluir.Close();

                    MessageBox.Show("Cadastro excluído com sucesso!");

                    dgv_consultasagendadas.Rows.Remove(dgv_consultasagendadas.CurrentRow);
                    tb_Datahora.Clear();
                    tb_codpet.Clear();                    
                    tb_codvet.Clear();                    
                    cb_Selecthorario.Text = "";
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao excluir!" + erro);
                }
            }
        }

            private void dgv_consultasagendadas_SelectionChanged(object sender, EventArgs e)
            {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string data = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string hora = dgv.SelectedRows[0].Cells[1].Value.ToString();

                string consulta = @"SELECT * FROM agendamento WHERE data_consulta='" + data + "' AND hora_consulta= '" + hora + "'";
                dt = BancoDados.Consulta(consulta);
                tb_Datahora.Text = dt.Rows[0].Field<string>("data_consulta");
                cb_Selecthorario.Text = dt.Rows[0].Field<string>("hora_consulta");
                tb_codpet.Text = dt.Rows[0].Field<string>("agendamento_codigopet");
                tb_codvet.Text = dt.Rows[0].Field<string>("agendamento_vetcrmv");


            }
        }

        private void bt_limparagendamento_Click(object sender, EventArgs e)
        {
            tb_Datahora.Clear();
            tb_codpet.Clear();
          
            tb_codvet.Clear();
            
            cb_Selecthorario.Text = "";
        }
    }
}
