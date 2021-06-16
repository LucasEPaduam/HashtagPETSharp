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
        DataTable data_table;
        private BindingSource bind_source;
        private MySqlDataAdapter data_adapter;

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
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

            BancoDados.insertdono(donopet);

                        
            Paciente paciente = new Paciente();
            paciente.codigopet = tb_Codigo_Pac.Text;
            paciente.nomepet = tb_Nome_Pac.Text;
            paciente.raca = tb_Raça.Text;
            paciente.idade = tb_Idade.Text;
            paciente.peso = tb_Peso.Text;
            paciente.sexo = tb_Altura.Text;

            BancoDados.insertpaciente(paciente);
            
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            //TextBox do Paciente
            tb_Codigo_Pac.Clear();
            tb_Nome_Pac.Clear();
            tb_Raça.Clear();
            tb_Idade.Clear();
            tb_Peso.Clear();
            tb_Altura.Clear();

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

            


        }

        private void pb_Pesquisar_Click(object sender, EventArgs e)
        {
            string codpet = tb_Pesquisar.Text;
            string consultaSQL = "SELECT * FROM paciente WHERE codigopet='" + codpet + "'";
            data_table = BancoDados.Consulta(consultaSQL);
            data_table = new DataTable();
            data_adapter.Fill(data_table);

            
            bind_source = new BindingSource();
            bind_source.DataSource = data_table;

            //Associa os dados da tabela com a propriedade "Text" dos textbox
            tb_Codigo_Pac.DataBindings.Add("Text", bind_source, "codigopet");
            tb_Nome_Pac.DataBindings.Add("Text", bind_source, "nomepet");
            

        }
    }
}
