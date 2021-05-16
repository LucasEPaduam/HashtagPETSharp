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
    public partial class TelaVisAgendamento : Form
    {
        public TelaVisAgendamento(TelaInicial telaInicial)
        {
            InitializeComponent();
            this.telaInicial = telaInicial;
        
        }

        private TelaInicial telaInicial;

        private void TelaVisAgendamento_Load(object sender, EventArgs e)
        {

            telaInicial.GetDateTime();
            {

                String Data = (DateTime.Now.ToString("dd / MM / yyyy"));
                
                lbl_RecebeDataPicker.Text = Data.ToString();

                lbl_RecebeDataPicker.Show();

            }

           


        }

        private void btn_FecharAgendamento_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
