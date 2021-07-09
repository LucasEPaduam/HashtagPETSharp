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

        private void btn_VIS_PAC_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVisUsu telavisusu = new TelaVisUsu(this);
            telavisusu.Show();
        }

        private void bt_NovoPac_Click(object sender, EventArgs e)
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

            tb_Cep_Med_Usu.Enabled = false;
            tb_CRMV_Usu.Enabled = false;
            tb_Nome_Vet_Usu.Enabled = false;
            tb_N_Usu.Enabled = false;
            tb_Rua_Usu.Enabled = false;
            tb_UF_Med_Usu.Enabled = false;
            tb_Cid_Usu.Enabled = false;
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

            if (tb_CPF_Usu.Text == "" || tb_CRMV_Usu.Text == "")
            {
                MessageBox.Show("Erro ao salvar!\nPesquise o usuário que deseja atualizar ou clique em novo.\nTodos os campos do formulário devem ser preenchidos.");
            }
            //TODOS OS CAMPOS SENDO VERIFICADOS
            //else if (tb_Cargo_Usu.Text == "" || tb_Cidade_Usu.Text == "" || tb_CEP_Usu.Text == "" || tb_CPF_Usu.Text == "" || tb_Cod_Usu.Text == "" || tb_Idade_Usu.Text == "" +|| tb_Nasc_Usu.Text == "" || tb_Nome_Usu.Text == "" || tb_Num_Usu.Text == "" || tb_Rua_Av_Usu.Text == "" || tb_UF_Usu.Text == "" || tb_Cep_Med_Usu.Text == "" || tb_CRMV_Usu.Text == "" || tb_Nome_Vet_Usu.Text == "" || tb_N_Usu.Text == "" || tb_Rua_Usu.Text == "" || tb_UF_Med_Usu.Text == "" || tb_Cid_Usu.Text == "")
            {
                MessageBox.Show("Erro ao salvar!\nTodos os campos do formulário devem ser preenchidos.");
            }
            /*
            else
            {
                if (rb_adm.Checked)
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
                            MySqlCommand remedioupdate = new MySqlCommand("UPDATE remedio SET nomeremedio = ?, precoremedio = ? Where codigo = ?", conexaoupdate);

                            remedioupdate.Parameters.Clear();
                            remedioupdate.Parameters.Add("@nomeremedio", MySqlDbType.VarChar, 10).Value = remedio.nome;
                            remedioupdate.Parameters.Add("@precoremedio", MySqlDbType.Double, 1).Value = remedio.preco;
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
            

                    CONSULTA AO BANCO DE DADOS PARA SABER SE É UM CADASTRO NOVO OU
                     UM CADASTRO QUE SERÁ ATUALIZADO


                    DataTable data_table = new DataTable();
                    string codmed = tb_Cod_Med.Text;
                    string consultaSQLvacina = "SELECT * FROM vacina WHERE codigo='" + codmed + "'";
                    if (data_table.Rows.Count != 0)
                    {
                        try
                        {
                            MySqlConnection conexaoupdate = new MySqlConnection("server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2");
                            conexaoupdate.Open();
                            MySqlCommand vacinaupdate = new MySqlCommand("UPDATE vacina SET nomevacina = ?, precovacina = ? Where codigo = ?", conexaoupdate);

                            vacinaupdate.Parameters.Clear();
                            vacinaupdate.Parameters.Add("@nomevacina", MySqlDbType.VarChar, 10).Value = vacina.nome;
                            vacinaupdate.Parameters.Add("@precovacina", MySqlDbType.Double, 1).Value = vacina.preco;
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
            */
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
                //REALIZADO SORTEIO DE NUMERO ALEATÓRIO PARA CÓDIGO DO PET
                //LOOPING PARA VERIFICAR SE O CÓDIGO SORTEADO JÁ EXISTE NO BANCO
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
    }
 }
