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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            
        }

        public TelaLogin(TelaInicial telaInicial)
        {
            InitializeComponent();
            this.tela_inicial = telaInicial;
        }

        private TelaInicial tela_inicial; 
        
        public TelaLogin(TelaCadNewLogin telaCadNewLogin)
        {
            InitializeComponent();
            this.telacadlogin = telaCadNewLogin;
        }

        private TelaCadNewLogin telacadlogin;



        private void btn_Acessar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial tela_inicial = new TelaInicial(this);
            tela_inicial.Show();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadNewLogin tela_cadnewusu = new TelaCadNewLogin(this);
            tela_cadnewusu.Show();
        }
    }
}
