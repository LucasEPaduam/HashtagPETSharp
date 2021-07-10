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

        public static DataTable SelectTodosPaciente()
        {

            MySqlDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM paciente";
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

       
        
        public void Exclui()
        {
            try
            {

                string connString = @"server=127.0.0.1;uid=root;database=hashpetsharp;ConnectionTimeout=2";
                MySqlConnection conexao = new MySqlConnection(connString);
                data_adapter = new MySqlDataAdapter();


                string exclui = "DELETE FROM tb_cliente WHERE cpf = @cpf ;";
                data_adapter.DeleteCommand = new MySqlCommand(exclui, conexao);
                data_adapter.DeleteCommand.Parameters.Add("@cpf", MySqlDbType.VarChar, 11, "cpf");

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

            }
            catch (Exception erro)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(erro.GetType().ToString());
                sb.AppendLine(erro.Message);
                sb.AppendLine("\n");
                sb.AppendLine(erro.StackTrace);
                MessageBox.Show(sb.ToString());
            }
        }



        public static void atualizarpaciente(Paciente paciente)
        {
            

            try
            {

                using (var connect = conexaoBanco())
                using (var cmd = connect.CreateCommand())
                {

                    cmd.CommandText = "UPDATE paciente SET " +
                            "nomepet=@nomepet, " +
                            "raca=@raca, idade=@idade, peso=@peso, sexo=@sexo" +
                            "Where codigopet = @codigopet;";

                   
                    cmd.Parameters.AddWithValue("@nomepet", paciente.nomepet);
                    cmd.Parameters.AddWithValue("@raca", paciente.raca);
                    cmd.Parameters.AddWithValue("@idade", paciente.idade);
                    cmd.Parameters.AddWithValue("@peso", paciente.peso);
                    cmd.Parameters.AddWithValue("@sexo", paciente.sexo);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Atualizado com sucesso!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar! \n" + ex.Message);
            }

        }







        public static void atualizardono(Donopet donopet)
        {
            try
            {
                using (var connect = conexaoBanco())
                using (var cmd = connect.CreateCommand())
                {

                    cmd.CommandText = "UPDATE dono SET " +
                            "nomedono=@nomedono, " +
                            "rua=@rua, numero=@numero, cep=@cep, cidade=@cidade" +
                            "UF=@UF, email=@email, telefone=@telefone" +
                            "Where paciente_codigopet = @paciente_codigopet;";

                    
                    
                    cmd.Parameters.AddWithValue("@nomedono", donopet.nomedono);
                    cmd.Parameters.AddWithValue("@rua", donopet.rua);
                    cmd.Parameters.AddWithValue("@numero", donopet.numero);
                    cmd.Parameters.AddWithValue("@cep", donopet.cep);
                    cmd.Parameters.AddWithValue("@cidade", donopet.cidade);
                    cmd.Parameters.AddWithValue("@UF", donopet.UF);
                    cmd.Parameters.AddWithValue("@email", donopet.email);
                    cmd.Parameters.AddWithValue("@telefone", donopet.telefone);
                    cmd.ExecuteNonQuery();

                    
                    MessageBox.Show("Atualizado com sucesso!");

                }
            }
            catch
            {
                MessageBox.Show("Erro ao atualizar!");
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
                    cmd.CommandText = "UPDATE administrativo SET " +
                            "cpf=@cpf, nome=@nome, rua=@rua, numero=@numero, cep=@cep, cidade=@cidade, UF=@UF";

                    cmd.Parameters.AddWithValue("@cpf", administrativo.CPF);
                    cmd.Parameters.AddWithValue("@nome",  administrativo.nome);
                    cmd.Parameters.AddWithValue("@rua", administrativo.rua);
                    cmd.Parameters.AddWithValue("@numero", administrativo.numero);
                    cmd.Parameters.AddWithValue("@cep", administrativo.CEP);
                    cmd.Parameters.AddWithValue("@cidade", administrativo.cidade);
                    cmd.Parameters.AddWithValue("@uf", administrativo.uf);
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
                    cmd.CommandText = "UPDATE veterinario SET " +
                            "crmv=@crmv, nome=@nome, rua=@rua, numero=@numero, cep=@cep, cidade=@cidade, UF=@UF";


                    cmd.Parameters.AddWithValue("@crmv", veterinario.crmv);
                    cmd.Parameters.AddWithValue("@nome", veterinario.nome);
                    cmd.Parameters.AddWithValue("@rua", veterinario.rua);
                    cmd.Parameters.AddWithValue("@numero", veterinario.numero);
                    cmd.Parameters.AddWithValue("@cep", veterinario.cep);
                    cmd.Parameters.AddWithValue("@cidade", veterinario.cidade);
                    cmd.Parameters.AddWithValue("@uf", veterinario.uf);
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





    }
}