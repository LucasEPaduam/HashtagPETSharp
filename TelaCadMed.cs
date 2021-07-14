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
    public partial class TelaCadMed : Form
    {
        public TelaCadMed(TelaInicial telaInicial)
        {
            InitializeComponent();
            this.tela_inicial = telaInicial;
        }
        private TelaInicial tela_inicial;

        public TelaCadMed(TelaVisMed telavismed)
        {
            InitializeComponent();
            this.tela_vismed = telavismed;
        }
        private TelaVisMed tela_vismed;

        public TelaCadMed (TelaVisVacina telaVisVacina)
        {
            InitializeComponent();
            this.tela_vivacina = telaVisVacina;
        }
        private TelaVisVacina tela_vivacina;

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

       

      

        private void pb_Pesquisar_Click(object sender, EventArgs e)
        {
            rb_Remedio.Enabled = false;
            rb_Vacina.Enabled = false;

            tb_Cod_Med.Enabled = false;
            tb_Nome_Med.Enabled = false;
            tb_Preco_Med.Enabled = false;

            bt_excluir.Enabled = true;

            string codmed = tb_Pesquisar.Text;

            

            string consultaSQL = "SELECT * FROM Remedio WHERE codigo='" + codmed + "'";
            DataTable dt = BancoDados.Consulta(consultaSQL);
            string consultaSQL2 = "SELECT * FROM Vacina WHERE codigo='" + codmed + "'";
            DataTable dt2 = BancoDados.Consulta(consultaSQL2);

            if (codmed == "")
            {
                MessageBox.Show("Informe o código do medicamento");
                tb_Pesquisar.Focus();
            }
            else if (dt.Rows.Count == 0 && dt2.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Medicamento encontrado!\nUtilize o botão Visualizar Remedio ou Visualizar Vacina.");
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

                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM vacina WHERE codigo='" + codmed + "'", conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            // TEXTBOX RECEBEM CONTEUDO CONSULTADO NO BANCO ATRAVES DO READER

                            while (reader.Read())
                            {
                                tb_Cod_Med.Text = reader.GetString(0);
                                tb_Nome_Med.Text = reader.GetString(1);
                                tb_Preco_Med.Text = reader.GetString(2);
                            }
                            if (reader.HasRows)
                            {
                               if (codmed.StartsWith("v") || (codmed.StartsWith("V")))
                               {
                                    rb_Vacina.Checked = true;
                                    tb_Cod_Med.Text = tb_Pesquisar.Text;
                                    MessageBox.Show("Vacina localizada!!!");
                               }
                            }
                           
                        }
                    
                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM remedio WHERE codigo='" + codmed + "'", conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tb_Cod_Med.Text = reader.GetString(0);
                                tb_Nome_Med.Text = reader.GetString(1);
                                tb_Preco_Med.Text = reader.GetString(2);
                            }

                            if (reader.HasRows)
                            {
                                if (codmed.StartsWith("R") || (codmed.StartsWith("r")))
                                {
                                    rb_Remedio.Checked = true;
                                    tb_Cod_Med.Text = tb_Pesquisar.Text;
                                    MessageBox.Show("Remédio localizado!!!");
                                }
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
    
        private void bt_NovoMed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escolha qual o tipo do medicamento.\nEm seguida, preencha todos os dados do formulário e clique em salvar.");

            bt_excluir.Enabled = false;

            tb_Pesquisar.Clear();
            tb_Cod_Med.Clear();
            tb_Nome_Med.Clear();
            tb_Preco_Med.Clear();
            

            rb_Remedio.Enabled = true;
            rb_Vacina.Enabled = true;
            tb_Cod_Med.Enabled = true;
            tb_Nome_Med.Enabled = true;
            tb_Preco_Med.Enabled = true;
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (tb_Nome_Med.Text == "")
            {
                MessageBox.Show("Utilize a barra de pesquisa para\nlocalizar o cadastro que deseja atualizar!");
            }

            // BOTÃO EXCLUIR DESABILITADO
            bt_excluir.Enabled = false;

            //CAMPOS HABILITADOS
            tb_Nome_Med.Enabled = true;
            tb_Preco_Med.Enabled = true;
        }
        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_Cod_Med.Clear();
            tb_Nome_Med.Clear();
            tb_Preco_Med.Clear();

            tb_Pesquisar.Clear();

            rb_Remedio.Enabled = false;
            rb_Vacina.Enabled = false;

            tb_Cod_Med.Enabled = false;
            tb_Nome_Med.Enabled = false;
            tb_Preco_Med.Enabled = false;
        }
        private void bt_excluir_Click(object sender, EventArgs e)
        {
            

            if (tb_Cod_Med.Text == "")
            {
                MessageBox.Show("Erro ao excluir!\nPesquise o medicamento que deseja excluir na barra de pesquisa.\nUtilize o botão VISUALIZAR MEDICAMENTOS para ver os medicamentos cadastrados no sistema!");
            }
            else
            {

                //BOTÃO DE CONFIRMAÇÃO DA EXCLUSÃO, OFERECENDO A OPÇÃO DE CONFIRMAÇÃO OU CANCELAMENTO

                const string mensagem = "Você tem certeza que deseja excluir o medicamento?";
                const string caption = "Exclusão de cadastro";
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
                        MySqlCommand vacinaexcluir = new MySqlCommand("DELETE FROM vacina WHERE codigo = @codigo", conexaoexcluir);

                        vacinaexcluir.Parameters.Add("@codigo", MySqlDbType.VarChar, 10).Value = tb_Cod_Med.Text;
                        vacinaexcluir.CommandType = CommandType.Text;
                        vacinaexcluir.ExecuteNonQuery();

                        MySqlCommand remedioexcluir = new MySqlCommand("DELETE FROM remedio WHERE codigo = @codigo", conexaoexcluir);

                        remedioexcluir.Parameters.Add("@codigo", MySqlDbType.VarChar, 10).Value = tb_Cod_Med.Text;
                        remedioexcluir.CommandType = CommandType.Text;
                        remedioexcluir.ExecuteNonQuery();
                        conexaoexcluir.Close();

                        MessageBox.Show("Cadastro excluído com sucesso!");

                        // LIMPEZA DOS CAMPOS APÓS CONFIRMADA A EXCLUSÃO PELO BANCO

                        tb_Pesquisar.Clear();
                        tb_Cod_Med.Clear();
                        tb_Nome_Med.Clear();
                        tb_Preco_Med.Clear();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao excluir!" + erro);
                    }
                }
            }

        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {

            if (tb_Cod_Med.Text == "")
            {
                MessageBox.Show("Erro ao salvar!\nPesquise o medicamento que deseja atualizar ou clique em novo.\nTodos os campos do formulário devem ser preenchidos.");
            }
            else if (tb_Preco_Med.Text.Contains(","))
            {
                MessageBox.Show("No campo peso utilize (PONTO) ao invés de (VÍRGULA).");
            }
            //TODOS OS CAMPOS SENDO VERIFICADOS
            else if (tb_Nome_Med.Text == "" || tb_Preco_Med.Text == "")
            {
                MessageBox.Show("Erro ao salvar!\nTodos os campos do formulário devem ser preenchidos.");
            }
            else
            {
                if (rb_Remedio.Checked)
                {
                    Remedio remedio = new Remedio();
                    remedio.codigo = tb_Cod_Med.Text;
                    remedio.nome = tb_Nome_Med.Text;
                    remedio.preco = tb_Preco_Med.Text;

                    DataTable data_table = new DataTable();
                    string codmed = tb_Cod_Med.Text;
                    string consultaSQLremedio = "SELECT * FROM remedio WHERE codigo='" + codmed + "'";

                    data_table = BancoDados.Consulta(consultaSQLremedio);

                    // SE O BANCO RETORNAR ALGUM CADASTRO SERÁ REALIZADA A ATUALIZAÇÃO
                    if (data_table.Rows.Count != 0)
                    {
                        try
                        {
                            MySqlConnection conexaoupdate = new MySqlConnection("server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2");
                            conexaoupdate.Open();
                            MySqlCommand remedioupdate = new MySqlCommand("UPDATE Remedio SET nome = ?, preco = ? Where codigo = ?", conexaoupdate);

                            remedioupdate.Parameters.Clear();
                            remedioupdate.Parameters.Add("@nome", MySqlDbType.VarChar, 10).Value = remedio.nome;
                            remedioupdate.Parameters.Add("@preco", MySqlDbType.Double, 1).Value = remedio.preco;
                            remedioupdate.Parameters.Add("codigo", MySqlDbType.VarChar).Value = remedio.codigo;
                            remedioupdate.CommandType = CommandType.Text;
                            remedioupdate.ExecuteNonQuery();

                            MessageBox.Show("Atualizado com sucesso!");
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Erro ao atualizar!" + erro);
                        }
                    }
                    else
                    {
                        BancoDados.insertremedio(remedio);
                    }

                }

                if (rb_Vacina.Checked)
                {
                    Vacina vacina = new Vacina();
                    vacina.codigo = tb_Cod_Med.Text;
                    vacina.nome = tb_Nome_Med.Text;
                    vacina.preco = tb_Preco_Med.Text;


                    /*CONSULTA AO BANCO DE DADOS PARA SABER SE É UM CADASTRO NOVO OU
                     UM CADASTRO QUE SERÁ ATUALIZADO*/


                    DataTable data_table = new DataTable();
                    string codmed = tb_Cod_Med.Text;
                    string consultaSQLvacina = "SELECT * FROM vacina WHERE codigo='" + codmed + "'";

                    data_table = BancoDados.Consulta(consultaSQLvacina);

                    if (data_table.Rows.Count != 0)
                    {
                        try
                        {
                            MySqlConnection conexaoupdate = new MySqlConnection("server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2");
                            conexaoupdate.Open();
                            MySqlCommand vacinaupdate = new MySqlCommand("UPDATE Vacina SET nome = ?, preco = ? Where codigo = ?", conexaoupdate);

                            vacinaupdate.Parameters.Clear();
                            vacinaupdate.Parameters.Add("@nome", MySqlDbType.VarChar, 10).Value = vacina.nome;
                            vacinaupdate.Parameters.Add("@preco", MySqlDbType.Double, 1).Value = vacina.preco;
                            vacinaupdate.Parameters.Add("codigo", MySqlDbType.VarChar).Value = vacina.codigo;
                            vacinaupdate.CommandType = CommandType.Text;
                            vacinaupdate.ExecuteNonQuery();

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
                        BancoDados.insertvacina(vacina);
                    }
                }
            }
            rb_Remedio.Enabled = false;
            rb_Vacina.Enabled = false;

            tb_Cod_Med.Enabled = false;
            tb_Nome_Med.Enabled = false;
            tb_Preco_Med.Enabled = false;
        }
        private void rb_Remedio_CheckedChanged(object sender, EventArgs e)
        {
            Random numeros = new Random();
            int numerosrandom;
            string novocodigomed;
            DataTable dt = new DataTable();
            string consultaSQL;

            if (rb_Remedio.Checked)
            {
                //REALIZADO SORTEIO DE NUMERO ALEATÓRIO PARA CÓDIGO DO PET
                //LOOPING PARA VERIFICAR SE O CÓDIGO SORTEADO JÁ EXISTE NO BANCO
                do
                {
                    numerosrandom = numeros.Next(0100, 0300);
                    novocodigomed = numerosrandom.ToString();
                    novocodigomed = "R" + novocodigomed;
                    consultaSQL = "SELECT * FROM remedio WHERE codigo='" + novocodigomed + "'";
                    dt = BancoDados.Consulta(consultaSQL);
                    tb_Cod_Med.Text = novocodigomed;
                    tb_Cod_Med.Enabled = false;
                } while (dt.Rows.Count > 0);
            }
        }

        private void rb_Vacina_CheckedChanged(object sender, EventArgs e)
        {
            Random numeros = new Random();
            int numerosrandom;
            string novocodigomed;
            DataTable dt = new DataTable();
            string consultaSQL;

            if (rb_Vacina.Checked)
            {
                //REALIZADO SORTEIO DE NUMERO ALEATÓRIO PARA CÓDIGO DO PET
                //LOOPING PARA VERIFICAR SE O CÓDIGO SORTEADO JÁ EXISTE NO BANCO
                do
                {
                    numerosrandom = numeros.Next(0100, 0300);
                    novocodigomed = numerosrandom.ToString();
                    novocodigomed = "V" + novocodigomed;
                    consultaSQL = "SELECT * FROM vacina WHERE codigo='" + novocodigomed + "'";
                    dt = BancoDados.Consulta(consultaSQL);
                    tb_Cod_Med.Text = novocodigomed;
                    tb_Cod_Med.Enabled = false;
                } while (dt.Rows.Count > 0);
            }
        }

        private void btn_VIS_MED_Click(object sender, EventArgs e)
        {
            TelaVisMed telavismed = new TelaVisMed(this);
            telavismed.ShowDialog();
        }

        private void btn_VisuVacina_Click(object sender, EventArgs e)
        {
            TelaVisVacina telaVisVacina = new TelaVisVacina(this);
            telaVisVacina.ShowDialog();
        }

       
    }
 }

