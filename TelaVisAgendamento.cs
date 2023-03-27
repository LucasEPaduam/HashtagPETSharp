using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace ProjInter
{
    public partial class TelaVisAgendamento : Form
    {
        public TelaVisAgendamento(string dataescolhida)
        {
            InitializeComponent();

            data_escolha = dataescolhida;
        }

        public string data_escolha;

        public TelaVisAgendamento(TelaInicial telainicial)
        {
            InitializeComponent();
            this.tela_inicial = telainicial;

        }
        private TelaInicial tela_inicial;



        private void TelaVisAgendamento_Load(object sender, EventArgs e)
        {

            string selectconsulta = @"SELECT consulta.consulta_data as 'DATA',
                                                consulta.consulta_hora as 'HORA',
                                                consulta.consulta_vetcrmv as 'CRMV',
                                                consulta.consulta_nomevet as 'NOME VET',
                                                consulta.consulta_codigopet as 'PET',
                                                consulta.consulta_nomepet as 'NOME PET',                                                
                                                consulta.consulta_peso as 'PESO',
                                                consulta.consulta_idade as 'IDADE',
                                                consulta.consulta_obs as 'OBS:',
                                                consulta.consulta_vacina as 'VACINA',
                                                consulta.consulta_remedio as 'REMEDIO',
                                                consulta.consulta_exame as 'EXAME'
                                                FROM consulta WHERE consulta_data ='" + data_escolha + "'ORDER BY consulta_data ASC;";

            dgv_consultasagendadas.DataSource = BancoDados.Consulta(selectconsulta);
            dgv_consultasagendadas.Columns[0].Width = 80;
            dgv_consultasagendadas.Columns[1].Width = 50;
            dgv_consultasagendadas.Columns[2].Width = 80;
            dgv_consultasagendadas.Columns[3].Width = 120;
            dgv_consultasagendadas.Columns[4].Width = 80;
            dgv_consultasagendadas.Columns[5].Width = 120;
            dgv_consultasagendadas.Columns[6].Width = 50;
            dgv_consultasagendadas.Columns[7].Width = 50;
            dgv_consultasagendadas.Columns[8].Width = 120;
            dgv_consultasagendadas.Columns[9].Width = 120;
            dgv_consultasagendadas.Columns[10].Width = 120;
            dgv_consultasagendadas.Columns[11].Width = 120;


            comboBox1.Enabled = false;
            btn_Pesdata.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            btn_Pesvet.Enabled = false;
            btn_Pespac.Enabled = false;


        }

        private void rb_data_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            btn_Pesdata.Enabled = true;

            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            btn_Pesvet.Enabled = false;
            btn_Pespac.Enabled = false;
            string selectdata = @"SELECT consulta.consulta_data FROM consulta GROUP BY consulta_data";
            comboBox1.DataSource = BancoDados.Consulta(selectdata);
            comboBox1.DisplayMember = "consulta_data";
            comboBox1.ValueMember = "consulta_data";



        }

        private void rb_vet_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            btn_Pesvet.Enabled = true; ;
            comboBox1.Text = "";
            comboBox3.Text = "";

            comboBox1.Enabled = false;
            comboBox3.Enabled = false;
            btn_Pesdata.Enabled = false;
            btn_Pespac.Enabled = false;
            string selectVET = @"SELECT Veterinario.nome FROM Veterinario ORDER BY nome ASC;";
            comboBox2.DataSource = BancoDados.Consulta(selectVET);
            comboBox2.DisplayMember = "nome";
            comboBox2.ValueMember = "nome";
        }

        private void rb_pac_CheckedChanged(object sender, EventArgs e)
        {

            comboBox3.Enabled = true;
            btn_Pespac.Enabled = true;

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;

            comboBox1.Text = "";
            comboBox2.Text = "";

            btn_Pesdata.Enabled = false;
            btn_Pesvet.Enabled = false;
            string selectPAC = @"SELECT paciente.nomepet FROM paciente ORDER BY nomepet ASC;";
            comboBox3.DataSource = BancoDados.Consulta(selectPAC);
            comboBox3.DisplayMember = "nomepet";
            comboBox3.ValueMember = "nomepet";
        }

        private void btn_Pesdata_Click(object sender, EventArgs e)
        {
            string data = comboBox1.Text;

            string selectconsulta = @"SELECT consulta.consulta_data as 'DATA',
                                                consulta.consulta_hora as 'HORA',
                                                consulta.consulta_vetcrmv as 'CRMV',
                                                consulta.consulta_nomevet as 'NOME VET',
                                                consulta.consulta_codigopet as 'PET',
                                                consulta.consulta_nomepet as 'NOME PET',                                                
                                                consulta.consulta_peso as 'PESO',
                                                consulta.consulta_idade as 'IDADE',
                                                consulta.consulta_obs as 'OBS:',
                                                consulta.consulta_vacina as 'VACINA',
                                                consulta.consulta_remedio as 'REMEDIO',
                                                consulta.consulta_exame as 'EXAME'
                                                FROM consulta WHERE consulta_data ='" + data + "'ORDER BY consulta_data, consulta_hora ASC;";

            dgv_consultasagendadas.DataSource = BancoDados.Consulta(selectconsulta);
            dgv_consultasagendadas.Columns[0].Width = 80;
            dgv_consultasagendadas.Columns[1].Width = 50;
            dgv_consultasagendadas.Columns[2].Width = 80;
            dgv_consultasagendadas.Columns[3].Width = 120;
            dgv_consultasagendadas.Columns[4].Width = 80;
            dgv_consultasagendadas.Columns[5].Width = 120;
            dgv_consultasagendadas.Columns[6].Width = 50;
            dgv_consultasagendadas.Columns[7].Width = 50;
            dgv_consultasagendadas.Columns[8].Width = 120;
            dgv_consultasagendadas.Columns[9].Width = 120;
            dgv_consultasagendadas.Columns[10].Width = 120;
            dgv_consultasagendadas.Columns[11].Width = 120;






        }

        private void btn_Pesvet_Click(object sender, EventArgs e)
        {
            string vet = comboBox2.Text;

            string selectconsulta = @"SELECT consulta.consulta_data as 'DATA',
                                                consulta.consulta_hora as 'HORA',
                                                consulta.consulta_vetcrmv as 'CRMV',
                                                consulta.consulta_nomevet as 'NOME VET',
                                                consulta.consulta_codigopet as 'PET',
                                                consulta.consulta_nomepet as 'NOME PET',                                                
                                                consulta.consulta_peso as 'PESO',
                                                consulta.consulta_idade as 'IDADE',
                                                consulta.consulta_obs as 'OBS:',
                                                consulta.consulta_vacina as 'VACINA',
                                                consulta.consulta_remedio as 'REMEDIO',
                                                consulta.consulta_exame as 'EXAME'
                                                FROM consulta WHERE consulta_nomevet ='" + vet + "'ORDER BY consulta_data, consulta_hora ASC;";

            dgv_consultasagendadas.DataSource = BancoDados.Consulta(selectconsulta);
            dgv_consultasagendadas.Columns[0].Width = 80;
            dgv_consultasagendadas.Columns[1].Width = 50;
            dgv_consultasagendadas.Columns[2].Width = 80;
            dgv_consultasagendadas.Columns[3].Width = 120;
            dgv_consultasagendadas.Columns[4].Width = 80;
            dgv_consultasagendadas.Columns[5].Width = 120;
            dgv_consultasagendadas.Columns[6].Width = 50;
            dgv_consultasagendadas.Columns[7].Width = 50;
            dgv_consultasagendadas.Columns[8].Width = 120;
            dgv_consultasagendadas.Columns[9].Width = 120;
            dgv_consultasagendadas.Columns[10].Width = 120;
            dgv_consultasagendadas.Columns[11].Width = 120;
        }

        private void btn_Pespac_Click(object sender, EventArgs e)
        {
            string pet = comboBox3.Text;

            string selectconsulta = @"SELECT consulta.consulta_data as 'DATA',
                                                consulta.consulta_hora as 'HORA',
                                                consulta.consulta_vetcrmv as 'CRMV',
                                                consulta.consulta_nomevet as 'NOME VET',
                                                consulta.consulta_codigopet as 'PET',
                                                consulta.consulta_nomepet as 'NOME PET',                                                
                                                consulta.consulta_peso as 'PESO',
                                                consulta.consulta_idade as 'IDADE',
                                                consulta.consulta_obs as 'OBS:',
                                                consulta.consulta_vacina as 'VACINA',
                                                consulta.consulta_remedio as 'REMEDIO',
                                                consulta.consulta_exame as 'EXAME'
                                                FROM consulta WHERE consulta_nomepet ='" + pet + "'ORDER BY consulta_data, consulta_hora ASC;";

            dgv_consultasagendadas.DataSource = BancoDados.Consulta(selectconsulta);
            dgv_consultasagendadas.Columns[0].Width = 80;
            dgv_consultasagendadas.Columns[1].Width = 50;
            dgv_consultasagendadas.Columns[2].Width = 80;
            dgv_consultasagendadas.Columns[3].Width = 120;
            dgv_consultasagendadas.Columns[4].Width = 80;
            dgv_consultasagendadas.Columns[5].Width = 120;
            dgv_consultasagendadas.Columns[6].Width = 50;
            dgv_consultasagendadas.Columns[7].Width = 50;
            dgv_consultasagendadas.Columns[8].Width = 120;
            dgv_consultasagendadas.Columns[9].Width = 120;
            dgv_consultasagendadas.Columns[10].Width = 120;
            dgv_consultasagendadas.Columns[11].Width = 120;
        }

        private void btn_todascon_Click(object sender, EventArgs e)
        {
            string selectconsulta = @"SELECT consulta.consulta_data as 'DATA',
                                                consulta.consulta_hora as 'HORA',
                                                consulta.consulta_vetcrmv as 'CRMV',
                                                consulta.consulta_nomevet as 'NOME VET',
                                                consulta.consulta_codigopet as 'PET',
                                                consulta.consulta_nomepet as 'NOME PET',                                                
                                                consulta.consulta_peso as 'PESO',
                                                consulta.consulta_idade as 'IDADE',
                                                consulta.consulta_obs as 'OBS:',
                                                consulta.consulta_vacina as 'VACINA',
                                                consulta.consulta_remedio as 'REMEDIO',
                                                consulta.consulta_exame as 'EXAME'
                                                FROM consulta ORDER BY consulta_data ASC;";

            dgv_consultasagendadas.DataSource = BancoDados.Consulta(selectconsulta);
            dgv_consultasagendadas.Columns[0].Width = 80;
            dgv_consultasagendadas.Columns[1].Width = 50;
            dgv_consultasagendadas.Columns[2].Width = 80;
            dgv_consultasagendadas.Columns[3].Width = 120;
            dgv_consultasagendadas.Columns[4].Width = 80;
            dgv_consultasagendadas.Columns[5].Width = 120;
            dgv_consultasagendadas.Columns[6].Width = 50;
            dgv_consultasagendadas.Columns[7].Width = 50;
            dgv_consultasagendadas.Columns[8].Width = 120;
            dgv_consultasagendadas.Columns[9].Width = 120;
            dgv_consultasagendadas.Columns[10].Width = 120;
            dgv_consultasagendadas.Columns[11].Width = 120;
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial telainicial = new TelaInicial(this);
            telainicial.Show();
        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            string nomearquivo = Caminho.caminho + @"\CONSULTAS\PETSHARPCONSULTA_" + nomepetselect + ".pdf";
            FileStream arquivoPDF = new FileStream(nomearquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Caminho.caminho + @"\logopata.png");
            logo.ScaleToFit(140f, 120f);
            logo.Alignment = Element.ALIGN_LEFT;
            logo.SetAbsolutePosition(100f, 700f);



            string dados = "";

            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 26, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("  HASHPETSHARP\n");

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("\n\nRelatório de consulta - " + dataselect + "-" + horaselect);

            Paragraph paragrafo3 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo3.Alignment = Element.ALIGN_LEFT;
            paragrafo3.Add("\nPaciente: " + nomepetselect + " - Idade: " + idadeselect + " anos - Peso: " + pesoselect);

            Paragraph paragrafo4 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo4.Alignment = Element.ALIGN_LEFT;
            paragrafo4.Add("Dono PET: " + nomedono);

            Paragraph paragrafo5 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo5.Alignment = Element.ALIGN_LEFT;
            paragrafo5.Add("Vet Resp.: " + nomevetselect + " - CRMV: " + codvetselect);


            Paragraph paragrafo6 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold));
            paragrafo6.Alignment = Element.ALIGN_CENTER;
            paragrafo6.Add("\nPRESCRIÇÃO\n\n");

            PdfPTable tabela = new PdfPTable(3);
            tabela.DefaultCell.FixedHeight = 20;

            tabela.AddCell("VACINA");
            tabela.AddCell("REMÉDIO");
            tabela.AddCell("EXAME");


            tabela.AddCell(vacina);
            tabela.AddCell(remedio);
            tabela.AddCell(exame);


            Paragraph paragrafo7 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo7.Alignment = Element.ALIGN_LEFT;
            paragrafo7.Add("Obs: " + obs);

            Paragraph paragrafo8 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo8.Alignment = Element.ALIGN_LEFT;
            paragrafo8.Add("\n\n HISTÓRICO DE CONSULTA\n\n");



            PdfPTable tabela2 = new PdfPTable(new float[] { 70f, 45f, 40f, 70f, 70f, 70f, 80f });
            
            tabela2.AddCell("DATA");
            tabela2.AddCell("IDADE");
            tabela2.AddCell("PESO");
            tabela2.AddCell("VACINA");
            tabela2.AddCell("REMÉDIO");
            tabela2.AddCell("EXAME");
            tabela2.AddCell("OBS.:");

            string consultahist = @"SELECT * FROM consulta WHERE consulta_codigopet='" + codpetselect + "'ORDER BY consulta_data, consulta_hora ASC";
            DataTable historico = BancoDados.Consulta(consultahist);
            for (int i = 0; i < historico.Rows.Count; i++)
            {

                tabela2.AddCell(historico.Rows[i].Field<string>("consulta_data"));
                tabela2.AddCell(historico.Rows[i].Field<string>("consulta_idade"));
                tabela2.AddCell(historico.Rows[i].Field<string>("consulta_peso"));
                tabela2.AddCell(historico.Rows[i].Field<string>("consulta_vacina"));
                tabela2.AddCell(historico.Rows[i].Field<string>("consulta_remedio"));
                tabela2.AddCell(historico.Rows[i].Field<string>("consulta_Exame"));
                tabela2.AddCell(historico.Rows[i].Field<string>("consulta_obs"));

            }



            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo1);
            doc.Add(paragrafo2);
            doc.Add(paragrafo3);
            doc.Add(paragrafo4);
            doc.Add(paragrafo5);
            doc.Add(paragrafo6);
            doc.Add(tabela);            
            doc.Add(paragrafo7);
            doc.Add(paragrafo8);
            doc.Add(tabela2);

            doc.Close();

            MessageBox.Show("Relatório criado com sucesso!");


            const string mensagem = "Deseja enviar os dados da consulta via email?";
            const string caption = "Envio email";
            var result = MessageBox.Show(mensagem, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {

                MessageBox.Show("Envio cancelado!");
            }
            else
            {

                {

                    try
                    {

                        var client = new SmtpClient("smtp.gmail.com", 587)
                        {
                            Credentials = new NetworkCredential("", ""),
                            EnableSsl = true
                        };
                        var mailMessage = new MailMessage
                        {
                            From = new MailAddress("hpetsharp@gmail.com"),
                            Subject = "Relatório PET - "+ nomepetselect,
                            Body = "<h1>Olá familia!! Segue anexo o relatório da consulta do seu neném.</h1>",
                            IsBodyHtml = true,
                        };
                        mailMessage.To.Add(emaildono);

                        string caminhoreport = Caminho.caminho + @"\CONSULTAS\PETSHARPCONSULTA_" + nomepetselect + ".pdf";
                        var attachment = new Attachment(caminhoreport, MediaTypeNames.Application.Pdf);
                        mailMessage.Attachments.Add(attachment);


                        client.Send(mailMessage);
                         
                         MessageBox.Show("Email enviado com sucesso!");

                        


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }


                }

            }
        }


        public string dataselect;
        public string horaselect;
        public string codpetselect;
        public string codvetselect;
        public string nomepetselect;
        public string nomevetselect;
        public string pesoselect;
        public string idadeselect;
        public string vacina;
        public string remedio;
        public string exame;
        public string obs;
        public string nomedono;
        public string emaildono;
        public string emailpetsharp = "hashpetsharp@gmail.com";

        private void dgv_consultasagendadas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string data = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string hora = dgv.SelectedRows[0].Cells[1].Value.ToString();
                string vet = dgv.SelectedRows[0].Cells[2].Value.ToString();

                string consulta = @"SELECT * FROM consulta WHERE consulta_data='" + data + "' AND consulta_hora= '" + hora + "'AND consulta_vetcrmv= '"+vet+"'";
                dt = BancoDados.Consulta(consulta);

                dataselect = dt.Rows[0].Field<string>("consulta_data");
                horaselect = dt.Rows[0].Field<string>("consulta_hora");
                codpetselect = dt.Rows[0].Field<string>("consulta_codigopet");
                codvetselect = dt.Rows[0].Field<string>("consulta_vetcrmv");
                nomepetselect = dt.Rows[0].Field<string>("consulta_nomepet");
                nomevetselect = dt.Rows[0].Field<string>("consulta_nomevet");
                pesoselect = dt.Rows[0].Field<string>("consulta_peso");
                idadeselect = dt.Rows[0].Field<string>("consulta_idade");
                vacina = dt.Rows[0].Field<string>("consulta_vacina");
                remedio = dt.Rows[0].Field<string>("consulta_remedio");
                exame = dt.Rows[0].Field<string>("consulta_exame");
                obs = dt.Rows[0].Field<string>("consulta_obs");

                DataTable dt2 = new DataTable();
                string consulta2 = @"SELECT * FROM dono WHERE paciente_codigopet='" + codpetselect+"'";
                dt2 = BancoDados.Consulta(consulta2);
                nomedono = dt2.Rows[0].Field<string>("nomedono");
                emaildono = dt2.Rows[0].Field<string>("email");
            }
        }

        
    }
}
