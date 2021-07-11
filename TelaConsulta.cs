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
    public partial class TelaConsulta : Form
    {

        DataTable data_table = new DataTable();
        public TelaConsulta(TelaInicial telaInicial)
        {
            InitializeComponent();
            this.tela_inicial = telaInicial;
        }

        private TelaInicial tela_inicial;

        

        
        private void btn_Iniciar_Consulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            TelaIniciarConsulta telaIniciar = new TelaIniciarConsulta(tb_Cod_PET.Text);
            telaIniciar.Show();


        }

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void TelaConsulta_Load(object sender, EventArgs e)
        {
            data_table.Clear();
            dgv_Histórico.Visible = false;
            vScrollBar1.Visible = false;

            
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            
            string codpet = tb_Cod_PET.Text;
            

            if (codpet == "")
            {
                MessageBox.Show("Código do PET não preenchido!");
                data_table.Clear();
                dgv_Histórico.Visible = false;
                vScrollBar1.Visible = false;
                tb_Cod_PET.Focus();
            }
            else
            {

                string consultaSQL = "SELECT paciente.codigopet as 'COD PET',  paciente.nomepet as 'NOME PET', paciente.raca as 'RACA', paciente.idade as 'IDADE', paciente.peso as 'PESO', paciente.sexo as 'SEXO' FROM paciente WHERE codigopet ='" + codpet + "'";
                data_table = BancoDados.Consulta(consultaSQL);

                if (data_table.Rows.Count == 1)
                {
                    int i = 0;
                    btn_Iniciar_Consulta.Enabled = true;
                    dgv_Histórico.Visible = true;
                    vScrollBar1.Visible = true;
                    dgv_Histórico.DataSource = data_table;
                    dgv_Histórico.Columns[0].Width = 70;
                    dgv_Histórico.Columns[1].Width = 150;
                    dgv_Histórico.Columns[2].Width = 140;
                    dgv_Histórico.Columns[3].Width = 50;
                    dgv_Histórico.Columns[4].Width = 50;
                    dgv_Histórico.Columns[5].Width = 70;
                    dgv_Histórico.Sort(dgv_Histórico.Columns[i], ListSortDirection.Ascending);

                    
                }
                else
                {
                    MessageBox.Show("PET não cadastrado, favor verificar!");
                }
                


            }

        

        }

            




    }
}
