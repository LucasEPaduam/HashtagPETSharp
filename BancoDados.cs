using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjInter
{
    class BancoDados
    {

        private MySqlDataAdapter data_adapter;
        private MySqlConnection conexao;

        public static MySqlConnection conexaoBanco()
        {

            string connString = @"server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=10";
            MySqlConnection conexao = new MySqlConnection(connString);
            conexao.Open();
            return conexao;
        }


        public static DataTable Consulta(string consultaSQL)
        {

            MySqlDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = consultaSQL;
                    data_adapter = new MySqlDataAdapter(cmd.CommandText, conexaoBanco());
                    data_adapter.Fill(data_table);
                    return data_table;
                }

            }
            catch (MySqlException erro)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(erro.GetType().ToString());
                sb.AppendLine(erro.Message);
                sb.Append(erro.SqlState);
                sb.AppendLine("\n");
                sb.AppendLine(erro.StackTrace);
                MessageBox.Show(sb.ToString());
                throw erro;

            }
            catch (Exception erro)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(erro.GetType().ToString());
                sb.AppendLine(erro.Message);
                sb.AppendLine("\n");
                sb.AppendLine(erro.StackTrace);
                MessageBox.Show(sb.ToString());
                throw erro;
            }
        }


        public static void insertpaciente(Paciente paciente)
        {

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO paciente " +
                                     "(codigopet, dono_cpf, nomepet, raca, idade, peso, sexo) " +
                                     "VALUES( @codigopet, @dono_cpf, @nomepet, @raca, @idade, @peso, @sexo)";
                    cmd.Parameters.AddWithValue("@codigopet", paciente.codigopet);
                    cmd.Parameters.AddWithValue("@dono_cpf", paciente.dono_cpf);
                    cmd.Parameters.AddWithValue("@nomepet", paciente.nomepet);
                    cmd.Parameters.AddWithValue("@raca", paciente.raca);
                    cmd.Parameters.AddWithValue("@idade", paciente.idade);
                    cmd.Parameters.AddWithValue("@peso", paciente.peso);
                    cmd.Parameters.AddWithValue("@sexo", paciente.sexo);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Novo paciente cadastrado com sucesso!");

                }

            }
            catch (FormatException virgulaerro)
            {

                MessageBox.Show("No campo PESO digite '.(ponto)' ao invés de ' , (virgula)!!");

               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar paciente \n" + ex.Message);

            }

        }

        public static void insertdono(Donopet donopet)
        {

            try
            {
                using (var connect = conexaoBanco())
                using (var cmd = connect.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO dono " +
                                     "(cpf, paciente_codigopet, nomedono, rua, numero, cep, cidade, UF, email, telefone) " +
                                     "VALUES( @cpf, @paciente_codigopet, @nomedono, @rua, @numero, @cep, @cidade, @UF, @email, @telefone)";
                    cmd.Parameters.AddWithValue("@cpf", donopet.cpf);
                    cmd.Parameters.AddWithValue("@paciente_codigopet", donopet.paciente_codigopet);
                    cmd.Parameters.AddWithValue("@nomedono", donopet.nomedono);
                    cmd.Parameters.AddWithValue("@rua", donopet.rua);
                    cmd.Parameters.AddWithValue("@numero", donopet.numero);
                    cmd.Parameters.AddWithValue("@cep", donopet.cep);
                    cmd.Parameters.AddWithValue("@cidade", donopet.cidade);
                    cmd.Parameters.AddWithValue("@UF", donopet.UF);
                    cmd.Parameters.AddWithValue("@email", donopet.email);
                    cmd.Parameters.AddWithValue("@telefone", donopet.telefone);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Donopet cadastrado com sucesso!");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar Donopet \n" + ex.Message);

            }

        }

        public static void insertremedio(Remedio remedio)
        {
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO remedio (codigo, nome, preco) VALUES( @codigo, @nome, @preco)";
                    cmd.Parameters.AddWithValue("@codigo", remedio.codigo);
                    cmd.Parameters.AddWithValue("@nome", remedio.nome);
                    cmd.Parameters.AddWithValue("@preco", remedio.preco);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Novo remédio cadastrado com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar remédio \n" + ex.Message);
            }
        }

        public static void insertvacina(Vacina vacina)
        {
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO vacina (codigo, nome, preco) VALUES( @codigo, @nome, @preco)";
                    cmd.Parameters.AddWithValue("@codigo", vacina.codigo);
                    cmd.Parameters.AddWithValue("@nome", vacina.nome);
                    cmd.Parameters.AddWithValue("@preco", vacina.preco);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Nova vacina cadastrada com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar vacina \n" + ex.Message);
            }
        }

        public static void insertadministrativo(Administrativo administrativo)
        {
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {

                    cmd.CommandText = "INSERT INTO Administrativo (cpf, nome, rua, numero, cep, cidade, UF)" +
                            "VALUES (@cpf, @nome, @rua, @numero, @cep, @cidade, @UF)";

                    cmd.Parameters.AddWithValue("@cpf", administrativo.CPF);
                    cmd.Parameters.AddWithValue("@nome", administrativo.nome);
                    cmd.Parameters.AddWithValue("@rua", administrativo.rua);
                    cmd.Parameters.AddWithValue("@numero", administrativo.numero);
                    cmd.Parameters.AddWithValue("@cep", administrativo.CEP);
                    cmd.Parameters.AddWithValue("@cidade", administrativo.cidade);
                    cmd.Parameters.AddWithValue("@UF", administrativo.uf);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Novo administrativo cadastrado com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar administrativo \n" + ex.Message);
            }
        }

        public static void insertveterinario(Veterinario veterinario)
        {
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Veterinario (crmv, nome, rua, numero, cep, cidade, UF)" +
                            "VALUES (@crmv, @nome, @rua, @numero, @cep, @cidade, @UF)";


                    cmd.Parameters.AddWithValue("@crmv", veterinario.crmv);
                    cmd.Parameters.AddWithValue("@nome", veterinario.nome);
                    cmd.Parameters.AddWithValue("@rua", veterinario.rua);
                    cmd.Parameters.AddWithValue("@numero", veterinario.numero);
                    cmd.Parameters.AddWithValue("@cep", veterinario.cep);
                    cmd.Parameters.AddWithValue("@cidade", veterinario.cidade);
                    cmd.Parameters.AddWithValue("@UF", veterinario.uf);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Novo veterinario cadastrado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar veterinario \n" + ex.Message);
            }
        }

        public static void insertexame(Exame exame)
        {
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Exame (codigo, nome, preco) VALUES( @codigo, @nome, @preco)";
                    cmd.Parameters.AddWithValue("@codigo", exame.codigo);
                    cmd.Parameters.AddWithValue("@nome", exame.nome);
                    cmd.Parameters.AddWithValue("@preco", exame.preco);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Novo exame cadastrado com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar exame \n" + ex.Message);
            }
        }

        public static void insertuser(UsuarioLogin user)
        {
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Usuario (usuario, nome_usuario, senha) VALUES( @usuario, @nome_usuario, @senha)";
                    cmd.Parameters.AddWithValue("@usuario", user.usercod);
                    cmd.Parameters.AddWithValue("@nome_usuario", user.nome_usuario);
                    cmd.Parameters.AddWithValue("@senha", user.senha);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cadastro de usuário falhou!" + ex.Message);
            }

        }

        public static void insertagendamento(Agendamento agendamento)
        {
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO agendamento (data_consulta, hora_consulta, agendamento_codigopet, agendamento_nomepet, agendamento_vetcrmv, agendamento_nomevet) VALUES(@data_consulta, @hora_consulta, @agendamento_codigopet, @agendamento_nomepet, @agendamento_vetcrmv, @agendamento_nomevet)";
                    cmd.Parameters.AddWithValue("@data_consulta", agendamento.dataagendamento);
                    cmd.Parameters.AddWithValue("@hora_consulta", agendamento.horaagendamento);
                    cmd.Parameters.AddWithValue("@agendamento_codigopet", agendamento.codpet);
                    cmd.Parameters.AddWithValue("@agendamento_nomepet", agendamento.nomepet);
                    cmd.Parameters.AddWithValue("@agendamento_vetcrmv", agendamento.codvet);
                    cmd.Parameters.AddWithValue("@agendamento_nomevet", agendamento.nomevet);
                    cmd.ExecuteNonQuery();



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cadastro da consulta falhou!" + ex.Message);
            }

        }

        public static void insertconsulta(Consulta consulta)
        {
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO consulta (consulta_data, consulta_hora, consulta_vetcrmv, consulta_nomevet, consulta_codigopet, consulta_nomepet, consulta_peso, consulta_idade, consulta_obs, consulta_vacina, consulta_remedio, consulta_exame) VALUES(@consulta_data, @consulta_hora, @consulta_vetcrmv, @consulta_nomevet, @consulta_codigopet, @consulta_nomepet, @consulta_peso, @consulta_idade, @consulta_obs, @consulta_vacina, @consulta_remedio, @consulta_exame)";
                    cmd.Parameters.AddWithValue("@consulta_data", consulta.consulta_data);
                    cmd.Parameters.AddWithValue("@consulta_hora", consulta.consulta_hora);
                    cmd.Parameters.AddWithValue("@consulta_vetcrmv", consulta.consulta_vetcrmv);
                    cmd.Parameters.AddWithValue("@consulta_nomevet", consulta.consulta_nomevet);
                    cmd.Parameters.AddWithValue("@consulta_codigopet", consulta.consulta_codigopet);
                    cmd.Parameters.AddWithValue("@consulta_nomepet", consulta.consulta_nomepet);
                    cmd.Parameters.AddWithValue("@consulta_peso", consulta.consulta_peso);
                    cmd.Parameters.AddWithValue("@consulta_idade", consulta.consulta_idade);
                    cmd.Parameters.AddWithValue("@consulta_obs", consulta.consulta_obs);
                    cmd.Parameters.AddWithValue("@consulta_vacina", consulta.consulta_vacina);
                    cmd.Parameters.AddWithValue("@consulta_remedio", consulta.consulta_remedio);
                    cmd.Parameters.AddWithValue("@consulta_exame", consulta.consulta_exame);


                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Consulta marcada com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cadastro da consulta falhou!" + ex.Message);
            }
        }
    }
}