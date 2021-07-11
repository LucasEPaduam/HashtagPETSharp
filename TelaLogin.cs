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

        DataTable dt = new DataTable();

        private void btn_Acessar_Click(object sender, EventArgs e)
        {
            /*string usuario = tb_Usu_login.Text;
            string senha = tb_Senha_login.Text;

            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Usuário ou Senha inválidos!\nVerifique os dados e tente novamente.");
                tb_Usu_login.Focus();
                return;
            }
            else
            {
                try
                {
                    string sql = "SELECT * FROM Usuario WHERE usuario= '" + usuario + "' AND senha= '" + senha + "'";
                    dt = BancoDados.Consulta(sql);

                    if (dt.Rows.Count == 1)
                    {*/
                        this.Hide();
                        TelaInicial tela_inicial = new TelaInicial(this);
                        tela_inicial.Show();
                   /* }
                    else
                    {                                                
                       
                            MessageBox.Show("Usuário ou Senha inválidos!\nVerifique os dados e tente novamente.");
                            tb_Usu_login.Focus();
                            return;
                        
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro de login!" + erro);
                }
            }*/
                      
        }

       
    }
}
