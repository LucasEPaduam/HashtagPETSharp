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

        public TelaCadUsu(TelaVisAdm telavisadm)
        {
            InitializeComponent();
            this.tela_visadm = telavisadm;
        }
        private TelaVisAdm tela_visadm;

        public TelaCadUsu(TelaVisVet telavisvet)
        {
            InitializeComponent();
            this.tela_visvet = telavisvet;
        }
        private TelaVisVet tela_visvet;
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            //TextBox do Administrativo
            tb_CPF_Adm.Clear();
            tb_Nome_Adm.Clear();
            tb_Rua_Adm.Clear();
            tb_Num_Adm.Clear();
            tb_CEP_Adm.Clear();
            tb_Cidade_Adm.Clear();
            tb_UF_Adm.Clear();

            //TextBox do Veterinário
            tb_CRMV_Vet.Clear();
            tb_Nome_Vet.Clear();
            tb_Rua_Vet.Clear();
            tb_Num_Vet.Clear();
            tb_Cep_Vet.Clear();
            tb_Cidade_Vet.Clear();
            tb_UF_Vet.Clear();

            rb_adm.Enabled = false;
            rb_vet.Enabled = false;


            tb_CPF_Adm.Enabled = false;
            tb_Nome_Adm.Enabled = false;
            tb_Rua_Adm.Enabled = false;
            tb_Num_Adm.Enabled = false;
            tb_CEP_Adm.Enabled = false;
            tb_Cidade_Adm.Enabled = false;
            tb_UF_Adm.Enabled = false;

            tb_CRMV_Vet.Enabled = false;
            tb_Nome_Vet.Enabled = false;
            tb_Rua_Vet.Enabled = false;
            tb_Num_Vet.Enabled = false;
            tb_Cep_Vet.Enabled = false;
            tb_Cidade_Vet.Enabled = false;
            tb_UF_Vet.Enabled = false;
        }


        private void pb_InicioTCad_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_VIS_Adm_Click(object sender, EventArgs e)
        { 
            TelaVisAdm telavisadm = new TelaVisAdm(this);
            telavisadm.ShowDialog();
        }
        private void btn_VIS_Vet_Click(object sender, EventArgs e)
        {
            TelaVisVet telavisvet = new TelaVisVet(this);
            telavisvet.ShowDialog();
        }

        private void bt_NovoUsu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escolha qual o tipo de usuário.\nEm seguida, preencha todos os dados do formulário e clique em salvar.");

            btn_Excluir.Enabled = false;

            rb_adm.Enabled = true;
            rb_vet.Enabled = true;

            tb_CPF_Adm.Clear();
            tb_Nome_Adm.Clear();
            tb_Rua_Adm.Clear();
            tb_Num_Adm.Clear();
            tb_CEP_Adm.Clear();
            tb_Cidade_Adm.Clear();
            tb_UF_Adm.Clear();


            tb_CRMV_Vet.Clear();
            tb_Nome_Vet.Clear();
            tb_Rua_Vet.Clear();
            tb_Num_Vet.Clear();
            tb_Cep_Vet.Clear();
            tb_Cidade_Vet.Clear();
            tb_UF_Vet.Clear();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (rb_adm.Checked)
            {
                if (tb_CPF_Adm.Text == "")
                {
                    MessageBox.Show("Utilize a barra de pesquisa para\nlocalizar o cadastro que deseja atualizar!");
                }
                // BOTÃO EXCLUIR DESABILITADO
                btn_Excluir.Enabled = false;

                tb_CPF_Adm.Enabled = true;
                tb_Nome_Adm.Enabled = true;
                tb_Rua_Adm.Enabled = true;
                tb_Num_Adm.Enabled = true;
                tb_CEP_Adm.Enabled = true;
                tb_Cidade_Adm.Enabled = true;
                tb_UF_Adm.Enabled = true;
            }
            else if (rb_vet.Checked)
            {
                if (tb_CRMV_Vet.Text == "")
                {
                    MessageBox.Show("Utilize a barra de pesquisa para\nlocalizar o cadastro que deseja atualizar!");
                }
                tb_CRMV_Vet.Enabled = true;
                tb_Nome_Vet.Enabled = true;
                tb_Rua_Vet.Enabled = true;
                tb_Num_Vet.Enabled = true;
                tb_Cep_Vet.Enabled = true;
                tb_Cidade_Vet.Enabled = true;
                tb_UF_Vet.Enabled = true;
            }

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Administrativo administrativo = new Administrativo();
            Veterinario veterinario = new Veterinario();

            if (tb_CPF_Adm.Text == "" || tb_CRMV_Vet.Text == "")
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

                        administrativoexcluir.Parameters.Add("@cpf", MySqlDbType.VarChar, 10).Value = tb_CPF_Adm.Text;
                        administrativoexcluir.CommandType = CommandType.Text;
                        administrativoexcluir.ExecuteNonQuery();


                        MySqlCommand veterinarioexcluir = new MySqlCommand("DELETE FROM veterinario WHERE crmv = @crmv", conexaoexcluir);

                        veterinarioexcluir.Parameters.Add("@crmv", MySqlDbType.VarChar, 11).Value = tb_CRMV_Vet.Text;
                        veterinarioexcluir.CommandType = CommandType.Text;
                        veterinarioexcluir.ExecuteNonQuery();
                        conexaoexcluir.Close();

                        MessageBox.Show("Cadastro excluído com sucesso!");

                        // LIMPEZA DOS CAMPOS APÓS CONFIRMADA A EXCLUSÃO PELO BANCO

                        //TextBox do Administrativo
                        tb_CPF_Adm.Clear();
                        tb_Nome_Adm.Clear();
                        tb_Rua_Adm.Clear();
                        tb_Num_Adm.Clear();
                        tb_CEP_Adm.Clear();
                        tb_Cidade_Adm.Clear();
                        tb_UF_Adm.Clear();

                        //TextBox do Veterinário
                        tb_CRMV_Vet.Clear();
                        tb_Nome_Vet.Clear();
                        tb_Rua_Vet.Clear();
                        tb_Num_Vet.Clear();
                        tb_Cep_Vet.Clear();
                        tb_Cidade_Vet.Clear();
                        tb_UF_Vet.Clear();
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
                if (tb_CPF_Adm.Text == "")
                {
                    MessageBox.Show("Erro ao salvar!\nPesquise o usuário que deseja atualizar ou clique em novo.\nTodos os campos do formulário devem ser preenchidos.");
                }

                //TODOS OS CAMPOS SENDO VERIFICADOS
                else if (tb_CPF_Adm.Text == "" || tb_Nome_Adm.Text == "" || tb_Rua_Adm.Text == "" || tb_Num_Adm.Text == "" || tb_CEP_Adm.Text == "" || tb_Cidade_Adm.Text == "" || tb_UF_Adm.Text == "")
                {
                    MessageBox.Show("Erro ao salvar!\nTodos os campos do formulário devem ser preenchidos.");
                }
                else
                {
                    Administrativo administrativo = new Administrativo();
                    administrativo.CPF = tb_CPF_Adm.Text;
                    administrativo.nome = tb_Nome_Adm.Text;
                    administrativo.rua = tb_Rua_Adm.Text;
                    administrativo.numero = tb_Num_Adm.Text;
                    administrativo.CEP = tb_CEP_Adm.Text;
                    administrativo.cidade = tb_Cidade_Adm.Text;
                    administrativo.uf = tb_UF_Adm.Text;

                    DataTable data_table = new DataTable();
                    string codadm = tb_CPF_Adm.Text;
                    string consultaSQL = "SELECT * FROM administrativo WHERE cpf='" + codadm + "'";

                    data_table = BancoDados.Consulta(consultaSQL);

                    // SE O BANCO RETORNAR ALGUM CADASTRO SERÁ REALIZADA A ATUALIZAÇÃO
                    if (data_table.Rows.Count != 0)
                    {
                        try
                        {
                            MySqlConnection conexaoupdate = new MySqlConnection("server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2");
                            conexaoupdate.Open();
                            MySqlCommand administrativoupdate = new MySqlCommand("UPDATE administrativo SET  nome = ?, cpf = ?,  rua = ?, numero = ?, cep = ?, cidade = ?, uf = ?", conexaoupdate);

                            administrativoupdate.Parameters.Clear();
                            administrativoupdate.Parameters.Add("@cpf", MySqlDbType.VarChar, 10).Value = administrativo.CPF;
                            administrativoupdate.Parameters.Add("@nome", MySqlDbType.VarChar, 10).Value = administrativo.nome;
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
                if (tb_CRMV_Vet.Text == "")
                {
                    MessageBox.Show("Erro ao salvar!\nPesquise o usuário que deseja atualizar ou clique em novo.\nTodos os campos do formulário devem ser preenchidos.");
                }
                else if (tb_CRMV_Vet.Text == "" || tb_Nome_Vet.Text == "" || tb_Rua_Vet.Text == "" || tb_Num_Vet.Text == "" ||  tb_Cep_Vet.Text == "" || tb_Cidade_Vet.Text == "" || tb_UF_Vet.Text == "" )
                {
                    MessageBox.Show("Erro ao salvar!\nTodos os campos do formulário devem ser preenchidos.");
                }
                else
                {
                    Veterinario veterinario = new Veterinario();
                    veterinario.crmv = tb_CRMV_Vet.Text;
                    veterinario.nome = tb_Nome_Vet.Text;
                    veterinario.rua = tb_Rua_Vet.Text;
                    veterinario.cep = tb_Cep_Vet.Text;
                    veterinario.numero = tb_Num_Vet.Text;
                    veterinario.cidade = tb_Cidade_Vet.Text;
                    veterinario.uf = tb_UF_Vet.Text;

                    DataTable data_table = new DataTable();
                    string codvet = tb_CRMV_Vet.Text;
                    string consultaSQLvacina = "SELECT * FROM veterinario WHERE crmv='" + codvet + "'";
                    if (data_table.Rows.Count != 0)
                    {
                        try
                        {
                            MySqlConnection conexaoupdate = new MySqlConnection("server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2");
                            conexaoupdate.Open();
                            MySqlCommand veterinarioupdate = new MySqlCommand("UPDATE veterinario SET nomevet = ?, cep = ?, numero = ?, cidade = ?, rua= ?, uf = ?", conexaoupdate);

                            veterinarioupdate.Parameters.Clear();
                            veterinarioupdate.Parameters.Add("@nomevet", MySqlDbType.VarChar, 10).Value = veterinario.nome;
                            veterinarioupdate.Parameters.Add("@rua", MySqlDbType.VarChar, 10).Value = veterinario.rua;
                            veterinarioupdate.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = veterinario.numero;
                            veterinarioupdate.Parameters.Add("@cep", MySqlDbType.VarChar, 10).Value = veterinario.cep;
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
    

        
        private void pb_Pesquisar_Click(object sender, EventArgs e)
        {
            rb_adm.Enabled = false;
            rb_vet.Enabled = false;

            tb_CPF_Adm.Enabled = false;
            tb_Nome_Adm.Enabled = false;
            tb_Rua_Adm.Enabled = false;
            tb_Num_Adm.Enabled = false;
            tb_CEP_Adm.Enabled = false;
            tb_Cidade_Adm.Enabled = false;
            tb_UF_Adm.Enabled = false;

            tb_CRMV_Vet.Enabled = false;
            tb_Nome_Vet.Enabled = false;
            tb_Rua_Vet.Enabled = false;
            tb_Num_Vet.Enabled = false;
            tb_Cep_Vet.Enabled = false;
            tb_Cidade_Vet.Enabled = false;
            tb_UF_Vet.Enabled = false;

            string codusu = tb_Pesquisar.Text;


            if (codusu == "")
            {
                MessageBox.Show("Informe o código do usuário");
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

                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM administrativo WHERE cpf='" + codusu + "'", conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tb_CPF_Adm.Text = reader.GetString(0);
                                tb_Nome_Adm.Text = reader.GetString(1);
                                tb_Rua_Adm.Text = reader.GetString(2);
                                tb_Num_Adm.Text = reader.GetString(3);
                                tb_CEP_Adm.Text = reader.GetString(4);
                                tb_Cidade_Adm.Text = reader.GetString(5);
                                tb_UF_Adm.Text = reader.GetString(6);
                            }
                        }
                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM veterinario WHERE crmv='" + codusu + "'", conn))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tb_CRMV_Vet.Text = reader.GetString(0);
                                tb_Nome_Vet.Text = reader.GetString(1);
                                tb_Cep_Vet.Text = reader.GetString(2);
                                tb_Num_Vet.Text = reader.GetString(3);
                                tb_Cidade_Vet.Text = reader.GetString(4);
                                tb_Rua_Vet.Text = reader.GetString(5);
                                tb_UF_Vet.Text = reader.GetString(6);

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

        private void rb_adm_CheckedChanged(object sender, EventArgs e)
        {
            tb_CPF_Adm.Enabled = true;
            tb_Nome_Adm.Enabled = true;
            tb_Rua_Adm.Enabled = true;
            tb_Num_Adm.Enabled = true;
            tb_CEP_Adm.Enabled = true;
            tb_Cidade_Adm.Enabled = true;
            tb_UF_Adm.Enabled = true;

            tb_Senha.Enabled = true;

            tb_CRMV_Vet.Enabled = false;
            tb_Nome_Vet.Enabled = false;
            tb_Rua_Vet.Enabled = false;
            tb_Num_Vet.Enabled = false;
            tb_Cep_Vet.Enabled = false;
            tb_Cidade_Vet.Enabled = false;
            tb_UF_Vet.Enabled = false;

            tb_CRMV_Vet.Clear();
            tb_Nome_Vet.Clear();
            tb_Rua_Vet.Clear();
            tb_Num_Vet.Clear();
            tb_Cep_Vet.Clear();
            tb_Cidade_Vet.Clear();
            tb_UF_Vet.Clear();
        }

        private void rb_vet_CheckedChanged(object sender, EventArgs e)
        {
            tb_CRMV_Vet.Enabled = true;
            tb_Nome_Vet.Enabled = true;
            tb_Rua_Vet.Enabled = true;
            tb_Num_Vet.Enabled = true;
            tb_Cep_Vet.Enabled = true;
            tb_Cidade_Vet.Enabled = true;
            tb_UF_Vet.Enabled = true;

            tb_Senha.Enabled = true;

            tb_CPF_Adm.Enabled = false;
            tb_Nome_Adm.Enabled = false;
            tb_Rua_Adm.Enabled = false;
            tb_Num_Adm.Enabled = false;
            tb_CEP_Adm.Enabled = false;
            tb_Cidade_Adm.Enabled = false;
            tb_UF_Adm.Enabled = false;

            tb_CPF_Adm.Clear();
            tb_Nome_Adm.Clear();
            tb_Rua_Adm.Clear();
            tb_Num_Adm.Clear();
            tb_CEP_Adm.Clear();
            tb_Cidade_Adm.Clear();
            tb_UF_Adm.Clear();

        }


    }
}

