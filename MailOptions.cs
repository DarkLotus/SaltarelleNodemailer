using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace NodeApi.NodeMailer
{
    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public class MailOptions
    {
        [ScriptName("from")]
        public string From;
        [ScriptName("to")]
        public string To;
        [ScriptName("cc")]
        public string CC;
        [ScriptName("bcc")]
        public string BCC;
        [ScriptName("replyTo")]
        public string ReplyTo;
        [ScriptName("inReplyto")]
        public string InReplyTo;
        [ScriptName("references")]
        public string References;

        [ScriptName("subject")]
        public string Subject;
        [ScriptName("text")]
        public string Text;
        [ScriptName("html")]
        public string HTML;
        [ScriptName("generateTextFromHTML")]
        public bool GenerateTextFromHTML;
        [ScriptName("headers")]
        public JsDictionary<string, string> Headers;
        [ScriptName("attachments")]
        public object[] Attachments;
        [ScriptName("alternatives")]
        public string Alternatives;
        [ScriptName("envelope")]
        public string Envelope;
    }
}
