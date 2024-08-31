using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class MailService
    {
        public void SendMail(Gmail mail)
        {
            mail.Send("dalgasal");
        }

    }
    class Gmail
    {
        public void Send(string mail)
        {

        }
    }
    class Hotmail
    {
        public void Send(string mail)
        {

        }
    }
    class Yandex
    {
        public void Send(string mail, string to)
        {

        }
    }

}
