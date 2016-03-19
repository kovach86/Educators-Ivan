using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TextHandlers
{
    public class MailSender
    {
        public string UserName { get; set; }

        public string SendEmail()
        {
            using (MailMessage mm = new MailMessage("ikovacevic86@gmail.com", "bojana.stojiljkovic@gmail.com"))
            {
                {
                    mm.IsBodyHtml = true;
                    mm.Body = "<html> <head></head> <body> <b>Evo malo texta </body> </b> ";
                    mm.Subject = "Eiiiij";

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;

                    NetworkCredential nwc = new NetworkCredential(" ", " ");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = nwc;
                    smtp.Port = 587;
                    try
                    {
                        smtp.Send(mm);
                        return "Send";
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.WriteError(ex);
                        return "";
                    }

                }
            }
        }
    }
}
