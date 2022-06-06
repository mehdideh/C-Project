using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine.Class
{
    public class Email
    {
        public void SendEmail(string To,String Subject,String Body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient Server = new SmtpClient("smtp.gmail.com");


            mail.From = new MailAddress("VaccineManagementCovid@gmail.com");

            mail.To.Add(To);
            mail.Subject = Subject;
            mail.Body = Body;
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            Server.Port = 587;
            Server.DeliveryMethod = SmtpDeliveryMethod.Network;

            Server.EnableSsl = true;
            Server.Credentials = new NetworkCredential("VaccineManagementCovid@gmail.com", "m12341234");

            Server.Send(mail);
        }
    }
}
