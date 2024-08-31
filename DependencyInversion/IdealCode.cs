using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversions
{
    public class MailService
    {
        public void SendMail(IMailService mailService, string to, string body)
        {
            mailService.Send(to, body);
        }
    }
    

    public interface IMailService
    {
        void Send(string to, string body);
    }
    class GmailServ : IMailService
    {
        public void Send(string to, string body)
        {
            
        }
    }
    class YandexServ : IMailService
    {
        public void Send(string to, string body)
        {

        }
    }
}
