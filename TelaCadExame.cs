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
    public partial class TelaCadExame : Form
    {
        public TelaCadExame(TelaInicial telaInicial)
        {
            InitializeComponent();
            this.tela_inicial = telaInicial;
        }
        private TelaInicial tela_inicial;

        public TelaCadExame(TelaVisExame telavisexame)
        {
            InitializeComponent();
            this.tela_visexame = telavisexame;
        }
        private TelaVisExame tela_visexame;

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tb_Cod_Exame.Clear();
            tb_Nome_Exame.Clear();
            tb_Preco_Exame.Clear();
        }

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // VERIFICA SE TODOS OS CAMPOS DO FORMULÁRIO ESTÃO PREENCHIDOS
            if (tb_Cod_Exame.Text == "" || tb_Nome_Exame.Text == "" || tb_Preco_Exame.Text == "")
            {
                MessageBox.Show("Erro ao salvar!\nPesquise o EXAME que deseja atualizar ou clique em novo.\nTodos os campos do formulário devem ser preenchidos.");
            }
            else
            {

                /*CONSULTA AO BANCO DE DADOS PARA SABER SE É UM CADASTRO NOVO OU
                 UM CADASTRO QUE SERÁ ATUALIZADO*/

                DataTable data_table = new DataTable();
                string codexame = tb_Cod_Exame.Text;
                string consultaSQL = "SELECT * FROM Exame WHERE codigo='" + codexame + "'";
                data_table = BancoDados.Consulta(consultaSQL);

                // SE O BANCO RETORNAR ALGUM CADASTRO SERÁ REALIZADA A ATUALIZAÇÃO
                if (data_table.Rows.Count != 0)
                {
                    try
                    {
                        MySqlConnection conexaoupdate = new MySqlConnection("server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2");
                        conexaoupdate.Open();
                        MySqlCommand exameupdate = new MySqlCommand("UPDATE Exame SET nome = ?, preco = ? Where codigo = ?", conexaoupdate);

                        exameupdate.Parameters.Clear();
                        exameupdate.Parameters.Add("@nome", MySqlDbType.VarChar, 20).Value = tb_Nome_Exame.Text;
                        exameupdate.Parameters.Add("@preco", MySqlDbType.Double, 1).Value = tb_Preco_Exame.Text;
                        exameupdate.CommandType = CommandType.Text;
                        exameupdate.ExecuteNonQuery();
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

                    try
                    {

                        MySqlConnection conexaoinsert = new MySqlConnection("server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2");
                        conexaoinsert.Open();
                        MySqlCommand exameinsert = new MySqlCommand("INSERT INTO Exame (codigo, nome, preco) VALUES (@codigo, @nome, @preco)", conexaoinsert);


                        exameinsert.Parameters.AddWithValue("@codigo", tb_Cod_Exame.Text);
                        exameinsert.Parameters.AddWithValue("@nome", tb_Nome_Exame.Text);
                        exameinsert.Parameters.AddWithValue("@nomepet", double.Parse(tb_Preco_Exame.Text));

                        exameinsert.ExecuteNonQuery();

                        MessageBox.Show("Novo Exame cadastrado com sucesso!");



                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao cadastrar exame \n" + ex.Message);

                    }
                }
            }
        }


        private void btn_Histórico_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVisExame telavisexame = new TelaVisExame(this);
            telavisexame.Show();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Preencha todos os dados do formulário e clique em salvar.");

            btn_Excluir.Enabled = false;
            tb_Pesquisar.Clear();
            tb_Cod_Exame.Clear();
            tb_Nome_Exame.Clear();
            tb_Preco_Exame.Clear();

            tb_Cod_Exame.Enabled = true;
            tb_Nome_Exame.Enabled = true;
            tb_Preco_Exame.Enabled = true;

            Random numeros = new Random();
            int numerosrandom;
            string novocodigoexame;
            DataTable dt = new DataTable();
            string consultaSQL;

            
                do
                {
                    numerosrandom = numeros.Next(0100, 0300);
                    novocodigoexame = numerosrandom.ToString();
                    novocodigoexame = "E" + novocodigoexame;
                    consultaSQL = "SELECT * FROM Exame WHERE codigo='" + novocodigoexame + "'";
                    dt = BancoDados.Consulta(consultaSQL);
                    tb_Cod_Exame.Text = novocodigoexame;

                } while (dt.Rows.Count > 0);
                        
        }

        private void pb_Pesquisar_Click(object sender, EventArgs e)
        {
            // DESABILITA A EDIÇÃO DOS CAMPOS DO FORMULÁRIO 

            tb_Cod_Exame.Enabled = false;
            tb_Nome_Exame.Enabled = false;
            tb_Preco_Exame.Enabled = false;

            btn_Excluir.Enabled = true;

            string codexame = tb_Pesquisar.Text;

            if (codexame == "")
            {
                MessageBox.Show("Informe o código do exame");
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

                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Exame WHERE codigo='" + codexame + "'", conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            // TEXTBOX RECEBEM CONTEUDO CONSULTADO NO BANCO ATRAVES DO READER

                            while (reader.Read())
                            {
                               
                                tb_Cod_Exame.Text = reader.GetString(0);
                                tb_Nome_Exame.Text = reader.GetString(1);
                                tb_Preco_Exame.Text = reader.GetString(2);
                                
                            }

                      
                            if (reader.HasRows)
                            {
                               
                                MessageBox.Show("Exame localizado!!!");

                            }
                            else
                            {
                                MessageBox.Show("Exame não encontrado!!!");

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

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (tb_Cod_Exame.Text == "")
            {
                MessageBox.Show("Erro ao excluir!\nPesquise o EXAME que deseja excluir na barra de pesquisa.\nUtilize o botão VISUALIZAR EXAME para ver os EXAMES cadastrados no sistema!");
            }
            else
            {

                //BOTÃO DE CONFIRMAÇÃO DA EXCLUSÃO, OFERECENDO A OPÇÃO DE CONFIRMAÇÃO OU CANCELAMENTO

                const string mensagem = "Você tem certeza que deseja excluir o EXAME?";
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
                        MySqlCommand exameexcluir = new MySqlCommand("DELETE FROM Exame WHERE codigo = @codigo", conexaoexcluir);

                        exameexcluir.Parameters.Add("@codigo", MySqlDbType.VarChar, 4).Value = tb_Cod_Exame.Text;
                        exameexcluir.CommandType = CommandType.Text;
                        exameexcluir.ExecuteNonQuery();                       
                        conexaoexcluir.Close();

                        MessageBox.Show("Cadastro excluído com sucesso!");

                        // LIMPEZA DOS CAMPOS APÓS CONFIRMADA A EXCLUSÃO PELO BANCO

                        tb_Pesquisar.Clear();
                        tb_Cod_Exame.Clear();
                        tb_Nome_Exame.Clear();
                        tb_Preco_Exame.Clear();
                       
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao excluir!" + erro);
                    }
                }
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (tb_Cod_Exame.Text == "")
            {
                MessageBox.Show("Utilize a barra de pesquisa para\nlocalizar o cadastro que deseja atualizar!");
            }

            // BOTÃO EXCLUIR DESABILITADO
            btn_Excluir.Enabled = false;

            //CAMPOS HABILITADOS
            tb_Cod_Exame.Enabled = true;
            tb_Nome_Exame.Enabled = true;
            tb_Preco_Exame.Enabled = true;
            
        }
    }
}
