﻿using System;
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

        public TelaCadPac(TelaVisPac telavispac)
        {
            InitializeComponent();
            this.tela_vispac = telavispac;
        }
        private TelaVisPac tela_vispac;

        // BOTÃO PARA VOLTAR PARA TELA DE INICIO DO PROGRAMA
        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }     
        
        private void TelaCadPac_Load(object sender, EventArgs e)
        {
            tb_Pesquisar.Focus();
        }

        

        private void pb_Pesquisar_Click(object sender, EventArgs e)
        {

            // DESABILITA A EDIÇÃO DOS CAMPOS DO FORMULÁRIO 

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
            maskedTextBox1.Enabled = false;
            tb_UF.Enabled = false;

            btn_Excluir.Enabled = true;

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

                        // CONSULTA O BANCO ATRAVÉS DO CÓDIGO DO PACIENTE

                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM paciente WHERE codigopet='" + codpet + "'", conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            // TEXTBOX RECEBEM CONTEUDO CONSULTADO NO BANCO ATRAVES DO READER

                            while (reader.Read())
                            {

                                tb_Codigo_Pac.Text = reader.GetString(0);
                                tb_Nome_Pac.Text = reader.GetString(2);
                                tb_Raça.Text = reader.GetString(3);
                                tb_Idade.Text = reader.GetString(4);
                                tb_Peso.Text = reader.GetString(5);
                                tb_Sexo.Text = reader.GetString(6);

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
                                maskedTextBox1.Text = reader.GetString(9);
                            }

                            if (reader.HasRows)
                            {
                                if (codpet.StartsWith("C") || (codpet.StartsWith("c")))
                                {
                                    rb_Cachorro.Checked = true;
                                    tb_Codigo_Pac.Text = tb_Pesquisar.Text;
                                }
                                
                                else if (codpet.StartsWith("G") || (codpet.StartsWith("g")))
                                {
                                    rb_Gato.Checked = true;
                                    tb_Codigo_Pac.Text = tb_Pesquisar.Text;
                                }
                                
                                else if (codpet.StartsWith("P") || (codpet.StartsWith("p")))
                                {
                                    rb_passaro.Checked = true;
                                    tb_Codigo_Pac.Text = tb_Pesquisar.Text;
                                }
                                
                                else if (codpet.StartsWith("O") || (codpet.StartsWith("o")))
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
            
            MessageBox.Show("Escolha a espécie do seu PET.\nEm seguida, preencha todos os dados do formulário e clique em salvar.");

            btn_Excluir.Enabled = false;

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
            maskedTextBox1.Clear();
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

            tb_CPF.Enabled = true;
            tb_NomeDono.Enabled = true;
            tb_Rua.Enabled = true;
            tb_Nº.Enabled = true;
            tb_CEP.Enabled = true;
            tb_Cidade.Enabled = true;
            tb_email.Enabled = true;
            maskedTextBox1.Enabled = true;
            tb_UF.Enabled = true;
                                    
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {

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
            maskedTextBox1.Clear();
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
            maskedTextBox1.Enabled = false;
            tb_UF.Enabled = false;
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
                //REALIZADO SORTEIO DE NUMERO ALEATÓRIO PARA CÓDIGO DO PET
                //LOOPING PARA VERIFICAR SE O CÓDIGO SORTEADO JÁ EXISTE NO BANCO
                do
                {
                    numerosrandom = numeros.Next(0100, 0300);
                    novocodigopet = numerosrandom.ToString();
                    novocodigopet = "C" + novocodigopet;
                    consultaSQL = "SELECT * FROM paciente WHERE codigopet='" + novocodigopet + "'";
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
                //REALIZADO SORTEIO DE NUMERO ALEATÓRIO PARA CÓDIGO DO PET
                //LOOPING PARA VERIFICAR SE O CÓDIGO SORTEADO JÁ EXISTE NO BANCO
                do
                {
                    numerosrandom = numeros.Next(0100, 0300);
                    novocodigopet = numerosrandom.ToString();
                    novocodigopet = "G" + novocodigopet;
                    consultaSQL = "SELECT * FROM paciente WHERE codigopet='" + novocodigopet + "'";
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
                //REALIZADO SORTEIO DE NUMERO ALEATÓRIO PARA CÓDIGO DO PET
                //LOOPING PARA VERIFICAR SE O CÓDIGO SORTEADO JÁ EXISTE NO BANCO
                do
                {
                    numerosrandom = numeros.Next(0100, 0300);
                    novocodigopet = numerosrandom.ToString();
                    novocodigopet = "P" + novocodigopet;
                    consultaSQL = "SELECT * FROM paciente WHERE codigopet='" + novocodigopet + "'";
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
                //REALIZADO SORTEIO DE NUMERO ALEATÓRIO PARA CÓDIGO DO PET
                //LOOPING PARA VERIFICAR SE O CÓDIGO SORTEADO JÁ EXISTE NO BANCO
                do
                {
                    numerosrandom = numeros.Next(0100, 0300);
                    novocodigopet = numerosrandom.ToString();
                    novocodigopet = "O" + novocodigopet;
                    consultaSQL = "SELECT * FROM paciente WHERE codigopet='" + novocodigopet + "'";
                    dt = BancoDados.Consulta(consultaSQL);
                    tb_Codigo_Pac.Text = novocodigopet;

                } while (dt.Rows.Count > 0);
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

            /* BOTÃO EDITAR APENAS HABILITA OS CAMPOS PARA EDIÇÃO, AS ALTERAÇÕES SÃO ENVIADAS
               AO BANCO ATRAVÉS DO BOTÃO SALVAR*/

            if (tb_Nome_Pac.Text == "")
            {
                MessageBox.Show("Utilize a barra de pesquisa para\nlocalizar o cadastro que deseja atualizar!");
            }

            // BOTÃO EXCLUIR DESABILITADO
            btn_Excluir.Enabled = false;

            //CAMPOS HABILITADOS
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
            maskedTextBox1.Enabled = true;
            tb_UF.Enabled = true;
          
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            Donopet donopet = new Donopet();

            if (tb_Codigo_Pac.Text == "")
            {
                MessageBox.Show("Erro ao excluir!\nPesquise o PET que deseja excluir na barra de pesquisa.\nUtilize o botão VISUALIZAR PACIENTE para ver os PETS cadastrados no sistema!");
            }
            else
            {

                //BOTÃO DE CONFIRMAÇÃO DA EXCLUSÃO, OFERECENDO A OPÇÃO DE CONFIRMAÇÃO OU CANCELAMENTO

                const string mensagem = "Você tem certeza que deseja excluir o PET?";
                const string caption = "Exclusão de cadastro";
                var result = MessageBox.Show(mensagem, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {

                    MessageBox.Show("Exclusão cancelada!");
                }
                else
                {

                    // APÓS CONFIRMAÇÃO DO USUÁRIO É REALIZADA A EXCLUSÃO DO PET E DONO DO BANCO
                    try
                    {
                        MySqlConnection conexaoexcluir = new MySqlConnection("server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2");
                        conexaoexcluir.Open();
                        MySqlCommand pacienteexcluir = new MySqlCommand("DELETE FROM paciente WHERE codigopet = @codigopet", conexaoexcluir);

                        pacienteexcluir.Parameters.Add("@codigopet", MySqlDbType.VarChar, 10).Value = tb_Codigo_Pac.Text;
                        pacienteexcluir.CommandType = CommandType.Text;
                        pacienteexcluir.ExecuteNonQuery();


                        MySqlCommand donopetexcluir = new MySqlCommand("DELETE FROM dono WHERE cpf = @cpf", conexaoexcluir);

                        donopetexcluir.Parameters.Add("@cpf", MySqlDbType.VarChar, 11).Value = tb_CPF.Text;
                        donopetexcluir.CommandType = CommandType.Text;
                        donopetexcluir.ExecuteNonQuery();
                        conexaoexcluir.Close();

                        MessageBox.Show("Cadastro excluído com sucesso!");

                        // LIMPEZA DOS CAMPOS APÓS CONFIRMADA A EXCLUSÃO PELO BANCO

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
                        maskedTextBox1.Clear();
                        tb_UF.Clear();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao excluir!" + erro);
                    }
                }
            }
            
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // VERIFICA SE OS PRINCIPAIS CAMPOS DO FORMULÁRIO ESTÃO PREENCHIDOS
            if (tb_Codigo_Pac.Text == "" )
            {
                MessageBox.Show("Erro ao salvar!\nPesquise o Pet que deseja atualizar ou clique em novo.\nTodos os campos do formulário devem ser preenchidos.");
            }
            else if (tb_Peso.Text.Contains("."))
            {
                MessageBox.Show("No campo peso utilize (VÍRGULA) ao invés de (PONTO).");
            }
            //TODOS OS CAMPOS SENDO VERIFICADOS
            else if (tb_Nome_Pac.Text == "" || tb_Raça.Text == "" || tb_Idade.Text == "" || tb_Peso.Text == "" || tb_Sexo.Text == "" || tb_CPF.Text == "" || tb_NomeDono.Text == "" || tb_Rua.Text == "" || tb_Nº.Text == "" || tb_CEP.Text == "" || tb_Cidade.Text == "" || tb_email.Text == "" || maskedTextBox1.Text == "" || tb_UF.Text == "")
            {
                MessageBox.Show("Erro ao salvar!\nTodos os campos do formulário devem ser preenchidos.");
            }
            else
            {
                // DECLARAÇÃO DOS OBJETOS PACIENTE E DONO
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
                donopet.telefone = maskedTextBox1.Text;


                Paciente paciente = new Paciente();
                paciente.codigopet = tb_Codigo_Pac.Text;
                paciente.dono_cpf = tb_CPF.Text;
                paciente.nomepet = tb_Nome_Pac.Text;
                paciente.raca = tb_Raça.Text;
                paciente.idade = tb_Idade.Text;
                paciente.peso = tb_Peso.Text;
                paciente.sexo = tb_Sexo.Text;


                /*CONSULTA AO BANCO DE DADOS PARA SABER SE É UM CADASTRO NOVO OU
                 UM CADASTRO QUE SERÁ ATUALIZADO*/

                DataTable data_table = new DataTable();
                string codpet = tb_Codigo_Pac.Text;
                string consultaSQL = "SELECT * FROM paciente WHERE codigopet='" + codpet + "'";
                data_table = BancoDados.Consulta(consultaSQL);

                // SE O BANCO RETORNAR ALGUM CADASTRO SERÁ REALIZADA A ATUALIZAÇÃO
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
                        pacienteupdate.Parameters.Add("@sexo", MySqlDbType.VarChar, 20).Value = paciente.sexo;
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

                    /* CASO O BANCO RETORNE 0 LINHAS UM NOVO CADASTRO É REALIZADO ATRAVÉS DOS METODOS
                    insertpaciente e insertdono*/
                }
                else
                {

                    BancoDados.insertpaciente(paciente);
                    BancoDados.insertdono(donopet);
                }
            }

        }

        private void btn_VIS_PAC_Click(object sender, EventArgs e)
        {
           
            TelaVisPac telavispac = new TelaVisPac(this);
            telavispac.ShowDialog();
        }
    }



}
