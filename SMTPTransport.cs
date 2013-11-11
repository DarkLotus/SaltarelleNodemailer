using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace NodeApi.NodeMailer
{
    [Imported]
    [IgnoreNamespace]
    public class SMTPTransport
    {

        public void sendMail(MailOptions options,Action<Exception,JsDictionary<string,string>> callback){}

        public void sendMail(MailOptions options) { }

        public void close() { }
    }
}
