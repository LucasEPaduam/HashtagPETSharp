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
            TelaIniciarConsulta telainiciarconsulta = new TelaIniciarConsulta(this);
            telainiciarconsulta.Show();
        }

        private void pb_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            data_table.Clear();
            dgv_Histórico.Visible = false;


            string nomepet = tb_Cod_PET.Text;

            if (nomepet == "")
            {
                MessageBox.Show("Código do PET não preenchido!");
                tb_Cod_PET.Focus();
            }
            else
            {

                string consultaSQL = "SELECT * FROM paciente WHERE nomepet='" + nomepet + "'";
                data_table = BancoDados.Consulta(consultaSQL);

                if (data_table.Rows.Count == 1)
                {
                    btn_Iniciar_Consulta.Enabled = true;
                    dgv_Histórico.Visible = true;
                    dgv_Histórico.DataSource = data_table;
                    //dgv_Histórico.Columns["codigopet"].Visible = false;
                }
                else
                {
                    MessageBox.Show("PET não cadastrado, favor verificar!");
                }
                


            }






        }
    }
}
