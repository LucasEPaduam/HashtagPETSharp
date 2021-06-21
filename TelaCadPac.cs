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
    public partial class TelaCadPac : Form
    {
        
        public TelaCadPac(TelaInicial telaInicial)
        {
            InitializeComponent();
            this.tela_inicial = telaInicial;
        }

        private TelaInicial tela_inicial;
       

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (tb_Codigo_Pac.Text == "")
            {
                MessageBox.Show("Erro ao salvar!\nPesquise o Pet que deseja atualizar ou clique em novo.\nTodos os campos do formulário devem ser preenchidos.");
            }
            else if (tb_Nome_Pac.Text == "")
            {
                MessageBox.Show("Erro ao salvar!\nTodos os campos do formulário devem ser preenchidos.");
            }
            else if (tb_CPF.Text == "")
            {
                MessageBox.Show("Erro ao salvar!\nTodos os campos do formulário devem ser preenchidos.");
            }
            else
            {

                Donopet donopet = new Donopet();
                donopet.cpf = tb_CPF.Text;
                donopet.paciente_codigopet = tb_Codigo_Pac.Text;
                donopet.nomedono = tb_NomeDono.Text;
                donopet.rua = tb_Rua.Text;
                donopet.numero = tb_Nº.Text;
                donopet.cep = tb_CEP.Text;
                donopet.cidade = tb_Cidade.Text;
                donopet.UF = tb_UF.Text;
                donopet.email = tb_email.Text;
                donopet.telefone = tb_Tel.Text;

                Paciente paciente = new Paciente();
                paciente.codigopet = tb_Codigo_Pac.Text;
                paciente.nomepet = tb_Nome_Pac.Text;
                paciente.raca = tb_Raça.Text;
                paciente.idade = tb_Idade.Text;
                paciente.peso = tb_Peso.Text;
                paciente.sexo = tb_Sexo.Text;

                DataTable data_table = new DataTable();
                string codpet = tb_Codigo_Pac.Text;
                string consultaSQL = "SELECT * FROM paciente WHERE codigopet='" + codpet + "'";
                data_table = BancoDados.Consulta(consultaSQL);

                if (data_table.Rows.Count != 0)
                {
                    try
                    {
                        MySqlConnection conexaoupdate = new MySqlConnection("server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2");
                        conexaoupdate.Open();
                        MySqlCommand pacienteupdate = new MySqlCommand("UPDATE paciente SET nomepet = ?, raca = ?, IDADE = ?, PESO = ?, sexo = ? Where codigopet = ?", conexaoupdate);

                        pacienteupdate.Parameters.Clear();
                        pacienteupdate.Parameters.Add("@nomepet", MySqlDbType.VarChar, 10).Value = paciente.nomepet;
                        pacienteupdate.Parameters.Add("@raca", MySqlDbType.VarChar, 10).Value = paciente.raca;
                        pacienteupdate.Parameters.Add("@IDADE", MySqlDbType.VarChar, 10).Value = paciente.idade;
                        pacienteupdate.Parameters.Add("@PESO", MySqlDbType.VarChar, 10).Value = paciente.peso;
                        pacienteupdate.Parameters.Add("@sexo", MySqlDbType.VarChar, 10).Value = paciente.sexo;
                        pacienteupdate.Parameters.Add("codigopet", MySqlDbType.VarChar).Value = paciente.codigopet;
                        pacienteupdate.CommandType = CommandType.Text;
                        pacienteupdate.ExecuteNonQuery();

                        MySqlCommand donoupdate = new MySqlCommand("UPDATE dono SET nomedono = ?, rua = ?, numero = ?, cep = ?, cidade = ?, UF = ?, email = ?, telefone = ? Where paciente_codigopet = ?", conexaoupdate);
                        donoupdate.Parameters.Clear();
                        donoupdate.Parameters.Add("@nomedono", MySqlDbType.VarChar, 50).Value = donopet.nomedono;
                        donoupdate.Parameters.Add("@rua", MySqlDbType.VarChar, 50).Value = donopet.rua;
                        donoupdate.Parameters.Add("@numero", MySqlDbType.VarChar, 5).Value = donopet.numero;
                        donoupdate.Parameters.Add("@cep", MySqlDbType.VarChar, 8).Value = donopet.cep;
                        donoupdate.Parameters.Add("@cidade", MySqlDbType.VarChar, 50).Value = donopet.cidade;
                        donoupdate.Parameters.Add("@UF", MySqlDbType.VarChar, 2).Value = donopet.UF;
                        donoupdate.Parameters.Add("@email", MySqlDbType.VarChar, 20).Value = donopet.email;
                        donoupdate.Parameters.Add("@telefone", MySqlDbType.VarChar, 11).Value = donopet.telefone;
                        donoupdate.Parameters.Add("paciente_codigopet", MySqlDbType.VarChar).Value = paciente.codigopet;
                        donoupdate.CommandType = CommandType.Text;
                        donoupdate.ExecuteNonQuery();
                        conexaoupdate.Close();

                        MessageBox.Show("Atualizado com sucesso!");
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao atualizar!" + erro);
                    }
                }
                else
                {
                    BancoDados.insertpaciente(paciente);
                    BancoDados.insertdono(donopet);
                }
            }

        }
        

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
           
            
            //TextBox do Paciente
            tb_Codigo_Pac.Clear();
            tb_Nome_Pac.Clear();
            tb_Raça.Clear();
            tb_Idade.Clear();
            tb_Peso.Clear();
            tb_Sexo.Clear();

            //TextBox do Dono 
            tb_CPF.Clear();
            tb_NomeDono.Clear();
            tb_Rua.Clear();
            tb_Nº.Clear();
            tb_CEP.Clear();
            tb_Cidade.Clear();
            tb_email.Clear();
            tb_Tel.Clear();
            tb_UF.Clear();

            rb_Cachorro.Enabled = false;
            rb_Gato.Enabled = false;
            rb_passaro.Enabled = false;
            rb_outros.Enabled = false;

            tb_Codigo_Pac.Enabled = false;
            tb_Nome_Pac.Enabled = false;
            tb_Raça.Enabled = false;
            tb_Idade.Enabled = false;
            tb_Peso.Enabled = false;
            tb_Sexo.Enabled = false;

            tb_CPF.Enabled = false;
            tb_NomeDono.Enabled = false;
            tb_Rua.Enabled = false;
            tb_Nº.Enabled = false;
            tb_CEP.Enabled = false;
            tb_Cidade.Enabled = false;
            tb_email.Enabled = false;
            tb_Tel.Enabled = false;
            tb_UF.Enabled = false;
        }

        public TelaCadPac(TelaVisPac telavispac)
        {
            InitializeComponent();
            this.tela_vispac = telavispac;
        }
        private TelaVisPac tela_vispac;

        private void btn_Histórico_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVisPac telavispac = new TelaVisPac(this);
            telavispac.Show();
        }

        

        private void TelaCadPac_Load(object sender, EventArgs e)
        {

            tb_Pesquisar.Focus();

        }

        private void pb_Pesquisar_Click(object sender, EventArgs e)
        {



            rb_Cachorro.Enabled = false;
            rb_Gato.Enabled = false;
            rb_passaro.Enabled = false;
            rb_outros.Enabled = false;

            tb_Codigo_Pac.Enabled = false;
            tb_Nome_Pac.Enabled = false;
            tb_Raça.Enabled = false;
            tb_Idade.Enabled = false;
            tb_Peso.Enabled = false;
            tb_Sexo.Enabled = false;

            tb_CPF.Enabled = false;
            tb_NomeDono.Enabled = false;
            tb_Rua.Enabled = false;
            tb_Nº.Enabled = false;
            tb_CEP.Enabled = false;
            tb_Cidade.Enabled = false;
            tb_email.Enabled = false;
            tb_Tel.Enabled = false;
            tb_UF.Enabled = false;


            string codpet = tb_Pesquisar.Text;

            if (codpet == "")
            {
                MessageBox.Show("Informe o código do PET");
                tb_Pesquisar.Focus();
            }
            else
            {
               

                try
                {   // STRING PARA CONEXÃO COM O BANCO DE DADOS

                    string connString = @"server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2";

                    //TENTATIVA DE CONEXÃO COM O BANCO

                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {

                        conn.Open();

                        // CONSULTA A TABELA PACIENTE ATRAVÉS DO CÓDIGO DO PACIENTE

                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM paciente WHERE codigopet='" + codpet + "'", conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            // TEXTBOX RECEBEM CONTEUDO CONSULTADO NO BANCO

                            while (reader.Read())
                            {

                                tb_Codigo_Pac.Text = reader.GetString(0);
                                tb_Nome_Pac.Text = reader.GetString(1);
                                tb_Raça.Text = reader.GetString(2);
                                tb_Idade.Text = reader.GetString(3);
                                tb_Peso.Text = reader.GetString(4);
                                tb_Sexo.Text = reader.GetString(5);


                            }

                            

                        }
                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM dono WHERE paciente_codigopet='" + codpet + "'", conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                tb_CPF.Text = reader.GetString(0);
                                tb_NomeDono.Text = reader.GetString(2);
                                tb_Rua.Text = reader.GetString(3);
                                tb_Nº.Text = reader.GetString(4);
                                tb_CEP.Text = reader.GetString(5);
                                tb_Cidade.Text = reader.GetString(6);
                                tb_UF.Text = reader.GetString(7);
                                tb_email.Text = reader.GetString(8);
                                tb_Tel.Text = reader.GetString(9);
                            }

                            if (reader.HasRows)
                            {

                                if (codpet.StartsWith("C"))
                                {
                                    rb_Cachorro.Checked = true;
                                    tb_Codigo_Pac.Text = tb_Pesquisar.Text;

                                }
                                else if (codpet.StartsWith("c"))
                                {
                                    rb_Cachorro.Checked = true;
                                    tb_Codigo_Pac.Text = tb_Pesquisar.Text;

                                }
                                else if (codpet.StartsWith("G"))
                                {
                                    rb_Gato.Checked = true;
                                    tb_Codigo_Pac.Text = tb_Pesquisar.Text;

                                }
                                else if (codpet.StartsWith("g"))
                                {
                                    rb_Gato.Checked = true;
                                    tb_Codigo_Pac.Text = tb_Pesquisar.Text;

                                }
                                else if (codpet.StartsWith("P"))
                                {
                                    rb_passaro.Checked = true;
                                    tb_Codigo_Pac.Text = tb_Pesquisar.Text;

                                }
                                else if (codpet.StartsWith("p"))
                                {
                                    rb_passaro.Checked = true;
                                    tb_Codigo_Pac.Text = tb_Pesquisar.Text;

                                }
                                else if (codpet.StartsWith("O"))
                                {
                                    rb_outros.Checked = true;
                                    tb_Codigo_Pac.Text = tb_Pesquisar.Text;

                                }
                                else if (codpet.StartsWith("o"))
                                {
                                    rb_outros.Checked = true;
                                    tb_Codigo_Pac.Text = tb_Pesquisar.Text;

                                }
                                MessageBox.Show("PET localizado!!!");
                                
                            }
                            else
                            {
                                MessageBox.Show("PET não encontrado!!!");
                                
                            }
                        }
                    }
                }
                catch (MySqlException erro)
                {
                    Console.WriteLine("Erro.Number" + erro.Number);
                    switch (erro.Number)
                    {
                        case 1042:
                            Console.WriteLine("Erro ao tentar conectar com o servidor!");
                            Console.WriteLine("Verifique se o endereço do servidor está correto!");
                            break;

                        default:
                            Console.WriteLine(erro.GetType());
                            Console.WriteLine(erro.Message);
                            Console.WriteLine(erro.ToString());
                            break;
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.GetType());
                    Console.WriteLine(erro.Message);
                    Console.WriteLine(erro.ToString());
                }

            }

           
           
            
        }

        private void bt_NovoPac_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Informe a espécie do seu PET.\nEm seguida, preencha todos os dados do formulário e clique em salvar");

            tb_Pesquisar.Clear();

            tb_Codigo_Pac.Clear();
            tb_Nome_Pac.Clear();
            tb_Raça.Clear();
            tb_Idade.Clear();
            tb_Peso.Clear();
            tb_Sexo.Clear();

           
            tb_CPF.Clear();
            tb_NomeDono.Clear();
            tb_Rua.Clear();
            tb_Nº.Clear();
            tb_CEP.Clear();
            tb_Cidade.Clear();
            tb_email.Clear();
            tb_Tel.Clear();
            tb_UF.Clear();





            rb_Cachorro.Enabled = true;
            rb_Gato.Enabled = true;
            rb_passaro.Enabled = true;
            rb_outros.Enabled = true;

            tb_Nome_Pac.Enabled = true;
            tb_Raça.Enabled = true;
            tb_Idade.Enabled = true;
            tb_Peso.Enabled = true;
            tb_Sexo.Enabled = true;

            //TextBox do Dono 
            tb_CPF.Enabled = true;
            tb_NomeDono.Enabled = true;
            tb_Rua.Enabled = true;
            tb_Nº.Enabled = true;
            tb_CEP.Enabled = true;
            tb_Cidade.Enabled = true;
            tb_email.Enabled = true;
            tb_Tel.Enabled = true;
            tb_UF.Enabled = true;

                        
        }

       
        private void rb_Cachorro_CheckedChanged(object sender, EventArgs e)
        {
            Random numeros = new Random();
            int numerosrandom;
            string novocodigopet;
            DataTable dt = new DataTable();
            string consultaSQL;

            if (rb_Cachorro.Checked)
            {
                do
                {
                    numerosrandom = numeros.Next(0001, 0300);
                    novocodigopet = numerosrandom.ToString();
                    novocodigopet = "C" + novocodigopet;
                    consultaSQL = "SELECT * FROM paciente WHERE nomepet='" + novocodigopet + "'";
                    dt = BancoDados.Consulta(consultaSQL);
                    tb_Codigo_Pac.Text = novocodigopet;

                } while (dt.Rows.Count > 0);
            }
        }

        private void rb_Gato_CheckedChanged(object sender, EventArgs e)
        {

            Random numeros = new Random();
            int numerosrandom;
            string novocodigopet;
            DataTable dt = new DataTable();
            string consultaSQL;

            if (rb_Gato.Checked)
            {
                do
                {
                    numerosrandom = numeros.Next(0001, 0300);
                    novocodigopet = numerosrandom.ToString();
                    novocodigopet = "G" + novocodigopet;
                    consultaSQL = "SELECT * FROM paciente WHERE nomepet='" + novocodigopet + "'";
                    dt = BancoDados.Consulta(consultaSQL);
                    tb_Codigo_Pac.Text = novocodigopet;

                } while (dt.Rows.Count > 0);
            }

        }

        private void rb_passaro_CheckedChanged(object sender, EventArgs e)
        {
            Random numeros = new Random();
            int numerosrandom;
            string novocodigopet;
            DataTable dt = new DataTable();
            string consultaSQL;

            if (rb_passaro.Checked)
            {
                do
                {
                    numerosrandom = numeros.Next(0001, 0300);
                    novocodigopet = numerosrandom.ToString();
                    novocodigopet = "P" + novocodigopet;
                    consultaSQL = "SELECT * FROM paciente WHERE nomepet='" + novocodigopet + "'";
                    dt = BancoDados.Consulta(consultaSQL);
                    tb_Codigo_Pac.Text = novocodigopet;

                } while (dt.Rows.Count > 0);
            }
        }

        private void rb_outros_CheckedChanged(object sender, EventArgs e)
        {
            Random numeros = new Random();
            int numerosrandom;
            string novocodigopet;
            DataTable dt = new DataTable();
            string consultaSQL;

            if (rb_outros.Checked)
            {
                do
                {
                    numerosrandom = numeros.Next(0001, 0300);
                    novocodigopet = numerosrandom.ToString();
                    novocodigopet = "O" + novocodigopet;
                    consultaSQL = "SELECT * FROM paciente WHERE nomepet='" + novocodigopet + "'";
                    dt = BancoDados.Consulta(consultaSQL);
                    tb_Codigo_Pac.Text = novocodigopet;

                } while (dt.Rows.Count > 0);
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            tb_Nome_Pac.Enabled = true;
            tb_Raça.Enabled = true;
            tb_Idade.Enabled = true;
            tb_Peso.Enabled = true;
            tb_Sexo.Enabled = true;
                      
            tb_CPF.Enabled = true;
            tb_NomeDono.Enabled = true;
            tb_Rua.Enabled = true;
            tb_Nº.Enabled = true;
            tb_CEP.Enabled = true;
            tb_Cidade.Enabled = true;
            tb_email.Enabled = true;
            tb_Tel.Enabled = true;
            tb_UF.Enabled = true;


          
        }
    }
    
}
