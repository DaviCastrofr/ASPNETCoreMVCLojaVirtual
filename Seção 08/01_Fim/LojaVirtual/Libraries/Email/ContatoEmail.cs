using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("davi18827@gmail.com","j3100davi");
            smtp.EnableSsl = true;

            MailMessage mensage = new MailMessage();
            mensage.From = new MailAddress("davi18827@gmail.com");
            mensage.To.Add("davi18827@gmail.com");
            mensage.Subject = "contai: " + contato.Email + " " + contato.Nome;
            mensage.Body = "eaeeee" +contato.Texto;
            mensage.IsBodyHtml = true;

            smtp.Send(mensage);
        }
    }
}
