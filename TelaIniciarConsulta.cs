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
    public partial class TelaIniciarConsulta : Form
    {
       
        public TelaIniciarConsulta(string hora, string codpet, string codvet, string nomepet, string nomevet)
        {
            InitializeComponent();

            horacon = hora;
            codpetcon = codpet;
            codvetcon = codvet;
            nomepetcon = nomepet;
            nomevetcon = nomevet;
        }
        public string horacon;
        public string codvetcon;
        public string codpetcon;
        public string nomepetcon;
        public string nomevetcon;
        public string data = DateTime.Now.ToShortDateString();


        private void btn_Finalizar_Consulta_Click(object sender, EventArgs e)
        {

            if (tb_Peso.Text.Contains("."))
            {
                MessageBox.Show("No campo peso utilize (Vírgula) ao invés de (Ponto).");
            }
            else
            {

                Consulta consulta = new Consulta();
                consulta.consulta_data = data;
                consulta.consulta_hora = horacon;
                consulta.consulta_vetcrmv = codvetcon;
                consulta.consulta_nomevet = nomevetcon;
                consulta.consulta_codigopet = codpetcon;
                consulta.consulta_nomepet = nomepetcon;
                consulta.consulta_peso = tb_Peso.Text;
                consulta.consulta_idade = tb_Idade.Text;
                consulta.consulta_obs = richTextBox1.Text;
                consulta.consulta_vacina = cb_Qual_Vac.Text;
                consulta.consulta_remedio = cb_Qual_Rem.Text;
                consulta.consulta_exame = cb_Qual_Exame.Text;



                DataTable data_table = new DataTable();

                string consultaSQL = "SELECT * FROM consulta WHERE consulta_data='" + data + "'AND consulta_hora='" + horacon + "' AND consulta_vetcrmv='" + codvetcon + "'";
                data_table = BancoDados.Consulta(consultaSQL);

                // SE O BANCO RETORNAR ALGUM CADASTRO SERÁ REALIZADA A ATUALIZAÇÃO
                if (data_table.Rows.Count != 0)
                {
                    try
                    {
                        MySqlConnection conexaoupdate = new MySqlConnection("server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2");
                        conexaoupdate.Open();
                        MySqlCommand consultaupdate = new MySqlCommand("UPDATE consulta SET consulta_nomevet= ?, consulta_codigopet = ?, consulta_nomepet= ?, consulta_peso = ?, consulta_idade = ?, consulta_obs = ?, consulta_vacina = ?, consulta_remedio = ?, consulta_exame = ? Where consulta_data = ? AND consulta_hora = ? AND consulta_vetcrmv = ?", conexaoupdate);

                        consultaupdate.Parameters.Clear();

                        consultaupdate.Parameters.Add("@consulta_nomevet", MySqlDbType.VarChar, 50).Value = consulta.consulta_nomevet;
                        consultaupdate.Parameters.Add("@consulta_codigopet", MySqlDbType.VarChar, 10).Value = consulta.consulta_codigopet;
                        consultaupdate.Parameters.Add("@consulta_nomepet", MySqlDbType.VarChar, 500).Value = consulta.consulta_nomepet;
                        consultaupdate.Parameters.Add("@consulta_peso", MySqlDbType.VarChar, 10).Value = consulta.consulta_peso;
                        consultaupdate.Parameters.Add("@consulta_idade", MySqlDbType.VarChar, 4).Value = consulta.consulta_idade;
                        consultaupdate.Parameters.Add("@consulta_obs", MySqlDbType.VarChar, 500).Value = consulta.consulta_obs;
                        consultaupdate.Parameters.Add("@consulta_vacina", MySqlDbType.VarChar, 100).Value = consulta.consulta_vacina;
                        consultaupdate.Parameters.Add("@consulta_remedio", MySqlDbType.VarChar, 100).Value = consulta.consulta_remedio;
                        consultaupdate.Parameters.Add("@consulta_exame", MySqlDbType.VarChar, 100).Value = consulta.consulta_exame;
                        consultaupdate.Parameters.Add("consulta_data", MySqlDbType.VarChar).Value = consulta.consulta_data;
                        consultaupdate.Parameters.Add("consulta_hora", MySqlDbType.VarChar).Value = consulta.consulta_hora;
                        consultaupdate.Parameters.Add("consulta_vetcrmv", MySqlDbType.VarChar).Value = consulta.consulta_vetcrmv;
                        consultaupdate.CommandType = CommandType.Text;
                        consultaupdate.ExecuteNonQuery();


                        conexaoupdate.Close();

                        MessageBox.Show("Consulta finalizada com sucesso!");

                        try
                        {
                            MySqlConnection conexaoexcluir = new MySqlConnection("server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2");
                            conexaoexcluir.Open();
                            MySqlCommand agendamentoexcluir = new MySqlCommand("DELETE FROM agendamento WHERE data_consulta = @data_consulta AND hora_consulta = @hora_consulta AND agendamento_vetcrmv = @agendamento_vetcrmv", conexaoexcluir);

                            agendamentoexcluir.Parameters.Add("@data_consulta", MySqlDbType.VarChar, 10).Value = consulta.consulta_data;
                            agendamentoexcluir.Parameters.Add("@hora_consulta", MySqlDbType.VarChar, 5).Value = consulta.consulta_hora;
                            agendamentoexcluir.Parameters.Add("@agendamento_vetcrmv", MySqlDbType.VarChar, 5).Value = consulta.consulta_vetcrmv;
                            agendamentoexcluir.CommandType = CommandType.Text;
                            agendamentoexcluir.ExecuteNonQuery();
                            conexaoexcluir.Close();

                            
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Erro ao excluir agendamento, Verifique consultas agendadas!" + erro);
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao atualizar!" + erro);
                    }


                }
                else
                {

                    MessageBox.Show("Erro ao finalizar consulta!");
                }
            }


        }


    

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void TelaIniciarConsulta_Load(object sender, EventArgs e)
        {

            
            tb_Paciente.Text = nomepetcon;
            
        }
        
        private void rb_sim_vac_CheckedChanged(object sender, EventArgs e)
        {
            string cb_vacina = @"SELECT codigo, nome FROM Vacina ORDER BY nome ASC";
            cb_Qual_Vac.DataSource = BancoDados.Consulta(cb_vacina);
            cb_Qual_Vac.DisplayMember = "nome";
            cb_Qual_Vac.ValueMember = "codigo";
        }

        private void rb_nao_vac_CheckedChanged(object sender, EventArgs e)
        {
            cb_Qual_Vac.Text = "";
        }

        private void rb_sim_rem_CheckedChanged(object sender, EventArgs e)
        {
            string cb_remedio = @"SELECT codigo, nome FROM Remedio ORDER BY nome ASC";           
            cb_Qual_Rem.DataSource = BancoDados.Consulta(cb_remedio);
            cb_Qual_Rem.DisplayMember = "nome";
            cb_Qual_Rem.ValueMember = "codigo";
        }

        private void rb_nao_rem_CheckedChanged(object sender, EventArgs e)
        {
            cb_Qual_Rem.Text = "";
        }

        private void rb_sim_exa_CheckedChanged(object sender, EventArgs e)
        {
            string cb_exame = @"SELECT codigo, nome FROM Exame ORDER BY nome ASC";                        
            cb_Qual_Exame.DataSource = BancoDados.Consulta(cb_exame);
            cb_Qual_Exame.DisplayMember = "nome";
            cb_Qual_Exame.ValueMember = "codigo";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cb_Qual_Exame.Text = "";
        }

        

    }
}
