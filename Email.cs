using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Net.Mail;

namespace ProjInter
{
    class Email
    {

        
        private static void mandaremail()
        {

            try
            {
                using (SmtpClient smpt = new SmtpClient())
                {
                    using (MailMessage email =new MailMessage())
                    {
                        smpt.Host = "smpt.gmail.com";
                        smpt.UseDefaultCredentials = false;
                        smpt.Credentials = new System.Net.NetworkCredential("hashpetsharp@gmail.com", "wolfairla");
                        smpt.Port = 587;
                        smpt.EnableSsl = true;

                        email.From = new MailAddress(txtRemetente.Text);
                        email.To.Add(txtDestinatario.Text);

                        email.Subject = txtAssunto.Text;
                        email.IsBodyHtml = false;
                        email.Body = txtMensagem.Text;

                        smpt.Send(email);




                    }

                }
                MessageBox.Show("Email Eenviado");


            }catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }





        }
        
        

    }
}
