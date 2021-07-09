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
    public partial class TelaCadUsu : Form
    {
        public TelaCadUsu(TelaLogin telaLogin)
        {
            InitializeComponent();
            this.tela_login = telaLogin;
        }

        public TelaCadUsu(TelaInicial telaInicial)
        {
            InitializeComponent();
            this.tela_inicial = telaInicial;
        }

        private TelaLogin tela_login;
        private TelaInicial tela_inicial;

        public TelaCadUsu(TelaVisUsu telavisusu)
        {
            InitializeComponent();
            this.tela_visusu = telavisusu;
        }
        private TelaVisUsu tela_visusu;

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            //TextBox do Administrativo
            tb_Cod_Usu.Clear();
            tb_Cargo_Usu.Clear();
            tb_Nasc_Usu.Clear();
            tb_CPF_Usu.Clear();
            tb_Nasc_Usu.Clear();
            tb_Idade_Usu.Clear();
            tb_Rua_Av_Usu.Clear();
            tb_Num_Usu.Clear();
            tb_CEP_Usu.Clear();
            tb_Cidade_Usu.Clear();
            tb_UF_Usu.Clear();

            //TextBox do Veterinário
            tb_CRMV_Usu.Clear();
            tb_Nome_Vet_Usu.Clear();
            tb_Rua_Usu.Clear();
            tb_N_Usu.Clear();
            tb_Cep_Med_Usu.Clear();
            tb_Cid_Usu.Clear();
            tb_UF_Med_Usu.Clear();

            rb_adm.Enabled = false;
            rb_vet.Enabled = false;

            tb_Cargo_Usu.Enabled = false;
            tb_Cidade_Usu.Enabled = false;
            tb_CEP_Usu.Enabled = false;
            tb_CPF_Usu.Enabled = false;
            tb_Cod_Usu.Enabled = false;
            tb_Idade_Usu.Enabled = false;
            tb_Nasc_Usu.Enabled = false;
            tb_Nome_Usu.Enabled = false;
            tb_Num_Usu.Enabled = false;
            tb_Rua_Av_Usu.Enabled = false;
            tb_UF_Usu.Enabled = false;

            tb_Cep_Med_Usu.Enabled = false;
            tb_CRMV_Usu.Enabled = false;
            tb_Nome_Vet_Usu.Enabled = false;
            tb_N_Usu.Enabled = false;
            tb_Rua_Usu.Enabled = false;
            tb_UF_Med_Usu.Enabled = false;
            tb_Cid_Usu.Enabled = false;
        }


        private void pb_InicioTCad_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_VIS_Usu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVisUsu telavisusu = new TelaVisUsu(this);
            telavisusu.Show();
        }

        private void bt_NovoUsu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escolha qual o tipo de usuário.\nEm seguida, preencha todos os dados do formulário e clique em salvar.");

            btn_Excluir.Enabled = false;

            rb_adm.Enabled = true;
            rb_vet.Enabled = true;

            tb_Pesquisar.Clear();
            tb_Cargo_Usu.Clear();
            tb_Cidade_Usu.Clear();
            tb_CEP_Usu.Clear();
            tb_CPF_Usu.Clear();
            tb_Cod_Usu.Clear();
            tb_Idade_Usu.Clear();
            tb_Nasc_Usu.Clear();
            tb_Nome_Usu.Clear();
            tb_Num_Usu.Clear();
            tb_Rua_Av_Usu.Clear();
            tb_UF_Usu.Clear();

            tb_Cep_Med_Usu.Clear();
            tb_CRMV_Usu.Clear();
            tb_Nome_Vet_Usu.Clear();
            tb_N_Usu.Clear();
            tb_Rua_Usu.Clear();
            tb_UF_Med_Usu.Clear();
            tb_Cid_Usu.Clear();

            if (rb_adm.Checked)
            {
                tb_Cod_Usu.Enabled = false;

                tb_Cargo_Usu.Enabled = true;
                tb_Cidade_Usu.Enabled = true;
                tb_CEP_Usu.Enabled = true;
                tb_CPF_Usu.Enabled = true;
                tb_Idade_Usu.Enabled = true;
                tb_Nasc_Usu.Enabled = true;
                tb_Nome_Usu.Enabled = true;
                tb_Num_Usu.Enabled = true;
                tb_Rua_Av_Usu.Enabled = true;
                tb_UF_Usu.Enabled = true;
            }

            if (rb_vet.Checked)
            {
                tb_Cep_Med_Usu.Enabled = true;
                tb_CRMV_Usu.Enabled = true;
                tb_Nome_Vet_Usu.Enabled = true;
                tb_N_Usu.Enabled = true;
                tb_Rua_Usu.Enabled = true;
                tb_UF_Med_Usu.Enabled = true;
                tb_Cid_Usu.Enabled = true;
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (tb_Nome_Usu.Text == "")
            {
                MessageBox.Show("Utilize a barra de pesquisa para\nlocalizar o cadastro que deseja atualizar!");
            }

            // BOTÃO EXCLUIR DESABILITADO
            btn_Excluir.Enabled = false;

            tb_Cargo_Usu.Enabled = true;
            tb_Cidade_Usu.Enabled = true;
            tb_CEP_Usu.Enabled = true;
            tb_CPF_Usu.Enabled = true;
            tb_Cod_Usu.Enabled = true;
            tb_Idade_Usu.Enabled = true;
            tb_Nasc_Usu.Enabled = true;
            tb_Nome_Usu.Enabled = true;
            tb_Num_Usu.Enabled = true;
            tb_Rua_Av_Usu.Enabled = true;
            tb_UF_Usu.Enabled = true;

            tb_Cep_Med_Usu.Enabled = true;
            tb_CRMV_Usu.Enabled = true;
            tb_Nome_Vet_Usu.Enabled = true;
            tb_N_Usu.Enabled = true;
            tb_Rua_Usu.Enabled = true;
            tb_UF_Med_Usu.Enabled = true;
            tb_Cid_Usu.Enabled = true;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Administrativo administrativo = new Administrativo();
            Veterinario veterinario = new Veterinario();

            if (tb_CPF_Usu.Text == "" || tb_CRMV_Usu.Text == "")
            {
                MessageBox.Show("Erro ao excluir!\nPesquise o usuário que deseja excluir na barra de pesquisa.\nUtilize o botão VISUALIZAR USUÁRIO para ver os usuários cadastrados no sistema!");
            }
            else
            {

                //BOTÃO DE CONFIRMAÇÃO DA EXCLUSÃO, OFERECENDO A OPÇÃO DE CONFIRMAÇÃO OU CANCELAMENTO

                const string mensagem = "Você tem certeza que deseja excluir o usuário?";
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
                        MySqlCommand administrativoexcluir = new MySqlCommand("DELETE FROM administrativo WHERE cpf = @cpf", conexaoexcluir);

                        administrativoexcluir.Parameters.Add("@cpf", MySqlDbType.VarChar, 10).Value = tb_CPF_Usu.Text;
                        administrativoexcluir.CommandType = CommandType.Text;
                        administrativoexcluir.ExecuteNonQuery();


                        MySqlCommand veterinarioexcluir = new MySqlCommand("DELETE FROM veterinario WHERE crmv = @crmv", conexaoexcluir);

                        veterinarioexcluir.Parameters.Add("@crmv", MySqlDbType.VarChar, 11).Value = tb_CRMV_Usu.Text;
                        veterinarioexcluir.CommandType = CommandType.Text;
                        veterinarioexcluir.ExecuteNonQuery();
                        conexaoexcluir.Close();

                        MessageBox.Show("Cadastro excluído com sucesso!");

                        // LIMPEZA DOS CAMPOS APÓS CONFIRMADA A EXCLUSÃO PELO BANCO

                        tb_Pesquisar.Clear();
                        tb_Cargo_Usu.Clear();
                        tb_Cidade_Usu.Clear();
                        tb_CEP_Usu.Clear();
                        tb_CPF_Usu.Clear();
                        tb_Cod_Usu.Clear();
                        tb_Idade_Usu.Clear();
                        tb_Nasc_Usu.Clear();
                        tb_Nome_Usu.Clear();
                        tb_Num_Usu.Clear();
                        tb_Rua_Av_Usu.Clear();
                        tb_UF_Usu.Clear();

                        tb_Cep_Med_Usu.Clear();
                        tb_CRMV_Usu.Clear();
                        tb_Nome_Vet_Usu.Clear();
                        tb_N_Usu.Clear();
                        tb_Rua_Usu.Clear();
                        tb_UF_Med_Usu.Clear();
                        tb_Cid_Usu.Clear();

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
            if (rb_adm.Checked)
            {
                if (tb_CPF_Usu.Text == "")
                {
                    MessageBox.Show("Erro ao salvar!\nPesquise o usuário que deseja atualizar ou clique em novo.\nTodos os campos do formulário devem ser preenchidos.");
                }

                //TODOS OS CAMPOS SENDO VERIFICADOS
                else if (tb_Cargo_Usu.Text == "" || tb_Cidade_Usu.Text == "" || tb_CEP_Usu.Text == "" || tb_CPF_Usu.Text == "" || tb_Cod_Usu.Text == "" || tb_Idade_Usu.Text == "" || tb_Nasc_Usu.Text == "" || tb_Nome_Usu.Text == "" || tb_Num_Usu.Text == "" || tb_Rua_Av_Usu.Text == "" || tb_UF_Usu.Text == "")
                {
                    MessageBox.Show("Erro ao salvar!\nTodos os campos do formulário devem ser preenchidos.");
                }
                else
                {
                    Administrativo administrativo = new Administrativo();
                    administrativo.codigo = tb_Cod_Usu.Text;
                    administrativo.nome = tb_Nome_Usu.Text;
                    administrativo.cargo = tb_Cargo_Usu.Text;
                    administrativo.cidade = tb_Cidade_Usu.Text;
                    administrativo.CPF = tb_CPF_Usu.Text;
                    administrativo.CEP = tb_CEP_Usu.Text;
                    administrativo.idade = tb_Idade_Usu.Text;
                    administrativo.nascimento = tb_Nasc_Usu.Text;
                    administrativo.numero = tb_Num_Usu.Text;
                    administrativo.rua = tb_Rua_Av_Usu.Text;
                    administrativo.uf = tb_UF_Usu.Text;

                    DataTable data_table = new DataTable();
                    string codadm = tb_Cod_Usu.Text;
                    string consultaSQL = "SELECT * FROM administrativo WHERE cpf='" + codadm + "'";

                    data_table = BancoDados.Consulta(consultaSQL);

                    // SE O BANCO RETORNAR ALGUM CADASTRO SERÁ REALIZADA A ATUALIZAÇÃO
                    if (data_table.Rows.Count != 0)
                    {
                        try
                        {
                            MySqlConnection conexaoupdate = new MySqlConnection("server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2");
                            conexaoupdate.Open();
                            MySqlCommand administrativoupdate = new MySqlCommand("UPDATE administrativo SET cargo = ?, nome = ?, cpf = ?, nascimento = ?, idade = ?, rua = ?, numero = ?, cep = ?, cidade = ?, uf = ?", conexaoupdate);

                            administrativoupdate.Parameters.Clear();
                            administrativoupdate.Parameters.Add("@nome", MySqlDbType.VarChar, 10).Value = administrativo.nome;
                            administrativoupdate.Parameters.Add("@cargo", MySqlDbType.VarChar, 10).Value = administrativo.cargo;
                            administrativoupdate.Parameters.Add("@cpf", MySqlDbType.VarChar, 10).Value = administrativo.CPF;
                            administrativoupdate.Parameters.Add("@nascimento", MySqlDbType.VarChar, 10).Value = administrativo.nascimento;
                            administrativoupdate.Parameters.Add("@idade", MySqlDbType.VarChar, 10).Value = administrativo.idade;
                            administrativoupdate.Parameters.Add("@rua", MySqlDbType.VarChar, 10).Value = administrativo.rua;
                            administrativoupdate.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = administrativo.numero;
                            administrativoupdate.Parameters.Add("@cep", MySqlDbType.VarChar, 10).Value = administrativo.CEP;
                            administrativoupdate.Parameters.Add("@cidade", MySqlDbType.VarChar, 10).Value = administrativo.cidade;
                            administrativoupdate.Parameters.Add("@uf", MySqlDbType.VarChar, 10).Value = administrativo.uf;

                            administrativoupdate.CommandType = CommandType.Text;
                            administrativoupdate.ExecuteNonQuery();

                            MessageBox.Show("Atualizado com sucesso!");
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Erro ao atualizar!" + erro);
                        }
                    }
                    else
                    {
                        BancoDados.insertadministrativo(administrativo);
                    }
                }
            }

            else if (rb_vet.Checked)
            {
                if (tb_CRMV_Usu.Text == "")
                {
                    MessageBox.Show("Erro ao salvar!\nPesquise o usuário que deseja atualizar ou clique em novo.\nTodos os campos do formulário devem ser preenchidos.");
                }
                else if (tb_Cep_Med_Usu.Text == "" || tb_CRMV_Usu.Text == "" || tb_Nome_Vet_Usu.Text == "" || tb_N_Usu.Text == "" || tb_Rua_Usu.Text == "" || tb_UF_Med_Usu.Text == "" || tb_Cid_Usu.Text == "")
                {
                    MessageBox.Show("Erro ao salvar!\nTodos os campos do formulário devem ser preenchidos.");
                }
                else
                {
                    Veterinario veterinario = new Veterinario();
                    veterinario.crmv = tb_CRMV_Usu.Text;
                    veterinario.nome = tb_Nome_Vet_Usu.Text;
                    veterinario.cep = tb_Cep_Med_Usu.Text;
                    veterinario.numero = tb_N_Usu.Text;
                    veterinario.cidade = tb_Cid_Usu.Text;
                    veterinario.uf = tb_UF_Med_Usu.Text;

                    DataTable data_table = new DataTable();
                    string codvet = tb_CRMV_Usu.Text;
                    string consultaSQLvacina = "SELECT * FROM veterinario WHERE crmv='" + codvet + "'";
                    if (data_table.Rows.Count != 0)
                    {
                        try
                        {
                            MySqlConnection conexaoupdate = new MySqlConnection("server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2");
                            conexaoupdate.Open();
                            MySqlCommand veterinarioupdate = new MySqlCommand("UPDATE veterinario SET nomevet = ?, cep = ?, numero = ?, cidade = ?, uf = ?", conexaoupdate);

                            veterinarioupdate.Parameters.Clear();
                            veterinarioupdate.Parameters.Add("@nomevet", MySqlDbType.VarChar, 10).Value = veterinario.nome;
                            veterinarioupdate.Parameters.Add("@cep", MySqlDbType.VarChar, 10).Value = veterinario.cep;
                            veterinarioupdate.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = veterinario.numero;
                            veterinarioupdate.Parameters.Add("@cidade", MySqlDbType.VarChar, 10).Value = veterinario.cidade;
                            veterinarioupdate.Parameters.Add("@uf", MySqlDbType.VarChar, 10).Value = veterinario.uf;
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
                        BancoDados.insertveterinario(veterinario);
                    }
                }
            }        
        }
    

        private void rb_adm_CheckedChanged(object sender, EventArgs e)
        {
            Random numeros = new Random();
            int numerosrandom;
            string novocodigoadm;
            DataTable dt = new DataTable();
            string consultaSQL;

            if (rb_adm.Checked)
            {
                do
                {
                    numerosrandom = numeros.Next(0100, 0300);
                    novocodigoadm = numerosrandom.ToString();
                    novocodigoadm = "A" + novocodigoadm;
                    consultaSQL = "SELECT * FROM administrativo WHERE codigo='" + novocodigoadm + "'";
                    dt = BancoDados.Consulta(consultaSQL);
                    tb_Cod_Usu.Text = novocodigoadm;

                } while (dt.Rows.Count > 0);
            }
        }

        private void pb_Pesquisar_Click(object sender, EventArgs e)
        {
            rb_adm.Enabled = false;
            rb_vet.Enabled = false;

            tb_Cargo_Usu.Enabled = false;
            tb_Cidade_Usu.Enabled = false;
            tb_CEP_Usu.Enabled = false;
            tb_CPF_Usu.Enabled = false;
            tb_Cod_Usu.Enabled = false;
            tb_Idade_Usu.Enabled = false;
            tb_Nasc_Usu.Enabled = false;
            tb_Nome_Usu.Enabled = false;
            tb_Num_Usu.Enabled = false;
            tb_Rua_Av_Usu.Enabled = false;
            tb_UF_Usu.Enabled = false;

            tb_Cep_Med_Usu.Enabled = false;
            tb_CRMV_Usu.Enabled = false;
            tb_Nome_Vet_Usu.Enabled = false;
            tb_N_Usu.Enabled = false;
            tb_Rua_Usu.Enabled = false;
            tb_UF_Med_Usu.Enabled = false;
            tb_Cid_Usu.Enabled = false;

            string codadm = tb_Pesquisar.Text;

            if (codadm == "")
            {
                MessageBox.Show("Informe o código do administrativo");
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

                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM administrativo WHERE cpf='" + codadm + "'", conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tb_Cod_Usu.Text = reader.GetString(0);
                                tb_Nome_Usu.Text = reader.GetString(1);
                                tb_Cargo_Usu.Text = reader.GetString(2);
                                tb_Cidade_Usu.Text = reader.GetString(3);
                                tb_CPF_Usu.Text = reader.GetString(4);
                                tb_CEP_Usu.Text = reader.GetString(5);
                                tb_Idade_Usu.Text = reader.GetString(6);
                                tb_Nasc_Usu.Text = reader.GetString(7);
                                tb_Num_Usu.Text = reader.GetString(8);
                                tb_Rua_Av_Usu.Text = reader.GetString(9);
                                tb_UF_Usu.Text = reader.GetString(10);
                            }
                        }
                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM veterinario WHERE crmv='" + codadm + "'", conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tb_CRMV_Usu.Text = reader.GetString(0);
                                tb_Nome_Vet_Usu.Text = reader.GetString(1);
                                tb_Cep_Med_Usu.Text = reader.GetString(2);
                                tb_N_Usu.Text = reader.GetString(3);
                                tb_Cid_Usu.Text = reader.GetString(4);
                                tb_UF_Med_Usu.Text = reader.GetString(5);
                                
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
    }
}

