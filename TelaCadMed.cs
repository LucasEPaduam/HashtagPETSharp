using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_Histórico_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVisMed telavismed = new TelaVisMed(this);
            telavismed.Show();
        }
        //AQUIIIIIIIIIIIIIIII

        private void pb_Pesquisar_Click(object sender, EventArgs e)
        {
            rb_Remedio.Enabled = false;
            rb_Vacina.Enabled = false;

            tb_Cod_Med.Enabled = false;
            tb_Nome_Med.Enabled = false;
            tb_Preco_Med.Enabled = false;

            //FALTA COISA
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


            rb_Remedio.Enabled = false;
            rb_Vacina.Enabled = false;

            tb_Cod_Med.Enabled = false;
            tb_Nome_Med.Enabled = false;
            tb_Preco_Med.Enabled = false;
        }
        private void bt_excluir_Click(object sender, EventArgs e)
        {
            //FALTA COISA
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {

            if (tb_Cod_Med.Text == "")
            {
                MessageBox.Show("Erro ao salvar!\nPesquise o medicamento que deseja atualizar ou clique em novo.\nTodos os campos do formulário devem ser preenchidos.");
            }
            //TODOS OS CAMPOS SENDO VERIFICADOS
            else if (tb_Nome_Med.Text == "" || tb_Preco_Med.Text == "")
            {
                MessageBox.Show("Erro ao salvar!\nTodos os campos do formulário devem ser preenchidos.");
            }
            /*
            else
            {

            }
            */
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


    }
 }

